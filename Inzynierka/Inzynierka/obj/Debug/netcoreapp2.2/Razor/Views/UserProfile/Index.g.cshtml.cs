#pragma checksum "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\UserProfile\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d72af151fd542d90d49a0739af0a66f677faf06b"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d72af151fd542d90d49a0739af0a66f677faf06b", @"/Views/UserProfile/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e51e35947ca9dd757bdad0a0b1ee4d7c528178d9", @"/Views/_ViewImports.cshtml")]
    public class Views_UserProfile_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Inzynierka.ViewModels.UserProfileViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/TravelCompanionStyle.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "UserProfile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditUserProfile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("h4 btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteTripAdvertUserProfile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddTripAdvert", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "TripAdvert", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(53, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d72af151fd542d90d49a0739af0a66f677faf06b6608", async() => {
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
            BeginContext(99, 76, true);
            WriteLiteral("\r\n<div class=\"row\" style=\"margin:auto\">\r\n\r\n    <h2 style=\"margin-bottom:1%\">");
            EndContext();
            BeginContext(176, 15, false);
#line 6 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\UserProfile\Index.cshtml"
                            Write(Model.PageTitle);

#line default
#line hidden
            EndContext();
            BeginContext(191, 43, true);
            WriteLiteral("</h2>\r\n    <div class=\"col-md-1\">\r\n        ");
            EndContext();
            BeginContext(234, 143, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d72af151fd542d90d49a0739af0a66f677faf06b8255", async() => {
                BeginContext(360, 13, true);
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
            BeginContext(377, 304, true);
            WriteLiteral(@"
    </div>

</div>


    <div style=""margin:auto; margin-bottom:1%"">

        <div class=""col-md-6 card card-body backgroundGrayColor"">
            <div style=""padding:10px"">
                <h4 class=""d-inline"">Imię i nazwisko: </h4>
                <h4 class="" d-inline font-weight-normal"">");
            EndContext();
            BeginContext(682, 28, false);
#line 19 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\UserProfile\Index.cshtml"
                                                    Write(Model.UserProfiles.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(710, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(712, 27, false);
#line 19 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\UserProfile\Index.cshtml"
                                                                                  Write(Model.UserProfiles.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(739, 173, true);
            WriteLiteral("</h4>\r\n            </div>\r\n            <div style=\"padding:10px\">\r\n                <h4 class=\"d-inline\">Wiek: </h4>\r\n                <h4 class=\"d-inline font-weight-normal\">");
            EndContext();
            BeginContext(913, 22, false);
#line 23 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\UserProfile\Index.cshtml"
                                                   Write(Model.UserProfiles.Age);

#line default
#line hidden
            EndContext();
            BeginContext(935, 173, true);
            WriteLiteral("</h4>\r\n            </div>\r\n            <div style=\"padding:10px\">\r\n                <h4 class=\"d-inline\">Płeć: </h4>\r\n                <h4 class=\"d-inline font-weight-normal\">");
            EndContext();
            BeginContext(1109, 25, false);
#line 27 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\UserProfile\Index.cshtml"
                                                   Write(Model.UserProfiles.Gender);

#line default
#line hidden
            EndContext();
            BeginContext(1134, 27, true);
            WriteLiteral("</h4>\r\n            </div>\r\n");
            EndContext();
#line 29 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\UserProfile\Index.cshtml"
             if (Model.UserProfiles.About != null)
            {

#line default
#line hidden
            BeginContext(1228, 160, true);
            WriteLiteral("                <div style=\"padding:10px\">\r\n                    <h4 class=\"d-inline\">O mnie: </h4>\r\n                    <h5 class=\"d-inline font-weight-normal\">");
            EndContext();
            BeginContext(1389, 24, false);
#line 33 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\UserProfile\Index.cshtml"
                                                       Write(Model.UserProfiles.About);

#line default
#line hidden
            EndContext();
            BeginContext(1413, 31, true);
            WriteLiteral("</h5>\r\n                </div>\r\n");
            EndContext();
#line 35 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\UserProfile\Index.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(1492, 242, true);
            WriteLiteral("                <div style=\"padding:10px\">\r\n                    <h4 class=\"d-inline\">O mnie: </h4>\r\n                    <h5 class=\"d-inline font-weight-normal\">Nie uzupełniono, możesz uzupełnić w edycji profilu.</h5>\r\n                </div>\r\n");
            EndContext();
#line 42 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\UserProfile\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1749, 162, true);
            WriteLiteral("        </div>\r\n    </div>\r\n     <p class=\"d-inline\"><h6 class=\"d-inline\">Informacja:</h6> Wiadomości od innych użytkowników będą przesyłane na Twój adres e-mail ");
            EndContext();
            BeginContext(1912, 24, false);
#line 45 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\UserProfile\Index.cshtml"
                                                                                                                                 Write(Model.UserProfiles.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1936, 89, true);
            WriteLiteral(".</p>\r\n\r\n   \r\n\r\n\r\n<h4 style=\"padding-top:20px; margin-bottom:2%\">Moje ogłoszenia</h4>\r\n\r\n");
            EndContext();
#line 52 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\UserProfile\Index.cshtml"
 if (Model.TripAdverts.Any())
{
    

#line default
#line hidden
#line 54 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\UserProfile\Index.cshtml"
     foreach (var tripAdvert in Model.TripAdverts)
    {

#line default
#line hidden
            BeginContext(2116, 305, true);
            WriteLiteral(@"<div class=""row"">
            <div style=""margin-bottom:3%"" class=""col-md-8"">
                <div class=""card"">
                    <div class=""card-body backgroundGrayColor "">
                        <div style=""margin-bottom:2%"">
                            <h4 class=""d-inline font-weight-bold "">");
            EndContext();
            BeginContext(2422, 16, false);
#line 60 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\UserProfile\Index.cshtml"
                                                              Write(tripAdvert.Title);

#line default
#line hidden
            EndContext();
            BeginContext(2438, 85, true);
            WriteLiteral("</h4>\r\n                            <p class=\"d-inline float-right font-weight-light\">");
            EndContext();
            BeginContext(2524, 21, false);
#line 61 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\UserProfile\Index.cshtml"
                                                                         Write(tripAdvert.AdvertDate);

#line default
#line hidden
            EndContext();
            BeginContext(2545, 173, true);
            WriteLiteral("</p>\r\n\r\n                        </div>\r\n                        <div style=\"margin-bottom:1%\">\r\n                            <h5 class=\" d-inline font-weight-normal\" > Kraj: ");
            EndContext();
            BeginContext(2719, 18, false);
#line 65 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\UserProfile\Index.cshtml"
                                                                        Write(tripAdvert.Country);

#line default
#line hidden
            EndContext();
            BeginContext(2737, 9, true);
            WriteLiteral("</h5>\r\n\r\n");
            EndContext();
#line 67 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\UserProfile\Index.cshtml"
                             if (!String.IsNullOrEmpty(tripAdvert.UserEmail))
                            {
                                

#line default
#line hidden
            BeginContext(2889, 157, false);
#line 69 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\UserProfile\Index.cshtml"
                           Write(Html.ActionLink(tripAdvert.UserEmail, "Index", "UserProfile", new { id = tripAdvert.UserEmail }, new { @class = "if-inline float-right font-weight-normal" }));

#line default
#line hidden
            EndContext();
#line 69 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\UserProfile\Index.cshtml"
                                                                                                                                                                                              
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(3144, 61, true);
            WriteLiteral("                                <p>tripAdvert.UserEmail</p>\r\n");
            EndContext();
#line 74 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\UserProfile\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(3236, 89, true);
            WriteLiteral("\r\n                        </div>\r\n                        <p class=\" font-weight-normal\">");
            EndContext();
            BeginContext(3326, 18, false);
#line 77 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\UserProfile\Index.cshtml"
                                                  Write(tripAdvert.Content);

#line default
#line hidden
            EndContext();
            BeginContext(3344, 107, true);
            WriteLiteral("</p>\r\n                    </div>\r\n\r\n                    <div class=\"card-footer\">\r\n                        ");
            EndContext();
            BeginContext(3451, 919, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d72af151fd542d90d49a0739af0a66f677faf06b19862", async() => {
                BeginContext(3552, 36, true);
                WriteLiteral("\r\n                             <span");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 3588, "\"", 3635, 2);
                WriteAttributeValue("", 3593, "confirmDeleteSpan_", 3593, 18, true);
#line 82 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\UserProfile\Index.cshtml"
WriteAttributeValue("", 3611, tripAdvert.TripAdvertID, 3611, 24, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3636, 253, true);
                WriteLiteral(" style=\"display:none\">\r\n                                 <span>Czy na pewno chcesz usunąć?</span>\r\n                                 <button type=\"submit\" class=\"btn btn-danger\">Tak</button>\r\n                                 <span class=\"btn btn-primary\"");
                EndContext();
                BeginWriteAttribute("onclick", "\r\n                                       onclick=\"", 3889, "\"", 3987, 4);
                WriteAttributeValue("", 3939, "confirmDelete(\'", 3939, 15, true);
#line 86 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\UserProfile\Index.cshtml"
WriteAttributeValue("", 3954, tripAdvert.TripAdvertID, 3954, 24, false);

#line default
#line hidden
                WriteAttributeValue("", 3978, "\',", 3978, 2, true);
                WriteAttributeValue(" ", 3980, "false)", 3981, 7, true);
                EndWriteAttribute();
                BeginContext(3988, 85, true);
                WriteLiteral(">Nie</span>\r\n                             </span>\r\n                             <span");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 4073, "\"", 4113, 2);
                WriteAttributeValue("", 4078, "deleteSpan_", 4078, 11, true);
#line 88 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\UserProfile\Index.cshtml"
WriteAttributeValue("", 4089, tripAdvert.TripAdvertID, 4089, 24, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4114, 64, true);
                WriteLiteral(">\r\n                                 <span class=\"btn btn-danger\"");
                EndContext();
                BeginWriteAttribute("onclick", "\r\n                                       onclick=\"", 4178, "\"", 4275, 4);
                WriteAttributeValue("", 4228, "confirmDelete(\'", 4228, 15, true);
#line 90 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\UserProfile\Index.cshtml"
WriteAttributeValue("", 4243, tripAdvert.TripAdvertID, 4243, 24, false);

#line default
#line hidden
                WriteAttributeValue("", 4267, "\',", 4267, 2, true);
                WriteAttributeValue(" ", 4269, "true)", 4270, 6, true);
                EndWriteAttribute();
                BeginContext(4276, 87, true);
                WriteLiteral(">Usuń ogłoszenie</span>\r\n                             </span>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 81 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\UserProfile\Index.cshtml"
                                                                         WriteLiteral(tripAdvert.TripAdvertID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4370, 98, true);
            WriteLiteral("\r\n\r\n                    </div>\r\n\r\n\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 101 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\UserProfile\Index.cshtml"
    }

#line default
#line hidden
#line 101 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\UserProfile\Index.cshtml"
     
}
else
{

#line default
#line hidden
            BeginContext(4487, 444, true);
            WriteLiteral(@"    <div class=""row"">
        <div style=""margin-bottom:3%"" class=""col-md-8"">
            <div class=""card"">
                <div class=""card-header"">
                    Nie ma jeszcze żadnych ogłoszeń
                </div>
                <div class=""card-body"">
                    <h5>Użyj przycisku poniżej aby dodać pierwsze ogłoszenie.</h5>
                </div>
                <div class=""card-footer"">
                    ");
            EndContext();
            BeginContext(4931, 102, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d72af151fd542d90d49a0739af0a66f677faf06b26618", async() => {
                BeginContext(5013, 16, true);
                WriteLiteral("Dodaj ogłoszenie");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5033, 74, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 120 "D:\GitHubDyskD\Inzynierka\Inzynierka\Inzynierka\Views\UserProfile\Index.cshtml"
}

#line default
#line hidden
            BeginContext(5110, 2, true);
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
