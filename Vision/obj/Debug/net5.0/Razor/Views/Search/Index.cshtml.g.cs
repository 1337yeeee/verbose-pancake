<<<<<<< HEAD
#pragma checksum "/Users/admin/ProjectsVS/Vision/Vision/Views/Search/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1a02917470f624eaf38183cc62448bb855b9d28"
=======
#pragma checksum "C:\Users\Adyan\OneDrive\Рабочий стол\проект\verbose-pancake\Vision\Views\Search\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79a70fa96a68ef2d99de5fb1fc1357025ed10a43"
>>>>>>> 965e38b267304459a973fb3bdd025d77619af826
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Search_Index), @"mvc.1.0.view", @"/Views/Search/Index.cshtml")]
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
#line 1 "C:\Users\Adyan\OneDrive\Рабочий стол\проект\verbose-pancake\Vision\Views\_ViewImports.cshtml"
using Vision;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Adyan\OneDrive\Рабочий стол\проект\verbose-pancake\Vision\Views\_ViewImports.cshtml"
using Vision.Models;

#line default
#line hidden
#nullable disable
<<<<<<< HEAD
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1a02917470f624eaf38183cc62448bb855b9d28", @"/Views/Search/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0f19e9f533fd6b5928f16a2d76a5ef8b54cf7e5", @"/Views/_ViewImports.cshtml")]
=======
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79a70fa96a68ef2d99de5fb1fc1357025ed10a43", @"/Views/Search/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4836f256c4d10f22571ff92922dcea95c533106c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
>>>>>>> 965e38b267304459a973fb3bdd025d77619af826
    public class Views_Search_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
<<<<<<< HEAD
            WriteLiteral("\n\n<div class=\"search\">\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f1a02917470f624eaf38183cc62448bb855b9d284034", async() => {
=======
            WriteLiteral("\r\n\r\n<div class=\"search\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "79a70fa96a68ef2d99de5fb1fc1357025ed10a434238", async() => {
>>>>>>> 965e38b267304459a973fb3bdd025d77619af826
                WriteLiteral(@"
        <input type=""radio"" name=""SearchModel"" value=""Article"" checked /> Поиск по статьям <br />
        <input type=""radio"" name=""SearchModel"" value=""Product"" /> Поиск по товарам <br />
        <input type=""radio"" name=""SearchModel"" value=""Brand"" /> Поиск по брендам <br />
        <input type=""radio"" name=""SearchModel"" value=""Author"" /> Поиск по авторам <br />
        <br /><p style=""font-size: 24px;""><b>Критерии</b></p><br />
        <input type=""text"" name=""name"" placeholder=""Называние"" />
        <input type=""text"" name=""authorName"" placeholder=""Имя Автора"" />
        <input type=""text"" name=""words"" placeholder=""ключевые слова"" />
        <input type=""text"" name=""brandName"" placeholder=""Бренд"" />
        <input type=""text"" name=""categoryName"" placeholder=""Категория"" />
        <p>Рейтинг</p>
        <input type=""number"" name=""ratingStart"" min=""0"" max=""5"" placeholder=""от"" step=""0.2""/>
        <input type=""number"" name=""ratingEnd"" min=""0"" max=""5"" placeholder=""до"" step=""0.2""/>
        <p>Цена</p>
        <");
                WriteLiteral("input type=\"number\" name=\"priceStart\" min=\"0\" max=\"9999999999\" placeholder=\"от\" step=\"1000\"/>\n        <input type=\"number\" name=\"priceEnd\" min=\"0\" max=\"9999999999\" placeholder=\"до\" step=\"1000\"/>\n        <input type=\"submit\" value=\"enter\" />\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
<<<<<<< HEAD
            WriteLiteral("\n</div>\n\n<div class=\"result\">\n");
#nullable restore
#line 27 "/Users/admin/ProjectsVS/Vision/Vision/Views/Search/Index.cshtml"
     if (Model.ModelOfSearch == "Article")
    {
        foreach (var article in Model.Articles)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"mini-article\">\n                <h3>");
#nullable restore
#line 32 "/Users/admin/ProjectsVS/Vision/Vision/Views/Search/Index.cshtml"
               Write(article.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n                <i>");
#nullable restore
#line 33 "/Users/admin/ProjectsVS/Vision/Vision/Views/Search/Index.cshtml"
              Write(article.author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i>\n                <i>");
#nullable restore
#line 34 "/Users/admin/ProjectsVS/Vision/Vision/Views/Search/Index.cshtml"
              Write(article.date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i>\n                <h4>");
#nullable restore
#line 35 "/Users/admin/ProjectsVS/Vision/Vision/Views/Search/Index.cshtml"
               Write(article.header);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n                <p>");
#nullable restore
#line 36 "/Users/admin/ProjectsVS/Vision/Vision/Views/Search/Index.cshtml"
              Write(article.text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n            </div>\n");
#nullable restore
#line 38 "/Users/admin/ProjectsVS/Vision/Vision/Views/Search/Index.cshtml"
        }
    }
    else if (Model.ModelOfSearch == "Product")
    {
        foreach (var product in Model.Products)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"mini-product\">\n                <h3>");
#nullable restore
#line 45 "/Users/admin/ProjectsVS/Vision/Vision/Views/Search/Index.cshtml"
               Write(product.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n                <b>");
#nullable restore
#line 46 "/Users/admin/ProjectsVS/Vision/Vision/Views/Search/Index.cshtml"
              Write(product.brand);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\n                <i>");
#nullable restore
#line 47 "/Users/admin/ProjectsVS/Vision/Vision/Views/Search/Index.cshtml"
              Write(product.category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i>\n                <p>Цена: ");
#nullable restore
#line 48 "/Users/admin/ProjectsVS/Vision/Vision/Views/Search/Index.cshtml"
                    Write(product.price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n            </div>\n");
#nullable restore
#line 50 "/Users/admin/ProjectsVS/Vision/Vision/Views/Search/Index.cshtml"
        }
    }
    else if (Model.ModelOfSearch == "Brand")
    {
        foreach (var brand in Model.Brands)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"mini-brand\">\n                <h3>");
#nullable restore
#line 57 "/Users/admin/ProjectsVS/Vision/Vision/Views/Search/Index.cshtml"
               Write(brand.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n                <p>");
#nullable restore
#line 58 "/Users/admin/ProjectsVS/Vision/Vision/Views/Search/Index.cshtml"
              Write(brand.disc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n            </div>\n");
#nullable restore
#line 60 "/Users/admin/ProjectsVS/Vision/Vision/Views/Search/Index.cshtml"
        }
    }
    else if (Model.ModelOfSearch == "Author")
    {
        foreach (var author in Model.Authors)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"mini-article\">\n                <h3>");
#nullable restore
#line 67 "/Users/admin/ProjectsVS/Vision/Vision/Views/Search/Index.cshtml"
               Write(author.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n                <p>");
#nullable restore
#line 68 "/Users/admin/ProjectsVS/Vision/Vision/Views/Search/Index.cshtml"
              Write(author.rating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n            </div>\n");
#nullable restore
#line 70 "/Users/admin/ProjectsVS/Vision/Vision/Views/Search/Index.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n");
=======
            WriteLiteral("\r\n</div>");
>>>>>>> 965e38b267304459a973fb3bdd025d77619af826
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
