#pragma checksum "C:\Users\miray\Önemli\.net\denemeler\CoreAndFood\CoreAndFood\Views\Food\FoodAdd.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bdcb5043da4312662256bc6de9827085b71c81aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Food_FoodAdd), @"mvc.1.0.view", @"/Views/Food/FoodAdd.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bdcb5043da4312662256bc6de9827085b71c81aa", @"/Views/Food/FoodAdd.cshtml")]
    public class Views_Food_FoodAdd : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CoreAndFood.Data.Models.Food>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\miray\Önemli\.net\denemeler\CoreAndFood\CoreAndFood\Views\Food\FoodAdd.cshtml"
  
    Layout = "/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Food Add Page</h2>\r\n<br />\r\n");
#nullable restore
#line 8 "C:\Users\miray\Önemli\.net\denemeler\CoreAndFood\CoreAndFood\Views\Food\FoodAdd.cshtml"
 using (Html.BeginForm("FoodAdd", "Food", FormMethod.Post))
{

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\miray\Önemli\.net\denemeler\CoreAndFood\CoreAndFood\Views\Food\FoodAdd.cshtml"
Write(Html.Label("Food Name"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\miray\Önemli\.net\denemeler\CoreAndFood\CoreAndFood\Views\Food\FoodAdd.cshtml"
Write(Html.TextBoxFor(x => x.FoodName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 16 "C:\Users\miray\Önemli\.net\denemeler\CoreAndFood\CoreAndFood\Views\Food\FoodAdd.cshtml"
Write(Html.Label("Stock"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\miray\Önemli\.net\denemeler\CoreAndFood\CoreAndFood\Views\Food\FoodAdd.cshtml"
Write(Html.TextBoxFor(x => x.FoodStock, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 21 "C:\Users\miray\Önemli\.net\denemeler\CoreAndFood\CoreAndFood\Views\Food\FoodAdd.cshtml"
Write(Html.Label("Price"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\miray\Önemli\.net\denemeler\CoreAndFood\CoreAndFood\Views\Food\FoodAdd.cshtml"
Write(Html.TextBoxFor(x => x.FoodPrice, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 26 "C:\Users\miray\Önemli\.net\denemeler\CoreAndFood\CoreAndFood\Views\Food\FoodAdd.cshtml"
Write(Html.Label("İmage Url"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\miray\Önemli\.net\denemeler\CoreAndFood\CoreAndFood\Views\Food\FoodAdd.cshtml"
Write(Html.TextBoxFor(x => x.FoodImageUrl, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 30 "C:\Users\miray\Önemli\.net\denemeler\CoreAndFood\CoreAndFood\Views\Food\FoodAdd.cshtml"
    //v1den taşıdığım değerlerin idsini al. Dropdownda kullan.
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\miray\Önemli\.net\denemeler\CoreAndFood\CoreAndFood\Views\Food\FoodAdd.cshtml"
Write(Html.Label("Category"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\miray\Önemli\.net\denemeler\CoreAndFood\CoreAndFood\Views\Food\FoodAdd.cshtml"
Write(Html.DropDownListFor(x => x.CategoryId, (List<SelectListItem>)ViewBag.v1, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 36 "C:\Users\miray\Önemli\.net\denemeler\CoreAndFood\CoreAndFood\Views\Food\FoodAdd.cshtml"
Write(Html.Label("Description"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\miray\Önemli\.net\denemeler\CoreAndFood\CoreAndFood\Views\Food\FoodAdd.cshtml"
Write(Html.TextAreaFor(x => x.FoodDescription, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
            WriteLiteral("    <button class=\"btn btn-success\">Save</button>\r\n");
#nullable restore
#line 42 "C:\Users\miray\Önemli\.net\denemeler\CoreAndFood\CoreAndFood\Views\Food\FoodAdd.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoreAndFood.Data.Models.Food> Html { get; private set; }
    }
}
#pragma warning restore 1591
