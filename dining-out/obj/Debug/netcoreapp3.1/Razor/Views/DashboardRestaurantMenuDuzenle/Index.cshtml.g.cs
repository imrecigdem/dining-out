#pragma checksum "C:\Users\cigde\Desktop\dining-out\dining-out\Views\DashboardRestaurantMenuDuzenle\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f3cbe03377ae48e4c7ce344876c6ddee0af609f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DashboardRestaurantMenuDuzenle_Index), @"mvc.1.0.view", @"/Views/DashboardRestaurantMenuDuzenle/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\cigde\Desktop\dining-out\dining-out\Views\_ViewImports.cshtml"
using dining_out;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\cigde\Desktop\dining-out\dining-out\Views\_ViewImports.cshtml"
using dining_out.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\cigde\Desktop\dining-out\dining-out\Views\_ViewImports.cshtml"
using dining_out.Models.DbModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f3cbe03377ae48e4c7ce344876c6ddee0af609f", @"/Views/DashboardRestaurantMenuDuzenle/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d48fe05ec330a429bac2dede8ec565cb4545ea94", @"/Views/_ViewImports.cshtml")]
    public class Views_DashboardRestaurantMenuDuzenle_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MenuVm>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MenuItemEkle", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "DashboardRestaurantMenuDuzenle", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-method", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-update", new global::Microsoft.AspNetCore.Html.HtmlString("#AllMenuItems"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\cigde\Desktop\dining-out\dining-out\Views\DashboardRestaurantMenuDuzenle\Index.cshtml"
  
    Layout = "~/Views/Shared/_LayoutDashboard.cshtml";
    ViewData["Title"] = "Dashboard Restaurant Menü Düzenleme";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<br />\r\n<div id=\"AllForms\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f3cbe03377ae48e4c7ce344876c6ddee0af609f5881", async() => {
                WriteLiteral(@"
        <div class=""shadow p-3 mb-5 bg-white rounded text-center"">
            <div class=""form-row text-center"">
                <div class=""col-lg-2 "">
                </div>
                <div class=""col-md-8"">
                    <h3 class=""text-primary"">Menü Düzenleme Formu</h3>
                </div>
                <div class=""col-lg-2 "">
                </div>
            </div>
            ");
#nullable restore
#line 21 "C:\Users\cigde\Desktop\dining-out\dining-out\Views\DashboardRestaurantMenuDuzenle\Index.cshtml"
       Write(Html.HiddenFor(md => md.menuItem.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <div class=\"form-row text-center\">\r\n                <div class=\"col-lg-2 \">\r\n                </div>\r\n                <div class=\"col-lg-4 col-md-6 form-group\">\r\n                    ");
#nullable restore
#line 26 "C:\Users\cigde\Desktop\dining-out\dining-out\Views\DashboardRestaurantMenuDuzenle\Index.cshtml"
               Write(Html.TextBoxFor(md => md.menuItem.MenuItemName, new { placeholder = "Menü Öğe İsmi", @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <div class=\"col-lg-4 col-md-6 form-group\">\r\n                    ");
#nullable restore
#line 29 "C:\Users\cigde\Desktop\dining-out\dining-out\Views\DashboardRestaurantMenuDuzenle\Index.cshtml"
               Write(Html.TextBoxFor(md => md.menuItem.Price, new { placeholder = "Fiyat", @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </div>
                <div class=""col-lg-2 "">
                </div>
            </div>
            <div class=""form-row text-center"">
                <div class=""col-lg-2 "">
                </div>
                <div class=""col-lg-4 col-md-6 form-group"">
                    ");
#nullable restore
#line 38 "C:\Users\cigde\Desktop\dining-out\dining-out\Views\DashboardRestaurantMenuDuzenle\Index.cshtml"
               Write(Html.TextAreaFor(md => md.menuItem.MenuItemDescription, new { placeholder = "Menü Öğe Açıklaması", @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <div class=\"col-lg-4 col-md-6 form-group\">\r\n                    ");
#nullable restore
#line 41 "C:\Users\cigde\Desktop\dining-out\dining-out\Views\DashboardRestaurantMenuDuzenle\Index.cshtml"
               Write(Html.TextAreaFor(md => md.menuItem.MenuItemIngredients, new { placeholder = "Menü Öğe İçindekiler", @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </div>
                <div class=""col-lg-2 "">
                </div>
            </div>
            <div class=""form-row text-center"">
                <div class=""col-lg-2 "">
                </div>
                <div class=""col-lg-8 col-md-6 form-group"">
                    ");
#nullable restore
#line 50 "C:\Users\cigde\Desktop\dining-out\dining-out\Views\DashboardRestaurantMenuDuzenle\Index.cshtml"
               Write(Html.TextBoxFor(md => md.menuItem.Category.CategoryName, new { placeholder = "Menü Öğe Kategorisi", @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </div>
                <div class=""col-lg-2 "">
                </div>
            </div>
            <div class=""form-row"">
                <div class=""col-lg-2 "">
                </div>
                <div class=""col-lg-8 col-md-6 form-group"">
                    <button type=""submit"" name=""menuItemAddButton"" value=""submitMenuItem"" class=""btn btn-primary float-right mt-6"">Ekle</button>
                </div>
                <div class=""col-lg-2"">
                </div>
            </div>

            <div class=""shadow p-3 mb-5 bg-white rounded text-center"" id=""AllMenuItems"">
                <div class=""form-row"">
                    <div class=""col-lg-12"">
                        ");
#nullable restore
#line 68 "C:\Users\cigde\Desktop\dining-out\dining-out\Views\DashboardRestaurantMenuDuzenle\Index.cshtml"
                   Write(Html.Partial("_AllMenuItems", Model));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-restaurantId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 10 "C:\Users\cigde\Desktop\dining-out\dining-out\Views\DashboardRestaurantMenuDuzenle\Index.cshtml"
                                                     WriteLiteral(Model.Restaurant.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["restaurantId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-restaurantId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["restaurantId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</div>\r\n\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MenuVm> Html { get; private set; }
    }
}
#pragma warning restore 1591
