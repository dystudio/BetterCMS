﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
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
    
    #line 1 "..\..\Views\Page\Partial\PagePropertiesEditPermalink.cshtml"
    using BetterCms.Module.Pages.Content.Resources;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Page\Partial\PagePropertiesEditPermalink.cshtml"
    using BetterCms.Module.Root.Content.Resources;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\Page\Partial\PagePropertiesEditPermalink.cshtml"
    using BetterCms.Module.Root.Mvc.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Page/Partial/PagePropertiesEditPermalink.cshtml")]
    public partial class _Views_Page_Partial_PagePropertiesEditPermalink_cshtml : System.Web.Mvc.WebViewPage<BetterCms.Module.Pages.ViewModels.Page.EditPagePropertiesViewModel>
    {
        public _Views_Page_Partial_PagePropertiesEditPermalink_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("<div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 8 "..\..\Views\Page\Partial\PagePropertiesEditPermalink.cshtml"
   Write(PagesGlobalization.EditPageProperties_AdvancedPropertiesTab_PageUrl_Title);

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 8 "..\..\Views\Page\Partial\PagePropertiesEditPermalink.cshtml"
                                                                              Write(Html.Tooltip(PagesGlobalization.EditPageProperties_AdvancedPropertiesTab_PageUrl_Tooltip_Description));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <a");

WriteLiteral(" id=\"bcms-pageproperties-editpermalink\"");

WriteLiteral(">");

            
            #line 9 "..\..\Views\Page\Partial\PagePropertiesEditPermalink.cshtml"
                                             Write(RootGlobalization.Button_Edit);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"bcms-editseo-urlpath\"");

WriteLiteral(" id=\"bcms-page-permalink-info\"");

WriteLiteral(">");

            
            #line 11 "..\..\Views\Page\Partial\PagePropertiesEditPermalink.cshtml"
                                                                Write(string.IsNullOrWhiteSpace(Model.PageUrl) ? Html.Raw("&nbsp;") : new MvcHtmlString(Html.Encode(Model.PageUrl)));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n\r\n    <div");

WriteLiteral(" class=\"bcms-edit-urlpath-box\"");

WriteLiteral(" style=\"display: none;\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 14 "..\..\Views\Page\Partial\PagePropertiesEditPermalink.cshtml"
   Write(Html.Hidden("PagePermalinkHidden", Model.PageUrl, new { @id = "bcms-page-permalink" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <div");

WriteLiteral(" class=\"bcms-field-wrapper\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 16 "..\..\Views\Page\Partial\PagePropertiesEditPermalink.cshtml"
       Write(Html.TextBoxFor(model => model.PageUrl, new { @id = "bcms-page-permalink-edit", @class = "bcms-field-text bcms-js-url-path" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 17 "..\..\Views\Page\Partial\PagePropertiesEditPermalink.cshtml"
       Write(Html.BcmsValidationMessageFor(f => f.PageUrl));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" class=\"bcms-btn-primary\"");

WriteLiteral(" id=\"bcms-save-permalink\"");

WriteLiteral(">");

            
            #line 20 "..\..\Views\Page\Partial\PagePropertiesEditPermalink.cshtml"
                                                          Write(RootGlobalization.Button_Ok);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n        <div");

WriteLiteral(" class=\"bcms-btn-cancel\"");

WriteLiteral(">");

            
            #line 21 "..\..\Views\Page\Partial\PagePropertiesEditPermalink.cshtml"
                                Write(RootGlobalization.Button_Cancel);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n\r\n        <div");

WriteLiteral(" class=\"bcms-edit-check-field\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 24 "..\..\Views\Page\Partial\PagePropertiesEditPermalink.cshtml"
       Write(Html.CheckBoxFor(model => model.RedirectFromOldUrl));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <div");

WriteLiteral(" class=\"bcms-edit-label\"");

WriteLiteral(">");

            
            #line 25 "..\..\Views\Page\Partial\PagePropertiesEditPermalink.cshtml"
                                    Write(PagesGlobalization.EditPageProperties_AdvancedPropertiesTab_CreatePermanentRedirectToOldUrl_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" class=\"bcms-edit-check-field\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 29 "..\..\Views\Page\Partial\PagePropertiesEditPermalink.cshtml"
       Write(Html.CheckBoxFor(model => model.UseCanonicalUrl));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <div");

WriteLiteral(" class=\"bcms-edit-label\"");

WriteLiteral(">");

            
            #line 30 "..\..\Views\Page\Partial\PagePropertiesEditPermalink.cshtml"
                                    Write(PagesGlobalization.EditPageProperties_AdvancedPropertiesTab_UseCanonicalUrl);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n        </div>\r\n");

            
            #line 32 "..\..\Views\Page\Partial\PagePropertiesEditPermalink.cshtml"
        
            
            #line default
            #line hidden
            
            #line 32 "..\..\Views\Page\Partial\PagePropertiesEditPermalink.cshtml"
         if (Model.IsInSitemap)
        {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"bcms-edit-check-field\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 35 "..\..\Views\Page\Partial\PagePropertiesEditPermalink.cshtml"
           Write(Html.CheckBoxFor(model => model.UpdateSitemap));

            
            #line default
            #line hidden
WriteLiteral("\r\n                <div");

WriteLiteral(" class=\"bcms-edit-label\"");

WriteLiteral(">");

            
            #line 36 "..\..\Views\Page\Partial\PagePropertiesEditPermalink.cshtml"
                                        Write(PagesGlobalization.EditPageProperties_AdvancedPropertiesTab_UpdateSitemap_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n            </div>\r\n");

            
            #line 38 "..\..\Views\Page\Partial\PagePropertiesEditPermalink.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
