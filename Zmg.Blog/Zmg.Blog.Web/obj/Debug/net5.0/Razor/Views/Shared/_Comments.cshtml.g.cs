#pragma checksum "C:\source\zmg_blog\Zmg.Blog\Zmg.Blog.Web\Views\Shared\_Comments.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a644a69d20a55b5e2d4f5a80acc71e3d108ecef0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Comments), @"mvc.1.0.view", @"/Views/Shared/_Comments.cshtml")]
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
#line 1 "C:\source\zmg_blog\Zmg.Blog\Zmg.Blog.Web\Views\_ViewImports.cshtml"
using Zmg.Blog.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\source\zmg_blog\Zmg.Blog\Zmg.Blog.Web\Views\_ViewImports.cshtml"
using Zmg.Blog.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a644a69d20a55b5e2d4f5a80acc71e3d108ecef0", @"/Views/Shared/_Comments.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ecf5231eb754086ff8f8c7113c3fcd61408f11b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Comments : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Zmg.Blog.Domain.Models.PostComment>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\source\zmg_blog\Zmg.Blog\Zmg.Blog.Web\Views\Shared\_Comments.cshtml"
     foreach (var item in Model)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <p class=\"comment-author\"> ");
#nullable restore
#line 7 "C:\source\zmg_blog\Zmg.Blog\Zmg.Blog.Web\Views\Shared\_Comments.cshtml"
                              Write(Html.DisplayFor(modelItem => item.username));

#line default
#line hidden
#nullable disable
            WriteLiteral(" said: </p>\r\n");
            WriteLiteral("        <p> ");
#nullable restore
#line 9 "C:\source\zmg_blog\Zmg.Blog\Zmg.Blog.Web\Views\Shared\_Comments.cshtml"
       Write(Html.DisplayFor(modelItem => item.content));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
            WriteLiteral("        <p class=\"text-muted justify-content-md-end\">");
#nullable restore
#line 11 "C:\source\zmg_blog\Zmg.Blog\Zmg.Blog.Web\Views\Shared\_Comments.cshtml"
                                                Write(Html.DisplayFor(modelItem => item.created_at));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 12 "C:\source\zmg_blog\Zmg.Blog\Zmg.Blog.Web\Views\Shared\_Comments.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Zmg.Blog.Domain.Models.PostComment>> Html { get; private set; }
    }
}
#pragma warning restore 1591