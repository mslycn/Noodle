﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Noodle.Localization.XmlEditor.Bing {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TranslateOptions", Namespace="http://schemas.datacontract.org/2004/07/Microsoft.MT.Web.Service.V2")]
    [System.SerializableAttribute()]
    public partial class TranslateOptions : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CategoryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ContentTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IncludeMultipleMTAlternativesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ReservedFlagsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UriField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Category {
            get {
                return this.CategoryField;
            }
            set {
                if ((object.ReferenceEquals(this.CategoryField, value) != true)) {
                    this.CategoryField = value;
                    this.RaisePropertyChanged("Category");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string ContentType {
            get {
                return this.ContentTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.ContentTypeField, value) != true)) {
                    this.ContentTypeField = value;
                    this.RaisePropertyChanged("ContentType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public bool IncludeMultipleMTAlternatives {
            get {
                return this.IncludeMultipleMTAlternativesField;
            }
            set {
                if ((this.IncludeMultipleMTAlternativesField.Equals(value) != true)) {
                    this.IncludeMultipleMTAlternativesField = value;
                    this.RaisePropertyChanged("IncludeMultipleMTAlternatives");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string ReservedFlags {
            get {
                return this.ReservedFlagsField;
            }
            set {
                if ((object.ReferenceEquals(this.ReservedFlagsField, value) != true)) {
                    this.ReservedFlagsField = value;
                    this.RaisePropertyChanged("ReservedFlags");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string State {
            get {
                return this.StateField;
            }
            set {
                if ((object.ReferenceEquals(this.StateField, value) != true)) {
                    this.StateField = value;
                    this.RaisePropertyChanged("State");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Uri {
            get {
                return this.UriField;
            }
            set {
                if ((object.ReferenceEquals(this.UriField, value) != true)) {
                    this.UriField = value;
                    this.RaisePropertyChanged("Uri");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string User {
            get {
                return this.UserField;
            }
            set {
                if ((object.ReferenceEquals(this.UserField, value) != true)) {
                    this.UserField = value;
                    this.RaisePropertyChanged("User");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetTranslationsResponse", Namespace="http://schemas.datacontract.org/2004/07/Microsoft.MT.Web.Service.V2")]
    [System.SerializableAttribute()]
    public partial class GetTranslationsResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FromField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Noodle.Localization.XmlEditor.Bing.TranslationMatch[] TranslationsField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string From {
            get {
                return this.FromField;
            }
            set {
                if ((object.ReferenceEquals(this.FromField, value) != true)) {
                    this.FromField = value;
                    this.RaisePropertyChanged("From");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string State {
            get {
                return this.StateField;
            }
            set {
                if ((object.ReferenceEquals(this.StateField, value) != true)) {
                    this.StateField = value;
                    this.RaisePropertyChanged("State");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public Noodle.Localization.XmlEditor.Bing.TranslationMatch[] Translations {
            get {
                return this.TranslationsField;
            }
            set {
                if ((object.ReferenceEquals(this.TranslationsField, value) != true)) {
                    this.TranslationsField = value;
                    this.RaisePropertyChanged("Translations");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TranslationMatch", Namespace="http://schemas.datacontract.org/2004/07/Microsoft.MT.Web.Service.V2")]
    [System.SerializableAttribute()]
    public partial class TranslationMatch : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int CountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorField;
        
        private int MatchDegreeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MatchedOriginalTextField;
        
        private int RatingField;
        
        private string TranslatedTextField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int Count {
            get {
                return this.CountField;
            }
            set {
                if ((this.CountField.Equals(value) != true)) {
                    this.CountField = value;
                    this.RaisePropertyChanged("Count");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Error {
            get {
                return this.ErrorField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorField, value) != true)) {
                    this.ErrorField = value;
                    this.RaisePropertyChanged("Error");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int MatchDegree {
            get {
                return this.MatchDegreeField;
            }
            set {
                if ((this.MatchDegreeField.Equals(value) != true)) {
                    this.MatchDegreeField = value;
                    this.RaisePropertyChanged("MatchDegree");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string MatchedOriginalText {
            get {
                return this.MatchedOriginalTextField;
            }
            set {
                if ((object.ReferenceEquals(this.MatchedOriginalTextField, value) != true)) {
                    this.MatchedOriginalTextField = value;
                    this.RaisePropertyChanged("MatchedOriginalText");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int Rating {
            get {
                return this.RatingField;
            }
            set {
                if ((this.RatingField.Equals(value) != true)) {
                    this.RatingField = value;
                    this.RaisePropertyChanged("Rating");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string TranslatedText {
            get {
                return this.TranslatedTextField;
            }
            set {
                if ((object.ReferenceEquals(this.TranslatedTextField, value) != true)) {
                    this.TranslatedTextField = value;
                    this.RaisePropertyChanged("TranslatedText");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Translation", Namespace="http://schemas.datacontract.org/2004/07/Microsoft.MT.Web.Service.V2")]
    [System.SerializableAttribute()]
    public partial class Translation : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string OriginalTextField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int RatingField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SequenceField;
        
        private string TranslatedTextField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string OriginalText {
            get {
                return this.OriginalTextField;
            }
            set {
                if ((object.ReferenceEquals(this.OriginalTextField, value) != true)) {
                    this.OriginalTextField = value;
                    this.RaisePropertyChanged("OriginalText");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public int Rating {
            get {
                return this.RatingField;
            }
            set {
                if ((this.RatingField.Equals(value) != true)) {
                    this.RatingField = value;
                    this.RaisePropertyChanged("Rating");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public int Sequence {
            get {
                return this.SequenceField;
            }
            set {
                if ((this.SequenceField.Equals(value) != true)) {
                    this.SequenceField = value;
                    this.RaisePropertyChanged("Sequence");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string TranslatedText {
            get {
                return this.TranslatedTextField;
            }
            set {
                if ((object.ReferenceEquals(this.TranslatedTextField, value) != true)) {
                    this.TranslatedTextField = value;
                    this.RaisePropertyChanged("TranslatedText");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TranslateArrayResponse", Namespace="http://schemas.datacontract.org/2004/07/Microsoft.MT.Web.Service.V2")]
    [System.SerializableAttribute()]
    public partial class TranslateArrayResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FromField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int[] OriginalTextSentenceLengthsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TranslatedTextField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int[] TranslatedTextSentenceLengthsField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Error {
            get {
                return this.ErrorField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorField, value) != true)) {
                    this.ErrorField = value;
                    this.RaisePropertyChanged("Error");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string From {
            get {
                return this.FromField;
            }
            set {
                if ((object.ReferenceEquals(this.FromField, value) != true)) {
                    this.FromField = value;
                    this.RaisePropertyChanged("From");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public int[] OriginalTextSentenceLengths {
            get {
                return this.OriginalTextSentenceLengthsField;
            }
            set {
                if ((object.ReferenceEquals(this.OriginalTextSentenceLengthsField, value) != true)) {
                    this.OriginalTextSentenceLengthsField = value;
                    this.RaisePropertyChanged("OriginalTextSentenceLengths");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string State {
            get {
                return this.StateField;
            }
            set {
                if ((object.ReferenceEquals(this.StateField, value) != true)) {
                    this.StateField = value;
                    this.RaisePropertyChanged("State");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string TranslatedText {
            get {
                return this.TranslatedTextField;
            }
            set {
                if ((object.ReferenceEquals(this.TranslatedTextField, value) != true)) {
                    this.TranslatedTextField = value;
                    this.RaisePropertyChanged("TranslatedText");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public int[] TranslatedTextSentenceLengths {
            get {
                return this.TranslatedTextSentenceLengthsField;
            }
            set {
                if ((object.ReferenceEquals(this.TranslatedTextSentenceLengthsField, value) != true)) {
                    this.TranslatedTextSentenceLengthsField = value;
                    this.RaisePropertyChanged("TranslatedTextSentenceLengths");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TranslateArray2Response", Namespace="http://schemas.datacontract.org/2004/07/Microsoft.MT.Web.Service.V2")]
    [System.SerializableAttribute()]
    public partial class TranslateArray2Response : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AlignmentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FromField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int[] OriginalTextSentenceLengthsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TranslatedTextField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int[] TranslatedTextSentenceLengthsField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Alignment {
            get {
                return this.AlignmentField;
            }
            set {
                if ((object.ReferenceEquals(this.AlignmentField, value) != true)) {
                    this.AlignmentField = value;
                    this.RaisePropertyChanged("Alignment");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Error {
            get {
                return this.ErrorField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorField, value) != true)) {
                    this.ErrorField = value;
                    this.RaisePropertyChanged("Error");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string From {
            get {
                return this.FromField;
            }
            set {
                if ((object.ReferenceEquals(this.FromField, value) != true)) {
                    this.FromField = value;
                    this.RaisePropertyChanged("From");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public int[] OriginalTextSentenceLengths {
            get {
                return this.OriginalTextSentenceLengthsField;
            }
            set {
                if ((object.ReferenceEquals(this.OriginalTextSentenceLengthsField, value) != true)) {
                    this.OriginalTextSentenceLengthsField = value;
                    this.RaisePropertyChanged("OriginalTextSentenceLengths");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string State {
            get {
                return this.StateField;
            }
            set {
                if ((object.ReferenceEquals(this.StateField, value) != true)) {
                    this.StateField = value;
                    this.RaisePropertyChanged("State");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string TranslatedText {
            get {
                return this.TranslatedTextField;
            }
            set {
                if ((object.ReferenceEquals(this.TranslatedTextField, value) != true)) {
                    this.TranslatedTextField = value;
                    this.RaisePropertyChanged("TranslatedText");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public int[] TranslatedTextSentenceLengths {
            get {
                return this.TranslatedTextSentenceLengthsField;
            }
            set {
                if ((object.ReferenceEquals(this.TranslatedTextSentenceLengthsField, value) != true)) {
                    this.TranslatedTextSentenceLengthsField = value;
                    this.RaisePropertyChanged("TranslatedTextSentenceLengths");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://api.microsofttranslator.com/V2", ConfigurationName="Bing.LanguageService")]
    public interface LanguageService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://api.microsofttranslator.com/V2/LanguageService/AddTranslation", ReplyAction="http://api.microsofttranslator.com/V2/LanguageService/AddTranslationResponse")]
        void AddTranslation(string appId, string originalText, string translatedText, string from, string to, int rating, string contentType, string category, string user, string uri);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://api.microsofttranslator.com/V2/LanguageService/BreakSentences", ReplyAction="http://api.microsofttranslator.com/V2/LanguageService/BreakSentencesResponse")]
        int[] BreakSentences(string appId, string text, string language);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://api.microsofttranslator.com/V2/LanguageService/Detect", ReplyAction="http://api.microsofttranslator.com/V2/LanguageService/DetectResponse")]
        string Detect(string appId, string text);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://api.microsofttranslator.com/V2/LanguageService/DetectArray", ReplyAction="http://api.microsofttranslator.com/V2/LanguageService/DetectArrayResponse")]
        string[] DetectArray(string appId, string[] texts);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://api.microsofttranslator.com/V2/LanguageService/GetAppIdToken", ReplyAction="http://api.microsofttranslator.com/V2/LanguageService/GetAppIdTokenResponse")]
        string GetAppIdToken(string appId, int minRatingRead, int maxRatingWrite, int expireSeconds);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://api.microsofttranslator.com/V2/LanguageService/GetLanguageNames", ReplyAction="http://api.microsofttranslator.com/V2/LanguageService/GetLanguageNamesResponse")]
        string[] GetLanguageNames(string appId, string locale, string[] languageCodes);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://api.microsofttranslator.com/V2/LanguageService/GetLanguagesForSpeak", ReplyAction="http://api.microsofttranslator.com/V2/LanguageService/GetLanguagesForSpeakRespons" +
            "e")]
        string[] GetLanguagesForSpeak(string appId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://api.microsofttranslator.com/V2/LanguageService/GetLanguagesForTranslate", ReplyAction="http://api.microsofttranslator.com/V2/LanguageService/GetLanguagesForTranslateRes" +
            "ponse")]
        string[] GetLanguagesForTranslate(string appId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://api.microsofttranslator.com/V2/LanguageService/GetTranslations", ReplyAction="http://api.microsofttranslator.com/V2/LanguageService/GetTranslationsResponse")]
        Noodle.Localization.XmlEditor.Bing.GetTranslationsResponse GetTranslations(string appId, string text, string from, string to, int maxTranslations, Noodle.Localization.XmlEditor.Bing.TranslateOptions options);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://api.microsofttranslator.com/V2/LanguageService/Translate", ReplyAction="http://api.microsofttranslator.com/V2/LanguageService/TranslateResponse")]
        string Translate(string appId, string text, string from, string to, string contentType, string category);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://api.microsofttranslator.com/V2/LanguageService/AddTranslationArray", ReplyAction="http://api.microsofttranslator.com/V2/LanguageService/AddTranslationArrayResponse" +
            "")]
        void AddTranslationArray(string appId, Noodle.Localization.XmlEditor.Bing.Translation[] translations, string from, string to, Noodle.Localization.XmlEditor.Bing.TranslateOptions options);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://api.microsofttranslator.com/V2/LanguageService/GetTranslationsArray", ReplyAction="http://api.microsofttranslator.com/V2/LanguageService/GetTranslationsArrayRespons" +
            "e")]
        Noodle.Localization.XmlEditor.Bing.GetTranslationsResponse[] GetTranslationsArray(string appId, string[] texts, string from, string to, int maxTranslations, Noodle.Localization.XmlEditor.Bing.TranslateOptions options);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://api.microsofttranslator.com/V2/LanguageService/Speak", ReplyAction="http://api.microsofttranslator.com/V2/LanguageService/SpeakResponse")]
        string Speak(string appId, string text, string language, string format, string options);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://api.microsofttranslator.com/V2/LanguageService/TranslateArray", ReplyAction="http://api.microsofttranslator.com/V2/LanguageService/TranslateArrayResponse")]
        Noodle.Localization.XmlEditor.Bing.TranslateArrayResponse[] TranslateArray(string appId, string[] texts, string from, string to, Noodle.Localization.XmlEditor.Bing.TranslateOptions options);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://api.microsofttranslator.com/V2/LanguageService/TranslateArray2", ReplyAction="http://api.microsofttranslator.com/V2/LanguageService/TranslateArray2Response")]
        Noodle.Localization.XmlEditor.Bing.TranslateArray2Response[] TranslateArray2(string appId, string[] texts, string from, string to, Noodle.Localization.XmlEditor.Bing.TranslateOptions options);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface LanguageServiceChannel : Noodle.Localization.XmlEditor.Bing.LanguageService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LanguageServiceClient : System.ServiceModel.ClientBase<Noodle.Localization.XmlEditor.Bing.LanguageService>, Noodle.Localization.XmlEditor.Bing.LanguageService {
        
        public LanguageServiceClient() {
        }
        
        public LanguageServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LanguageServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LanguageServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LanguageServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void AddTranslation(string appId, string originalText, string translatedText, string from, string to, int rating, string contentType, string category, string user, string uri) {
            base.Channel.AddTranslation(appId, originalText, translatedText, from, to, rating, contentType, category, user, uri);
        }
        
        public int[] BreakSentences(string appId, string text, string language) {
            return base.Channel.BreakSentences(appId, text, language);
        }
        
        public string Detect(string appId, string text) {
            return base.Channel.Detect(appId, text);
        }
        
        public string[] DetectArray(string appId, string[] texts) {
            return base.Channel.DetectArray(appId, texts);
        }
        
        public string GetAppIdToken(string appId, int minRatingRead, int maxRatingWrite, int expireSeconds) {
            return base.Channel.GetAppIdToken(appId, minRatingRead, maxRatingWrite, expireSeconds);
        }
        
        public string[] GetLanguageNames(string appId, string locale, string[] languageCodes) {
            return base.Channel.GetLanguageNames(appId, locale, languageCodes);
        }
        
        public string[] GetLanguagesForSpeak(string appId) {
            return base.Channel.GetLanguagesForSpeak(appId);
        }
        
        public string[] GetLanguagesForTranslate(string appId) {
            return base.Channel.GetLanguagesForTranslate(appId);
        }
        
        public Noodle.Localization.XmlEditor.Bing.GetTranslationsResponse GetTranslations(string appId, string text, string from, string to, int maxTranslations, Noodle.Localization.XmlEditor.Bing.TranslateOptions options) {
            return base.Channel.GetTranslations(appId, text, from, to, maxTranslations, options);
        }
        
        public string Translate(string appId, string text, string from, string to, string contentType, string category) {
            return base.Channel.Translate(appId, text, from, to, contentType, category);
        }
        
        public void AddTranslationArray(string appId, Noodle.Localization.XmlEditor.Bing.Translation[] translations, string from, string to, Noodle.Localization.XmlEditor.Bing.TranslateOptions options) {
            base.Channel.AddTranslationArray(appId, translations, from, to, options);
        }
        
        public Noodle.Localization.XmlEditor.Bing.GetTranslationsResponse[] GetTranslationsArray(string appId, string[] texts, string from, string to, int maxTranslations, Noodle.Localization.XmlEditor.Bing.TranslateOptions options) {
            return base.Channel.GetTranslationsArray(appId, texts, from, to, maxTranslations, options);
        }
        
        public string Speak(string appId, string text, string language, string format, string options) {
            return base.Channel.Speak(appId, text, language, format, options);
        }
        
        public Noodle.Localization.XmlEditor.Bing.TranslateArrayResponse[] TranslateArray(string appId, string[] texts, string from, string to, Noodle.Localization.XmlEditor.Bing.TranslateOptions options) {
            return base.Channel.TranslateArray(appId, texts, from, to, options);
        }
        
        public Noodle.Localization.XmlEditor.Bing.TranslateArray2Response[] TranslateArray2(string appId, string[] texts, string from, string to, Noodle.Localization.XmlEditor.Bing.TranslateOptions options) {
            return base.Channel.TranslateArray2(appId, texts, from, to, options);
        }
    }
}
