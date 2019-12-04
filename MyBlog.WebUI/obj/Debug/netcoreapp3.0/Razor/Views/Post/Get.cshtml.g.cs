#pragma checksum "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Post\Get.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa250c91b082ecde082242463c7e74ad1042f28d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Post_Get), @"mvc.1.0.view", @"/Views/Post/Get.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa250c91b082ecde082242463c7e74ad1042f28d", @"/Views/Post/Get.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc7d4d6404a600e7932f1d62349b2eca37f84ae5", @"/Views/_ViewImports.cshtml")]
    public class Views_Post_Get : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyBlog.WebUI.Models.ViewModels.PostGetViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Post\Get.cshtml"
  
    ViewData["Title"] = $"{Model.PostDetail.Title} - Ömer ARIYÜREK";

#line default
#line hidden
#nullable disable
            WriteLiteral("<section class=\"post-content\">\r\n    <h2 class=\"post-content__title\">");
#nullable restore
#line 6 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Post\Get.cshtml"
                               Write(Model.PostDetail.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    <ul class=\"post-content__info-list\">\r\n        <li>\r\n");
#nullable restore
#line 9 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Post\Get.cshtml"
             foreach (var category in Model.PostDetail.PostCategories)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a");
            BeginWriteAttribute("href", " href=\"", 392, "\"", 467, 1);
#nullable restore
#line 11 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Post\Get.cshtml"
WriteAttributeValue("", 399, Url.Action("CategoryPosts","Category",new{@seoUrl=category.SeoUrl}), 399, 68, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 11 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Post\Get.cshtml"
                                                                                          Write(category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 12 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Post\Get.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </li>
        <li class=""hyphen"">-</li>
        <li>
            <i class=""far fa-comment""></i>
            <small class=""post-content__info-list--comment"">0</small>
        </li>
    </ul>
    <div class=""post-content__content"">
        <img");
            BeginWriteAttribute("src", " src=\"", 770, "\"", 804, 1);
#nullable restore
#line 21 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Post\Get.cshtml"
WriteAttributeValue("", 776, Model.PostDetail.FirstImage, 776, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"post-content__main-photo\">\r\n        <div class=\"post-content__content--content-txt\">\r\n            ");
#nullable restore
#line 23 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Post\Get.cshtml"
       Write(Html.Raw(Model.PostDetail.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
        <ul class=""share-social-media"">
            <li style=""font-size: larger"">Paylaş</li>
            <li><a href=""#""><i class=""fab fa-facebook-f""></i></a></li>
            <li><a href=""#""><i class=""fab fa-twitter""></i></a></li>
            <li><a href=""#""><i class=""fab fa-instagram""></i></a></li>
        </ul>
    </div>
    <div class=""post-content__category-tag"">
");
#nullable restore
#line 33 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Post\Get.cshtml"
         foreach (var tag in Model.PostTags)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a");
            BeginWriteAttribute("href", " href=\"", 1416, "\"", 1476, 1);
#nullable restore
#line 35 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Post\Get.cshtml"
WriteAttributeValue("", 1423, Url.Action("TagPosts","Tag",new{@seoUrl=tag.SeoUrl}), 1423, 53, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 35 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Post\Get.cshtml"
                                                                       Write(tag.TagName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 36 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Post\Get.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <div class=\"post-content__related-post\">\r\n        <h5 class=\"post-content__related-post--title\">Diğer Paylaşımlar</h5>\r\n        <ul class=\"post-content__related-post--related-list\">\r\n");
#nullable restore
#line 41 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Post\Get.cshtml"
            foreach (var post in Model.RandomTwoPosts)
           {

#line default
#line hidden
#nullable disable
            WriteLiteral("               <li class=\"post-content__related-post--list-item\">\r\n                   <a");
            BeginWriteAttribute("href", " href=\"", 1864, "\"", 1923, 1);
#nullable restore
#line 44 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Post\Get.cshtml"
WriteAttributeValue("", 1871, Url.Action("Index","Post",new{@seoUrl=post.SeoUrl}), 1871, 52, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                       <div class=\"img-and-tag\">\r\n                           <img");
            BeginWriteAttribute("src", " src=\"", 2008, "\"", 2030, 1);
#nullable restore
#line 46 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Post\Get.cshtml"
WriteAttributeValue("", 2014, post.CoverImage, 2014, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2031, "\"", 2037, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                       </div>\r\n                       <h5 class=\"post-content__related-post--related-list--title\">");
#nullable restore
#line 48 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Post\Get.cshtml"
                                                                              Write(post.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                   </a>\r\n               </li>\r\n");
#nullable restore
#line 51 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Post\Get.cshtml"
           }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n    </div>\r\n");
            WriteLiteral("</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyBlog.WebUI.Models.ViewModels.PostGetViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
