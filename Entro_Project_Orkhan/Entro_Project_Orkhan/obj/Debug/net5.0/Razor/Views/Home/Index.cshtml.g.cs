#pragma checksum "C:\Users\ASUS\Desktop\Entro-main\Entro_Project_Orkhan\Entro_Project_Orkhan\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0464d05e2dd694fb8409702b398216ec281d505"
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
#line 1 "C:\Users\ASUS\Desktop\Entro-main\Entro_Project_Orkhan\Entro_Project_Orkhan\Views\_ViewImports.cshtml"
using Entro_Project_Orkhan;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\Entro-main\Entro_Project_Orkhan\Entro_Project_Orkhan\Views\_ViewImports.cshtml"
using Entro_Project_Orkhan.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0464d05e2dd694fb8409702b398216ec281d505", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18389c388cd5a88f8f995b4aba46eede443cc025", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Setting>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Guitarist Ramish"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/icon/h.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\Entro-main\Entro_Project_Orkhan\Entro_Project_Orkhan\Views\Home\Index.cshtml"
   ViewData["Title"] = "Home Page"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"





<section class=""slider_section"">
    <div id=""myCarousel"" class=""carousel slide"" data-ride=""carousel"">
        <ol class=""carousel-indicators"">
            <li data-target=""#myCarousel"" data-slide-to=""0"" class=""active""></li>
            <li data-target=""#myCarousel"" data-slide-to=""1""></li>
            <li data-target=""#myCarousel"" data-slide-to=""2""></li>
        </ol>
        <div class=""carousel-inner"">
