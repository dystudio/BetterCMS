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
    
    #line 1 "..\..\Views\Sitemap\Edit.cshtml"
    using BetterCms.Module.Pages.Content.Resources;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Sitemap\Edit.cshtml"
    using BetterCms.Module.Pages.Controllers;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\Sitemap\Edit.cshtml"
    using BetterCms.Module.Pages.ViewModels.Sitemap;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Views\Sitemap\Edit.cshtml"
    using BetterCms.Module.Root;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Views\Sitemap\Edit.cshtml"
    using BetterCms.Module.Root.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 6 "..\..\Views\Sitemap\Edit.cshtml"
    using BetterCms.Module.Root.ViewModels.Tags;
    
    #line default
    #line hidden
    
    #line 7 "..\..\Views\Sitemap\Edit.cshtml"
    using Microsoft.Web.Mvc;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Sitemap/Edit.cshtml")]
    public partial class _Views_Sitemap_Edit_cshtml : System.Web.Mvc.WebViewPage<SitemapViewModel>
    {
        public _Views_Sitemap_Edit_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 9 "..\..\Views\Sitemap\Edit.cshtml"
  
    var tagsTemplateViewModel = new TagsTemplateViewModel
    {
        TooltipDescription = NavigationGlobalization.Sitemap_EditDialog_AddTags_Tooltip_Description
    };

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"bcms-tab-header\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"bcms-modal-frame-holder\"");

WriteLiteral(">\r\n        <a");

WriteLiteral(" class=\"bcms-tab-item bcms-active\"");

WriteLiteral(" data-name=\"#bcms-tab-1\"");

WriteLiteral(">Properties</a>\r\n        <a");

WriteLiteral(" class=\"bcms-tab-item\"");

WriteLiteral(" data-name=\"#bcms-tab-2\"");

WriteLiteral(">Nodes</a>\r\n    </div>\r\n</div>\r\n\r\n<div");

