#pragma checksum "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\TripAdvert\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a7743719cede77d8bfd5486a989e46fabee34fb"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a7743719cede77d8bfd5486a989e46fabee34fb", @"/Views/TripAdvert/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e51e35947ca9dd757bdad0a0b1ee4d7c528178d9", @"/Views/_ViewImports.cshtml")]
    public class Views_TripAdvert_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Inzynierka.Models.TripAdverts.TripAdvert>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(62, 51, true);
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-8\">\r\n");
            EndContext();
#line 6 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\TripAdvert\Index.cshtml"
         foreach (var tripAdvert in Model)
        {

#line default
#line hidden
            BeginContext(166, 178, true);
            WriteLiteral("<div style=\"margin-bottom:5%\">\r\n                <div class=\"card card-body bg-light \">\r\n                    <div>\r\n                        <h4 class=\"d-inline font-weight-bold \">");
            EndContext();
            BeginContext(345, 16, false);
#line 10 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\TripAdvert\Index.cshtml"
                                                          Write(tripAdvert.Title);

#line default
#line hidden
            EndContext();
            BeginContext(361, 81, true);
            WriteLiteral("</h4>\r\n                        <p class=\"d-inline float-right font-weight-light\">");
            EndContext();
            BeginContext(443, 21, false);
#line 11 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\TripAdvert\Index.cshtml"
                                                                     Write(tripAdvert.AdvertDate);

#line default
#line hidden
            EndContext();
            BeginContext(464, 94, true);
            WriteLiteral("</p>\r\n\r\n                    </div>\r\n                    <h5 class=\"font-weight-normal\"> Kraj: ");
            EndContext();
            BeginContext(559, 18, false);
#line 14 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\TripAdvert\Index.cshtml"
                                                     Write(tripAdvert.Country);

#line default
#line hidden
            EndContext();
            BeginContext(577, 60, true);
            WriteLiteral("</h5>\r\n\r\n                    <p class=\" font-weight-normal\">");
            EndContext();
            BeginContext(638, 18, false);
#line 16 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\TripAdvert\Index.cshtml"
                                              Write(tripAdvert.Content);

#line default
#line hidden
            EndContext();
            BeginContext(656, 56, true);
            WriteLiteral("</p>\r\n                    <p class=\"font-weight-normal\">");
            EndContext();
            BeginContext(713, 17, false);
#line 17 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\TripAdvert\Index.cshtml"
                                             Write(tripAdvert.UserId);

#line default
#line hidden
            EndContext();
            BeginContext(730, 50, true);
            WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 20 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\TripAdvert\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(791, 300, true);
            WriteLiteral(@"    </div>
    <div class=""col-md-4"">
        <a class=""twitter-timeline"" data-height=""800"" href=""https://twitter.com/maccit5/lists/podr-uj"">Tweety związane z podróżami.</a>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Inzynierka.Models.TripAdverts.TripAdvert>> Html { get; private set; }
    }
}
#pragma warning restore 1591
