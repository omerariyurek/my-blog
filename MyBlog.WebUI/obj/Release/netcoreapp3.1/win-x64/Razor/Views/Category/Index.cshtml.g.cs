#pragma checksum "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e334e0e90b1b560ffe3e594bd9c74ce33b57a4c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Index), @"mvc.1.0.view", @"/Views/Category/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e334e0e90b1b560ffe3e594bd9c74ce33b57a4c2", @"/Views/Category/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc7d4d6404a600e7932f1d62349b2eca37f84ae5", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyBlog.WebUI.Models.ViewModels.CategoryIndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/category-background.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::MyBlog.WebUI.TagHelpers.CategoriesPagingHelper __MyBlog_WebUI_TagHelpers_CategoriesPagingHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Category\Index.cshtml"
  
    ViewData["Title"] = "Kategoriler - Ömer ARIYÜREK";

#line default
#line hidden
            WriteLiteral("<section class=\"category-content\">\r\n    <div class=\"category-content__category-name\">\r\n        <h2 class=\"category-content__category-name--category\">Kategoriler</h2>\r\n    </div>\r\n    <ul class=\"category-content__content-box\">\r\n");
#line 10 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Category\Index.cshtml"
         foreach (var category in Model.Categories)
        {

#line default
#line hidden
            WriteLiteral("            <li class=\"category-content__content-box--item\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e334e0e90b1b560ffe3e594bd9c74ce33b57a4c24002", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 13 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Category\Index.cshtml"
AddHtmlAttributeValue("", 552, category.CategoryName, 552, 22, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 13 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Category\Index.cshtml"
AddHtmlAttributeValue("", 581, category.CategoryName, 581, 22, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 626, "\"", 702, 1);
#line 14 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Category\Index.cshtml"
WriteAttributeValue("", 633, Url.Action("CategoryPosts","Category",new{@seoUrl=@category.SeoUrl}), 633, 69, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(" class=\"title\"");
            BeginWriteAttribute("title", " title=\"", 717, "\"", 747, 1);
#line 14 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Category\Index.cshtml"
WriteAttributeValue("", 725, category.CategoryName, 725, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(">");
#line 14 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Category\Index.cshtml"
                                                                                                                                        Write(category.CategoryName);

#line default
#line hidden
            WriteLiteral("</a>\r\n            </li>\r\n");
#line 16 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Category\Index.cshtml"
        }

#line default
#line hidden
            WriteLiteral("    </ul>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("categories-paging", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e334e0e90b1b560ffe3e594bd9c74ce33b57a4c27158", async() => {
                WriteLiteral("\r\n    ");
            }
            );
            __MyBlog_WebUI_TagHelpers_CategoriesPagingHelper = CreateTagHelper<global::MyBlog.WebUI.TagHelpers.CategoriesPagingHelper>();
            __tagHelperExecutionContext.Add(__MyBlog_WebUI_TagHelpers_CategoriesPagingHelper);
#line 18 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Category\Index.cshtml"
__MyBlog_WebUI_TagHelpers_CategoriesPagingHelper.PageSize = Model.PageSize;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("page-size", __MyBlog_WebUI_TagHelpers_CategoriesPagingHelper.PageSize, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 18 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Category\Index.cshtml"
__MyBlog_WebUI_TagHelpers_CategoriesPagingHelper.PageCount = Model.PageCount;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("page-count", __MyBlog_WebUI_TagHelpers_CategoriesPagingHelper.PageCount, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 18 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Category\Index.cshtml"
__MyBlog_WebUI_TagHelpers_CategoriesPagingHelper.CurrentPage = Model.CurrentPage;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("current-page", __MyBlog_WebUI_TagHelpers_CategoriesPagingHelper.CurrentPage, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyBlog.WebUI.Models.ViewModels.CategoryIndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
