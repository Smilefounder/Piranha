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

namespace Piranha.Areas.Manager.Views.Shared.Partial
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Manager/Views/Shared/Partial/TinyMCE.cshtml")]
    public partial class TinyMCE : System.Web.Mvc.WebViewPage<dynamic>
    {
        public TinyMCE()
        {
        }
        public override void Execute()
        {
WriteLiteral("<script");

WriteLiteral(" type=\"text/javascript\"");

WriteAttribute("src", Tuple.Create(" src=\"", 30), Tuple.Create("\"", 99)
, Tuple.Create(Tuple.Create("", 36), Tuple.Create<System.Object, System.Int32>(Href("~/res.ashx/areas/manager/content/js/ext/tiny_mce/tinymce.min.js")
, 36), false)
);

WriteLiteral("></script>\r\n<script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(@">
    tinymce.init({
        mode: 'specific_textareas',
        editor_selector: ""editor"",
        convert_urls: false,
        plugins: [
            ""autoresize autolink code hr paste piranhaimage link""
        ],
        width: ""100%"",
        height: ""340"",
        autoresize_min_height: 340,
");

            
            #line 13 "..\..\Areas\Manager\Views\Shared\Partial\TinyMCE.cshtml"
        
            
            #line default
            #line hidden
            
            #line 13 "..\..\Areas\Manager\Views\Shared\Partial\TinyMCE.cshtml"
         if (File.Exists(Server.MapPath("~/areas/manager/content/css/editor.css"))) {

            
            #line default
            #line hidden
WriteLiteral("        ");

WriteLiteral("content_css: \"");

            
            #line 14 "..\..\Areas\Manager\Views\Shared\Partial\TinyMCE.cshtml"
                       Write(Url.Content("~/areas/manager/content/css/editor.css"));

            
            #line default
            #line hidden
WriteLiteral("\",");

WriteLiteral("\r\n");

            
            #line 15 "..\..\Areas\Manager\Views\Shared\Partial\TinyMCE.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("        toolbar: \"bold italic underline | bullist numlist hr | formatselect remov" +
"eformat | cut copy paste | link piranhaimage | code\",\r\n    });\r\n</script>\r\n");

        }
    }
}
#pragma warning restore 1591
