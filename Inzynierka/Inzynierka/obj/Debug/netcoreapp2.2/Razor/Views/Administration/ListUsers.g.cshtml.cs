#pragma checksum "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\Administration\ListUsers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "446e68f3ad12269525ffac9fe858319612ffb8ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administration_ListUsers), @"mvc.1.0.view", @"/Views/Administration/ListUsers.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Administration/ListUsers.cshtml", typeof(AspNetCore.Views_Administration_ListUsers))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"446e68f3ad12269525ffac9fe858319612ffb8ae", @"/Views/Administration/ListUsers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e51e35947ca9dd757bdad0a0b1ee4d7c528178d9", @"/Views/_ViewImports.cshtml")]
    public class Views_Administration_ListUsers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Inzynierka.Models.ApplicationUsers.ApplicationUser>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Identity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(72, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\Administration\ListUsers.cshtml"
  
    ViewBag.Title = "Wszyscy użytkownicy";

#line default
#line hidden
            BeginContext(125, 219, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-8\">\r\n        <div class=\"row\" style=\"margin:auto\" >\r\n            <h2 style=\"margin-bottom:2%\">Zarządzaj użytkownikami<h2>\r\n            <div class=\"col-md-1\">\r\n                ");
            EndContext();
            BeginContext(344, 104, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "446e68f3ad12269525ffac9fe858319612ffb8ae4790", async() => {
                BeginContext(420, 24, true);
                WriteLiteral("Dodaj nowego użytkownika");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(448, 40, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n");
            EndContext();
#line 16 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\Administration\ListUsers.cshtml"
         if (Model.Any())
        {


            foreach (var user in Model)
            {

#line default
#line hidden
            BeginContext(586, 183, true);
            WriteLiteral("                <div style=\"margin-bottom:3%\">\r\n                    <div class=\"card\">\r\n                        <div class=\"card-header\">\r\n                            ID użytkownika: ");
            EndContext();
            BeginContext(770, 7, false);
#line 25 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\Administration\ListUsers.cshtml"
                                       Write(user.Id);

#line default
#line hidden
            EndContext();
            BeginContext(777, 134, true);
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"card-body\">\r\n                            <h5 class=\"card-title\">");
            EndContext();
            BeginContext(912, 13, false);
#line 28 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\Administration\ListUsers.cshtml"
                                              Write(user.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(925, 144, true);
            WriteLiteral("</h5>\r\n                        </div>\r\n                        <div class=\"card-footer\">\r\n                            <a class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 1069, "\'", 1150, 1);
#line 31 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\Administration\ListUsers.cshtml"
WriteAttributeValue("", 1076, Url.Action("OtherUserProfile", "UserProfile", new { id = user.UserName }), 1076, 74, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1151, 191, true);
            WriteLiteral(" >Zobacz profil</a>\r\n                            <a class=\"btn btn-danger\" href=\"#\" >Usuń użytkownika</a>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 36 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\Administration\ListUsers.cshtml"
            }
        }
        else
        {

#line default
#line hidden
            BeginContext(1393, 390, true);
            WriteLiteral(@"            <div style=""margin-bottom:3%"">
                <div class=""card"">
                    <div class=""card-header"">
                        Nie ma jeszcze żadnych użytkowników
                    </div>
                    <div class=""card-body"">
                        <h5>Użyj przycisku powyżej</h5>
                    </div>
                </div>
            </div>
");
            EndContext();
#line 50 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\Administration\ListUsers.cshtml"
        }

#line default
#line hidden
            BeginContext(1794, 20, true);
            WriteLiteral("    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Inzynierka.Models.ApplicationUsers.ApplicationUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
