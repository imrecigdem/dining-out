#pragma checksum "/Users/cetin/Desktop/workspaces-wsc/dining-out/dining-out/Views/Anasayfa/Restaurant.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b1ea80e4d2d990af3e105aef25c6943b61dce3d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Anasayfa_Restaurant), @"mvc.1.0.view", @"/Views/Anasayfa/Restaurant.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b1ea80e4d2d990af3e105aef25c6943b61dce3d", @"/Views/Anasayfa/Restaurant.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db1e818469822cea25997ec769de68a3e441debc", @"/Views/_ViewImports.cshtml")]
    public class Views_Anasayfa_Restaurant : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/cetin/Desktop/workspaces-wsc/dining-out/dining-out/Views/Anasayfa/Restaurant.cshtml"
  
    ViewData["Title"] = "Restaurant Arama";

#line default
#line hidden
#nullable disable
            WriteLiteral("<br/>\n<div class=\"text-center\">\n");
#nullable restore
#line 6 "/Users/cetin/Desktop/workspaces-wsc/dining-out/dining-out/Views/Anasayfa/Restaurant.cshtml"
       Html.RenderPartialAsync("RestaurantSearch"); 

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n<br />\n<div>\n");
#nullable restore
#line 10 "/Users/cetin/Desktop/workspaces-wsc/dining-out/dining-out/Views/Anasayfa/Restaurant.cshtml"
       Html.RenderPartialAsync("RestaurantSearchResult");

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
