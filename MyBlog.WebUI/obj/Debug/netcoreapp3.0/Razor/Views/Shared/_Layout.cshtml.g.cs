#pragma checksum "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df94ee843c8cb46fc30126fe240897046e992891"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df94ee843c8cb46fc30126fe240897046e992891", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a1a53d4907155e01462ebbd66339dfe9c594e23", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/styles/reset.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/styles/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/images/Spinner-1s-200px.gif"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/images/logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("left-bar__logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/scripts/app.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "df94ee843c8cb46fc30126fe240897046e9928915587", async() => {
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"ie=edge\">\r\n    <title>");
#nullable restore
#line 7 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Shared\_Layout.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</title>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "df94ee843c8cb46fc30126fe240897046e9928916277", async() => {
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
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "df94ee843c8cb46fc30126fe240897046e9928917455", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <link href=""https://fonts.googleapis.com/css?family=Poppins:100,200,300,400,500,600,700"" rel=""stylesheet"">
    <link rel=""stylesheet"" href=""https://use.fontawesome.com/releases/v5.8.1/css/all.css"" integrity=""sha384-50oBUHEmvpQ+1lW4y57PTFmhCaXp0ML5d60M1M7uH2+nqUivzIebhndOJK28anvf"" crossorigin=""anonymous"">
