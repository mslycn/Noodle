﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using MongoDB.Driver;
using Noodle.Web;

namespace Noodle.Localization.Services
{
    public class LanguageInstaller : ILanguageInstaller
    {
        private readonly ILanguageService _languageService;
        private readonly ILocalizationService _localizationService;
        private readonly IErrorNotifier _errorNotifier;

        public LanguageInstaller(ILanguageService languageService,
            ILocalizationService localizationService,
            IErrorNotifier errorNotifier)
        {
            _languageService = languageService;
            _localizationService = localizationService;
            _errorNotifier = errorNotifier;
        }

        public void Install(string languagesXmlFileLocation)
        {
            // Let's first delete everything
            _languageService.DeleteAll();

            var languages = DeserializeLanguagesFile(languagesXmlFileLocation);

            try
            {

                foreach (var languageResourcesKeyValue in languages)
                {
                    _languageService.InsertLanguage(languageResourcesKeyValue.Key);
                    foreach (var resource in languageResourcesKeyValue.Value)
                    {
                        resource.LanguageId = languageResourcesKeyValue.Key.Id;
                        _localizationService.InsertLocaleStringResource(resource);
                    }
                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine("Problem installing languages. " + ex.Message);
                _errorNotifier.Notify(ex);
            }
        }

        public Dictionary<Language, List<LocaleStringResource>> DeserializeLanguagesFile(string languagesXmlFileLocation)
        {
            var result = new Dictionary<Language, List<LocaleStringResource>>();
            var originalXmlDocument = new XmlDocument();

            originalXmlDocument.Load(languagesXmlFileLocation);

            foreach (XmlNode languageNode in originalXmlDocument.SelectNodes(@"//Languages/Language"))
            {
                var language = GetLanguage(languageNode);
                var resultResources = new List<LocaleStringResource>();
                result.Add(language, resultResources);

                var resources = new List<LocaleStringResourceParent>();

                foreach (XmlNode resNode in languageNode.SelectNodes(@"LocaleResource"))
                    resources.Add(new LocaleStringResourceParent(resNode));

                //resources.Sort((x1, x2) => String.CompareOrdinal(x1.ResourceName, x2.ResourceName));
                //foreach (var resource in resources)
                //    RecursivelySortChildrenResource(resource);

                var sb = new StringBuilder();
                var writer = XmlWriter.Create(sb);
                writer.WriteStartDocument();
                writer.WriteStartElement("Language", "");

                writer.WriteStartAttribute("Name", "");
                writer.WriteString(languageNode.Attributes["Name"].InnerText.Trim());
                writer.WriteEndAttribute();

                foreach (var resource in resources)
                    RecursivelyWriteResource(resource, writer);

                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Flush();



                //read and parse resources (without <Children> elements)
                var resXml = new XmlDocument();
                var sr = new StringReader(sb.ToString());
                resXml.Load(sr);
                var resNodeList = resXml.SelectNodes(@"//Language/LocaleResource");
                foreach (XmlNode resNode in resNodeList)
                {
                    if (resNode.Attributes != null && resNode.Attributes["Name"] != null)
                    {
                        var resName = resNode.Attributes["Name"].InnerText.Trim();
                        var resValue = resNode.SelectSingleNode("Value").InnerText;
                        if (!String.IsNullOrEmpty(resName))
                        {
                            //ensure it's not duplicate
                            bool duplicate =
                                resultResources.Any(
                                    res1 =>
                                    resName.Equals(res1.ResourceName, StringComparison.InvariantCultureIgnoreCase));

                            if (duplicate)
                                continue;

                            //insert resource
                            var lsr = new LocaleStringResource
                            {
                                ResourceName = resName,
                                ResourceValue = resValue
                            };
                            resultResources.Add(lsr);
                        }
                    }
                }
            }
            return result;
        }

        #region Helpers

        /// <summary>
        /// Recursivelies the write resource.
        /// </summary>
        /// <param name="resource">The resource.</param>
        /// <param name="writer">The writer.</param>
        /// <remarks></remarks>
        private void RecursivelyWriteResource(LocaleStringResourceParent resource, XmlWriter writer)
        {
            //The value isn't actually used, but the name is used to create a namespace.
            if (resource.IsPersistable)
            {
                writer.WriteStartElement("LocaleResource", "");

                writer.WriteStartAttribute("Name", "");
                writer.WriteString(resource.NameWithNamespace);
                writer.WriteEndAttribute();

                writer.WriteStartElement("Value", "");
                writer.WriteString(resource.ResourceValue);
                writer.WriteEndElement();

                writer.WriteEndElement();
            }

            foreach (var child in resource.ChildLocaleStringResources)
            {
                RecursivelyWriteResource(child, writer);
            }
        }

        /// <summary>
        /// Gets the language.
        /// </summary>
        /// <param name="languageNode">The language node.</param>
        /// <returns>The language representing the current node</returns>
        /// <remarks></remarks>
        public Language GetLanguage(XmlNode languageNode)
        {
            var nameAttribute = languageNode.Attributes["Name"];
            if (nameAttribute == null || string.IsNullOrEmpty(nameAttribute.Value))
                throw new NoodleException("You must specify a name with every language element.");

            var cultureAttribute = languageNode.Attributes["CultureCode"];
            if (cultureAttribute == null || string.IsNullOrEmpty(cultureAttribute.Value))
                throw new NoodleException("You must specify a culture code with every language element.");

            try
            {
                new CultureInfo(cultureAttribute.Value);
            }
            catch
            {
                throw new NoodleException("{0} is not a valid culture code.", cultureAttribute.Value);
            }

            return new Language
            {
                Name = nameAttribute.Value,
                LanguageCulture = cultureAttribute.Value,
                Published = true
            };
        }

        #endregion

        #region Nested Types

        /// <summary>
        /// This class helps to manage recursive references
        /// </summary>
        /// <remarks></remarks>
        private class LocaleStringResourceParent : LocaleStringResource
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="LocaleStringResourceParent"/> class.
            /// </summary>
            /// <param name="localStringResource">The local string resource.</param>
            /// <param name="nameSpace">The name space.</param>
            /// <remarks></remarks>
            public LocaleStringResourceParent(XmlNode localStringResource, string nameSpace = "")
            {
                Namespace = nameSpace;
                var resNameAttribute = localStringResource.Attributes["Name"];
                var resValueNode = localStringResource.SelectSingleNode("Value");

                if (resNameAttribute == null)
                {
                    throw new NoodleException("All language resources must have an attribute Name=\"Value\".");
                }
                var resName = resNameAttribute.Value.Trim();
                if (string.IsNullOrEmpty(resName))
                {
                    throw new NoodleException("All languages resource attributes 'Name' must have a value.'");
                }
                ResourceName = resName;

                if (resValueNode == null || string.IsNullOrEmpty(resValueNode.InnerText.Trim()))
                {
                    IsPersistable = false;
                }
                else
                {
                    IsPersistable = true;
                    ResourceValue = resValueNode.InnerText.Trim();
                }

                foreach (XmlNode childResource in localStringResource.SelectNodes("Children/LocaleResource"))
                {
                    ChildLocaleStringResources.Add(new LocaleStringResourceParent(childResource, NameWithNamespace));
                }
            }
            /// <summary>
            /// Gets or sets the namespace.
            /// </summary>
            /// <value>The namespace.</value>
            /// <remarks></remarks>
            public string Namespace { get; set; }

            /// <summary>
            /// The child resources
            /// </summary>
            public IList<LocaleStringResourceParent> ChildLocaleStringResources = new List<LocaleStringResourceParent>();

            /// <summary>
            /// Gets or sets a value indicating whether this instance is persistable.
            /// </summary>
            /// <value><c>true</c> if this instance is persistable; otherwise, <c>false</c>.</value>
            /// <remarks></remarks>
            public bool IsPersistable { get; set; }

            /// <summary>
            /// Gets the name with namespace.
            /// </summary>
            /// <remarks></remarks>
            public string NameWithNamespace
            {
                get
                {
                    var newNamespace = Namespace;
                    if (!string.IsNullOrEmpty(newNamespace))
                    {
                        newNamespace += ".";
                    }
                    return newNamespace + ResourceName;
                }
            }
        }

        #endregion
    }
}