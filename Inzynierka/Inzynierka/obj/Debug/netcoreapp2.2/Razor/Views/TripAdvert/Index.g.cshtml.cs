#pragma checksum "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\TripAdvert\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8bb63d989e8477d2ec7a4a05aa70c9eb4f923d62"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TripAdvert_Index), @"mvc.1.0.view", @"/Views/TripAdvert/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/TripAdvert/Index.cshtml", typeof(AspNetCore.Views_TripAdvert_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8bb63d989e8477d2ec7a4a05aa70c9eb4f923d62", @"/Views/TripAdvert/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e51e35947ca9dd757bdad0a0b1ee4d7c528178d9", @"/Views/_ViewImports.cshtml")]
    public class Views_TripAdvert_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Inzynierka.ViewModels.TripAdvertsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/TravelCompanionStyle.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(53, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8bb63d989e8477d2ec7a4a05aa70c9eb4f923d623620", async() => {
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
            BeginContext(99, 78, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n<div class=\"col-md-8\">\r\n    <h2 style=\"margin-bottom:2%\">");
            EndContext();
            BeginContext(178, 15, false);
#line 6 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\TripAdvert\Index.cshtml"
                            Write(Model.PageTitle);

#line default
#line hidden
            EndContext();
            BeginContext(193, 7, true);
            WriteLiteral("</h2>\r\n");
            EndContext();
#line 7 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\TripAdvert\Index.cshtml"
     foreach (var tripAdvert in Model.TripAdverts)
    {

#line default
#line hidden
            BeginContext(257, 202, true);
            WriteLiteral("<div style=\"margin-bottom:4%\">\r\n            <div class=\"card card-body backgroundGrayColor \">\r\n                <div style=\"margin-bottom:1%\">\r\n                    <h4 class=\"d-inline font-weight-bold \">");
            EndContext();
            BeginContext(460, 16, false);
#line 11 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\TripAdvert\Index.cshtml"
                                                      Write(tripAdvert.Title);

#line default
#line hidden
            EndContext();
            BeginContext(476, 77, true);
            WriteLiteral("</h4>\r\n                    <p class=\"d-inline float-right font-weight-light\">");
            EndContext();
            BeginContext(554, 21, false);
#line 12 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\TripAdvert\Index.cshtml"
                                                                 Write(tripAdvert.AdvertDate);

#line default
#line hidden
            EndContext();
            BeginContext(575, 146, true);
            WriteLiteral("</p>\r\n                </div>\r\n                <div style=\"margin-bottom:1%\">\r\n                    <h5 class=\" d-inline font-weight-normal\"> Kraj: ");
            EndContext();
            BeginContext(722, 18, false);
#line 15 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\TripAdvert\Index.cshtml"
                                                               Write(tripAdvert.Country);

#line default
#line hidden
            EndContext();
            BeginContext(740, 24, true);
            WriteLiteral("</h5>                 \r\n");
            EndContext();
#line 16 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\TripAdvert\Index.cshtml"
                     if (!String.IsNullOrEmpty(tripAdvert.UserEmail))
                    {
                        

#line default
#line hidden
            BeginContext(883, 217, false);
#line 18 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\TripAdvert\Index.cshtml"
                   Write(Html.ActionLink(tripAdvert.UserEmail, "OtherUserProfile", "UserProfile", 
                       new { id = tripAdvert.UserEmail },
                       new { @class = "if-inline float-right font-weight-normal" }));

#line default
#line hidden
            EndContext();
#line 20 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\TripAdvert\Index.cshtml"
                                                                                   
                    }                  

#line default
#line hidden
            BeginContext(1143, 71, true);
            WriteLiteral("                </div>\r\n                <p class=\" font-weight-normal\">");
            EndContext();
            BeginContext(1215, 18, false);
#line 23 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\TripAdvert\Index.cshtml"
                                          Write(tripAdvert.Content);

#line default
#line hidden
            EndContext();
            BeginContext(1233, 42, true);
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 26 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\TripAdvert\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1282, 287, true);
            WriteLiteral(@"</div>
<div class=""col-md-4"">
    <a class=""twitter-timeline"" data-height=""800"" href=""https://twitter.com/Travel34851312/lists/podr-uj"">Tweety związane z podróżami.</a>
    <script async src=""https://platform.twitter.com/widgets.js"" charset=""utf-8""></script>
</div>
</div>




");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Inzynierka.ViewModels.TripAdvertsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
