#pragma checksum "/Users/cetin/Desktop/workspaces-wsc/dining-out/dining-out/Views/DashboardRestaurant/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c72789550809cd50eb4ab034b8fb2d775d6bfc0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DashboardRestaurant_Index), @"mvc.1.0.view", @"/Views/DashboardRestaurant/Index.cshtml")]
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
#line 1 "/Users/cetin/Desktop/workspaces-wsc/dining-out/dining-out/Views/_ViewImports.cshtml"
using dining_out;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/cetin/Desktop/workspaces-wsc/dining-out/dining-out/Views/_ViewImports.cshtml"
using dining_out.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/cetin/Desktop/workspaces-wsc/dining-out/dining-out/Views/_ViewImports.cshtml"
using dining_out.Models.DbModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c72789550809cd50eb4ab034b8fb2d775d6bfc0", @"/Views/DashboardRestaurant/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db1e818469822cea25997ec769de68a3e441debc", @"/Views/_ViewImports.cshtml")]
    public class Views_DashboardRestaurant_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DashboardRestaurantVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "DashboardRestaurantEkle", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "DashboardRestaurantMenuDuzenle", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/cetin/Desktop/workspaces-wsc/dining-out/dining-out/Views/DashboardRestaurant/Index.cshtml"
  
    Layout = "~/Views/Shared/_LayoutDashboard.cshtml";
    ViewData["Title"] = "Dashboard Restaurantlar";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<br />\n<div>\n    <div class=\"p-3 mb-5 float-right\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c72789550809cd50eb4ab034b8fb2d775d6bfc04985", async() => {
                WriteLiteral("Yeni Restaurant Ekle");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </div>\n    <div class=\"shadow p-3 mb-5 bg-white rounded text-center\">\n");
#nullable restore
#line 14 "/Users/cetin/Desktop/workspaces-wsc/dining-out/dining-out/Views/DashboardRestaurant/Index.cshtml"
         if (Model.Restaurants != null && Model.Restaurants.Count > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <table id=""newrez-table"" class=""table table-striped table-bordered"" style=""width:95%"">
                <thead>
                    <tr>
                        <th>Restaurant Numarası</th>
                        <th>Restaurant İsmi</th>
                        <th>Restaurant Sistem İsmi</th>
                        <th>Restaurant Şehir</th>
                        <th>Restaurant İlçe</th>
                        <th>Restaurant Kapasite</th>
                        <th>Yeni Rezervasyonlu Masalar</th>
                        <th>Aktif Rezervasyonlu Masalar</th>
                        <th>Geçmiş Rezervasyonlu Masalar</th>
                        <th>Menü Düzenle</th>
                    </tr>
                </thead>
                <tbody>

");
#nullable restore
#line 33 "/Users/cetin/Desktop/workspaces-wsc/dining-out/dining-out/Views/DashboardRestaurant/Index.cshtml"
                     foreach (var restaurant in Model.Restaurants)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\n                        <td>");
#nullable restore
#line 36 "/Users/cetin/Desktop/workspaces-wsc/dining-out/dining-out/Views/DashboardRestaurant/Index.cshtml"
                       Write(restaurant.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 37 "/Users/cetin/Desktop/workspaces-wsc/dining-out/dining-out/Views/DashboardRestaurant/Index.cshtml"
                       Write(restaurant.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 38 "/Users/cetin/Desktop/workspaces-wsc/dining-out/dining-out/Views/DashboardRestaurant/Index.cshtml"
                       Write(restaurant.SystemDefinitionName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 39 "/Users/cetin/Desktop/workspaces-wsc/dining-out/dining-out/Views/DashboardRestaurant/Index.cshtml"
                       Write(restaurant.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 40 "/Users/cetin/Desktop/workspaces-wsc/dining-out/dining-out/Views/DashboardRestaurant/Index.cshtml"
                       Write(restaurant.District);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 41 "/Users/cetin/Desktop/workspaces-wsc/dining-out/dining-out/Views/DashboardRestaurant/Index.cshtml"
                       Write(restaurant.Capacity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 42 "/Users/cetin/Desktop/workspaces-wsc/dining-out/dining-out/Views/DashboardRestaurant/Index.cshtml"
                       Write(restaurant.NewBookingCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 43 "/Users/cetin/Desktop/workspaces-wsc/dining-out/dining-out/Views/DashboardRestaurant/Index.cshtml"
                       Write(restaurant.ApprovedBookingCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 44 "/Users/cetin/Desktop/workspaces-wsc/dining-out/dining-out/Views/DashboardRestaurant/Index.cshtml"
                       Write(restaurant.ClosedBookingCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c72789550809cd50eb4ab034b8fb2d775d6bfc010547", async() => {
                WriteLiteral("\n                                <i class=\"bi bi-arrow-right-circle-fill\" style=\"font-size: 2rem; color: cornflowerblue;\">\n                                </i>\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-restaurantId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 48 "/Users/cetin/Desktop/workspaces-wsc/dining-out/dining-out/Views/DashboardRestaurant/Index.cshtml"
                                           WriteLiteral(restaurant.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["restaurantId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-restaurantId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["restaurantId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                        </td>\n                    </tr>\n");
#nullable restore
#line 54 "/Users/cetin/Desktop/workspaces-wsc/dining-out/dining-out/Views/DashboardRestaurant/Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\n            </table>\n");
#nullable restore
#line 57 "/Users/cetin/Desktop/workspaces-wsc/dining-out/dining-out/Views/DashboardRestaurant/Index.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <span class=\"text-primary\">Kayıt Bulunmamaktadır</span>\n");
#nullable restore
#line 61 "/Users/cetin/Desktop/workspaces-wsc/dining-out/dining-out/Views/DashboardRestaurant/Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DashboardRestaurantVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