WriteLiteral(" class=\"bcms-modal-frame-holder\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" id=\"bcms-sitemap-addnode\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 24 "..\..\Views\Sitemap\Edit.cshtml"
   Write(Html.TabbedContentMessagesBox());

            
            #line default
            #line hidden
WriteLiteral("\r\n        ");

WriteLiteral("\r\n");

            
            #line 26 "..\..\Views\Sitemap\Edit.cshtml"
        
            
            #line default
            #line hidden
            
            #line 26 "..\..\Views\Sitemap\Edit.cshtml"
         using (Html.BeginForm<SitemapController>(f => f.EditSitemap(null), FormMethod.Post, new
        {
            @class = "bcms-sitemap-form bcms-ajax-form",
            data_readonly = Model.IsReadOnly.ToString().ToLower()
        }))
        {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" id=\"bcms-tab-1\"");

WriteLiteral(" class=\"bcms-tab-single\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"bcms-padded-content\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 35 "..\..\Views\Sitemap\Edit.cshtml"
                   Write(Html.Tooltip(NavigationGlobalization.Sitemap_EditDialog_SitemapTitle_Tooltip_Description));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 36 "..\..\Views\Sitemap\Edit.cshtml"
                                                    Write(NavigationGlobalization.Sitemap_EditDialog_SitemapTitle_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                        <div");

WriteLiteral(" class=\"bcms-input-box\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 38 "..\..\Views\Sitemap\Edit.cshtml"
                       Write(Html.TextBoxFor(model => model.Title, new { @class = "bcms-editor-field-box", data_bind = "value: title, valueUpdate: 'afterkeydown', hasfocus: true" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                            ");

            
            #line 39 "..\..\Views\Sitemap\Edit.cshtml"
                       Write(Html.BcmsValidationMessageFor(f => f.Title));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                            ");

            
            #line 40 "..\..\Views\Sitemap\Edit.cshtml"
                       Write(Html.HiddenFor(m => m.Id));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                            ");

            
            #line 41 "..\..\Views\Sitemap\Edit.cshtml"
                       Write(Html.HiddenFor(m => m.Version));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                   " +
" <div");

WriteLiteral(" class=\"bcms-tags-box-holder\"");

WriteLiteral(" data-bind=\"with: tags\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 45 "..\..\Views\Sitemap\Edit.cshtml"
                   Write(Html.Partial("~/Areas/bcms-root/Views/Tags/TagsTemplate.cshtml", tagsTemplateViewModel));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n");

            
            #line 47 "..\..\Views\Sitemap\Edit.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 47 "..\..\Views\Sitemap\Edit.cshtml"
                     if (Model.AccessControlEnabled)
                {
                
            
            #line default
            #line hidden
            
            #line 49 "..\..\Views\Sitemap\Edit.cshtml"
           Write(Html.Partial(RootModuleConstants.AccessControlTemplate));

            
            #line default
            #line hidden
            
            #line 49 "..\..\Views\Sitemap\Edit.cshtml"
                                                                        
                }

            
            #line default
            #line hidden
WriteLiteral("                </div>\r\n            </div>\r\n");

WriteLiteral("            <div");

WriteLiteral(" id=\"bcms-tab-2\"");

WriteLiteral(" class=\"bcms-tab-single\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"bcms-scroll-window\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"bcms-columns-container\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"bcms-sitemap-filter-holder\"");

WriteLiteral(" data-bind=\"with: sitemap\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"bcms-language-bar\"");

WriteLiteral(" style=\"display: none;\"");

WriteLiteral(" data-bind=\"visible: showLanguages, with: language\"");

WriteLiteral(">\r\n                                <div");

WriteLiteral(" class=\"bcms-filter-text bcms-table-middle-box\"");

WriteLiteral(">Edit sitemap in language:</div>\r\n                                <div");

WriteLiteral(" class=\"bcms-table-middle-box\"");

WriteLiteral(">\r\n                                    <select");

WriteLiteral(" class=\"bcms-global-select\"");

WriteLiteral(" data-bind=\"options: languages, optionsText: \'value\', optionsValue: \'key\', value:" +
" languageId\"");

WriteLiteral("></select>\r\n                                </div>\r\n                            <" +
"/div>\r\n                            <div");

WriteLiteral(" class=\"bcms-expand-link-holder\"");

WriteLiteral(" ");

WriteLiteral(">\r\n                                <div");

WriteLiteral(" class=\"bcms-expand-link\"");

WriteLiteral(" data-bind=\"click: expandAll\"");

WriteLiteral(">");

            
            #line 64 "..\..\Views\Sitemap\Edit.cshtml"
                                                                                      Write(NavigationGlobalization.Sitemap_Button_ExpandAll);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                                <div");

WriteLiteral(" class=\"bcms-expand-link\"");

WriteLiteral(" data-bind=\"click: collapseAll\"");

WriteLiteral(">");

            
            #line 65 "..\..\Views\Sitemap\Edit.cshtml"
                                                                                        Write(NavigationGlobalization.Sitemap_Button_CollapseAll);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                            </div>\r\n                        </div>\r\n     " +
"                   <div");

WriteLiteral(" class=\"bcms-leftcol bcms-add-node-col\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"bcms-sitemap-links-holder\"");

WriteLiteral(" data-bind=\"template: { name: \'bcms-navigation-pagelinks-template\' }\"");

WriteLiteral("></div>\r\n                        </div>\r\n                        <div");

WriteLiteral(" class=\"bcms-rightcol\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"bcms-sitemap-holder bcms-sitemap-edit\"");

WriteLiteral(">\r\n                                <div");

WriteAttribute("class", Tuple.Create(" class=\"", 4298), Tuple.Create("\"", 4383)
, Tuple.Create(Tuple.Create("", 4306), Tuple.Create("bcms-addnode-placement-holder", 4306), true)
            
            #line 73 "..\..\Views\Sitemap\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 4335), Tuple.Create<System.Object, System.Int32>(Model.IsReadOnly ? "-readonly" : string.Empty
            
            #line default
            #line hidden
, 4335), false)
);

WriteLiteral(">\r\n");

WriteLiteral("                                    ");

            
            #line 74 "..\..\Views\Sitemap\Edit.cshtml"
                               Write(Html.Partial("Partial/Sitemap", new SitemapNodeViewModel()));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n   " +
"                     </div>\r\n                    </div>\r\n                </div>\r" +
"\n            </div>\r\n");

            
            #line 81 "..\..\Views\Sitemap\Edit.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n</div>\r\n\r\n");

            
            #line 85 "..\..\Views\Sitemap\Edit.cshtml"
Write(Html.Partial("Partial/SitemapTemplate", new SitemapNodeViewModel()));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<script");

WriteLiteral(" type=\"text/html\"");

WriteLiteral(" id=\"bcms-navigation-pagelinks-template\"");

WriteLiteral(">\r\n    <div class=\"bcms-plain-text\">");

            
            #line 88 "..\..\Views\Sitemap\Edit.cshtml"
                            Write(NavigationGlobalization.Sitemap_EditDialog_PageLink_Header);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n    <div class=\"bcms-sidebar-search\">\r\n        <input type=\"text\" class=\"" +
"bcms-editor-field-box\" placeholder=\"");

            
            #line 90 "..\..\Views\Sitemap\Edit.cshtml"
                                                                 Write(NavigationGlobalization.Sitemap_EditDialog_AddPageLink_SearchPlaceHolder);

            
            #line default
            #line hidden
WriteLiteral("\"\r\n               data-bind=\"hasfocus: hasfocus, value: searchQuery, valueUpdate:" +
" \'afterkeydown\', enterPress: searchForPageLinks\" />\r\n        <div class=\"bcms-bt" +
"n-search\" data-bind=\"click: searchForPageLinks\">");

            
            #line 92 "..\..\Views\Sitemap\Edit.cshtml"
                                                                      Write(NavigationGlobalization.Sitemap_EditDialog_AddPageLink_SearchButton);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n    </div>\r\n    <div class=\"bcms-addnode-placement-holder");

            
            #line 94 "..\..\Views\Sitemap\Edit.cshtml"
                                         Write(Model.IsReadOnly ? "-readonly" : string.Empty);

            
            #line default
            #line hidden
WriteLiteral("\" data-bind=\"template: { name: \'bcms-navigation-pagelink-template\', foreach: page" +
"Links }\"></div>\r\n</script>\r\n\r\n<script");

WriteLiteral(" type=\"text/html\"");

WriteLiteral(" id=\"bcms-navigation-pagelink-template\"");

WriteLiteral(">\r\n    <!-- ko if: isVisible() || isCustom() -->\r\n    <div class=\"bcms-placement-" +
"node\" data-bind=\"");

            
            #line 99 "..\..\Views\Sitemap\Edit.cshtml"
                                            Write(!Model.IsReadOnly ? "draggable: $parentContext.$index, " : string.Empty);

            
            #line default
            #line hidden
WriteLiteral(@"css: { 'bcms-placement-node-drag': isBeingDragged() }, style: { borderColor: isOnSitemap() == true ? '#0383df' : '' }"">
        <div class=""bcms-placement-title"" data-bind=""text: title()""></div>
        <div class=""bcms-placement-path""><a data-bind=""text: url, attr: { href: url }"" href="""" target=""_blank""></a></div>
    </div>
    <!-- ko if: isBeingDragged() -->
    <div class=""bcms-placement-dropzone""></div>
    <!-- /ko -->
    <!-- /ko -->
</script>
");

        }
    }
}
#pragma warning restore 1591
