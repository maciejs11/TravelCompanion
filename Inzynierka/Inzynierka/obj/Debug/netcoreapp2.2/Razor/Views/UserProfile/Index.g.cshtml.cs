#pragma checksum "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\UserProfile\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "432b9b1bff5c3607ff46d6205fd47c20e1507eba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserProfile_Index), @"mvc.1.0.view", @"/Views/UserProfile/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/UserProfile/Index.cshtml", typeof(AspNetCore.Views_UserProfile_Index))]
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
#line 1 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\_ViewImports.cshtml"
using Inzynierka;

#line default
#line hidden
#line 2 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\_ViewImports.cshtml"
using Inzynierka.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"432b9b1bff5c3607ff46d6205fd47c20e1507eba", @"/Views/UserProfile/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e51e35947ca9dd757bdad0a0b1ee4d7c528178d9", @"/Views/_ViewImports.cshtml")]
    public class Views_UserProfile_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Inzynierka.Models.ApplicationUsers.ApplicationUser>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(59, 33, true);
            WriteLiteral("\r\n<h2>Profil użytkownika</h2>\r\n\r\n");
            EndContext();
            BeginContext(253, 184, true);
            WriteLiteral("\r\n<div class=\"col-md-6 card card-body bg-light\">\r\n    <div style=\"padding:10px\">\r\n        <h4 class=\"d-inline\">Imię i nazwisko: </h4>\r\n        <h4 class=\" d-inline font-weight-normal\">");
            EndContext();
            BeginContext(438, 15, false);
#line 17 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\UserProfile\Index.cshtml"
                                            Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(453, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(455, 14, false);
#line 17 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\UserProfile\Index.cshtml"
                                                             Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(469, 141, true);
            WriteLiteral("</h4>\r\n    </div>\r\n    <div style=\"padding:10px\">\r\n        <h4 class=\"d-inline\">Wiek: </h4>\r\n        <h4 class=\"d-inline font-weight-normal\">");
            EndContext();
            BeginContext(611, 9, false);
#line 21 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\UserProfile\Index.cshtml"
                                           Write(Model.Age);

#line default
#line hidden
            EndContext();
            BeginContext(620, 141, true);
            WriteLiteral("</h4>\r\n    </div>\r\n    <div style=\"padding:10px\">\r\n        <h4 class=\"d-inline\">Płeć: </h4>\r\n        <h4 class=\"d-inline font-weight-normal\">");
            EndContext();
            BeginContext(762, 12, false);
#line 25 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\UserProfile\Index.cshtml"
                                           Write(Model.Gender);

#line default
#line hidden
            EndContext();
            BeginContext(774, 143, true);
            WriteLiteral("</h4>\r\n    </div>\r\n    <div style=\"padding:10px\">\r\n        <h4 class=\"d-inline\">O mnie: </h4>\r\n        <h4 class=\"d-inline font-weight-normal\">");
            EndContext();
            BeginContext(918, 11, false);
#line 29 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\UserProfile\Index.cshtml"
                                           Write(Model.About);

#line default
#line hidden
            EndContext();
            BeginContext(929, 27, true);
            WriteLiteral("</h4>\r\n    </div>\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Inzynierka.Models.ApplicationUsers.ApplicationUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
