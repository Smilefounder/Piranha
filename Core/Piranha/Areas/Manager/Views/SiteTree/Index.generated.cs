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

namespace Piranha.Areas.Manager.Views.SiteTree
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Manager/Views/SiteTree/Index.cshtml")]
    public partial class Index : System.Web.Mvc.WebViewPage<Piranha.Areas.Manager.Models.SiteTreeListModel>
    {
        public Index()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Areas\Manager\Views\SiteTree\Index.cshtml"
  
    ViewBag.Title = Piranha.Resources.SiteTree.ListTitle ;

            
            #line default
            #line hidden
WriteLiteral("\r\n");

DefineSection("Head", () => {

WriteLiteral("\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n        var deletemsg = \'");

            
            #line 7 "..\..\Areas\Manager\Views\SiteTree\Index.cshtml"
                    Write(Piranha.Resources.SiteTree.MessageDeleteConfirm);

            
            #line default
            #line hidden
WriteLiteral(@"';

        $(document).ready(function () {
            // Setup list
            var options = {
                listClass:  'list-js',
                searchId: 'search',
                valueNames: ['title', 'description', 'updated', 'created']
            };
            new List('list', options);

            $('.list .delete').click(function () {
                return confirm(deletemsg);
            });
        });
    </script>
");

});

DefineSection("Toolbar", () => {

WriteLiteral(" \r\n");

            
            #line 24 "..\..\Areas\Manager\Views\SiteTree\Index.cshtml"
Write(Html.Partial("Partial/Tabs"));

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"toolbar\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"inner\"");

WriteLiteral(">\r\n        <ul>\r\n            <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 837), Tuple.Create("\"", 875)
            
            #line 28 "..\..\Areas\Manager\Views\SiteTree\Index.cshtml"
, Tuple.Create(Tuple.Create("", 844), Tuple.Create<System.Object, System.Int32>(Url.Action("edit", "sitetree")
            
            #line default
            #line hidden
, 844), false)
);

WriteLiteral(" class=\"add\"");

WriteLiteral(">");

            
            #line 28 "..\..\Areas\Manager\Views\SiteTree\Index.cshtml"
                                                                 Write(Piranha.Resources.Global.ToolbarAdd);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n            <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 954), Tuple.Create("\"", 981)
            
            #line 29 "..\..\Areas\Manager\Views\SiteTree\Index.cshtml"
, Tuple.Create(Tuple.Create("", 961), Tuple.Create<System.Object, System.Int32>(Url.Action("index")
            
            #line default
            #line hidden
, 961), false)
);

WriteLiteral(" class=\"refresh\"");

WriteLiteral(">");

            
            #line 29 "..\..\Areas\Manager\Views\SiteTree\Index.cshtml"
                                                          Write(Piranha.Resources.Global.ToolbarReload);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n");

WriteLiteral("            ");

            
            #line 30 "..\..\Areas\Manager\Views\SiteTree\Index.cshtml"
       Write(Piranha.WebPages.Hooks.Manager.Toolbar.Render(Url, Model));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </ul>\r\n        <button");

WriteLiteral(" class=\"search\"");

WriteAttribute("title", Tuple.Create(" title=\"", 1166), Tuple.Create("\"", 1213)
            
            #line 32 "..\..\Areas\Manager\Views\SiteTree\Index.cshtml"
, Tuple.Create(Tuple.Create("", 1174), Tuple.Create<System.Object, System.Int32>(Piranha.Resources.Global.ToolbarSearch
            
            #line default
            #line hidden
, 1174), false)
);

WriteLiteral("></button>");

            
            #line 32 "..\..\Areas\Manager\Views\SiteTree\Index.cshtml"
                                                                                   Write(Html.TextBox("search"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <div");

WriteLiteral(" class=\"clear\"");

WriteLiteral("></div>\r\n    </div>\r\n</div>\r\n");

});

WriteLiteral("<div");

WriteLiteral(" class=\"grid_12\"");

WriteLiteral(">\r\n    <table");

WriteLiteral(" id=\"list\"");

WriteLiteral(" class=\"list\"");

WriteLiteral(">\r\n        <thead>\r\n            <tr>\r\n                <th><span");

WriteLiteral(" class=\"sort asc\"");

WriteLiteral(" data-sort=\"title\"");

WriteLiteral(">");

            
            #line 41 "..\..\Areas\Manager\Views\SiteTree\Index.cshtml"
                                                        Write(Piranha.Resources.Global.Title);

            
            #line default
            #line hidden
