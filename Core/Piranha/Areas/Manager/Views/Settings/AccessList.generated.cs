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

namespace Piranha.Areas.Manager.Views.Settings
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Manager/Views/Settings/AccessList.cshtml")]
    public partial class AccessList : System.Web.Mvc.WebViewPage<Piranha.Models.Manager.SettingModels.AccessListModel>
    {
        public AccessList()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Areas\Manager\Views\Settings\AccessList.cshtml"
  
    ViewBag.Title = @Piranha.Resources.Settings.ListTitleAccess ;

            
            #line default
            #line hidden
WriteLiteral("\r\n");

DefineSection("Head", () => {

WriteLiteral("\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(@">
        $(document).ready(function () {
            $(document).ready(function () {
                var options = {
                    listClass: 'list-js',
                    searchId: 'search',
                    valueNames: ['name', 'group', 'updated', 'created']
                };
                var list = new List('list', options);
            });
        });
    </script>
");

});

DefineSection("Toolbar", () => {

WriteLiteral("\r\n");

            
            #line 20 "..\..\Areas\Manager\Views\Settings\AccessList.cshtml"
Write(Html.Partial("Partial/Tabs"));

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"toolbar\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"inner\"");

WriteLiteral(">\r\n        <ul>\r\n            <li");

WriteLiteral(" id=\"add\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 728), Tuple.Create("\"", 756)
            
            #line 24 "..\..\Areas\Manager\Views\Settings\AccessList.cshtml"
, Tuple.Create(Tuple.Create("", 735), Tuple.Create<System.Object, System.Int32>(Url.Action("access")
            
            #line default
            #line hidden
, 735), false)
);

WriteLiteral(" class=\"add\"");

WriteLiteral(">");

            
            #line 24 "..\..\Areas\Manager\Views\Settings\AccessList.cshtml"
                                                                Write(Piranha.Resources.Global.ToolbarAdd);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n            <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 835), Tuple.Create("\"", 867)
            
            #line 25 "..\..\Areas\Manager\Views\Settings\AccessList.cshtml"
, Tuple.Create(Tuple.Create("", 842), Tuple.Create<System.Object, System.Int32>(Url.Action("accesslist")
            
            #line default
            #line hidden
, 842), false)
);

WriteLiteral(" class=\"refresh\"");

WriteLiteral(">");

            
            #line 25 "..\..\Areas\Manager\Views\Settings\AccessList.cshtml"
                                                               Write(Piranha.Resources.Global.ToolbarReload);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n        </ul>\r\n        <button");

WriteLiteral(" class=\"search\"");

WriteLiteral("></button>");

            
            #line 27 "..\..\Areas\Manager\Views\Settings\AccessList.cshtml"
                                   Write(Html.TextBox("search"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <div");

WriteLiteral(" class=\"clear\"");

WriteLiteral("></div>\r\n    </div>\r\n</div>\r\n");

});

WriteLiteral("\r\n<div");

WriteLiteral(" class=\"grid_12\"");

WriteLiteral(">\r\n    <table");

WriteLiteral(" id=\"list\"");

WriteLiteral(" class=\"list\"");

WriteLiteral(">\r\n        <thead>\r\n            <tr>\r\n                <th><span");

WriteLiteral(" class=\"sort asc\"");

WriteLiteral(" data-sort=\"name\"");

WriteLiteral(">");

            
            #line 37 "..\..\Areas\Manager\Views\Settings\AccessList.cshtml"
                                                       Write(Piranha.Resources.Global.Name);

            
            #line default
            #line hidden
WriteLiteral("</span></th>\r\n                <th><span");

WriteLiteral(" class=\"sort\"");

WriteLiteral(" data-sort=\"group\"");

WriteLiteral(">");

            
            #line 38 "..\..\Areas\Manager\Views\Settings\AccessList.cshtml"
                                                    Write(Piranha.Resources.Global.Group);

            
            #line default
            #line hidden
WriteLiteral("</span></th>\r\n                <th");

WriteLiteral(" class=\"date\"");

WriteLiteral("><span");

WriteLiteral(" class=\"sort\"");

