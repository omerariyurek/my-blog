#pragma checksum "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Category\CategoryPosts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a163a5d58a98c54cbbcda5f44a799dec9a7aa73a"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a163a5d58a98c54cbbcda5f44a799dec9a7aa73a", @"/Views/Category/CategoryPosts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a1a53d4907155e01462ebbd66339dfe9c594e23", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_CategoryPosts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyBlog.WebUI.Models.ViewModels.CategoryPostsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Category\CategoryPosts.cshtml"
  
    ViewData["Title"] = "CategoryPosts";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"load-more\">\r\n    <h2 class=\"load-more--main-title\">");
#nullable restore
#line 7 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Category\CategoryPosts.cshtml"
                                 Write(Model.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" kategorisine ait yazılar</h2>\r\n");
#nullable restore
#line 8 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Category\CategoryPosts.cshtml"
     foreach (var post in Model.PostDetails)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"load-more__other-post\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 352, "\"", 410, 1);
#nullable restore
#line 11 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Category\CategoryPosts.cshtml"
WriteAttributeValue("", 359, Url.Action("Get","Post",new{@seoUrl=@post.SeoUrl}), 359, 51, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 434, "\"", 456, 1);
#nullable restore
#line 12 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Category\CategoryPosts.cshtml"
WriteAttributeValue("", 440, post.FirstImage, 440, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 457, "\"", 463, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <h2 class=\"load-more__other-post--title\">");
#nullable restore
#line 13 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Category\CategoryPosts.cshtml"
                                                    Write(post.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n            </a>\r\n            <ul class=\"load-more__other-post--date-category\">\r\n                <li class=\"date\">Nisan 14, 2019</li>\r\n                <li class=\"hyphen\">-</li>\r\n                <li class=\"category\">\r\n");
#nullable restore
#line 19 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Category\CategoryPosts.cshtml"
                     foreach (var category in post.PostCategories)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a");
            BeginWriteAttribute("href", " href=\"", 876, "\"", 952, 1);
#nullable restore
#line 21 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Category\CategoryPosts.cshtml"
WriteAttributeValue("", 883, Url.Action("CategoryPosts","Category",new{@seoUrl=@category.SeoUrl}), 883, 69, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"title\">");
#nullable restore
#line 21 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Category\CategoryPosts.cshtml"
                                                                                                                 Write(category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 22 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Category\CategoryPosts.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </li>\r\n            </ul>\r\n            <div class=\"load-more__other-post--summary\">\r\n");
#nullable restore
#line 26 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Category\CategoryPosts.cshtml"
                  
                    var postContent = post.Content.Length > 330 ? post.Content.Substring(0, 336) + "..." : post.Content;
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Category\CategoryPosts.cshtml"
               Write(Html.Raw(postContent));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>


            <ul class=""social-media"">
                <li><a href=""#""><i class=""fab fa-facebook-f""></i></a></li>
                <li><a href=""#""><i class=""fab fa-twitter""></i></a></li>
                <li><a href=""#""><i class=""fab fa-instagram""></i></a></li>
            </ul>
        </div>
");
#nullable restore
#line 39 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Category\CategoryPosts.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <ul class=\"load-more__pagenation\">\r\n        <li><a href=\"#\">1</a></li>\r\n        <li><a href=\"#\">2</a></li>\r\n        <li><a href=\"#\">3</a></li>\r\n        <li><a href=\"#\">4</a></li>\r\n    </ul>\r\n</section>");
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
