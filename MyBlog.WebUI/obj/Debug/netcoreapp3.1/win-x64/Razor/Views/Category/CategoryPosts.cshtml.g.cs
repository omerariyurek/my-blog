#pragma checksum "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Category\CategoryPosts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4df2731582c7ae3aff2259546d9d8da0829cb56e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_CategoryPosts), @"mvc.1.0.view", @"/Views/Category/CategoryPosts.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4df2731582c7ae3aff2259546d9d8da0829cb56e", @"/Views/Category/CategoryPosts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc7d4d6404a600e7932f1d62349b2eca37f84ae5", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_CategoryPosts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyBlog.WebUI.Models.ViewModels.CategoryPostsViewModel>
    {
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
        private global::MyBlog.WebUI.TagHelpers.CategoryPostsPagingHelper __MyBlog_WebUI_TagHelpers_CategoryPostsPagingHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Category\CategoryPosts.cshtml"
  
    ViewData["Title"] = $"{Model.Category.CategoryName} Kategorisi - Ömer ARIYÜREK";

#line default
#line hidden
            DefineSection("metaTags", async() => {
                WriteLiteral("\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 205, "\"", 246, 1);
#line 7 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Category\CategoryPosts.cshtml"
WriteAttributeValue("", 215, Model.Category.MetaDescription, 215, 31, false);

#line default
#line hidden
                EndWriteAttribute();
                WriteLiteral("/>\r\n    <meta name=\"keywords\"");
                BeginWriteAttribute("content", " content=\"", 276, "\"", 314, 1);
#line 8 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Category\CategoryPosts.cshtml"
WriteAttributeValue("", 286, Model.Category.MetaKeywords, 286, 28, false);

#line default
#line hidden
                EndWriteAttribute();
                WriteLiteral("/>\r\n    <meta property=\"og:title\"");
                BeginWriteAttribute("content", " content=\"", 348, "\"", 376, 1);
#line 9 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Category\CategoryPosts.cshtml"
WriteAttributeValue("", 358, ViewData["Title"], 358, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                WriteLiteral(">\r\n    <meta property=\"og:url\"");
                BeginWriteAttribute("content", " content=\"", 407, "\"", 477, 2);
                WriteAttributeValue("", 417, "https://www.omerariyurek.com/category/", 417, 38, true);
#line 10 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Category\CategoryPosts.cshtml"
WriteAttributeValue("", 455, Model.Category.SeoUrl, 455, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                WriteLiteral(">\r\n    <meta property=\"og:description\"");
                BeginWriteAttribute("content", " content=\"", 516, "\"", 557, 1);
#line 11 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Category\CategoryPosts.cshtml"
WriteAttributeValue("", 526, Model.Category.MetaDescription, 526, 31, false);

#line default
#line hidden
                EndWriteAttribute();
                WriteLiteral("/>\r\n");
            }
            );
            WriteLiteral("<section class=\"load-more\">\r\n    <h2 class=\"load-more--main-title\">");
#line 14 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Category\CategoryPosts.cshtml"
                                 Write(Model.Category.CategoryName);

#line default
#line hidden
            WriteLiteral(" kategorisine ait yazılar</h2>\r\n");
#line 15 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Category\CategoryPosts.cshtml"
     foreach (var post in Model.PostDetails)
    {

#line default
#line hidden
            WriteLiteral("        <div class=\"load-more__other-post\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 804, "\"", 862, 1);
#line 18 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Category\CategoryPosts.cshtml"
WriteAttributeValue("", 811, Url.Action("Get","Post",new{@seoUrl=@post.SeoUrl}), 811, 51, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 863, "\"", 882, 1);
#line 18 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Category\CategoryPosts.cshtml"
WriteAttributeValue("", 871, post.Title, 871, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 906, "\"", 928, 1);
#line 19 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Category\CategoryPosts.cshtml"
WriteAttributeValue("", 912, post.FirstImage, 912, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 929, "\"", 946, 1);
#line 19 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Category\CategoryPosts.cshtml"
WriteAttributeValue("", 935, post.Title, 935, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 947, "\"", 966, 1);
#line 19 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Category\CategoryPosts.cshtml"
WriteAttributeValue("", 955, post.Title, 955, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(">\r\n                <h2 class=\"load-more__other-post--title\">");
#line 20 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Category\CategoryPosts.cshtml"
                                                    Write(post.Title);

#line default
#line hidden
            WriteLiteral("</h2>\r\n            </a>\r\n            <ul class=\"load-more__other-post--date-category\">\r\n                <li class=\"date\">");
#line 23 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Category\CategoryPosts.cshtml"
                            Write(post.CreatedDate.ToString("MM/dd/yyyy"));

#line default
#line hidden
            WriteLiteral("</li>\r\n                <li class=\"hyphen\">-</li>\r\n                <li class=\"category\">\r\n");
#line 26 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Category\CategoryPosts.cshtml"
                     foreach (var category in post.PostCategories)
                    {

#line default
#line hidden
            WriteLiteral("                        <a");
            BeginWriteAttribute("href", " href=\"", 1405, "\"", 1481, 1);
#line 28 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Category\CategoryPosts.cshtml"
WriteAttributeValue("", 1412, Url.Action("CategoryPosts","Category",new{@seoUrl=@category.SeoUrl}), 1412, 69, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(" class=\"title\"");
            BeginWriteAttribute("title", " title=\"", 1496, "\"", 1526, 1);
#line 28 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Category\CategoryPosts.cshtml"
WriteAttributeValue("", 1504, category.CategoryName, 1504, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(">");
#line 28 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Category\CategoryPosts.cshtml"
                                                                                                                                                Write(category.CategoryName);

#line default
#line hidden
            WriteLiteral("</a>\r\n");
#line 29 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Category\CategoryPosts.cshtml"
                    }

#line default
#line hidden
            WriteLiteral("                </li>\r\n            </ul>\r\n        </div>\r\n");
#line 33 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Category\CategoryPosts.cshtml"
    }

#line default
#line hidden
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("category-posts-paging", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4df2731582c7ae3aff2259546d9d8da0829cb56e9977", async() => {
            }
            );
            __MyBlog_WebUI_TagHelpers_CategoryPostsPagingHelper = CreateTagHelper<global::MyBlog.WebUI.TagHelpers.CategoryPostsPagingHelper>();
            __tagHelperExecutionContext.Add(__MyBlog_WebUI_TagHelpers_CategoryPostsPagingHelper);
#line 34 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Category\CategoryPosts.cshtml"
__MyBlog_WebUI_TagHelpers_CategoryPostsPagingHelper.PageSize = Model.PageSize;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("page-size", __MyBlog_WebUI_TagHelpers_CategoryPostsPagingHelper.PageSize, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 34 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Category\CategoryPosts.cshtml"
__MyBlog_WebUI_TagHelpers_CategoryPostsPagingHelper.PageCount = Model.PageCount;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("page-count", __MyBlog_WebUI_TagHelpers_CategoryPostsPagingHelper.PageCount, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 34 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Category\CategoryPosts.cshtml"
__MyBlog_WebUI_TagHelpers_CategoryPostsPagingHelper.CurrentPage = Model.CurrentPage;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("current-page", __MyBlog_WebUI_TagHelpers_CategoryPostsPagingHelper.CurrentPage, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 34 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Category\CategoryPosts.cshtml"
                                                                                                                             WriteLiteral(Model.CurrentCategory);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __MyBlog_WebUI_TagHelpers_CategoryPostsPagingHelper.CurrentCategory = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("current-category", __MyBlog_WebUI_TagHelpers_CategoryPostsPagingHelper.CurrentCategory, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyBlog.WebUI.Models.ViewModels.CategoryPostsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
