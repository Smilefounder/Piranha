﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Piranha.Areas.Manager.Views.Extensions
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Piranha.Web;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Manager/Views/Extensions/MarkdownRegion.cshtml")]
    public partial class MarkdownRegion : System.Web.Mvc.WebViewPage<Piranha.Extend.Regions.MarkdownRegion>
    {
        public MarkdownRegion()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Areas\Manager\Views\Extensions\MarkdownRegion.cshtml"
  
    var id = ViewData.TemplateInfo.GetFullHtmlFieldId("") ;

            
            #line default
            #line hidden
WriteLiteral("\r\n<style");

WriteLiteral(" type=\"text/css\"");

WriteLiteral(@">
    .markdown-container {
        border-top: 1px solid #ddd;
        padding-left: 10px;
    }
    .markdown {
        border: 0;
        width: 100%;
        max-width: 853px;
        min-width: 100%;
        height: 400px;
        overflow-y: visible;
    }
</style>
<div");

WriteLiteral(" class=\"markdown-container\"");

WriteLiteral(">\r\n");

WriteLiteral("    ");

            
            #line 20 "..\..\Areas\Manager\Views\Extensions\MarkdownRegion.cshtml"
Write(Html.TextAreaFor(m => m, new { @rows = 10, @class = "markdown" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
