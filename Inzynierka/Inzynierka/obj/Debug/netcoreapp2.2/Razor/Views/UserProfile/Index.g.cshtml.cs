#pragma checksum "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\UserProfile\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f492852529c9f1241a72b5910a48f5f224d8587f"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f492852529c9f1241a72b5910a48f5f224d8587f", @"/Views/UserProfile/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e51e35947ca9dd757bdad0a0b1ee4d7c528178d9", @"/Views/_ViewImports.cshtml")]
    public class Views_UserProfile_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Inzynierka.ViewModels.UserProfileViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/TravelCompanionStyle.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "UserProfile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditUserProfile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("h4 btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(53, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f492852529c9f1241a72b5910a48f5f224d8587f4737", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(99, 84, true);
            WriteLiteral("\r\n<div class=\"row\" style=\"margin:auto\">\r\n    \r\n        <h2 style=\"margin-bottom:1%\">");
            EndContext();
            BeginContext(184, 15, false);
#line 6 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\UserProfile\Index.cshtml"
                                Write(Model.PageTitle);

#line default
#line hidden
            EndContext();
            BeginContext(199, 51, true);
            WriteLiteral("</h2>\r\n        <div class=\"col-md-1\">\r\n            ");
            EndContext();
            BeginContext(250, 143, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f492852529c9f1241a72b5910a48f5f224d8587f6404", async() => {
                BeginContext(376, 13, true);
                WriteLiteral("Edytuj profil");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 8 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\UserProfile\Index.cshtml"
                                                                           WriteLiteral(Model.UserProfiles.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(393, 276, true);
            WriteLiteral(@"
        </div>
        
</div>

<div  style=""margin:auto"">
    <div class=""col-md-6 card card-body backgroundGrayColor"" >
        <div style=""padding:10px"">
            <h4 class=""d-inline"">Imię i nazwisko: </h4>
            <h4 class="" d-inline font-weight-normal"">");
            EndContext();
            BeginContext(670, 28, false);
#line 17 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\UserProfile\Index.cshtml"
                                                Write(Model.UserProfiles.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(698, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(700, 27, false);
#line 17 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\UserProfile\Index.cshtml"
                                                                              Write(Model.UserProfiles.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(727, 157, true);
            WriteLiteral("</h4>\r\n        </div>\r\n        <div style=\"padding:10px\">\r\n            <h4 class=\"d-inline\">Wiek: </h4>\r\n            <h4 class=\"d-inline font-weight-normal\">");
            EndContext();
            BeginContext(885, 22, false);
#line 21 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\UserProfile\Index.cshtml"
                                               Write(Model.UserProfiles.Age);

#line default
#line hidden
            EndContext();
            BeginContext(907, 157, true);
            WriteLiteral("</h4>\r\n        </div>\r\n        <div style=\"padding:10px\">\r\n            <h4 class=\"d-inline\">Płeć: </h4>\r\n            <h4 class=\"d-inline font-weight-normal\">");
            EndContext();
            BeginContext(1065, 25, false);
#line 25 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\UserProfile\Index.cshtml"
                                               Write(Model.UserProfiles.Gender);

#line default
#line hidden
            EndContext();
            BeginContext(1090, 159, true);
            WriteLiteral("</h4>\r\n        </div>\r\n        <div style=\"padding:10px\">\r\n            <h4 class=\"d-inline\">O mnie: </h4>\r\n            <h5 class=\"d-inline font-weight-normal\">");
            EndContext();
            BeginContext(1250, 24, false);
#line 29 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\UserProfile\Index.cshtml"
                                               Write(Model.UserProfiles.About);

#line default
#line hidden
            EndContext();
            BeginContext(1274, 100, true);
            WriteLiteral("</h5>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n\r\n<h4 style=\"padding-top:20px\">Moje ogłoszenia</h4>\r\n\r\n");
            EndContext();
#line 37 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\UserProfile\Index.cshtml"
     foreach (var tripAdvert in Model.TripAdverts)
    {

#line default
#line hidden
            BeginContext(1431, 198, true);
            WriteLiteral("<div style=\"margin-bottom:3%\" class=\"row col-md-8\">\r\n            <div class=\"card card-body backgroundGrayColor \">\r\n                <div>\r\n                    <h4 class=\"d-inline font-weight-bold \">");
            EndContext();
            BeginContext(1630, 16, false);
#line 41 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\UserProfile\Index.cshtml"
                                                      Write(tripAdvert.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1646, 77, true);
            WriteLiteral("</h4>\r\n                    <p class=\"d-inline float-right font-weight-light\">");
            EndContext();
            BeginContext(1724, 21, false);
#line 42 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\UserProfile\Index.cshtml"
                                                                 Write(tripAdvert.AdvertDate);

#line default
#line hidden
            EndContext();
            BeginContext(1745, 123, true);
            WriteLiteral("</p>\r\n\r\n                </div>\r\n                <div>\r\n                    <h5 class=\" d-inline font-weight-normal\"> Kraj: ");
            EndContext();
            BeginContext(1869, 18, false);
#line 46 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\UserProfile\Index.cshtml"
                                                               Write(tripAdvert.Country);

#line default
#line hidden
            EndContext();
            BeginContext(1887, 7, true);
            WriteLiteral("</h5>\r\n");
            EndContext();
            BeginContext(2057, 10, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
            EndContext();
#line 53 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\UserProfile\Index.cshtml"
                     if (!String.IsNullOrEmpty(tripAdvert.UserEmail))
                    {
                        

#line default
#line hidden
            BeginContext(2186, 157, false);
#line 55 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\UserProfile\Index.cshtml"
                   Write(Html.ActionLink(tripAdvert.UserEmail, "Index", "UserProfile", new { id = tripAdvert.UserEmail }, new { @class = "if-inline float-right font-weight-normal" }));

#line default
#line hidden
            EndContext();
#line 55 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\UserProfile\Index.cshtml"
                                                                                                                                                                                      
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(2417, 53, true);
            WriteLiteral("                        <p>tripAdvert.UserEmail</p>\r\n");
            EndContext();
#line 60 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\UserProfile\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(2493, 73, true);
            WriteLiteral("\r\n                </div>\r\n                <p class=\" font-weight-normal\">");
            EndContext();
            BeginContext(2567, 18, false);
#line 63 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\UserProfile\Index.cshtml"
                                          Write(tripAdvert.Content);

#line default
#line hidden
            EndContext();
            BeginContext(2585, 46, true);
            WriteLiteral("</p>\r\n\r\n\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 68 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\UserProfile\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(2638, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Inzynierka.ViewModels.UserProfileViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
