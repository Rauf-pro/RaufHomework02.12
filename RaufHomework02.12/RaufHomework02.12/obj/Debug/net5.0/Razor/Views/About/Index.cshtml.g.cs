#pragma checksum "C:\Users\User\Desktop\BackEnd all tasks\RaufHomework_02.12\RaufHomework02.12\RaufHomework02.12\Views\About\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fffcac24271ace395381ce0a278022625fd38491"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_About_Index), @"mvc.1.0.view", @"/Views/About/Index.cshtml")]
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
#line 1 "C:\Users\User\Desktop\BackEnd all tasks\RaufHomework_02.12\RaufHomework02.12\RaufHomework02.12\Views\_ViewImports.cshtml"
using RaufHomework02._12;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\BackEnd all tasks\RaufHomework_02.12\RaufHomework02.12\RaufHomework02.12\Views\_ViewImports.cshtml"
using RaufHomework02._12.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fffcac24271ace395381ce0a278022625fd38491", @"/Views/About/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6dcc47f0ba6331919b5e677ec0d34ea06126e2b", @"/Views/_ViewImports.cshtml")]
    public class Views_About_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<About>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("contact_bg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\User\Desktop\BackEnd all tasks\RaufHomework_02.12\RaufHomework02.12\RaufHomework02.12\Views\About\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!-- about  -->\r\n<div id=\"about\" class=\"about\">\r\n    <div class=\"container\">\r\n        <div class=\"row display_boxflex\">\r\n            <div class=\"col-xl-6 col-lg-6 col-md-6 col-sm-12\">\r\n                <div class=\"about-box\">\r\n");
