#pragma checksum "D:\GitHub\Challengify\Challengify\Views\Users\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0fad49d4a6d70c0e4cae294b0b8fc93aa81c5dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Index), @"mvc.1.0.view", @"/Views/Users/Index.cshtml")]
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
#line 1 "D:\GitHub\Challengify\Challengify\Views\_ViewImports.cshtml"
using Challengify;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\GitHub\Challengify\Challengify\Views\_ViewImports.cshtml"
using Challengify.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0fad49d4a6d70c0e4cae294b0b8fc93aa81c5dd", @"/Views/Users/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a708ff3ee9adaa371eba95cb70402975ff3ad315", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<User>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\GitHub\Challengify\Challengify\Views\Users\Index.cshtml"
  
    ViewData["Title"] = "Users";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"display-4\">Список пользователей</h1>\r\n\r\n");
#nullable restore
#line 8 "D:\GitHub\Challengify\Challengify\Views\Users\Index.cshtml"
 foreach (var user in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card\">\r\n        <div class=\"card-body\">\r\n            <h5 class=\"card-title\">");
#nullable restore
#line 12 "D:\GitHub\Challengify\Challengify\Views\Users\Index.cshtml"
                              Write(user.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            <h5 class=\"card-title\">");
#nullable restore
#line 13 "D:\GitHub\Challengify\Challengify\Views\Users\Index.cshtml"
                              Write(user.XP);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        </div>\r\n        <div class=\"card-footer\">\r\n            <h5 class=\"card-title\">");
#nullable restore
#line 16 "D:\GitHub\Challengify\Challengify\Views\Users\Index.cshtml"
                              Write(user.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            <small class=\"text-muted\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 478, "\"", 507, 3);
            WriteAttributeValue("", 485, "/users/", 485, 7, true);
#nullable restore
#line 18 "D:\GitHub\Challengify\Challengify\Views\Users\Index.cshtml"
WriteAttributeValue("", 492, user.Username, 492, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 506, "/", 506, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Перейти в профиль</a>\r\n            </small>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 22 "D:\GitHub\Challengify\Challengify\Views\Users\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<User>> Html { get; private set; }
    }
}
#pragma warning restore 1591