");
#nullable restore
#line 17 "C:\Users\ASUS\Desktop\Entro-main\Entro_Project_Orkhan\Entro_Project_Orkhan\Views\Home\Index.cshtml"
               IEnumerable<Slider> slider = ViewData["Slider"] as IEnumerable<Slider>;
                foreach (var item in slider)
                {
                    if (item.Id == 1)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""carousel-item active"">

        <div class=""container"">
            <div class=""carousel-caption"">
                <div class=""row"">
                    <div class=""col-md-12"">
                        <div class=""text-bg"">
                            <span>");
#nullable restore
#line 29 "C:\Users\ASUS\Desktop\Entro-main\Entro_Project_Orkhan\Entro_Project_Orkhan\Views\Home\Index.cshtml"
                             Write(item.SupTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                            <h1>");
#nullable restore
#line 30 "C:\Users\ASUS\Desktop\Entro-main\Entro_Project_Orkhan\Entro_Project_Orkhan\Views\Home\Index.cshtml"
                           Write(item.SubTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n                            <p>");
#nullable restore
#line 31 "C:\Users\ASUS\Desktop\Entro-main\Entro_Project_Orkhan\Entro_Project_Orkhan\Views\Home\Index.cshtml"
                          Write(item.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            <a href=\"#\">Music & Entertainment</a> <a href=\"#\">Buy Tickets </a>\n                        </div>\n                    </div>\n                </div>\n            </div>\n        </div>\n    </div> ");
#nullable restore
#line 38 "C:\Users\ASUS\Desktop\Entro-main\Entro_Project_Orkhan\Entro_Project_Orkhan\Views\Home\Index.cshtml"
           }

if (item.Id == 2)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"carousel-item\">\n\n    <div class=\"container \">\n        <div class=\"carousel-caption\">\n            <div class=\"row\">\n                <div class=\"col-md-12\">\n                    <div class=\"text-bg\">\n                        <span>");
#nullable restore
#line 49 "C:\Users\ASUS\Desktop\Entro-main\Entro_Project_Orkhan\Entro_Project_Orkhan\Views\Home\Index.cshtml"
                         Write(item.SupTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                        <h1>");
#nullable restore
#line 50 "C:\Users\ASUS\Desktop\Entro-main\Entro_Project_Orkhan\Entro_Project_Orkhan\Views\Home\Index.cshtml"
                       Write(item.SubTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n                        <p>");
#nullable restore
#line 51 "C:\Users\ASUS\Desktop\Entro-main\Entro_Project_Orkhan\Entro_Project_Orkhan\Views\Home\Index.cshtml"
                      Write(item.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                        <a href=\"#\">Music & Entertainment</a><a href=\"#\">Buy Tickets </a>\n                    </div>\n                </div>\n            </div>\n        </div>\n    </div>\n</div> ");
#nullable restore
#line 58 "C:\Users\ASUS\Desktop\Entro-main\Entro_Project_Orkhan\Entro_Project_Orkhan\Views\Home\Index.cshtml"
       }


if (item.Id == 3)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"carousel-item\">\n\n    <div class=\"container\">\n        <div class=\"carousel-caption \">\n            <div class=\"row\">\n                <div class=\"col-md-12\">\n                    <div class=\"text-bg\">\n                        <span>");
#nullable restore
#line 70 "C:\Users\ASUS\Desktop\Entro-main\Entro_Project_Orkhan\Entro_Project_Orkhan\Views\Home\Index.cshtml"
                         Write(item.SupTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                        <h1>");
#nullable restore
#line 71 "C:\Users\ASUS\Desktop\Entro-main\Entro_Project_Orkhan\Entro_Project_Orkhan\Views\Home\Index.cshtml"
                       Write(item.SubTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n                        <p>");
#nullable restore
#line 72 "C:\Users\ASUS\Desktop\Entro-main\Entro_Project_Orkhan\Entro_Project_Orkhan\Views\Home\Index.cshtml"
                      Write(item.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                        <a href=\"#\">Music & Entertainment</a> <a href=\"#\">Buy Tickets </a>\n                    </div>\n                </div>\n            </div>\n        </div>\n    </div>\n</div> ");
#nullable restore
#line 79 "C:\Users\ASUS\Desktop\Entro-main\Entro_Project_Orkhan\Entro_Project_Orkhan\Views\Home\Index.cshtml"
       }

} 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

        </div>

        <a class=""carousel-control-prev"" href=""#myCarousel"" role=""button"" data-slide=""prev"">
            <i class=""fa fa-long-arrow-left"" aria-hidden=""true""></i>

        </a>
        <a class=""carousel-control-next"" href=""#myCarousel"" role=""button"" data-slide=""next"">
            <i class=""fa fa-long-arrow-right"" aria-hidden=""true""></i>

        </a>
    </div>



</section>
</header>





<!-- about  -->
");
#nullable restore
#line 106 "C:\Users\ASUS\Desktop\Entro-main\Entro_Project_Orkhan\Entro_Project_Orkhan\Views\Home\Index.cshtml"
   IEnumerable<AboutUs> aboutUs = ViewData["AboutUs"] as IEnumerable<AboutUs>;

    foreach (var item in aboutUs)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div id=\"about\" class=\"about\"");
            BeginWriteAttribute("style", " style=\"", 3014, "\"", 3154, 10);
            WriteAttributeValue("", 3022, "background:", 3022, 11, true);
            WriteAttributeValue(" ", 3033, "url(../images/", 3034, 15, true);
#nullable restore
#line 110 "C:\Users\ASUS\Desktop\Entro-main\Entro_Project_Orkhan\Entro_Project_Orkhan\Views\Home\Index.cshtml"
WriteAttributeValue("", 3048, item.BackgroundImage, 3048, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3069, ");", 3069, 2, true);
            WriteAttributeValue(" ", 3071, "background-repeat:", 3072, 19, true);
            WriteAttributeValue(" ", 3090, "no-repeat;", 3091, 11, true);
            WriteAttributeValue(" ", 3101, "background-size:", 3102, 17, true);
            WriteAttributeValue(" ", 3118, "cover;", 3119, 7, true);
            WriteAttributeValue(" ", 3125, "background-position:", 3126, 21, true);
            WriteAttributeValue(" ", 3146, "center;", 3147, 8, true);
            EndWriteAttribute();
            WriteLiteral(">\n    <div class=\"container\">\n        <div class=\"row display_boxflex\">\n            <div class=\"col-xl-6 col-lg-6 col-md-6 col-sm-12\">\n                <div class=\"about-box\">\n                    <h2>About Us</h2>\n                    <p>");
