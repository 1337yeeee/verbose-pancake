#pragma checksum "/Users/admin/ProjectsVS/Vision/Vision/Views/Product/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "575746656814850f20c0ce5f2d6b7dab83fe776b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
#line 1 "/Users/admin/ProjectsVS/Vision/Vision/Views/_ViewImports.cshtml"
using Vision;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/admin/ProjectsVS/Vision/Vision/Views/_ViewImports.cshtml"
using Vision.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"575746656814850f20c0ce5f2d6b7dab83fe776b", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0f19e9f533fd6b5928f16a2d76a5ef8b54cf7e5", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 4 "/Users/admin/ProjectsVS/Vision/Vision/Views/Product/Index.cshtml"
 if(Model != null){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container-fluid\">\n        <div class=\"product\">\n            <div class=\"productname\">\n                <p>");
#nullable restore
#line 8 "/Users/admin/ProjectsVS/Vision/Vision/Views/Product/Index.cshtml"
              Write(Model.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n            </div>\n            <div class=\"productbrand\">\n                <p>Brand: ");
#nullable restore
#line 11 "/Users/admin/ProjectsVS/Vision/Vision/Views/Product/Index.cshtml"
                     Write(Model.brand?.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n            </div>\n            <div class=\"productimage\">\n                <img");
            BeginWriteAttribute("src", " src = \"", 411, "\"", 440, 1);
#nullable restore
#line 14 "/Users/admin/ProjectsVS/Vision/Vision/Views/Product/Index.cshtml"
WriteAttributeValue("", 419, ViewBag.ImageDataUrl, 419, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n            </div>\n            <div class=\"productprice\">\n                <p>Price: ");
#nullable restore
#line 17 "/Users/admin/ProjectsVS/Vision/Vision/Views/Product/Index.cshtml"
                     Write(Model.price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" $</p>\n            </div>\n        </div>\n    </div>\n");
#nullable restore
#line 22 "/Users/admin/ProjectsVS/Vision/Vision/Views/Product/Index.cshtml"
                                  
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