WriteLiteral("</span></th>\r\n                <th><span");

WriteLiteral(" class=\"sort\"");

WriteLiteral(" data-sort=\"description\"");

WriteLiteral(">");

            
            #line 42 "..\..\Areas\Manager\Views\SiteTree\Index.cshtml"
                                                          Write(Piranha.Resources.Global.Description);

            
            #line default
            #line hidden
WriteLiteral("</span></th>\r\n                <th");

WriteLiteral(" class=\"date\"");

WriteLiteral("><span");

WriteLiteral(" class=\"sort\"");

WriteLiteral(" data-sort=\"updated\"");

WriteLiteral(">");

            
            #line 43 "..\..\Areas\Manager\Views\SiteTree\Index.cshtml"
                                                                   Write(Piranha.Resources.Global.Updated);

            
            #line default
            #line hidden
WriteLiteral("</span></th>\r\n                <th");

WriteLiteral(" class=\"date\"");

WriteLiteral("><span");

WriteLiteral(" class=\"sort\"");

WriteLiteral(" data-sort=\"created\"");

WriteLiteral(">");

            
            #line 44 "..\..\Areas\Manager\Views\SiteTree\Index.cshtml"
                                                                   Write(Piranha.Resources.Global.Created);

            
            #line default
            #line hidden
WriteLiteral("</span></th>\r\n                <th");

WriteLiteral(" class=\"one\"");

WriteLiteral("></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody");

WriteLiteral(" class=\"list-js\"");

WriteLiteral(">\r\n");

            
            #line 49 "..\..\Areas\Manager\Views\SiteTree\Index.cshtml"
            
            
            #line default
            #line hidden
            
            #line 49 "..\..\Areas\Manager\Views\SiteTree\Index.cshtml"
             foreach (var site in Model.Sites) {

            
            #line default
            #line hidden
WriteLiteral("            <tr>\r\n                <td");

WriteLiteral(" class=\"title\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 2072), Tuple.Create("\"", 2120)
            
            #line 51 "..\..\Areas\Manager\Views\SiteTree\Index.cshtml"
, Tuple.Create(Tuple.Create("", 2079), Tuple.Create<System.Object, System.Int32>(Url.Action("edit", new { id = site.Id })
            
            #line default
            #line hidden
, 2079), false)
);

WriteLiteral(">");

            
            #line 51 "..\..\Areas\Manager\Views\SiteTree\Index.cshtml"
                                                                                 Write(site.Name);

            
            #line default
            #line hidden
WriteLiteral("</a></td>\r\n                <td");

WriteLiteral(" class=\"description\"");

WriteLiteral(">");

            
            #line 52 "..\..\Areas\Manager\Views\SiteTree\Index.cshtml"
                                   Write(site.Description);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td");

WriteLiteral(" class=\"updated\"");

WriteLiteral(">");

            
            #line 53 "..\..\Areas\Manager\Views\SiteTree\Index.cshtml"
                               Write(site.Updated.ToString("yyyy-MM-dd"));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td");

WriteLiteral(" class=\"created\"");

WriteLiteral(">");

            
            #line 54 "..\..\Areas\Manager\Views\SiteTree\Index.cshtml"
                               Write(site.Created.ToString("yyyy-MM-dd"));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td");

WriteLiteral(" class=\"buttons\"");

WriteLiteral(">\r\n");

            
            #line 56 "..\..\Areas\Manager\Views\SiteTree\Index.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 56 "..\..\Areas\Manager\Views\SiteTree\Index.cshtml"
                     if (Model.CanDeleteSite[site.Id] && site.Id != Piranha.Config.DefaultSiteTreeId) {

            
            #line default
            #line hidden
WriteLiteral("                    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 2530), Tuple.Create("\"", 2580)
            
            #line 57 "..\..\Areas\Manager\Views\SiteTree\Index.cshtml"
, Tuple.Create(Tuple.Create("", 2537), Tuple.Create<System.Object, System.Int32>(Url.Action("delete", new { id = site.Id })
            
            #line default
            #line hidden
, 2537), false)
);

WriteLiteral(" title=\"\"");

WriteLiteral(" class=\"icon delete\"");

WriteLiteral("></a>\r\n");

            
            #line 58 "..\..\Areas\Manager\Views\SiteTree\Index.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </td>\r\n            </tr>\r\n");

            
            #line 61 "..\..\Areas\Manager\Views\SiteTree\Index.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
