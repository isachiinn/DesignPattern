#pragma checksum "C:\Users\sachinsaharan\Downloads\Design Pattern\Design Pattern\Web\BookReadingEvent.Web\Views\CreateEvent\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a74cf73f5d29bdf795ad4d15432968f8543f766"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CreateEvent_Index), @"mvc.1.0.view", @"/Views/CreateEvent/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a74cf73f5d29bdf795ad4d15432968f8543f766", @"/Views/CreateEvent/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0133f9920160cf33e87e1cf2f1ee78f6f4792d4c", @"/Views/_ViewImports.cshtml")]
    public class Views_CreateEvent_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Event>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\sachinsaharan\Downloads\Design Pattern\Design Pattern\Web\BookReadingEvent.Web\Views\CreateEvent\Index.cshtml"
  

    Layout = "_LayoutEvent";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"shadow-none\" style=\"width: 100%; margin-left: 5px; margin-right:50px; margin-top:20px;margin-bottom:20px; text-align:left;background-color:ghostwhite\">\r\n");
#nullable restore
#line 8 "C:\Users\sachinsaharan\Downloads\Design Pattern\Design Pattern\Web\BookReadingEvent.Web\Views\CreateEvent\Index.cshtml"
     using (Html.BeginForm("", "CreateEvent", FormMethod.Post))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"form-group mb-3\">\r\n\r\n            ");