#nullable restore
#line 13 "C:\Users\User\Desktop\BackEnd all tasks\RaufHomework_02.12\RaufHomework02.12\RaufHomework02.12\Views\About\Index.cshtml"
                     foreach (var about in Model) { 

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h2>");
#nullable restore
#line 14 "C:\Users\User\Desktop\BackEnd all tasks\RaufHomework_02.12\RaufHomework02.12\RaufHomework02.12\Views\About\Index.cshtml"
                       Write(about.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                        <p>");
#nullable restore
#line 15 "C:\Users\User\Desktop\BackEnd all tasks\RaufHomework_02.12\RaufHomework02.12\RaufHomework02.12\Views\About\Index.cshtml"
                      Write(about.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <a href=\"Javascript:void(0)\">Read More</a>\r\n");
#nullable restore
#line 17 "C:\Users\User\Desktop\BackEnd all tasks\RaufHomework_02.12\RaufHomework02.12\RaufHomework02.12\Views\About\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>
            <div class=""col-xl-6 col-lg-6 col-md-6 col-sm-12"">
                <div class=""about-box"">
                    <figure><img src=""images/about.png"" alt=""#"" /></figure>
                </div>
            </div>
        </div>

    </div>
</div>
<!-- end abouts -->
<!-- upcoming -->
<div id=""upcoming"" class=""upcoming"">
    <div class=""container-fluid padding_left3"">
        <div class=""row display_boxflex"">
            <div class=""col-xl-5 col-lg-5 col-md-5 col-sm-12"">
                <div class=""box_text"">
                    <div class=""titlepage"">
                        <h2>Upcoming Concerts</h2>
                    </div>
                    <p>It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it lookIt is a long");
            WriteLiteral(@" established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look</p>
                    <a href=""Javascript:void(0)"">Read More</a>
                </div>
            </div>

            <div class=""col-xl-7 col-lg-7 col-md-7 col-sm-12 border_right"">
                <div class=""upcomimg"">
                    <figure><img src=""images/up.jpg"" alt=""#"" /></figure>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- end upcoming -->
<!-- Gallery -->


<div id=""gallery"" class=""Gallery"">
    <div class=""container"">
        <div class=""row display_boxflex"">
            <div class=""col-xl-8 col-lg-8 col-md-8 col-sm-12"">
                <div class=""row"">
                    <div class=""col-xl-6 col-lg-6 col-md-6 col-sm-12 margi_bott"">
                        <div cla");
            WriteLiteral(@"ss=""Gallery_img"">
                            <figure><img src=""images/Gallery1.jpg"" alt=""#"" /></figure>
                        </div>
                        <div class=""hover_box"">

                            <ul class=""icon_hu"">
                                <h3>Music night</h3>
                                <li><a href=""#""><img src=""icon/h.png"" alt=""#"" /></a></li>
                                <li><a href=""#""><img src=""icon/h.png"" alt=""#"" /></a></li>
                            </ul>
                        </div>
                    </div>
                    <div class=""col-xl-6 col-lg-6 col-md-6 col-sm-12 margi_bott"">
                        <div class=""Gallery_img"">
                            <figure><img src=""images/Gallery2.jpg"" alt=""#"" /></figure>
                        </div>
                        <div class=""hover_box"">

                            <ul class=""icon_hu"">
                                <h3>Music night</h3>
                                <li><a href=");
            WriteLiteral(@"""#""><img src=""icon/h.png"" alt=""#"" /></a></li>
                                <li><a href=""#""><img src=""icon/h.png"" alt=""#"" /></a></li>
                            </ul>
                        </div>
                    </div>
                    <div class=""col-xl-6 col-lg-6 col-md-6 col-sm-12 margi_bott1"">
                        <div class=""Gallery_img"">
                            <figure><img src=""images/Gallery3.jpg"" alt=""#"" /></figure>
                        </div>
                        <div class=""hover_box"">

                            <ul class=""icon_hu"">
                                <h3>Music night</h3>
                                <li><a href=""#""><img src=""icon/h.png"" alt=""#"" /></a></li>
                                <li><a href=""#""><img src=""icon/h.png"" alt=""#"" /></a></li>
                            </ul>
                        </div>
                    </div>
                    <div class=""col-xl-6 col-lg-6 col-md-6 col-sm-12"">
                        <div cla");
            WriteLiteral(@"ss=""Gallery_img"">
                            <figure><img src=""images/Gallery4.jpg"" alt=""#"" /></figure>
                        </div>
                        <div class=""hover_box"">

                            <ul class=""icon_hu"">
                                <h3>Music night</h3>
                                <li><a href=""#""><img src=""icon/h.png"" alt=""#"" /></a></li>
                                <li><a href=""#""><img src=""icon/h.png"" alt=""#"" /></a></li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-xl-4 col-lg-4 col-md-4 col-sm-12"">
                <div class=""Gallery_text"">
                    <div class=""titlepage"">
                        <h2>Gallery</h2>
                    </div>
                    <p>It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that");
            WriteLiteral(@" it has a more-or-less normal distribution of letters, as opposed to usin</p>
                    <a href=""Javascript:void(0)"">Read More</a>
                </div>
            </div>
        </div>
    </div>
</div>

<!-- end Gallery -->
<!--  footer -->
<footr>
    <div class=""footer "">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-12"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fffcac24271ace395381ce0a278022625fd3849111299", async() => {
                WriteLiteral(@"
                        <div class=""row"">
                            <div class=""col-md-12"">
                                <div class=""titlepage"">
                                    <h2>Contact us</h2>
                                </div>
                                <div class=""col-md-12"">
                                    <input class=""contactus"" placeholder=""Your Name"" type=""text"" name=""Your Name"">
                                </div>
                                <div class=""col-md-12"">
                                    <input class=""contactus"" placeholder=""Your Email"" type=""text"" name=""Your Email"">
                                </div>
                                <div class=""col-md-12"">
                                    <input class=""contactus"" placeholder=""Your Phone"" type=""text"" name=""Your Phone"">
                                </div>
                                <div class=""col-md-12"">
                                    <textarea class=""textarea"" placehold");
                WriteLiteral(@"er=""Message"" type=""text"" name=""Message""></textarea>
                                </div>
                                <div class=""col-xl-12 col-lg-12 col-md-12 col-sm-12"">
                                    <button class=""send"">Send</button>
                                </div>
                            </div>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<About>> Html { get; private set; }
    }
}
#pragma warning restore 1591