#nullable restore
#line 116 "C:\Users\ASUS\Desktop\Entro-main\Entro_Project_Orkhan\Entro_Project_Orkhan\Views\Home\Index.cshtml"
                  Write(item.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                    <a href=\"Javascript:void(0)\">Read More</a>\n                </div>\n            </div>\n            <div class=\"col-xl-6 col-lg-6 col-md-6 col-sm-12\">\n                <div class=\"about-box\">\n                    <figure>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e0464d05e2dd694fb8409702b398216ec281d50512647", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3652, "~/images/", 3652, 9, true);
#nullable restore
#line 122 "C:\Users\ASUS\Desktop\Entro-main\Entro_Project_Orkhan\Entro_Project_Orkhan\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 3661, item.Image, 3661, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</figure>\n                </div>\n            </div>\n        </div>\n    </div>\n</div> ");
#nullable restore
#line 127 "C:\Users\ASUS\Desktop\Entro-main\Entro_Project_Orkhan\Entro_Project_Orkhan\Views\Home\Index.cshtml"
       } 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<!-- end abouts -->\n<!-- upcoming -->\n");
#nullable restore
#line 131 "C:\Users\ASUS\Desktop\Entro-main\Entro_Project_Orkhan\Entro_Project_Orkhan\Views\Home\Index.cshtml"
   IEnumerable<Concert> concert = ViewData["Concert"] as IEnumerable<Concert>;

    foreach (var item in concert)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div id=""upcoming"" class=""upcoming"">
                        <div class=""container-fluid padding_left3"">
                            <div class=""row display_boxflex"">
                                <div class=""col-xl-5 col-lg-5 col-md-5 col-sm-12"">
                                    <div class=""box_text"">
                                        <div class=""titlepage"">
                                            <h2>");
#nullable restore
#line 141 "C:\Users\ASUS\Desktop\Entro-main\Entro_Project_Orkhan\Entro_Project_Orkhan\Views\Home\Index.cshtml"
                                           Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n                                        </div>\n                                        <p>");
#nullable restore
#line 143 "C:\Users\ASUS\Desktop\Entro-main\Entro_Project_Orkhan\Entro_Project_Orkhan\Views\Home\Index.cshtml"
                                      Write(item.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                        <a href=""Javascript:void(0)"">Read More</a>
                                    </div>
                                </div>

                                <div class=""col-xl-7 col-lg-7 col-md-7 col-sm-12 border_right"">
                                    <div class=""upcomimg"">
");
#nullable restore
#line 150 "C:\Users\ASUS\Desktop\Entro-main\Entro_Project_Orkhan\Entro_Project_Orkhan\Views\Home\Index.cshtml"
                                           
                                            IEnumerable<ConcertImage> concertImage = ViewData["ConcertImage"] as IEnumerable<ConcertImage>;
                                            foreach (var image in concertImage)
                                            {
                                                if (image.Id == item.Id)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <figure><img");
            BeginWriteAttribute("src", " src=\"", 5336, "\"", 5361, 2);
            WriteAttributeValue("", 5342, "images/", 5342, 7, true);
#nullable restore
#line 156 "C:\Users\ASUS\Desktop\Entro-main\Entro_Project_Orkhan\Entro_Project_Orkhan\Views\Home\Index.cshtml"
WriteAttributeValue("", 5349, image.Image, 5349, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"#\" /></figure>\r\n");
#nullable restore
#line 157 "C:\Users\ASUS\Desktop\Entro-main\Entro_Project_Orkhan\Entro_Project_Orkhan\Views\Home\Index.cshtml"
                                                }
                                            }
                                            
                                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        \n                                    </div>\n                                </div>\n                            </div>\n                        </div>\n                    </div>\n");
