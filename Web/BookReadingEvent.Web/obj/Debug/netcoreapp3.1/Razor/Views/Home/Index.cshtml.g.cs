#pragma checksum "C:\Users\sachinsaharan\Downloads\Design Pattern\Design Pattern\Web\BookReadingEvent.Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90b00198aa62d98d95fd6d4de73ffcc0da717eb8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\sachinsaharan\Downloads\Design Pattern\Design Pattern\Web\BookReadingEvent.Web\Views\_ViewImports.cshtml"
using BookReadingEvent.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sachinsaharan\Downloads\Design Pattern\Design Pattern\Web\BookReadingEvent.Web\Views\_ViewImports.cshtml"
using BookReadingEvent.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90b00198aa62d98d95fd6d4de73ffcc0da717eb8", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0133f9920160cf33e87e1cf2f1ee78f6f4792d4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Event>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "GetEvent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-layout", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
#nullable restore
#line 2 "C:\Users\sachinsaharan\Downloads\Design Pattern\Design Pattern\Web\BookReadingEvent.Web\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-6\" >\r\n            <h3 style=\"text-align:center;\"><b>UpComing Events</b> </h3>\r\n");
#nullable restore
#line 9 "C:\Users\sachinsaharan\Downloads\Design Pattern\Design Pattern\Web\BookReadingEvent.Web\Views\Home\Index.cshtml"
             foreach (var e in ViewBag.UpcomingEvents)
             {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90b00198aa62d98d95fd6d4de73ffcc0da717eb84814", async() => {
                WriteLiteral(@"
                <div class=""card shadow-lg"" style=""width: 46%; margin-bottom: 6px; float: left; margin-right: 6px; margin-left: 6px; background-color: bisque; border-radius: 10px"">
                    <div class=""card-body"">
                        <h4 class=""card-title"">");
#nullable restore
#line 14 "C:\Users\sachinsaharan\Downloads\Design Pattern\Design Pattern\Web\BookReadingEvent.Web\Views\Home\Index.cshtml"
                                          Write(e.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n                        <h6 class=\"card-subtitle mb-2 text-muted\"><b>Description :</b>");
#nullable restore
#line 15 "C:\Users\sachinsaharan\Downloads\Design Pattern\Design Pattern\Web\BookReadingEvent.Web\Views\Home\Index.cshtml"
                                                                                 Write(e.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </h6>\r\n                        <h6 class=\"card-subtitle mb-2 text-muted\"><b>Date :</b>");
#nullable restore
#line 16 "C:\Users\sachinsaharan\Downloads\Design Pattern\Design Pattern\Web\BookReadingEvent.Web\Views\Home\Index.cshtml"
                                                                          Write(e.Date.ToShortDateString());

#line default
#line hidden
#nullable disable
                WriteLiteral(" </h6>\r\n                        <h6 class=\"card-subtitle mb-2 text-muted\"><b>Duration :</b>");
#nullable restore
#line 17 "C:\Users\sachinsaharan\Downloads\Design Pattern\Design Pattern\Web\BookReadingEvent.Web\Views\Home\Index.cshtml"
                                                                              Write(e.Duration);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n                        <h6 class=\"card-subtitle mb-2 text-muted\"><b>Location :</b>");
#nullable restore
#line 18 "C:\Users\sachinsaharan\Downloads\Design Pattern\Design Pattern\Web\BookReadingEvent.Web\Views\Home\Index.cshtml"
                                                                              Write(e.Location);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n                        <h6 class=\"card-subtitle mb-2 text-muted\"><b>StartTime :</b>");
#nullable restore
#line 19 "C:\Users\sachinsaharan\Downloads\Design Pattern\Design Pattern\Web\BookReadingEvent.Web\Views\Home\Index.cshtml"
                                                                               Write(e.StartTime);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n                    </div>\r\n                </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 11 "C:\Users\sachinsaharan\Downloads\Design Pattern\Design Pattern\Web\BookReadingEvent.Web\Views\Home\Index.cshtml"
                                                                  WriteLiteral(e.EventId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-layout", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["layout"] = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 23 "C:\Users\sachinsaharan\Downloads\Design Pattern\Design Pattern\Web\BookReadingEvent.Web\Views\Home\Index.cshtml"
             }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div class=\"col-6\">\r\n            <h3 style=\"text-align:center;\"><b>Past Events </b></h3>\r\n");
#nullable restore
#line 27 "C:\Users\sachinsaharan\Downloads\Design Pattern\Design Pattern\Web\BookReadingEvent.Web\Views\Home\Index.cshtml"
             foreach (var e in ViewBag.PastEvents)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90b00198aa62d98d95fd6d4de73ffcc0da717eb811188", async() => {
                WriteLiteral(@"
                <div class=""card shadow-lg""  style=""width: 46%; margin-bottom: 6px; float: left; margin-right: 6px;margin-left:6px; background-color: bisque; border-radius:10px"">
                    <div class=""card-body"">
                        <h4 class=""card-title"">");
#nullable restore
#line 32 "C:\Users\sachinsaharan\Downloads\Design Pattern\Design Pattern\Web\BookReadingEvent.Web\Views\Home\Index.cshtml"
                                          Write(e.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n                        <h6 class=\"card-subtitle mb-2 text-muted\"><b>Description :</b>");
#nullable restore
#line 33 "C:\Users\sachinsaharan\Downloads\Design Pattern\Design Pattern\Web\BookReadingEvent.Web\Views\Home\Index.cshtml"
                                                                                 Write(e.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n                        <h6 class=\"card-subtitle mb-2 text-muted\"><b>Date :</b>");
#nullable restore
#line 34 "C:\Users\sachinsaharan\Downloads\Design Pattern\Design Pattern\Web\BookReadingEvent.Web\Views\Home\Index.cshtml"
                                                                          Write(e.Date);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n                        <h6 class=\"card-subtitle mb-2 text-muted\"><b>Duration :</b>");
#nullable restore
#line 35 "C:\Users\sachinsaharan\Downloads\Design Pattern\Design Pattern\Web\BookReadingEvent.Web\Views\Home\Index.cshtml"
                                                                              Write(e.Duration);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n                        <h6 class=\"card-subtitle mb-2 text-muted\"><b>Location :</b>");
#nullable restore
#line 36 "C:\Users\sachinsaharan\Downloads\Design Pattern\Design Pattern\Web\BookReadingEvent.Web\Views\Home\Index.cshtml"
                                                                              Write(e.Location);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n                        <h6 class=\"card-subtitle mb-2 text-muted\"><b>StartTime :</b>");
#nullable restore
#line 37 "C:\Users\sachinsaharan\Downloads\Design Pattern\Design Pattern\Web\BookReadingEvent.Web\Views\Home\Index.cshtml"
                                                                               Write(e.StartTime);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n                    </div>\r\n                </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 29 "C:\Users\sachinsaharan\Downloads\Design Pattern\Design Pattern\Web\BookReadingEvent.Web\Views\Home\Index.cshtml"
                                                                  WriteLiteral(e.EventId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-layout", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["layout"] = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 41 "C:\Users\sachinsaharan\Downloads\Design Pattern\Design Pattern\Web\BookReadingEvent.Web\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Event>> Html { get; private set; }
    }
}
#pragma warning restore 1591