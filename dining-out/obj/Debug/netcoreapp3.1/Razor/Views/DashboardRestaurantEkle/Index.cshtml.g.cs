#pragma checksum "/Users/cetin/Desktop/workspaces-wsc/dining-out/dining-out/Views/DashboardRestaurantEkle/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f9132129f070dbf315e73a855f1843fa06e1e21"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DashboardRestaurantEkle_Index), @"mvc.1.0.view", @"/Views/DashboardRestaurantEkle/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f9132129f070dbf315e73a855f1843fa06e1e21", @"/Views/DashboardRestaurantEkle/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db1e818469822cea25997ec769de68a3e441debc", @"/Views/_ViewImports.cshtml")]
    public class Views_DashboardRestaurantEkle_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RestaurantVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "DashboardRestaurant", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("selectedCityId"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("districtId"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Ekle", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "DashboardRestaurantEkle", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/cetin/Desktop/workspaces-wsc/dining-out/dining-out/Views/DashboardRestaurantEkle/Index.cshtml"
  
    Layout = "~/Views/Shared/_LayoutDashboard.cshtml";
    ViewData["Title"] = "Dashboard Restaurant Ekle";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral(@"
<style type=""text/css"">
    .custom-file-input.selected:lang(en)::after {
        content: """" !important;
    }

    .custom-file-input-cover.selected:lang(en)::after {
        content: """" !important;
    }

    .custom-file {
        overflow: hidden;
    }

    .custom-file-input {
        white-space: nowrap;
    }

    .custom-file-input-cover {
        white-space: nowrap;
    }
</style>

<br />
<div>
    <div class=""shadow p-3 mb-5 bg-white rounded text-center"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f9132129f070dbf315e73a855f1843fa06e1e217894", async() => {
                WriteLiteral("\n            <div class=\"form-row\">\n                <div class=\"form-group col-lg-12 col-md-6\">\n");
#nullable restore
#line 36 "/Users/cetin/Desktop/workspaces-wsc/dining-out/dining-out/Views/DashboardRestaurantEkle/Index.cshtml"
                     if (ViewBag.Basarili != null && ViewBag.Basarili == true)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div class=\"alert alert-success\" role=\"alert\">\n                            Restaurant kayıt işlemi başarıyla gerçekleştirilmiştir.\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f9132129f070dbf315e73a855f1843fa06e1e218749", async() => {
                    WriteLiteral("Restaurantlar Bölümüne Gidebilirsiniz");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                        </div>\n");
#nullable restore
#line 42 "/Users/cetin/Desktop/workspaces-wsc/dining-out/dining-out/Views/DashboardRestaurantEkle/Index.cshtml"
                    }
                    else if (ViewBag.Basarili != null && ViewBag.Basarili == false)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div class=\"alert alert-danger\" role=\"alert\">\n                            ");
#nullable restore
#line 46 "/Users/cetin/Desktop/workspaces-wsc/dining-out/dining-out/Views/DashboardRestaurantEkle/Index.cshtml"
                       Write(ViewBag.hataMesaji);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        </div>\n");
#nullable restore
#line 48 "/Users/cetin/Desktop/workspaces-wsc/dining-out/dining-out/Views/DashboardRestaurantEkle/Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                </div>
            </div>
            <div class=""form-row text-center"">
                <div class=""col-lg-2 "">
                </div>
                <div class=""col-md-8"">
                    <h2 class=""text-primary"">Restaurant Ekleme Formu</h2>
                </div>
                <div class=""col-lg-2 "">
                </div>
            </div>
            <div class=""form-row"">
                <div class=""col-lg-2 "">
                </div>
                <div class=""col-lg-4 col-md-6 form-group"">
                    <input type=""text"" class=""form-control"" name=""Name"" id=""Name"" placeholder=""Restaurant İsmi"">
                </div>
                <div class=""col-lg-4 col-md-6 form-group"">
                    <input type=""text"" class=""form-control"" name=""SystemDefinitionName"" id=""SystemDefinitionName"" placeholder=""Sistem Restaurant İsmi"">
                </div>
                <div class=""col-lg-2 "">
                </div>
            </div>
            <div class=""form-row"">
          ");
                WriteLiteral("      <div class=\"col-lg-2 \">\n                </div>\n                <div class=\"col-lg-4 col-md-6 form-group\">\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f9132129f070dbf315e73a855f1843fa06e1e2112638", async() => {
                    WriteLiteral("\n");
#nullable restore
#line 77 "/Users/cetin/Desktop/workspaces-wsc/dining-out/dining-out/Views/DashboardRestaurantEkle/Index.cshtml"
                         foreach (var city in ViewBag.CitiesData)
                        {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f9132129f070dbf315e73a855f1843fa06e1e2113237", async() => {
#nullable restore
#line 79 "/Users/cetin/Desktop/workspaces-wsc/dining-out/dining-out/Views/DashboardRestaurantEkle/Index.cshtml"
                                                 Write(city.Value);

#line default
#line hidden
#nullable disable
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
#nullable restore
#line 79 "/Users/cetin/Desktop/workspaces-wsc/dining-out/dining-out/Views/DashboardRestaurantEkle/Index.cshtml"
                               WriteLiteral(city.Key);

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
#line 80 "/Users/cetin/Desktop/workspaces-wsc/dining-out/dining-out/Views/DashboardRestaurantEkle/Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
                    WriteLiteral("                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 76 "/Users/cetin/Desktop/workspaces-wsc/dining-out/dining-out/Views/DashboardRestaurantEkle/Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CityId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                </div>\n                <div class=\"col-lg-4 col-md-6 form-group\">\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f9132129f070dbf315e73a855f1843fa06e1e2116998", async() => {
                    WriteLiteral("\n");
#nullable restore
#line 85 "/Users/cetin/Desktop/workspaces-wsc/dining-out/dining-out/Views/DashboardRestaurantEkle/Index.cshtml"
                         foreach (var district in ViewBag.DistrictiesData)
                        {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f9132129f070dbf315e73a855f1843fa06e1e2117606", async() => {
#nullable restore
#line 87 "/Users/cetin/Desktop/workspaces-wsc/dining-out/dining-out/Views/DashboardRestaurantEkle/Index.cshtml"
                                                     Write(district.Value);

#line default
#line hidden
#nullable disable
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
#nullable restore
#line 87 "/Users/cetin/Desktop/workspaces-wsc/dining-out/dining-out/Views/DashboardRestaurantEkle/Index.cshtml"
                               WriteLiteral(district.Key);

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
#line 88 "/Users/cetin/Desktop/workspaces-wsc/dining-out/dining-out/Views/DashboardRestaurantEkle/Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
                    WriteLiteral("                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 84 "/Users/cetin/Desktop/workspaces-wsc/dining-out/dining-out/Views/DashboardRestaurantEkle/Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.DistrictId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                </div>
                <div class=""col-lg-2 "">
                </div>
            </div>
            <div class=""form-row"">
                <div class=""col-lg-2 "">
                </div>
                <div class=""col-lg-8 col-md-6 form-group"">
                    <textarea class=""form-control"" name=""Address"" id=""Address"" placeholder=""Açık Adres"" rows=""2""></textarea>
                </div>
                <div class=""col-lg-2 "">
                </div>
            </div>
            <div class=""form-row"">
                <div class=""col-lg-2 "">
                </div>
                <div class=""col-lg-8 col-md-6 form-group"">
                    <textarea class=""form-control"" name=""Desc"" id=""Desc"" placeholder=""Açıklama"" rows=""10""></textarea>
                </div>
                <div class=""col-lg-2 "">
                </div>
            </div>
            <div class=""form-row"">
                <div class=""col-lg-2 "">
                </div>
                <div class=""col-lg-4 col-md-6 form-gr");
                WriteLiteral(@"oup"">
                    <input class=""form-control"" type=""number"" name=""Capacity"" id=""Capacity"" placeholder=""Kapasite"">
                </div>
                <div class=""col-lg-4 col-md-6 form-group"">
                    <div class=""input-group"">
                        <div class=""custom-file"">
                            <input type=""file"" class=""custom-file-input"" name=""LogoFile"" id=""LogoFile"" aria-describedby=""LogoFile"">
                            <label class=""custom-file-label"" for=""LogoFile"">Logo Seç</label>
                        </div>
                        <div class=""input-group-append"">
                            <button class=""btn btn-primary"" type=""button"" id=""LogoFile"">Logo Yükle</button>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-2 "">
                </div>
            </div>
            <div class=""form-row"">
                <div class=""col-lg-2 "">
                </div>
                <div class=""col-lg-8 col-m");
                WriteLiteral(@"d-6 form-group"">
                    <div class=""input-group"">
                        <div class=""custom-file"">
                            <input type=""file"" class=""custom-file-input-cover"" name=""CoverImgFile"" id=""CoverImgFile"" aria-describedby=""CoverImgFile"">
                            <label class=""custom-file-label"" for=""CoverImgFile"">Kapat Photo Seç</label>
                        </div>
                        <div class=""input-group-append"">
                            <button class=""btn btn-primary"" type=""button"" id=""CoverImgFile"">Kapat Photo Yükle</button>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-2 "">
                </div>
            </div>
            <div class=""form-row"">
                <div class=""col-lg-2 "">
                </div>
                <div class=""col-lg-8"">
                    <button type=""submit"" class=""btn btn-primary float-right mt-6"">Ekle</button>
                </div>
                <div class=""co");
                WriteLiteral("l-lg-2 \">\n                </div>\n            </div>\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </div>\n</div>\n\n\n<script type=\"text/javascript\">\n    $(\"#selectedCityId\").change(function () {\n        $(\"#districtId\").empty();\n        var city = $(\"#selectedCityId\").val();\n\n        $.ajax({\n            url: \'");
#nullable restore
#line 169 "/Users/cetin/Desktop/workspaces-wsc/dining-out/dining-out/Views/DashboardRestaurantEkle/Index.cshtml"
             Write(Url.Action("GetDistrictiesByCity", "Anasayfa"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            type: ""POST"",
            dataType: ""json"",
            data: { cityId: city },
            success: function (data) {
                console.log(data);
                for (var i = 0; i < data.length; i++) {
                    var district = data[i];
                    var opt = $(""<option></option>"");
                    opt.val(district.key);
                    opt.text(district.value);
                    console.log(opt);
                    $(""#districtId"").append(opt);
                }
            }
        });
    });
</script>

<script type=""text/javascript"">

    document.querySelector('.custom-file-input').addEventListener('change', function (e) {
        var name = document.getElementById(""LogoFile"").files[0].name;
        var nextSibling = e.target.nextElementSibling
        nextSibling.innerText = name
    })

    document.querySelector('.custom-file-input-cover').addEventListener('change', function (e) {
        var name = document.getElementById(""CoverImgFile"").files[0].nam");
            WriteLiteral("e;\n        var nextSibling = e.target.nextElementSibling\n        nextSibling.innerText = name\n    })\n\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RestaurantVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
