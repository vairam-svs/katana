﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18213
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Owin.Diagnostics.Views {
    
    #line 1 "DiagnosticsPage.cshtml"
    using System;
    
    #line default
    #line hidden
    
    #line 2 "DiagnosticsPage.cshtml"
    using System.Globalization;
    
    #line default
    #line hidden
    
    
    public class DiagnosticsPage : Microsoft.Owin.Diagnostics.Views.BaseView {
        
#line hidden
        
        public DiagnosticsPage() {
        }
        
        public override void Execute() {
            
            #line 3 "DiagnosticsPage.cshtml"
  
    Response.ContentType = "text/html";
    string error = Request.Query.Get("error");
    if (!string.IsNullOrWhiteSpace(error))
    {
        throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture, "User requested error '{0}'", error));
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html");

WriteLiteral(" lang=\"en\"");

WriteLiteral(" xmlns=\"http://www.w3.org/1999/xhtml\"");

WriteLiteral(">\r\n<head>\r\n    <meta");

WriteLiteral(" charset=\"utf-8\"");

WriteLiteral(" />\r\n    <title>");

            
            #line 16 "DiagnosticsPage.cshtml"
      Write(Resources.DiagnosticsPageHtml_Title);

            
            #line default
            #line hidden
WriteLiteral("</title>\r\n</head>\r\n<body>\r\n    <div");

WriteLiteral(" class=\"main\"");

WriteLiteral(">\r\n        <h1>");

            
            #line 20 "DiagnosticsPage.cshtml"
       Write(Resources.DiagnosticsPageHtml_Title);

            
            #line default
            #line hidden
WriteLiteral("</h1>\r\n        <p>");

            
            #line 21 "DiagnosticsPage.cshtml"
      Write(Resources.DiagnosticsPageHtml_Information);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"errors\"");

WriteLiteral(">\r\n        <h2>");

            
            #line 24 "DiagnosticsPage.cshtml"
       Write(Resources.DiagnosticsPageHtml_TestErrorSection);

            
            #line default
            #line hidden
WriteLiteral("</h2>\r\n        <p><a");

WriteAttribute("href", Tuple.Create(" href=\"", 767), Tuple.Create("\"", 858)
            
            #line 25 "DiagnosticsPage.cshtml"
, Tuple.Create(Tuple.Create("", 774), Tuple.Create<System.Object, System.Int32>(Request.PathBase
            
            #line default
            #line hidden
, 774), false)
            
            #line 25 "DiagnosticsPage.cshtml"
, Tuple.Create(Tuple.Create("", 791), Tuple.Create<System.Object, System.Int32>(Request.Path
            
            #line default
            #line hidden
, 791), false)
, Tuple.Create(Tuple.Create("", 804), Tuple.Create("?error=", 804), true)
            
            #line 25 "DiagnosticsPage.cshtml"
, Tuple.Create(Tuple.Create("", 811), Tuple.Create<System.Object, System.Int32>(Resources.DiagnosticsPageHtml_TestErrorMessage
            
            #line default
            #line hidden
, 811), false)
);

WriteLiteral(">throw InvalidOperationException</a></p>\r\n    </div>\r\n</body>\r\n</html>\r\n");

        }
    }
}
