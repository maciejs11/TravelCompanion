#pragma checksum "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\UserProfile\OtherUserProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e5dc296a8b989e9994446e85dcbc8539496bf0c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserProfile_OtherUserProfile), @"mvc.1.0.view", @"/Views/UserProfile/OtherUserProfile.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/UserProfile/OtherUserProfile.cshtml", typeof(AspNetCore.Views_UserProfile_OtherUserProfile))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5dc296a8b989e9994446e85dcbc8539496bf0c0", @"/Views/UserProfile/OtherUserProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e51e35947ca9dd757bdad0a0b1ee4d7c528178d9", @"/Views/_ViewImports.cshtml")]
    public class Views_UserProfile_OtherUserProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Inzynierka.ViewModels.UserProfileViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/TravelCompanionStyle.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Chat", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ChatIndex", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e5dc296a8b989e9994446e85dcbc8539496bf0c04801", async() => {
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
            BeginContext(99, 54, true);
            WriteLiteral("\r\n<div class=\"row\" style=\"margin-left:auto\">\r\n    <h2>");
            EndContext();
            BeginContext(154, 15, false);
#line 5 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\UserProfile\OtherUserProfile.cshtml"
   Write(Model.PageTitle);

#line default
#line hidden
            EndContext();
            BeginContext(169, 17, true);
            WriteLiteral("</h2>\r\n</div>\r\n\r\n");
            EndContext();
            BeginContext(375, 253, true);
            WriteLiteral("<div class=\"row\" style=\"margin-left:auto\">\r\n    <div class=\"col-md-6 card card-body backgroundGrayColor\">\r\n        <div style=\"padding:10px\">\r\n            <h4 class=\"d-inline\">Imię i nazwisko: </h4>\r\n            <h4 class=\" d-inline font-weight-normal\">");
            EndContext();
            BeginContext(629, 28, false);
