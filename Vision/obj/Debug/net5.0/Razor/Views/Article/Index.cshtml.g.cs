#pragma checksum "/Users/admin/ProjectsVS/Vision/Vision/Views/Article/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94786d3bb3832d6be4317912eb40d3bb60414309"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Article_Index), @"mvc.1.0.view", @"/Views/Article/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94786d3bb3832d6be4317912eb40d3bb60414309", @"/Views/Article/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0f19e9f533fd6b5928f16a2d76a5ef8b54cf7e5", @"/Views/_ViewImports.cshtml")]
    public class Views_Article_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/fullArticle.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Article", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "94786d3bb3832d6be4317912eb40d3bb604143094270", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "94786d3bb3832d6be4317912eb40d3bb604143094528", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n");
            WriteLiteral("\n<div id=\"banner\"");
            BeginWriteAttribute("style", " style=\"", 2523, "\"", 2607, 7);
            WriteAttributeValue("", 2531, "background:", 2531, 11, true);
            WriteAttributeValue("  ", 2542, "url(", 2544, 6, true);
#nullable restore
#line 72 "/Users/admin/ProjectsVS/Vision/Vision/Views/Article/Index.cshtml"
WriteAttributeValue("", 2548, Model.Article.banner.ImageData, 2548, 31, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2579, "),", 2579, 2, true);
            WriteAttributeValue(" ", 2581, "no-repeat,", 2582, 11, true);
            WriteAttributeValue(" ", 2592, "center", 2593, 7, true);
            WriteAttributeValue(" ", 2599, "center;", 2600, 8, true);
            EndWriteAttribute();
            WriteLiteral(@">
    <div class=""naming-zone"">
        <div class=""container-fluid"" id=""namecontainer"">
            <div class=""row align-items-center justify-content-center"">
                <div class=""col-12"">
                    <div class=""naming"">
                        <h1>");
#nullable restore
#line 78 "/Users/admin/ProjectsVS/Vision/Vision/Views/Article/Index.cshtml"
                       Write(Model.Article.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n                        <h5>");
#nullable restore
#line 79 "/Users/admin/ProjectsVS/Vision/Vision/Views/Article/Index.cshtml"
                       Write(Model.Article.header);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                        <p><a href=\"#\">");
#nullable restore
#line 80 "/Users/admin/ProjectsVS/Vision/Vision/Views/Article/Index.cshtml"
                                  Write(Model.Article.author.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></p>\n                        <p><i>");
#nullable restore
#line 81 "/Users/admin/ProjectsVS/Vision/Vision/Views/Article/Index.cshtml"
                         Write(Model.Article.date);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</i></p>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<div class=""container-fluid"">
    <div class=""Article"">
        <div class=""row"">
            <div class=""col-md-2""></div>
            <div class=""col-md-5"">
                <p>");
#nullable restore
#line 93 "/Users/admin/ProjectsVS/Vision/Vision/Views/Article/Index.cshtml"
              Write(Model.Article.text);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                <div class=""row product-in-art"">
                    <div class=""col-md-6 link-container"">
                        <div class=""card"">
                            <img src=""https://static.street-beat.ru/upload/iblock/9cd/9cda04c98670b48a3616cff5fb2f38bd.jpg"" class=""card-img-top"" alt=""..."">
                            <div class=""card-body"">
                                <h5 class=""card-title text-center""><b>Nike</b> Air Huarache</h5>
                                <p class=""card-text"">Вдохновленные архивными моделями adidas, эти массивные кроссовки созданы привлекать внимание.</p>
                                <a href=""#"" class=""btn btn-primary stretched-link"">Go see Air Huarache</a>
                            </div>
                        </div>
                    </div>
                    <div class=""col-md-6 link-container text-center"">
                        <div class=""card"">
                            <img src=""https://static.street-beat.ru/upload/iblock/7d4/7d465bd6d75b7a");
            WriteLiteral(@"0ba2404dbd8f63f9b4.jpg"" class=""card-img-top"" alt=""..."">
                            <div class=""card-body"">
                                <h5 class=""card-title text-center""><b>Adidas</b> Ozelia</h5>
                                <p class=""card-text"">Кроссовки Nike Air Huarache — это популярная уличная модель, обеспечивающая удобную посадку и комфорт.</p>
                                <a href=""#"" class=""btn btn-primary stretched-link"">Go see Ozelia</a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-md-2"">
                <div class=""white-space"">
                </div>
");
#nullable restore
#line 120 "/Users/admin/ProjectsVS/Vision/Vision/Views/Article/Index.cshtml"
                   var articles = Model.Articles.Where(x => x.poster != null).ToList();
					var article = articles[new Random().Next(0,articles.Count())];

#line default
#line hidden
#nullable disable
#nullable restore
#line 122 "/Users/admin/ProjectsVS/Vision/Vision/Views/Article/Index.cshtml"
                 if (article != null) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"link-container text-center article-add\">\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "94786d3bb3832d6be4317912eb40d3bb6041430911431", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 124 "/Users/admin/ProjectsVS/Vision/Vision/Views/Article/Index.cshtml"
                                                      WriteLiteral(article.id.ToString());

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                            <img");
            BeginWriteAttribute("src", " src=\"", 5500, "\"", 5532, 1);
#nullable restore
#line 125 "/Users/admin/ProjectsVS/Vision/Vision/Views/Article/Index.cshtml"
WriteAttributeValue("", 5506, article.poster.DataImgUrl, 5506, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\">\n                            <p>");
#nullable restore
#line 126 "/Users/admin/ProjectsVS/Vision/Vision/Views/Article/Index.cshtml"
                          Write(article.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>");
#nullable restore
#line 126 "/Users/admin/ProjectsVS/Vision/Vision/Views/Article/Index.cshtml"
                                           Write(article.header);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                    </div>\n");
#nullable restore
#line 128 "/Users/admin/ProjectsVS/Vision/Vision/Views/Article/Index.cshtml"
				}

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
