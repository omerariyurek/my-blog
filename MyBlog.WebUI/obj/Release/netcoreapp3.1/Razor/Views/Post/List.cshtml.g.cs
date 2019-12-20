#pragma checksum "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Post\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90e09735a346c4653092d3ed3cae4f63944d7f26"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Post_List), @"mvc.1.0.view", @"/Views/Post/List.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90e09735a346c4653092d3ed3cae4f63944d7f26", @"/Views/Post/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc7d4d6404a600e7932f1d62349b2eca37f84ae5", @"/Views/_ViewImports.cshtml")]
    public class Views_Post_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyBlog.WebUI.Models.ViewModels.PostListViewModel>
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
        private global::MyBlog.WebUI.TagHelpers.PostAllPagingHelper __MyBlog_WebUI_TagHelpers_PostAllPagingHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Post\List.cshtml"
  
    ViewData["Title"] = $"{@TempData["searchPost"]} - Ömer ARIYÜREK";

#line default
#line hidden
            WriteLiteral("<section class=\"load-more\">\r\n    <h1 class=\"load-more--main-title\">");
#line 6 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Post\List.cshtml"
                                 Write(TempData["searchPost"]);

#line default
#line hidden
            WriteLiteral(" için arama sonuçları</h1>\r\n    <div class=\"load-more__other-post\">\r\n");
#line 8 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Post\List.cshtml"
         if (Model.PostDetails.Count == 0)
        {

#line default
#line hidden
            WriteLiteral("            <p style=\"margin-bottom: 19%;margin-top: 26px;\">Aradığınız yazı bulunamadı.</p>\r\n");
#line 11 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Post\List.cshtml"
        }
        else
        {
            foreach (var post in Model.PostDetails)
            {


#line default
#line hidden
            WriteLiteral("                <a");
            BeginWriteAttribute("href", " href=\"", 566, "\"", 624, 1);
#line 17 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Post\List.cshtml"
WriteAttributeValue("", 573, Url.Action("Get","Post",new{@seoUrl=@post.SeoUrl}), 573, 51, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 625, "\"", 644, 1);
#line 17 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Post\List.cshtml"
WriteAttributeValue("", 633, post.Title, 633, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 672, "\"", 694, 1);
#line 18 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Post\List.cshtml"
WriteAttributeValue("", 678, post.FirstImage, 678, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 695, "\"", 712, 1);
#line 18 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Post\List.cshtml"
WriteAttributeValue("", 701, post.Title, 701, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 713, "\"", 742, 1);
#line 18 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Post\List.cshtml"
WriteAttributeValue("", 721, post.MetaDescription, 721, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <h2 class=\"load-more__other-post--title\">");
#line 19 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Post\List.cshtml"
                                                        Write(post.Title);

#line default
#line hidden
            WriteLiteral("</h2>\r\n                </a>\r\n                <ul class=\"load-more__other-post--date-category\">\r\n                    <li class=\"date\">");
#line 22 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Post\List.cshtml"
                                Write(post.CreatedDate.ToString("dd/MM/yyyy"));

#line default
#line hidden
            WriteLiteral("</li>\r\n                    <li class=\"hyphen\">-</li>\r\n                    <li class=\"category\">\r\n");
#line 25 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Post\List.cshtml"
                         foreach (var category in post.PostCategories)
                        {

#line default
#line hidden
            WriteLiteral("                            <a");
            BeginWriteAttribute("href", " href=\"", 1217, "\"", 1297, 1);
#line 27 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Post\List.cshtml"
WriteAttributeValue("", 1224, Url.Action("CategoryPosts", "Category", new {@seoUrl = category.SeoUrl}), 1224, 73, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 1298, "\"", 1328, 1);
#line 27 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Post\List.cshtml"
WriteAttributeValue("", 1306, category.CategoryName, 1306, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(">");
#line 27 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Post\List.cshtml"
                                                                                                                                          Write(category.CategoryName);

#line default
#line hidden
            WriteLiteral("</a>\r\n");
#line 28 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Post\List.cshtml"
                        }

#line default
#line hidden
            WriteLiteral("                    </li>\r\n                </ul>\r\n");
#line 31 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Post\List.cshtml"
            
            }
        }

#line default
#line hidden
            WriteLiteral("    </div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("post-all-paging", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90e09735a346c4653092d3ed3cae4f63944d7f267863", async() => {
            }
            );
            __MyBlog_WebUI_TagHelpers_PostAllPagingHelper = CreateTagHelper<global::MyBlog.WebUI.TagHelpers.PostAllPagingHelper>();
            __tagHelperExecutionContext.Add(__MyBlog_WebUI_TagHelpers_PostAllPagingHelper);
#line 35 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Post\List.cshtml"
__MyBlog_WebUI_TagHelpers_PostAllPagingHelper.PageSize = Model.PageSize;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("page-size", __MyBlog_WebUI_TagHelpers_PostAllPagingHelper.PageSize, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 35 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Post\List.cshtml"
__MyBlog_WebUI_TagHelpers_PostAllPagingHelper.PageCount = Model.PageCount;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("page-count", __MyBlog_WebUI_TagHelpers_PostAllPagingHelper.PageCount, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 35 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Post\List.cshtml"
__MyBlog_WebUI_TagHelpers_PostAllPagingHelper.CurrentPage = Model.CurrentPage;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("current-page", __MyBlog_WebUI_TagHelpers_PostAllPagingHelper.CurrentPage, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 35 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Post\List.cshtml"
                                                                                                                  WriteLiteral(Model.SearchKey);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __MyBlog_WebUI_TagHelpers_PostAllPagingHelper.SearchPost = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("search-post", __MyBlog_WebUI_TagHelpers_PostAllPagingHelper.SearchPost, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyBlog.WebUI.Models.ViewModels.PostListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