#nullable restore
#line 167 "C:\Users\ASUS\Desktop\Entro-main\Entro_Project_Orkhan\Entro_Project_Orkhan\Views\Home\Index.cshtml"
                } 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<!-- end upcoming -->\n<!-- Gallery -->\n\n\n");
            WriteLiteral("\n<!-- end Gallery -->\n\n\n<div id=\"gallery\" class=\"Gallery\">\n    <div class=\"container\">\n        <div class=\"row display_boxflex\">\n            <div class=\"col-xl-8 col-lg-8 col-md-8 col-sm-12\">\n                <div class=\"row\">\n");
#nullable restore
#line 253 "C:\Users\ASUS\Desktop\Entro-main\Entro_Project_Orkhan\Entro_Project_Orkhan\Views\Home\Index.cshtml"
                       IEnumerable<Gallery> gallery = ViewData["Gallery"] as IEnumerable<Gallery>;
                        foreach (var item in gallery)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col-xl-6 col-lg-6 col-md-6 col-sm-12 margi_bott\">\n                                <div class=\"Gallery_img\">\n                                    <figure>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e0464d05e2dd694fb8409702b398216ec281d50519303", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 10004, "~/images/", 10004, 9, true);
#nullable restore
#line 258 "C:\Users\ASUS\Desktop\Entro-main\Entro_Project_Orkhan\Entro_Project_Orkhan\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 10013, item.Image, 10013, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</figure>\n                                </div>\n                                <div class=\"hover_box\">\n\n                                    <ul class=\"icon_hu\">\n                                        <h3>");
#nullable restore
#line 263 "C:\Users\ASUS\Desktop\Entro-main\Entro_Project_Orkhan\Entro_Project_Orkhan\Views\Home\Index.cshtml"
                                       Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n                                        <li><a");
            BeginWriteAttribute("href", " href=\"", 10306, "\"", 10324, 1);
#nullable restore
#line 264 "C:\Users\ASUS\Desktop\Entro-main\Entro_Project_Orkhan\Entro_Project_Orkhan\Views\Home\Index.cshtml"
WriteAttributeValue("", 10313, item.Link1, 10313, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e0464d05e2dd694fb8409702b398216ec281d50521813", async() => {
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
            WriteLiteral("</a></li>\n                                        <li><a");
            BeginWriteAttribute("href", " href=\"", 10416, "\"", 10434, 1);
#nullable restore
#line 265 "C:\Users\ASUS\Desktop\Entro-main\Entro_Project_Orkhan\Entro_Project_Orkhan\Views\Home\Index.cshtml"
WriteAttributeValue("", 10423, item.Link2, 10423, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e0464d05e2dd694fb8409702b398216ec281d50523367", async() => {
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
            WriteLiteral("</a></li>\n                                    </ul>\n                                </div>\n                            </div>\n");
#nullable restore
#line 269 "C:\Users\ASUS\Desktop\Entro-main\Entro_Project_Orkhan\Entro_Project_Orkhan\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                </div>
            </div>
            <div class=""col-xl-4 col-lg-4 col-md-4 col-sm-12"">
                <div class=""Gallery_text"">
                    <div class=""titlepage"">
                        <h2>Gallery</h2>
                    </div>
");
#nullable restore
#line 279 "C:\Users\ASUS\Desktop\Entro-main\Entro_Project_Orkhan\Entro_Project_Orkhan\Views\Home\Index.cshtml"
                       
                        foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p>");
#nullable restore
#line 282 "C:\Users\ASUS\Desktop\Entro-main\Entro_Project_Orkhan\Entro_Project_Orkhan\Views\Home\Index.cshtml"
                          Write(item.GalleryText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 283 "C:\Users\ASUS\Desktop\Entro-main\Entro_Project_Orkhan\Entro_Project_Orkhan\Views\Home\Index.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                    \n                    <a href=\"Javascript:void(0)\">Read More</a>\n                </div>\n            </div>\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Setting>> Html { get; private set; }
    }
}
#pragma warning restore 1591