#line 20 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\UserProfile\OtherUserProfile.cshtml"
                                                Write(Model.UserProfiles.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(657, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(659, 27, false);
#line 20 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\UserProfile\OtherUserProfile.cshtml"
                                                                              Write(Model.UserProfiles.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(686, 157, true);
            WriteLiteral("</h4>\r\n        </div>\r\n        <div style=\"padding:10px\">\r\n            <h4 class=\"d-inline\">Wiek: </h4>\r\n            <h4 class=\"d-inline font-weight-normal\">");
            EndContext();
            BeginContext(844, 22, false);
#line 24 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\UserProfile\OtherUserProfile.cshtml"
                                               Write(Model.UserProfiles.Age);

#line default
#line hidden
            EndContext();
            BeginContext(866, 157, true);
            WriteLiteral("</h4>\r\n        </div>\r\n        <div style=\"padding:10px\">\r\n            <h4 class=\"d-inline\">Płeć: </h4>\r\n            <h4 class=\"d-inline font-weight-normal\">");
            EndContext();
            BeginContext(1024, 25, false);
#line 28 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\UserProfile\OtherUserProfile.cshtml"
                                               Write(Model.UserProfiles.Gender);

#line default
#line hidden
            EndContext();
            BeginContext(1049, 159, true);
            WriteLiteral("</h4>\r\n        </div>\r\n        <div style=\"padding:10px\">\r\n            <h4 class=\"d-inline\">O mnie: </h4>\r\n            <h5 class=\"d-inline font-weight-normal\">");
            EndContext();
            BeginContext(1209, 24, false);
#line 32 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\UserProfile\OtherUserProfile.cshtml"
                                               Write(Model.UserProfiles.About);

#line default
#line hidden
            EndContext();
            BeginContext(1233, 65, true);
            WriteLiteral("</h5>\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"col-md-4\">\r\n");
            EndContext();
            BeginContext(1360, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(1368, 95, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e5dc296a8b989e9994446e85dcbc8539496bf0c09421", async() => {
                BeginContext(1443, 16, true);
                WriteLiteral("Napisz wiadomość");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1463, 102, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<h4 style=\"padding-top:20px; margin-bottom:2%\">Ogłoszenia użytkownika</h4>\r\n\r\n");
            EndContext();
#line 44 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\UserProfile\OtherUserProfile.cshtml"
 if (Model.TripAdverts.Any())
{
    

#line default
#line hidden
#line 46 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\UserProfile\OtherUserProfile.cshtml"
     foreach (var tripAdvert in Model.TripAdverts)
    {

#line default
#line hidden
            BeginContext(1658, 206, true);
            WriteLiteral("        <div style=\"margin-bottom:3%\" class=\"row col-md-8\">\r\n            <div class=\"card card-body backgroundGrayColor \">\r\n                <div>\r\n                    <h4 class=\"d-inline font-weight-bold \">");
            EndContext();
            BeginContext(1865, 16, false);
#line 51 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\UserProfile\OtherUserProfile.cshtml"
                                                      Write(tripAdvert.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1881, 77, true);
            WriteLiteral("</h4>\r\n                    <p class=\"d-inline float-right font-weight-light\">");
            EndContext();
            BeginContext(1959, 21, false);
#line 52 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\UserProfile\OtherUserProfile.cshtml"
                                                                 Write(tripAdvert.AdvertDate);

#line default
#line hidden
            EndContext();
            BeginContext(1980, 123, true);
            WriteLiteral("</p>\r\n\r\n                </div>\r\n                <div>\r\n                    <h5 class=\" d-inline font-weight-normal\"> Kraj: ");
            EndContext();
            BeginContext(2104, 18, false);
#line 56 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\UserProfile\OtherUserProfile.cshtml"
                                                               Write(tripAdvert.Country);

#line default
#line hidden
            EndContext();
            BeginContext(2122, 7, true);
            WriteLiteral("</h5>\r\n");
            EndContext();
            BeginContext(2292, 10, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
            EndContext();
#line 63 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\UserProfile\OtherUserProfile.cshtml"
                     if (!String.IsNullOrEmpty(tripAdvert.UserEmail))
                    {
                        

#line default
#line hidden
            BeginContext(2421, 168, false);
#line 65 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\UserProfile\OtherUserProfile.cshtml"
                   Write(Html.ActionLink(tripAdvert.UserEmail, "OtherUserProfile", "UserProfile", new { id = tripAdvert.UserEmail }, new { @class = "if-inline float-right font-weight-normal" }));

#line default
#line hidden
            EndContext();
#line 65 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\UserProfile\OtherUserProfile.cshtml"
                                                                                                                                                                                                 
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(2663, 53, true);
            WriteLiteral("                        <p>tripAdvert.UserEmail</p>\r\n");
            EndContext();
#line 70 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\UserProfile\OtherUserProfile.cshtml"
                    }

#line default
#line hidden
            BeginContext(2739, 73, true);
            WriteLiteral("\r\n                </div>\r\n                <p class=\" font-weight-normal\">");
            EndContext();
            BeginContext(2813, 18, false);
#line 73 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\UserProfile\OtherUserProfile.cshtml"
                                          Write(tripAdvert.Content);

#line default
#line hidden
            EndContext();
            BeginContext(2831, 46, true);
            WriteLiteral("</p>\r\n\r\n\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 78 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\UserProfile\OtherUserProfile.cshtml"
    }

#line default
#line hidden
#line 78 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\UserProfile\OtherUserProfile.cshtml"
     

}
else
{

#line default
#line hidden
            BeginContext(2898, 422, true);
            WriteLiteral(@"    <div class=""row"">
        <div style=""margin-bottom:3%"" class=""col-md-8"">
            <div class=""card"">
                <div class=""card-header"">
                    Brak ogłoszeń
                </div>
                <div class=""card-body"">
                    <h5>Użytkownik nie dodał jeszcze żadnych ogłoszeń.</h5>
                </div>
                
            </div>
        </div>
    </div>
");
            EndContext();
#line 96 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\UserProfile\OtherUserProfile.cshtml"
}

#line default
#line hidden
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
