#pragma checksum "/Users/cetin/Desktop/workspaces-wsc/dining-out/dining-out/Views/MasaRezervasyon/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "723c71af569db1cd36d2610e6d4421fc216417ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MasaRezervasyon_Index), @"mvc.1.0.view", @"/Views/MasaRezervasyon/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"723c71af569db1cd36d2610e6d4421fc216417ae", @"/Views/MasaRezervasyon/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db1e818469822cea25997ec769de68a3e441debc", @"/Views/_ViewImports.cshtml")]
    public class Views_MasaRezervasyon_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RezervasyonYap", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "MasaRezervasyon", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/cetin/Desktop/workspaces-wsc/dining-out/dining-out/Views/MasaRezervasyon/Index.cshtml"
  
    ViewData["Title"] = "Masa Rezervasyon ";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<br />
<!-- Table Reservation Form -->


<section id=""book-a-table"" class=""book-a-table"">
    <div class=""container"" data-aos=""fade-up"">
        <div class=""shadow w-100 p-3 mb-5 bg-white rounded"">
            <div class=""row"">
                <div class=""col-md-8 offset-md-2 text-center"">
                    <h2 class=""text-primary"">Masa Rezervasyonu</h2>
                    <h3 class=""text-primary"">");
#nullable restore
#line 15 "/Users/cetin/Desktop/workspaces-wsc/dining-out/dining-out/Views/MasaRezervasyon/Index.cshtml"
                                        Write(ViewBag.Restaurant.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n                    <p class=\"mb-5\">");
#nullable restore
#line 16 "/Users/cetin/Desktop/workspaces-wsc/dining-out/dining-out/Views/MasaRezervasyon/Index.cshtml"
                               Write(ViewBag.Restaurant.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                </div>\n            </div>\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "723c71af569db1cd36d2610e6d4421fc216417ae5742", async() => {
                WriteLiteral(@"
                <div class=""row"">
                    <div class=""col-lg-4 col-md-6 form-group"">
                        <input type=""text"" name=""IsimSoyisim"" class=""form-control"" id=""IsimSoyisim"" placeholder=""İsminiz"">
                    </div>
                    <div class=""col-lg-4 col-md-6 form-group"">
                        <input type=""email"" class=""form-control"" name=""Email"" id=""Email"" placeholder=""E-Mail Adresi"">
                    </div>
                    <div class=""col-lg-4 col-md-6 form-group"">
                        <input type=""number"" class=""form-control"" name=""Telefon"" id=""Telefon"" placeholder=""Telefon Numarası"">
                    </div>
                    <div class=""col-lg-4 col-md-6 form-group"">
                        <input type=""date"" name=""Tarih"" class=""form-control"" id=""Tarih"" placeholder=""Tarih"">
                    </div>
                    <div class=""col-lg-4 col-md-6 form-group"">
                        <input type=""time"" class=""form-control"" name=""TarihSaat"" id=""Tarih");
                WriteLiteral("Saat\" placeholder=\"TarihSaat\">\n                    </div>\n                    <div class=\"col-lg-4 col-md-6 form-group\">\n                        <select class=\"form-control\" name=\"KisiSayisi\" id=\"KisiSayisi\">\n");
#nullable restore
#line 38 "/Users/cetin/Desktop/workspaces-wsc/dining-out/dining-out/Views/MasaRezervasyon/Index.cshtml"
                             foreach (var kisiData in ViewBag.KisilerData)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "723c71af569db1cd36d2610e6d4421fc216417ae7675", async() => {
#nullable restore
#line 40 "/Users/cetin/Desktop/workspaces-wsc/dining-out/dining-out/Views/MasaRezervasyon/Index.cshtml"
                                                         Write(kisiData.Value);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 40 "/Users/cetin/Desktop/workspaces-wsc/dining-out/dining-out/Views/MasaRezervasyon/Index.cshtml"
                                   WriteLiteral(kisiData.Key);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
#nullable restore
#line 41 "/Users/cetin/Desktop/workspaces-wsc/dining-out/dining-out/Views/MasaRezervasyon/Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        </select>
                    </div>
                </div>
                <div class=""row m-1"">
                    <textarea class=""form-control"" name=""Aciklama"" placeholder=""Aciklama"" rows=""10""></textarea>
                </div>

                <div class=""row m-1 float-right"">
                    <button type=""submit"" class=""btn btn-primary float-right mt-6"">Rezervasyon Yap</button>
                </div>
                <div class=""row"">
                    <br />
                    <br />
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-restaurantId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 19 "/Users/cetin/Desktop/workspaces-wsc/dining-out/dining-out/Views/MasaRezervasyon/Index.cshtml"
                                                                                           WriteLiteral(ViewBag.Restaurant.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["restaurantId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-restaurantId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["restaurantId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                <div class=\"row m-1\">\n");
#nullable restore
#line 58 "/Users/cetin/Desktop/workspaces-wsc/dining-out/dining-out/Views/MasaRezervasyon/Index.cshtml"
                     if (ViewBag.Basarili != null && ViewBag.Basarili == true)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""alert alert-success"" role=""alert"">
                            Rezervasyonuz alınmıştır. En kısa sürede rezervasyon onayınız iletilecektir.
                            Restauranta gitmeden menü seçimlerinizi profilinizden yapabilirsiniz.
                        </div>
");
#nullable restore
#line 64 "/Users/cetin/Desktop/workspaces-wsc/dining-out/dining-out/Views/MasaRezervasyon/Index.cshtml"
                    }
                    else if (ViewBag.Basarili != null && ViewBag.Basarili == false)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"alert alert-danger\" role=\"alert\">\n                            Bir hata ile karşılaşıldı daha sonra tekrar deneyiniz.!!!\n                        </div>\n");
#nullable restore
#line 70 "/Users/cetin/Desktop/workspaces-wsc/dining-out/dining-out/Views/MasaRezervasyon/Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\n        </div>\n    </div>\n</section>\n    <!-- End Table Reservation Form -->\n\n\n");
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