");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "df94ee843c8cb46fc30126fe240897046e9928919660", async() => {
                WriteLiteral("\r\n    <div class=\"load-wrapper hidden\">\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "df94ee843c8cb46fc30126fe240897046e9928919969", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    </div>\r\n    <section class=\"mobile-header\">\r\n        <div class=\"mobile-header__mobile-logo\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "df94ee843c8cb46fc30126fe240897046e99289111176", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
        </div>
        <i class=""fas fa-bars menu-icon""></i>
        <div class=""mobile-header__menu-wrapper"">
            <i class=""fas fa-times close""></i>
            <ul class=""mobile-header__menu"">
                <li class=""mobile-header__menu--item"">
                    <span class=""mobile-header__menu--title"">Lorem Ipsum</span>
                    <ul class=""mobile-header__menu--dropdown"">
                        <li class=""mobile-header__menu--dropdown-item"">Lorem Ipsum</li>
                        <li class=""mobile-header__menu--dropdown-item"">Lorem Ipsum</li>
                        <li class=""mobile-header__menu--dropdown-item"">Lorem Ipsum</li>
                        <li class=""mobile-header__menu--dropdown-item"">Lorem Ipsum</li>
                    </ul>
                </li>
                <li class=""mobile-header__menu--item"">
                    <span class=""mobile-header__menu--title"">Lorem</span>
                    <ul class=""mobile-header__menu--dropdown"">
            ");
                WriteLiteral(@"            <li class=""mobile-header__menu--dropdown-item"">Lorem Ipsum</li>
                        <li class=""mobile-header__menu--dropdown-item"">Lorem Ipsum</li>
                        <li class=""mobile-header__menu--dropdown-item"">Lorem Ipsum</li>
                        <li class=""mobile-header__menu--dropdown-item"">Lorem Ipsum</li>
                    </ul>
                </li>
                <li class=""mobile-header__menu--item"">
                    <span class=""mobile-header__menu--title"">Lorem Ipsum</span>
                    <ul class=""mobile-header__menu--dropdown"">
                        <li class=""mobile-header__menu--dropdown-item"">Lorem Ipsum</li>
                        <li class=""mobile-header__menu--dropdown-item"">Lorem Ipsum</li>
                        <li class=""mobile-header__menu--dropdown-item"">Lorem Ipsum</li>
                        <li class=""mobile-header__menu--dropdown-item"">Lorem Ipsum</li>
                    </ul>
                </li>
                <li cla");
                WriteLiteral(@"ss=""mobile-header__menu--item"">
                    <span class=""mobile-header__menu--title"">Lorem</span>
                    <ul class=""mobile-header__menu--dropdown"">
                        <li class=""mobile-header__menu--dropdown-item"">Lorem Ipsum</li>
                        <li class=""mobile-header__menu--dropdown-item"">Lorem Ipsum</li>
                        <li class=""mobile-header__menu--dropdown-item"">Lorem Ipsum</li>
                        <li class=""mobile-header__menu--dropdown-item"">Lorem Ipsum</li>
                    </ul>
                </li>
                <li class=""mobile-header__menu--item"">
                    <span class=""mobile-header__menu--title"">Lorem Ipsum</span>
                    <ul class=""mobile-header__menu--dropdown"">
                        <li class=""mobile-header__menu--dropdown-item"">Lorem Ipsum</li>
                        <li class=""mobile-header__menu--dropdown-item"">Lorem Ipsum</li>
                        <li class=""mobile-header__menu--dropdown-it");
                WriteLiteral(@"em"">Lorem Ipsum</li>
                        <li class=""mobile-header__menu--dropdown-item"">Lorem Ipsum</li>
                    </ul>
                </li>
                <li class=""mobile-header__menu--item"">
                    <span class=""mobile-header__menu--title"">Lorem</span>
                    <ul class=""mobile-header__menu--dropdown"">
                        <li class=""mobile-header__menu--dropdown-item"">Lorem Ipsum</li>
                        <li class=""mobile-header__menu--dropdown-item"">Lorem Ipsum</li>
                        <li class=""mobile-header__menu--dropdown-item"">Lorem Ipsum</li>
                        <li class=""mobile-header__menu--dropdown-item"">Lorem Ipsum</li>
                    </ul>
                </li>
            </ul>
            <div class=""mobile-header__menu--search-wrapper"">
                <input type=""text"" class=""mobile-header__menu--search"" placeholder=""Bir şeyler arayın..."">
                <button><i class=""fas fa-search search""></i></button>
 ");
                WriteLiteral(@"           </div>
            <ul class=""mobile-header__social-media"">
                <li><a href=""https://github.com/omerariyurek"" target=""_blank""><i class=""fab fa-github""></i></a></li>
                <li><a href=""https://www.linkedin.com/in/omerariyurek/"" target=""_blank""><i class=""fab fa-linkedin""></i></a></li>
                <li><a");
                BeginWriteAttribute("href", " href=\"", 5393, "\"", 5433, 2);
                WriteAttributeValue("", 5400, "https://medium.com/", 5400, 19, true);
                WriteLiteral("@");
                WriteAttributeValue("", 5421, "omerariyurek", 5421, 12, true);
                EndWriteAttribute();
                WriteLiteral(" target=\"_blank\"><i class=\"fab fa-medium\"></i></a></li>\r\n                <li><a");
                BeginWriteAttribute("href", " href=\"", 5513, "\"", 5552, 2);
                WriteAttributeValue("", 5520, "mailto:omerariyurek", 5520, 19, true);
                WriteLiteral("@");
                WriteAttributeValue("", 5541, "hotmail.com", 5541, 11, true);
                EndWriteAttribute();
                WriteLiteral("><i class=\"fas fa-envelope\"></i></a></li>\r\n            </ul>\r\n        </div>\r\n    </section>\r\n    <section class=\"left-bar\">\r\n        <a");
                BeginWriteAttribute("href", " href=\"", 5689, "\"", 5723, 1);
#nullable restore
#line 93 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 5696, Url.Action("Index","Home"), 5696, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "df94ee843c8cb46fc30126fe240897046e99289118292", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</a>\r\n        <ul class=\"left-bar__menu\">\r\n            <li class=\"left-bar__menu--item\">\r\n                <span class=\"left-bar__menu--title\"><a class=\"left-bar__menu--text\"");
                BeginWriteAttribute("href", " href=\"", 5958, "\"", 5992, 1);
#nullable restore
#line 96 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 5965, Url.Action("Index","Home"), 5965, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Anasayfa</a></span>\r\n            </li>\r\n            <li class=\"left-bar__menu--item\">\r\n                <span class=\"left-bar__menu--title\">\r\n                    <a class=\"left-bar__menu--text\"");
                BeginWriteAttribute("href", " href=\"", 6186, "\"", 6220, 1);
#nullable restore
#line 100 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 6193, Url.Action("Index","Post"), 6193, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Yazılar</a>\r\n                </span>\r\n            </li>\r\n            <li class=\"left-bar__menu--item\">\r\n                <span class=\"left-bar__menu--title\"><a class=\"left-bar__menu--text\"");
                BeginWriteAttribute("href", " href=\"", 6409, "\"", 6448, 1);
#nullable restore
#line 104 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 6416, Url.Action("Index", "Category"), 6416, 32, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Kategoriler</a>\r\n                </span>\r\n            </li>\r\n            <li class=\"left-bar__menu--item\">\r\n                <span class=\"left-bar__menu--title\"><a class=\"left-bar__menu--text\"");
                BeginWriteAttribute("href", " href=\"", 6641, "\"", 6674, 1);
#nullable restore
#line 108 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 6648, Url.Action("Index","Tag"), 6648, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Etiketler</a></span>\r\n            </li>\r\n           \r\n            <li class=\"left-bar__menu--item\">\r\n                <span class=\"left-bar__menu--title\"><a class=\"left-bar__menu--text\"");
                BeginWriteAttribute("href", " href=\"", 6860, "\"", 6898, 1);
#nullable restore
#line 112 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 6867, Url.Action("Index", "Contact"), 6867, 31, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">İletişim</a>
                </span>
            </li>
        </ul>
        <div class=""left-bar__menu--search-wrapper"">
            <input type=""text"" class=""left-bar__menu--search"" placeholder=""Bir şeyler arayın..."">
            <button><i class=""fas fa-search search""></i></button>
        </div>
        <ul class=""left-bar__social-media"">
            <li><a href=""https://github.com/omerariyurek"" target=""_blank""><i class=""fab fa-github""></i></a></li>
            <li><a href=""https://www.linkedin.com/in/omerariyurek/"" target=""_blank""><i class=""fab fa-linkedin""></i></a></li>
            <li><a");
                BeginWriteAttribute("href", " href=\"", 7512, "\"", 7552, 2);
                WriteAttributeValue("", 7519, "https://medium.com/", 7519, 19, true);
                WriteLiteral("@");
                WriteAttributeValue("", 7540, "omerariyurek", 7540, 12, true);
                EndWriteAttribute();
                WriteLiteral(" target=\"_blank\"><i class=\"fab fa-medium\"></i></a></li>\r\n            <li><a");
                BeginWriteAttribute("href", " href=\"", 7628, "\"", 7667, 2);
                WriteAttributeValue("", 7635, "mailto:omerariyurek", 7635, 19, true);
                WriteLiteral("@");
                WriteAttributeValue("", 7656, "hotmail.com", 7656, 11, true);
                EndWriteAttribute();
                WriteLiteral("><i class=\"fas fa-envelope\"></i></a></li>\r\n        </ul>\r\n    </section>\r\n    ");
#nullable restore
#line 127 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <div class=\"scroll-top\">\r\n        <i class=\"arrow up\"></i>\r\n    </div>\r\n    <section class=\"footer\">\r\n        <div class=\"footer__top\">\r\n            <li>\r\n                <span class=\"footer__top--title\"><a class=\"footer__top--title-text\"");
                BeginWriteAttribute("href", " href=\"", 8003, "\"", 8036, 1);
#nullable restore
#line 134 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 8010, Url.Action("Index","Tag"), 8010, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">Etiketler</a></span>
                <ul class=""footer__top--tags-list"">
                    <li><a href=""#"">Technology</a></li>
                    <li><a href=""#"">Technology</a></li>
                    <li><a href=""#"">Technology</a></li>
                    <li><a href=""#"">Technology</a></li>
                    <li><a href=""#"">Technology</a></li>
                    <li><a href=""#"">Technology</a></li>
                </ul>
            </li>
            <li>
                <span class=""footer__top--title""><a class=""footer__top--title-text""");
                BeginWriteAttribute("href", " href=\"", 8598, "\"", 8636, 1);
#nullable restore
#line 145 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 8605, Url.Action("Index","Category"), 8605, 31, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" target=""_blank"">Kategoriler</a></span>
                <ul class=""footer__top--categories-list"">
                    <li><a href=""#"">Technology</a></li>
                    <li><a href=""#"">Technology</a></li>
                    <li><a href=""#"">Technology</a></li>
                    <li><a href=""#"">Technology</a></li>
                    <li><a href=""#"">Technology</a></li>
                    <li><a href=""#"">Technology</a></li>
                </ul>
            </li>
            <li>
                <span class=""footer__top--title"">Beni Takip Edin</span>
                <ul class=""footer__top--social-media"">
                    <li><a href=""#""><i class=""fab fa-facebook-f""></i></a></li>
                    <li><a href=""#""><i class=""fab fa-twitter""></i></a></li>
                    <li><a href=""#""><i class=""fab fa-instagram""></i></a></li>
                </ul>
            </li>
        </div>
        <div class=""footer-bottom"">
            <p>Bu sitenin kaynak kodlarına <a href=""https://gi");
                WriteLiteral(@"thub.com/omerariyurek/my-blog"" target=""_blank""><i class=""fab fa-github git-icon""></i> GitHub</a> üzerinden ulaşabilirsiniz.</p>
            <nav>
                <a href=""#"">Anasayfa</a>
                <a href=""#"">Yazılar</a>
                <a href=""#"">İletişim</a>
            </nav>
        </div>
    </section>
    <!--Script-->
");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "df94ee843c8cb46fc30126fe240897046e99289127229", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 175 "C:\Users\omerariyurek\Desktop\MyBlog\MyBlog.WebUI\Views\Shared\_Layout.cshtml"
Write(RenderSection("scripts",false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