#nullable restore
#line 12 "C:\Users\sachinsaharan\Downloads\Design Pattern\Design Pattern\Web\BookReadingEvent.Web\Views\CreateEvent\Index.cshtml"
       Write(Html.LabelFor(model => model.Title, htmlAttributes: new { @class = "fs-5" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n            ");
#nullable restore
#line 15 "C:\Users\sachinsaharan\Downloads\Design Pattern\Design Pattern\Web\BookReadingEvent.Web\Views\CreateEvent\Index.cshtml"
       Write(Html.EditorFor(model => model.Title, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 16 "C:\Users\sachinsaharan\Downloads\Design Pattern\Design Pattern\Web\BookReadingEvent.Web\Views\CreateEvent\Index.cshtml"
       Write(Html.ValidationMessageFor(model => model.Title, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </div>\r\n");
            WriteLiteral("        <div class=\"form-group mb-3\">\r\n\r\n            ");
#nullable restore
#line 22 "C:\Users\sachinsaharan\Downloads\Design Pattern\Design Pattern\Web\BookReadingEvent.Web\Views\CreateEvent\Index.cshtml"
       Write(Html.LabelFor(model => model.Date, htmlAttributes: new { @class = "fs-5" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            ");
#nullable restore
#line 24 "C:\Users\sachinsaharan\Downloads\Design Pattern\Design Pattern\Web\BookReadingEvent.Web\Views\CreateEvent\Index.cshtml"
       Write(Html.EditorFor(model => model.Date, new { htmlAttributes = new { @class = "form-control datepicker " } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 25 "C:\Users\sachinsaharan\Downloads\Design Pattern\Design Pattern\Web\BookReadingEvent.Web\Views\CreateEvent\Index.cshtml"
       Write(Html.ValidationMessageFor(model => model.Date, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
            WriteLiteral("        <div class=\"form-group mb-3\">\r\n\r\n            ");
#nullable restore
#line 31 "C:\Users\sachinsaharan\Downloads\Design Pattern\Design Pattern\Web\BookReadingEvent.Web\Views\CreateEvent\Index.cshtml"
       Write(Html.LabelFor(model => model.Location, htmlAttributes: new { @class = "fs-5" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            ");
#nullable restore
#line 33 "C:\Users\sachinsaharan\Downloads\Design Pattern\Design Pattern\Web\BookReadingEvent.Web\Views\CreateEvent\Index.cshtml"
       Write(Html.EditorFor(model => model.Location, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 34 "C:\Users\sachinsaharan\Downloads\Design Pattern\Design Pattern\Web\BookReadingEvent.Web\Views\CreateEvent\Index.cshtml"
       Write(Html.ValidationMessageFor(model => model.Location, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
            WriteLiteral("        <div class=\"form-group mb-3\">\r\n\r\n            ");
#nullable restore
#line 39 "C:\Users\sachinsaharan\Downloads\Design Pattern\Design Pattern\Web\BookReadingEvent.Web\Views\CreateEvent\Index.cshtml"
       Write(Html.LabelFor(model => model.StartTime, htmlAttributes: new { @class = "fs-5" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            ");
#nullable restore
#line 41 "C:\Users\sachinsaharan\Downloads\Design Pattern\Design Pattern\Web\BookReadingEvent.Web\Views\CreateEvent\Index.cshtml"
       Write(Html.EditorFor(model => model.StartTime, new { htmlAttributes = new { @class = "form-control timepicker " } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
            WriteLiteral("        <div class=\"form-group mb-3\">\r\n\r\n            ");
#nullable restore
#line 47 "C:\Users\sachinsaharan\Downloads\Design Pattern\Design Pattern\Web\BookReadingEvent.Web\Views\CreateEvent\Index.cshtml"
       Write(Html.LabelFor(model => model.Type, htmlAttributes: new { @class = "fs-5" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n            <div>");
#nullable restore
#line 50 "C:\Users\sachinsaharan\Downloads\Design Pattern\Design Pattern\Web\BookReadingEvent.Web\Views\CreateEvent\Index.cshtml"
            Write(Html.RadioButtonFor(model => model.Type, "public", new { htmlAttributes = new { @class = "form-control " } }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" Public</div>\r\n            <div>");
#nullable restore
#line 51 "C:\Users\sachinsaharan\Downloads\Design Pattern\Design Pattern\Web\BookReadingEvent.Web\Views\CreateEvent\Index.cshtml"
            Write(Html.RadioButtonFor(model => model.Type, "private", new { htmlAttributes = new { @class = "form-control " } }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" Private</div>\r\n\r\n        </div>\r\n");
            WriteLiteral("        <div class=\"form-group mb-3\">\r\n\r\n            ");
#nullable restore
#line 58 "C:\Users\sachinsaharan\Downloads\Design Pattern\Design Pattern\Web\BookReadingEvent.Web\Views\CreateEvent\Index.cshtml"
       Write(Html.LabelFor(model => model.Duration, htmlAttributes: new { @class = "fs-5" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 59 "C:\Users\sachinsaharan\Downloads\Design Pattern\Design Pattern\Web\BookReadingEvent.Web\Views\CreateEvent\Index.cshtml"
       Write(Html.EditorFor(model => model.Duration, new { htmlAttributes = new { @class = "form-control", @max = 4, @min = 0 } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
            WriteLiteral("        <div class=\"form-group mb-3\">\r\n\r\n            ");
#nullable restore
#line 64 "C:\Users\sachinsaharan\Downloads\Design Pattern\Design Pattern\Web\BookReadingEvent.Web\Views\CreateEvent\Index.cshtml"
       Write(Html.LabelFor(model => model.Description, htmlAttributes: new { @class = "fs-5" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            ");
#nullable restore
#line 66 "C:\Users\sachinsaharan\Downloads\Design Pattern\Design Pattern\Web\BookReadingEvent.Web\Views\CreateEvent\Index.cshtml"
       Write(Html.EditorFor(model => model.Description, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
            WriteLiteral("        <div class=\"form-group mb-3\">\r\n\r\n            ");
#nullable restore
#line 71 "C:\Users\sachinsaharan\Downloads\Design Pattern\Design Pattern\Web\BookReadingEvent.Web\Views\CreateEvent\Index.cshtml"
       Write(Html.LabelFor(model => model.OtherDetails, htmlAttributes: new { @class = "fs-5" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            ");
#nullable restore
#line 73 "C:\Users\sachinsaharan\Downloads\Design Pattern\Design Pattern\Web\BookReadingEvent.Web\Views\CreateEvent\Index.cshtml"
       Write(Html.EditorFor(model => model.OtherDetails, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
            WriteLiteral("        <div class=\"form-group mb-4\">\r\n\r\n            ");
#nullable restore
#line 79 "C:\Users\sachinsaharan\Downloads\Design Pattern\Design Pattern\Web\BookReadingEvent.Web\Views\CreateEvent\Index.cshtml"
       Write(Html.LabelFor(model => model.InviteByEmail, htmlAttributes: new { @class = "fs-5" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            ");
#nullable restore
#line 81 "C:\Users\sachinsaharan\Downloads\Design Pattern\Design Pattern\Web\BookReadingEvent.Web\Views\CreateEvent\Index.cshtml"
       Write(Html.EditorFor(model => model.InviteByEmail, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
            WriteLiteral("        <div class=\"row mb-5\" style=\"margin-left:5px;\">\r\n            <button type=\"submit\" class=\"btn btn-success fs-5 ps-5 pe-5 \">Create</button>\r\n        </div>\r\n");
#nullable restore
#line 87 "C:\Users\sachinsaharan\Downloads\Design Pattern\Design Pattern\Web\BookReadingEvent.Web\Views\CreateEvent\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Event> Html { get; private set; }
    }
}
#pragma warning restore 1591
