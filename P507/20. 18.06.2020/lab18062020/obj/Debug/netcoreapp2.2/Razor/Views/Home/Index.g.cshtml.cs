#pragma checksum "C:\Users\User\Desktop\LAB\P507\20. 18.06.2020\lab18062020\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fcca6c058f83891965f7479d8cd4973a847cdf1c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\User\Desktop\LAB\P507\20. 18.06.2020\lab18062020\Views\_ViewImports.cshtml"
using lab18062020;

#line default
#line hidden
#line 2 "C:\Users\User\Desktop\LAB\P507\20. 18.06.2020\lab18062020\Views\_ViewImports.cshtml"
using lab18062020.Models;

#line default
#line hidden
#line 1 "C:\Users\User\Desktop\LAB\P507\20. 18.06.2020\lab18062020\Views\Home\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#line 2 "C:\Users\User\Desktop\LAB\P507\20. 18.06.2020\lab18062020\Views\Home\Index.cshtml"
using X.PagedList.Web.Common;

#line default
#line hidden
#line 3 "C:\Users\User\Desktop\LAB\P507\20. 18.06.2020\lab18062020\Views\Home\Index.cshtml"
using X.PagedList;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fcca6c058f83891965f7479d8cd4973a847cdf1c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db20037ce2c5c139c804a0b7688097b6cc8b293c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(82, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "C:\Users\User\Desktop\LAB\P507\20. 18.06.2020\lab18062020\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(158, 106, true);
            WriteLiteral("\r\n<div class=\"row centered\">\r\n    <div class=\"col-12 my-3\">\r\n        <h2>Product List</h2>\r\n    </div>\r\n\r\n");
            EndContext();
#line 15 "C:\Users\User\Desktop\LAB\P507\20. 18.06.2020\lab18062020\Views\Home\Index.cshtml"
     foreach (var product in Model)
    {

#line default
#line hidden
            BeginContext(308, 303, true);
            WriteLiteral(@"        <div class=""col-lg-4 mb-3"">
            <div class=""card"" style=""width: 18rem;"">
                <img src=""https://via.placeholder.com/286x180"" class=""card-img-top"" alt=""https://via.placeholder.com/286x180"">
                <div class=""card-body"">
                    <h5 class=""card-title"">");
            EndContext();
            BeginContext(612, 12, false);
#line 21 "C:\Users\User\Desktop\LAB\P507\20. 18.06.2020\lab18062020\Views\Home\Index.cshtml"
                                      Write(product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(624, 48, true);
            WriteLiteral("</h5>\r\n                    <p class=\"card-text\">");
            EndContext();
            BeginContext(673, 19, false);
#line 22 "C:\Users\User\Desktop\LAB\P507\20. 18.06.2020\lab18062020\Views\Home\Index.cshtml"
                                    Write(product.Description);

#line default
#line hidden
            EndContext();
            BeginContext(692, 140, true);
            WriteLiteral("</p>\r\n                    <a href=\"#\" class=\"btn btn-primary\">Go somewhere</a>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 27 "C:\Users\User\Desktop\LAB\P507\20. 18.06.2020\lab18062020\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(839, 42, true);
            WriteLiteral("\r\n\r\n\r\n\r\n    <div class=\"col-12\">\r\n        ");
            EndContext();
            BeginContext(882, 137, false);
#line 33 "C:\Users\User\Desktop\LAB\P507\20. 18.06.2020\lab18062020\Views\Home\Index.cshtml"
   Write(Html.PagedListPager((IPagedList)Model, page => Url.Action("Index", new { page = page }),
        new PagedListRenderOptionsBase.Minimal));

#line default
#line hidden
            EndContext();
            BeginContext(1019, 18, true);
            WriteLiteral("\r\n\r\n    </div>\r\n\r\n");
            EndContext();
            BeginContext(1679, 14, true);
            WriteLiteral("\r\n\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1710, 160, true);
                WriteLiteral("\r\n    <script>\r\n\r\n        $(document).ready(function () {\r\n            $(\'ul.pagination > li.disabled > a\').addClass(\'page-link\');\r\n        });\r\n    </script>\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
