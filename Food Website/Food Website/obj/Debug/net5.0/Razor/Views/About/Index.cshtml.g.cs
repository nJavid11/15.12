#pragma checksum "C:\Users\User\source\repos\Food Website\Food Website\Views\About\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fbcb641ded1c48421561b396e83acb2ff5024d94"
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
#line 1 "C:\Users\User\source\repos\Food Website\Food Website\Views\_ViewImports.cshtml"
using Food_Website;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\source\repos\Food Website\Food Website\Views\_ViewImports.cshtml"
using Food_Website.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbcb641ded1c48421561b396e83acb2ff5024d94", @"/Views/About/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96a73b9f043af86d4929926dcd02dd5c9e281c3a", @"/Views/_ViewImports.cshtml")]
    public class Views_About_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\User\source\repos\Food Website\Food Website\Views\About\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Page Header Start -->
<div class=""page-header mb-0"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12"">
                <h2>About Us</h2>
            </div>
            <div class=""col-12"">
                <a");
            BeginWriteAttribute("href", " href=\"", 302, "\"", 309, 0);
            EndWriteAttribute();
            WriteLiteral(">Home</a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 339, "\"", 346, 0);
            EndWriteAttribute();
            WriteLiteral(@">About Us</a>
            </div>
        </div>
    </div>
</div>
<!-- Page Header End -->
<!-- Food Start -->
<div class=""food mt-0"">
    <div class=""container"">
        <div class=""row align-items-center"">
            <div class=""col-md-4"">
                <div class=""food-item"">
                    <i class=""flaticon-burger""></i>
                    <h2>Burgers</h2>
                    <p>
                        Lorem ipsum dolor sit amet elit. Phasel nec pretium mi. Curabit facilis ornare velit non vulputa. Aliquam metus tortor auctor quis sem.
                    </p>
                    <a");
            BeginWriteAttribute("href", " href=\"", 967, "\"", 974, 0);
            EndWriteAttribute();
            WriteLiteral(@">View Menu</a>
                </div>
            </div>
            <div class=""col-md-4"">
                <div class=""food-item"">
                    <i class=""flaticon-snack""></i>
                    <h2>Snacks</h2>
                    <p>
                        Lorem ipsum dolor sit amet elit. Phasel nec pretium mi. Curabit facilis ornare velit non vulputa. Aliquam metus tortor auctor quis sem.
                    </p>
                    <a");
            BeginWriteAttribute("href", " href=\"", 1435, "\"", 1442, 0);
            EndWriteAttribute();
            WriteLiteral(@">View Menu</a>
                </div>
            </div>
            <div class=""col-md-4"">
                <div class=""food-item"">
                    <i class=""flaticon-cocktail""></i>
                    <h2>Beverages</h2>
                    <p>
                        Lorem ipsum dolor sit amet elit. Phasel nec pretium mi. Curabit facilis ornare velit non vulputa. Aliquam metus tortor auctor quis sem.
                    </p>
                    <a");
            BeginWriteAttribute("href", " href=\"", 1909, "\"", 1916, 0);
            EndWriteAttribute();
            WriteLiteral(@">View Menu</a>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Food End -->
<!-- About Start -->
<div class=""about"">
    <div class=""container"">
        <div class=""row align-items-center"">
            <div class=""col-lg-6"">
                <div class=""about-img"">
                    <img src=""img/about.jpg"" alt=""Image"">
                    <button type=""button"" class=""btn-play"" data-toggle=""modal"" data-src=""https://www.youtube.com/embed/DWRcNpR6Kdc"" data-target=""#videoModal"">
                        <span></span>
                    </button>
                </div>
            </div>
            <div class=""col-lg-6"">
                <div class=""about-content"">
                    <div class=""section-header"">
                        <p>About Us</p>
                        <h2>Cooking Since 1990</h2>
                    </div>
                    <div class=""about-text"">
                        <p>
                            Lorem ipsum dolor sit ame");
            WriteLiteral(@"t, consectetur adipiscing elit. Phasellus nec pretium mi. Curabitur facilisis ornare velit non vulputate. Aliquam metus tortor, auctor id gravida condimentum, viverra quis sem.
                        </p>
                        <p>
                            Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus nec pretium mi. Curabitur facilisis ornare velit non vulputate. Aliquam metus tortor, auctor id gravida condimentum, viverra quis sem. Curabitur non nisl nec nisi scelerisque maximus. Aenean consectetur convallis porttitor. Aliquam interdum at lacus non blandit.
                        </p>
                        <a class=""btn custom-btn""");
            BeginWriteAttribute("href", " href=\"", 3616, "\"", 3623, 0);
            EndWriteAttribute();
            WriteLiteral(@">Book A Table</a>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- About End -->
<!-- Video Modal Start-->
<div class=""modal fade"" id=""videoModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-body"">
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
                <!-- 16:9 aspect ratio -->
                <div class=""embed-responsive embed-responsive-16by9"">
                    <iframe class=""embed-responsive-item""");
            BeginWriteAttribute("src", " src=\"", 4400, "\"", 4406, 0);
            EndWriteAttribute();
            WriteLiteral(" id=\"video\" allowscriptaccess=\"always\" allow=\"autoplay\"></iframe>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- Video Modal End -->\r\n");
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
