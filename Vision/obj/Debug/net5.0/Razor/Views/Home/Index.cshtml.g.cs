#pragma checksum "/Users/admin/ProjectsVS/Vision/Vision/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b511c3849a79b00581a6b437c12075b31fe51a56"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b511c3849a79b00581a6b437c12075b31fe51a56", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0f19e9f533fd6b5928f16a2d76a5ef8b54cf7e5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ActAuthor", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ActArticle", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-cotroller", new global::Microsoft.AspNetCore.Html.HtmlString("Home"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ActBrand", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ActCategory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ActProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n\n");
            WriteLiteral("\n   <div class=\"newdata new-author\">\n         <h3>Авторы</h3>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b511c3849a79b00581a6b437c12075b31fe51a565792", async() => {
                WriteLiteral("\n    <input name=\"name\" placeholder=\"name\" />\n    <input name=\"rating\" placeholder=\"rating\" />\n    <button type=\"submit\">Submit</button>\n");
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
            WriteLiteral("\n");
#nullable restore
#line 107 "/Users/admin/ProjectsVS/Vision/Vision/Views/Home/Index.cshtml"
 if (Model != null)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 109 "/Users/admin/ProjectsVS/Vision/Vision/Views/Home/Index.cshtml"
     foreach (var author in Model.Authors)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>");
#nullable restore
#line 111 "/Users/admin/ProjectsVS/Vision/Vision/Views/Home/Index.cshtml"
      Write(author.name);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 111 "/Users/admin/ProjectsVS/Vision/Vision/Views/Home/Index.cshtml"
                    Write(author.rating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n");
#nullable restore
#line 112 "/Users/admin/ProjectsVS/Vision/Vision/Views/Home/Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p style=\"font-size: 48px;\">Articles:</p>\n");
#nullable restore
#line 114 "/Users/admin/ProjectsVS/Vision/Vision/Views/Home/Index.cshtml"
     foreach(var article in Model.Articles) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>");
#nullable restore
#line 115 "/Users/admin/ProjectsVS/Vision/Vision/Views/Home/Index.cshtml"
                  Write(article.name);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 115 "/Users/admin/ProjectsVS/Vision/Vision/Views/Home/Index.cshtml"
                                 Write(article.header);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 115 "/Users/admin/ProjectsVS/Vision/Vision/Views/Home/Index.cshtml"
                                                  Write(article.author);

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 115 "/Users/admin/ProjectsVS/Vision/Vision/Views/Home/Index.cshtml"
                                                                   Write(article.authorID);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\n");
#nullable restore
#line 116 "/Users/admin/ProjectsVS/Vision/Vision/Views/Home/Index.cshtml"
				}

#line default
#line hidden
#nullable disable
#nullable restore
#line 116 "/Users/admin/ProjectsVS/Vision/Vision/Views/Home/Index.cshtml"
                 

}

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n\n<div class=\"newdata new-article\">\n    <h3>Добавить статью</h3>\n    <h4>можно здесь</h4>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b511c3849a79b00581a6b437c12075b31fe51a5610400", async() => {
                WriteLiteral(@"
        <p>Название</p>
        <input type=""text"" name=""name"" required />
        <p>Заголовок</p>
        <input type=""text"" name=""header"" required />
        <p>Автор</p>
        <input type=""text"" name=""authorName"" required list=""authorsList"" />
        <datalist id=""authorsList"">
");
#nullable restore
#line 132 "/Users/admin/ProjectsVS/Vision/Vision/Views/Home/Index.cshtml"
             foreach (var author in Model.Authors)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b511c3849a79b00581a6b437c12075b31fe51a5611210", async() => {
#nullable restore
#line 134 "/Users/admin/ProjectsVS/Vision/Vision/Views/Home/Index.cshtml"
                   Write(author.name);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
#nullable restore
#line 135 "/Users/admin/ProjectsVS/Vision/Vision/Views/Home/Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </datalist>\n        <p>Ваша статья</p>\n        <input type=\"text\" name=\"text\" required />\n        <p>Изображение</p>\n        <input type=\"submit\" value=\"enter\" />\n\n    ");
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n\n<div class=\"newdata new-brand\">\n    <h3>Бренды</h3>\n    <h4></h4>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b511c3849a79b00581a6b437c12075b31fe51a5614358", async() => {
                WriteLiteral("\n        <input name=\"name\" input placeholder=\"name\" required />\n        <p></p>\n        <input type=\"text\" input name=\"disc\" input placeholder=\"disc\" required/>\n        <button type=\"submit\">Нажми</button>\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 154 "/Users/admin/ProjectsVS/Vision/Vision/Views/Home/Index.cshtml"
     if(Model != null)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 156 "/Users/admin/ProjectsVS/Vision/Vision/Views/Home/Index.cshtml"
         foreach(var brand in Model.Brands)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>");
#nullable restore
#line 158 "/Users/admin/ProjectsVS/Vision/Vision/Views/Home/Index.cshtml"
          Write(brand.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                ");
#nullable restore
#line 159 "/Users/admin/ProjectsVS/Vision/Vision/Views/Home/Index.cshtml"
           Write(brand.disc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n");
#nullable restore
#line 160 "/Users/admin/ProjectsVS/Vision/Vision/Views/Home/Index.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 163 "/Users/admin/ProjectsVS/Vision/Vision/Views/Home/Index.cshtml"
           
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n\n<div class=\"newdata new-category\">\n    <h3>Категории</h3>\n    <h4></h4>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b511c3849a79b00581a6b437c12075b31fe51a5617531", async() => {
                WriteLiteral("\n        <input name=\"name\" input placeholder=\"name\" required />\n        <p></p>\n        <input type=\"text\" input name=\"sizeTable\" input placeholder=\"sizeTable\" required/>\n        <button type=\"submit\">Нажми</button>\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 176 "/Users/admin/ProjectsVS/Vision/Vision/Views/Home/Index.cshtml"
     if(Model != null)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 178 "/Users/admin/ProjectsVS/Vision/Vision/Views/Home/Index.cshtml"
         foreach(var category in Model.Categories)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>");
#nullable restore
#line 180 "/Users/admin/ProjectsVS/Vision/Vision/Views/Home/Index.cshtml"
          Write(category.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                ");
#nullable restore
#line 181 "/Users/admin/ProjectsVS/Vision/Vision/Views/Home/Index.cshtml"
           Write(category.sizeTable);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n");
#nullable restore
#line 182 "/Users/admin/ProjectsVS/Vision/Vision/Views/Home/Index.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 185 "/Users/admin/ProjectsVS/Vision/Vision/Views/Home/Index.cshtml"
            
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n<div class=\"newdata new-product\">\n    <h3>Продукт</h3>\n    <h4></h4>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b511c3849a79b00581a6b437c12075b31fe51a5620728", async() => {
                WriteLiteral(@"
        <p>Название</p>
        <input type=""text"" name=""name"" required />
        <p>Цена</p>
        <input type=""text"" name=""price"" required />
        <p>Оценка</p>
        <input type=""text"" name=""rating"" required />
        <p>Ссылка</p>
        <input type=""text"" name=""link"" required/>
         <p>Изображение</p>
        <input type=""text"" name=""img"" required/>
       
       
        <p>Категория</p>
        <input  name=""categoryName"" required list=""categoriesList"" />
        <datalist id=""categoriesList"">
");
#nullable restore
#line 207 "/Users/admin/ProjectsVS/Vision/Vision/Views/Home/Index.cshtml"
             foreach (var category in Model.Categories)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b511c3849a79b00581a6b437c12075b31fe51a5621788", async() => {
#nullable restore
#line 209 "/Users/admin/ProjectsVS/Vision/Vision/Views/Home/Index.cshtml"
                   Write(category.name);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
#nullable restore
#line 210 "/Users/admin/ProjectsVS/Vision/Vision/Views/Home/Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </datalist>\n\n         <input  name=\"brandName\" required list=\"brandsList\" />\n        <datalist id=\"brandsList\">\n");
#nullable restore
#line 215 "/Users/admin/ProjectsVS/Vision/Vision/Views/Home/Index.cshtml"
             foreach (var brand in Model.Brands)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b511c3849a79b00581a6b437c12075b31fe51a5623489", async() => {
#nullable restore
#line 217 "/Users/admin/ProjectsVS/Vision/Vision/Views/Home/Index.cshtml"
                   Write(brand.name);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
#nullable restore
#line 218 "/Users/admin/ProjectsVS/Vision/Vision/Views/Home/Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </datalist>\n        \n        <input type=\"submit\" value=\"enter\" />\n    ");
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n");
#nullable restore
#line 224 "/Users/admin/ProjectsVS/Vision/Vision/Views/Home/Index.cshtml"
     if(Model != null)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 226 "/Users/admin/ProjectsVS/Vision/Vision/Views/Home/Index.cshtml"
         foreach(var product in Model.Products)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>");
#nullable restore
#line 228 "/Users/admin/ProjectsVS/Vision/Vision/Views/Home/Index.cshtml"
          Write(product.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                ");
#nullable restore
#line 229 "/Users/admin/ProjectsVS/Vision/Vision/Views/Home/Index.cshtml"
           Write(product.price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                ");
#nullable restore
#line 230 "/Users/admin/ProjectsVS/Vision/Vision/Views/Home/Index.cshtml"
           Write(product.rating);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                <b>");
#nullable restore
#line 231 "/Users/admin/ProjectsVS/Vision/Vision/Views/Home/Index.cshtml"
              Write(product.brand.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                ");
#nullable restore
#line 232 "/Users/admin/ProjectsVS/Vision/Vision/Views/Home/Index.cshtml"
           Write(product.category.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></p>\n");
#nullable restore
#line 233 "/Users/admin/ProjectsVS/Vision/Vision/Views/Home/Index.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 236 "/Users/admin/ProjectsVS/Vision/Vision/Views/Home/Index.cshtml"
                   
    }

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
