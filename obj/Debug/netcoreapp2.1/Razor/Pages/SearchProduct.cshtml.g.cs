#pragma checksum "C:\Users\Chaklun\Documents\GitHub\SportShop\Pages\SearchProduct.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "02483ea4a88d4ae6942bfe8b70c13664ab84bdd50164cc610a4835d0a6f350c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SportShop.Models.Pages_SearchProduct), @"mvc.1.0.razor-page", @"/Pages/SearchProduct.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/SearchProduct.cshtml", typeof(SportShop.Models.Pages_SearchProduct), null)]
namespace SportShop.Models
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Chaklun\Documents\GitHub\SportShop\Pages\_ViewImports.cshtml"
using SportShop;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"02483ea4a88d4ae6942bfe8b70c13664ab84bdd50164cc610a4835d0a6f350c5", @"/Pages/SearchProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"5e1f4717c15b2c19f315a8e1f02604783a31da8816ac411ddd8e199d677f573d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_SearchProduct : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "C:\Users\Chaklun\Documents\GitHub\SportShop\Pages\SearchProduct.cshtml"
  
    ViewData["Title"] = "Searching";

#line default
#line hidden
            BeginContext(124, 31, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    ");
            EndContext();
            BeginContext(156, 53, false);
#line 9 "C:\Users\Chaklun\Documents\GitHub\SportShop\Pages\SearchProduct.cshtml"
Write(Html.Partial("_ProductsTablePartial", Model.Products));

#line default
#line hidden
            EndContext();
            BeginContext(209, 8, true);
            WriteLiteral("\r\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SportShop.Pages.SearchProductModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SportShop.Pages.SearchProductModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SportShop.Pages.SearchProductModel>)PageContext?.ViewData;
        public SportShop.Pages.SearchProductModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
