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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Manager/Views/Settings/ParamList.cshtml")]
    public partial class ParamList : System.Web.Mvc.WebViewPage<Piranha.Models.Manager.SettingModels.ParamListModel>
    {
        public ParamList()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Areas\Manager\Views\Settings\ParamList.cshtml"
  
    ViewBag.Title = @Piranha.Resources.Settings.ListTitleParams ;

            
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
                    valueNames: ['name', 'updated', 'created']
                };
                var list = new List('list', options);
            });
        });
    </script>
");

});

DefineSection("Toolbar", () => {

WriteLiteral("\r\n");

            
            #line 20 "..\..\Areas\Manager\Views\Settings\ParamList.cshtml"
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

WriteAttribute("href", Tuple.Create(" href=\"", 718), Tuple.Create("\"", 745)
            
            #line 24 "..\..\Areas\Manager\Views\Settings\ParamList.cshtml"
, Tuple.Create(Tuple.Create("", 725), Tuple.Create<System.Object, System.Int32>(Url.Action("param")
            
            #line default
            #line hidden
, 725), false)
);

WriteLiteral(" class=\"add\"");

WriteLiteral(">");

            
            #line 24 "..\..\Areas\Manager\Views\Settings\ParamList.cshtml"
                                                               Write(Piranha.Resources.Global.ToolbarAdd);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n            <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 824), Tuple.Create("\"", 855)
            
            #line 25 "..\..\Areas\Manager\Views\Settings\ParamList.cshtml"
, Tuple.Create(Tuple.Create("", 831), Tuple.Create<System.Object, System.Int32>(Url.Action("paramlist")
            
            #line default
            #line hidden
, 831), false)
);

WriteLiteral(" class=\"refresh\"");

WriteLiteral(">");

            
            #line 25 "..\..\Areas\Manager\Views\Settings\ParamList.cshtml"
                                                              Write(Piranha.Resources.Global.ToolbarReload);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n        </ul>\r\n        <button");

WriteLiteral(" class=\"search\"");

WriteLiteral("></button>");

            
            #line 27 "..\..\Areas\Manager\Views\Settings\ParamList.cshtml"
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

WriteLiteral(" data-sort=\"name\"");

WriteLiteral(">");

            
            #line 36 "..\..\Areas\Manager\Views\Settings\ParamList.cshtml"
                                                       Write(Piranha.Resources.Global.Name);

            
            #line default
            #line hidden
WriteLiteral("</span></th>\r\n                <th");

WriteLiteral(" class=\"date\"");

WriteLiteral("><span");

WriteLiteral(" class=\"sort\"");

WriteLiteral(" data-sort=\"updated\"");

WriteLiteral(">");

            
            #line 37 "..\..\Areas\Manager\Views\Settings\ParamList.cshtml"
                                                                   Write(Piranha.Resources.Global.Updated);

            
            #line default
            #line hidden
WriteLiteral("</span></th>\r\n                <th");

WriteLiteral(" class=\"date\"");

WriteLiteral("><span");

WriteLiteral(" class=\"sort\"");

WriteLiteral(" data-sort=\"created\"");

WriteLiteral(">");

            
            #line 38 "..\..\Areas\Manager\Views\Settings\ParamList.cshtml"
                                                                   Write(Piranha.Resources.Global.Created);

            
            #line default
            #line hidden
WriteLiteral("</span></th>\r\n                <th");

WriteLiteral(" class=\"one\"");

WriteLiteral("></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody");

WriteLiteral(" class=\"list-js\"");

WriteLiteral(">\r\n");

            
            #line 43 "..\..\Areas\Manager\Views\Settings\ParamList.cshtml"
            
            
            #line default
            #line hidden
            
            #line 43 "..\..\Areas\Manager\Views\Settings\ParamList.cshtml"
             foreach (var param in Model.Params) {

            
            #line default
            #line hidden
WriteLiteral("            <tr>\r\n                <td");

WriteLiteral(" class=\"name\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1711), Tuple.Create("\"", 1761)
            
            #line 45 "..\..\Areas\Manager\Views\Settings\ParamList.cshtml"
, Tuple.Create(Tuple.Create("", 1718), Tuple.Create<System.Object, System.Int32>(Url.Action("param", new { id = param.Id })
            
            #line default
            #line hidden
, 1718), false)
);

WriteLiteral(">");

            
            #line 45 "..\..\Areas\Manager\Views\Settings\ParamList.cshtml"
                                                                                  Write(param.Name);

            
            #line default
            #line hidden
WriteLiteral("</a></td>\r\n                <td");

WriteLiteral(" class=\"updated\"");

WriteLiteral(">");

            
            #line 46 "..\..\Areas\Manager\Views\Settings\ParamList.cshtml"
                               Write(param.Updated.ToString("yyyy-MM-dd"));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td");

WriteLiteral(" class=\"created\"");

WriteLiteral(">");

            
            #line 47 "..\..\Areas\Manager\Views\Settings\ParamList.cshtml"
                               Write(param.Created.ToString("yyyy-MM-dd"));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td");

WriteLiteral(" class=\"buttons\"");

WriteLiteral(">\r\n");

            
            #line 49 "..\..\Areas\Manager\Views\Settings\ParamList.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 49 "..\..\Areas\Manager\Views\Settings\ParamList.cshtml"
                     if (!param.IsLocked) {

            
            #line default
            #line hidden
WriteLiteral("                    <a");

WriteLiteral(" class=\"icon delete\"");

WriteAttribute("href", Tuple.Create(" href=\"", 2070), Tuple.Create("\"", 2126)
            
            #line 50 "..\..\Areas\Manager\Views\Settings\ParamList.cshtml"
, Tuple.Create(Tuple.Create("", 2077), Tuple.Create<System.Object, System.Int32>(Url.Action("deleteparam", new { id = param.Id })
            
            #line default
            #line hidden
, 2077), false)
);

WriteLiteral("></a>\r\n");

            
            #line 51 "..\..\Areas\Manager\Views\Settings\ParamList.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </td>\r\n            </tr>\r\n");

            
            #line 54 "..\..\Areas\Manager\Views\Settings\ParamList.cshtml"
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