WriteLiteral(" data-sort=\"updated\"");

WriteLiteral(">");

            
            #line 39 "..\..\Areas\Manager\Views\Settings\AccessList.cshtml"
                                                                   Write(Piranha.Resources.Global.Updated);

            
            #line default
            #line hidden
WriteLiteral("</span></th>\r\n                <th");

WriteLiteral(" class=\"date\"");

WriteLiteral("><span");

WriteLiteral(" class=\"sort\"");

WriteLiteral(" data-sort=\"created\"");

WriteLiteral(">");

            
            #line 40 "..\..\Areas\Manager\Views\Settings\AccessList.cshtml"
                                                                   Write(Piranha.Resources.Global.Created);

            
            #line default
            #line hidden
WriteLiteral("</span></th>\r\n                <th");

WriteLiteral(" class=\"one\"");

WriteLiteral("></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody");

WriteLiteral(" class=\"list-js\"");

WriteLiteral(">\r\n");

            
            #line 45 "..\..\Areas\Manager\Views\Settings\AccessList.cshtml"
            
            
            #line default
            #line hidden
            
            #line 45 "..\..\Areas\Manager\Views\Settings\AccessList.cshtml"
             foreach (var access in Model.Access) {

            
            #line default
            #line hidden
WriteLiteral("            <tr>\r\n                <td");

WriteLiteral(" class=\"name\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1828), Tuple.Create("\"", 1880)
            
            #line 47 "..\..\Areas\Manager\Views\Settings\AccessList.cshtml"
, Tuple.Create(Tuple.Create("", 1835), Tuple.Create<System.Object, System.Int32>(Url.Action("access", new { id = access.Id })
            
            #line default
            #line hidden
, 1835), false)
);

WriteLiteral(">");

            
            #line 47 "..\..\Areas\Manager\Views\Settings\AccessList.cshtml"
                                                                                    Write(access.Function);

            
            #line default
            #line hidden
WriteLiteral("</a></td>\r\n                <td");

WriteLiteral(" class=\"group\"");

WriteLiteral(">");

            
            #line 48 "..\..\Areas\Manager\Views\Settings\AccessList.cshtml"
                             Write(access.GroupName);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td");

WriteLiteral(" class=\"updated\"");

WriteLiteral(">");

            
            #line 49 "..\..\Areas\Manager\Views\Settings\AccessList.cshtml"
                               Write(access.Updated.ToString("yyyy-MM-dd"));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td");

WriteLiteral(" class=\"created\"");

WriteLiteral(">");

            
            #line 50 "..\..\Areas\Manager\Views\Settings\AccessList.cshtml"
                               Write(access.Created.ToString("yyyy-MM-dd"));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td");

WriteLiteral(" class=\"buttons\"");

WriteLiteral(">\r\n");

            
            #line 52 "..\..\Areas\Manager\Views\Settings\AccessList.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 52 "..\..\Areas\Manager\Views\Settings\AccessList.cshtml"
                     if (!access.IsLocked) {

            
            #line default
            #line hidden
WriteLiteral("                    <a");

WriteLiteral(" class=\"icon delete\"");

WriteAttribute("href", Tuple.Create(" href=\"", 2255), Tuple.Create("\"", 2313)
            
            #line 53 "..\..\Areas\Manager\Views\Settings\AccessList.cshtml"
, Tuple.Create(Tuple.Create("", 2262), Tuple.Create<System.Object, System.Int32>(Url.Action("deleteaccess", new { id = access.Id })
            
            #line default
            #line hidden
, 2262), false)
);

WriteLiteral("></a>\r\n");

            
            #line 54 "..\..\Areas\Manager\Views\Settings\AccessList.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </td>\r\n            </tr>\r\n");

            
            #line 57 "..\..\Areas\Manager\Views\Settings\AccessList.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </tbody>\r\n        <tfoot>\r\n            <tr>\r\n                <td");

WriteLiteral(" colspan=\"6\"");

WriteLiteral("></td>\r\n            </tr>\r\n        </tfoot>\r\n    </table>\r\n</div>");

        }
    }
}
#pragma warning restore 1591
