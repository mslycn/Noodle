﻿using System;
using System.Collections.Generic;
using System.Globalization;
using Noodle.Web;

#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Noodle.Diagnostics
{
    
    #line 2 "..\..\Diagnostics\Diagnostics.cshtml"

    #line default
    #line hidden
    
    #line 3 "..\..\Diagnostics\Diagnostics.cshtml"
#line default
    #line hidden
    
    #line 4 "..\..\Diagnostics\Diagnostics.cshtml"
#line default
    #line hidden
    
    #line 5 "..\..\Diagnostics\Diagnostics.cshtml"
#line default
    #line hidden
#line 6 "..\..\Diagnostics\Diagnostics.cshtml"

#line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.4.1.0")]
    internal partial class Diagnostics : RazorPageBase
    {
#line hidden

        #line 8 "..\..\Diagnostics\Diagnostics.cshtml"

    public List<DiagnosticsPlugin> DiagnosticsPlugins { get; set; }

        #line default
        #line hidden

        public override void Execute()
        {


WriteLiteral("\r\n");








WriteLiteral(@"
<!DOCTYPE html>
<html>
<head>
    <meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge,chrome=1"">
    <title>MethodFactory Diagnostics</title>
    <meta name=""description"" content="""">
    <meta name=""viewport"" content=""width=device-width"">
    <link rel=""stylesheet"" href=""/method/embedded/bootstrapcss"" />
    <script type=""text/javascript"" src=""/method/embedded/jquery""></script>
    <script type=""text/javascript"" src=""/method/embedded/bootstrapjs""></script>
</head>
<body>
    <div class=""container"">
        <div class=""row"">
            <div class=""span12"">
                <div class=""page-header"">
                    <h1>Diagnostics</h1>
                </div>
            </div>
            <div class=""span12"">
                <div class=""accordion"" id=""diagnostics-accordian"">
");


            
            #line 33 "..\..\Diagnostics\Diagnostics.cshtml"
                     foreach (var plugin in DiagnosticsPlugins)
                    {
                        var name = plugin.GetType().Name.ToLower();

            
            #line default
            #line hidden
WriteLiteral("                        <div class=\"accordion-group\">\r\n                          " +
"  <div class=\"accordion-heading\">\r\n                                <a class=\"acc" +
"ordion-toggle\" data-toggle=\"collapse\" data-parent=\"#diagnostics-accordian\" href=" +
"\"#");


            
            #line 38 "..\..\Diagnostics\Diagnostics.cshtml"
                                                                                                                          Write(name);

            
            #line default
            #line hidden
WriteLiteral("\">");


            
            #line 38 "..\..\Diagnostics\Diagnostics.cshtml"
                                                                                                                                 Write(plugin.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                            </div>\r\n                            <div id=\"");


            
            #line 40 "..\..\Diagnostics\Diagnostics.cshtml"
                                Write(name);

            
            #line default
            #line hidden
WriteLiteral("\" class=\"accordion-body collapse out\">\r\n                                <div clas" +
"s=\"accordion-inner\">\r\n                                    ");


            
            #line 42 "..\..\Diagnostics\Diagnostics.cshtml"
                               Write(Html(plugin.BuildHtml()));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n   " +
"                     </div>\r\n");


            
            #line 46 "..\..\Diagnostics\Diagnostics.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </div>\r\n                <hr />\r\n                ");


            
            #line 49 "..\..\Diagnostics\Diagnostics.cshtml"
           Write(DateTime.Now.ToString(CultureInfo.InvariantCulture));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</body>\r\n</html>\r\n");


        }
    }
}
#pragma warning restore 1591
