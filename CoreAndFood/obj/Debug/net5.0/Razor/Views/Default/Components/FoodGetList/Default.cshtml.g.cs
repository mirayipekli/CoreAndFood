#pragma checksum "C:\Users\miray\Önemli\.net\denemeler\CoreAndFood\CoreAndFood\Views\Default\Components\FoodGetList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05338796f00059f5cf751b9fbd8e851bf4aec389"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Default_Components_FoodGetList_Default), @"mvc.1.0.view", @"/Views/Default/Components/FoodGetList/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05338796f00059f5cf751b9fbd8e851bf4aec389", @"/Views/Default/Components/FoodGetList/Default.cshtml")]
    public class Views_Default_Components_FoodGetList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CoreAndFood.Data.Models.Food>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"agile_top_brands_grids\" >\r\n");
#nullable restore
#line 3 "C:\Users\miray\Önemli\.net\denemeler\CoreAndFood\CoreAndFood\Views\Default\Components\FoodGetList\Default.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""col-md-3 top_brand_left""style=""margin-bottom:8px"">
            <div class=""hover14 column"">
                <div class=""agile_top_brand_left_grid"">
                    <div class=""agile_top_brand_left_grid1"">
                        <figure >
                            <div class=""snipcart-item block"">
                                <div class=""snipcart-thumb"">
                                    <a href=""single.html""><img title="" "" alt="" """);
            BeginWriteAttribute("src", " src=", 603, "", 626, 1);
#nullable restore
#line 12 "C:\Users\miray\Önemli\.net\denemeler\CoreAndFood\CoreAndFood\Views\Default\Components\FoodGetList\Default.cshtml"
WriteAttributeValue("", 608, item.FoodImageUrl, 608, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("width", " width=\"", 626, "\"", 634, 0);
            EndWriteAttribute();
            WriteLiteral("250px\"\" height=\"200px\"/></a>\r\n                                    <p>");
#nullable restore
#line 13 "C:\Users\miray\Önemli\.net\denemeler\CoreAndFood\CoreAndFood\Views\Default\Components\FoodGetList\Default.cshtml"
                                  Write(item.FoodName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <h4>");
#nullable restore
#line 14 "C:\Users\miray\Önemli\.net\denemeler\CoreAndFood\CoreAndFood\Views\Default\Components\FoodGetList\Default.cshtml"
                                   Write(item.FoodPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₺</h4>\r\n                                    <p>Stock: ");
#nullable restore
#line 15 "C:\Users\miray\Önemli\.net\denemeler\CoreAndFood\CoreAndFood\Views\Default\Components\FoodGetList\Default.cshtml"
                                         Write(item.FoodStock);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                </div>
                                <div class=""snipcart-details top_brand_home_details"">
                                    <form action=""checkout.html"" method=""post"">
                                        <fieldset>
                                            <input type=""hidden"" name=""cmd"" value=""_cart"" />
                                            <input type=""hidden"" name=""add"" value=""1"" />
                                            <input type=""hidden"" name=""business"" value="" "" />
                                            <input type=""hidden"" name=""item_name"" value=""Fortune Sunflower Oil"" />
                                            <input type=""hidden"" name=""amount"" value=""7.99"" />
                                            <input type=""hidden"" name=""discount_amount"" value=""1.00"" />
                                            <input type=""hidden"" name=""currency_code"" value=""USD"" />
                                            <input type=""hid");
            WriteLiteral(@"den"" name=""return"" value="" "" />
                                            <input type=""hidden"" name=""cancel_return"" value="" "" />
                                            <input type=""submit"" name=""submit"" value=""Sepete Ekle"" class=""button"" />
                                        </fieldset>
                                    </form>
                                </div>
                            </div>
                        </figure>
                    </div>
                </div>
            </div>
        </div>
");
#nullable restore
#line 39 "C:\Users\miray\Önemli\.net\denemeler\CoreAndFood\CoreAndFood\Views\Default\Components\FoodGetList\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n<div class=\"clearfix\"> </div>\r\n    </div>\r\n    </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CoreAndFood.Data.Models.Food>> Html { get; private set; }
    }
}
#pragma warning restore 1591
