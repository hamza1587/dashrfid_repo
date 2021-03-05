#pragma checksum "C:\Users\hamza\Desktop\dashrfid_repo\dashrfid_repo\ManagementSoft\ManagementSoft\Views\Home\DashBoard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e27f130364a10e2472a5e37ba7549de80aafe5b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_DashBoard), @"mvc.1.0.view", @"/Views/Home/DashBoard.cshtml")]
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
#line 1 "C:\Users\hamza\Desktop\dashrfid_repo\dashrfid_repo\ManagementSoft\ManagementSoft\Views\_ViewImports.cshtml"
using ManagementSoft;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hamza\Desktop\dashrfid_repo\dashrfid_repo\ManagementSoft\ManagementSoft\Views\_ViewImports.cshtml"
using ManagementSoft.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e27f130364a10e2472a5e37ba7549de80aafe5b0", @"/Views/Home/DashBoard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8de362d898c9bd1205613fe9357ea2d9015e2e01", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_DashBoard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DataLib.Entities.TimeSpentOperations>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("quickForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DashBoard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\hamza\Desktop\dashrfid_repo\dashrfid_repo\ManagementSoft\ManagementSoft\Views\Home\DashBoard.cshtml"
  
    ViewData["Title"] = "Operations dashboard";
    Layout = "~/Views/Shared/adminlayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<meta http-equiv=\"refresh\" content=\"120\">\r\n<div id=\"buttons\" class=\"text-center m-0\"></div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e27f130364a10e2472a5e37ba7549de80aafe5b04749", async() => {
                WriteLiteral(@"
    <div class=""card-body"">
        <div class=""table-responsive"">
            <table id=""tbloperation"" class=""table table-bordered table-hover"">
                <thead>
                    <tr>
                        <th>Body</th>
                        <th>Seq</th>
                        <th>Place</th>
                        <th>Area</th>
                        <th>Conditions</th>
                        <th>Status</th>
                        <th>Offline Time</th>
                        <th>OTD</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 25 "C:\Users\hamza\Desktop\dashrfid_repo\dashrfid_repo\ManagementSoft\ManagementSoft\Views\Home\DashBoard.cshtml"
                     foreach (var item in Model)
                    {
                        int min = item.total_minutes;
                        TimeSpan elapsedTime = new TimeSpan(0, min, 0);
                        int day = elapsedTime.Days;
                        int hour = elapsedTime.Hours;
                        int mint = elapsedTime.Minutes;
                        string minutes = "";
                        if (item.total_minutes <= 60)
                        {
                            minutes = string.Format("{0} minutes", mint);
                        }
                        if (item.total_minutes > 60 && item.total_minutes <= 72)
                        {
                            minutes = string.Format("{0} hour {1} minutes", hour, mint);
                        }
                        if (item.total_minutes > 72)
                        {
                            minutes = string.Format("{0} day {1} hours", day, hour);
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tr");
                BeginWriteAttribute("style", " style=\'", 1964, "\'", 2025, 3);
                WriteAttributeValue("", 1972, "background-color:", 1972, 17, true);
#nullable restore
#line 45 "C:\Users\hamza\Desktop\dashrfid_repo\dashrfid_repo\ManagementSoft\ManagementSoft\Views\Home\DashBoard.cshtml"
WriteAttributeValue(" ", 1989, hour >= 2 ? "#ffcccb" : "white", 1990, 34, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2024, ";", 2024, 1, true);
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n                            <td>MKDHH98421</td>\r\n                            <td>123</td>\r\n                            <td>");
#nullable restore
#line 49 "C:\Users\hamza\Desktop\dashrfid_repo\dashrfid_repo\ManagementSoft\ManagementSoft\Views\Home\DashBoard.cshtml"
                           Write(item.location_id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td><span class=\"badge badge-primary\">");
#nullable restore
#line 50 "C:\Users\hamza\Desktop\dashrfid_repo\dashrfid_repo\ManagementSoft\ManagementSoft\Views\Home\DashBoard.cshtml"
                                                             Write(item.location_name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></td>\r\n                            <td>---------</td>\r\n                            <td><span class=\"badge badge-secondary\"><big>WAITING</big></span></td>\r\n                            <td>");
#nullable restore
#line 53 "C:\Users\hamza\Desktop\dashrfid_repo\dashrfid_repo\ManagementSoft\ManagementSoft\Views\Home\DashBoard.cshtml"
                           Write(minutes);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td>0 hrs 33 min</td>\r\n                        </tr>\r\n");
#nullable restore
#line 56 "C:\Users\hamza\Desktop\dashrfid_repo\dashrfid_repo\ManagementSoft\ManagementSoft\Views\Home\DashBoard.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>

        var tbloperation = $('#tbloperation').DataTable({
            ""responsive"": true,
            ""autoWidth"": false,
            ""processing"": true,
            ""bProcessing"": true,
            ""order"": [],
            ""pageLength"": 25,
            ""lengthChange"": true,
            ""lengthMenu"": [
                [25, 100, 1000, -1],
                [25, 100, 1000, ""All""]
            ],
        });
        var buttons = new $.fn.dataTable.Buttons(tbloperation, {
            buttons: [{
                extend: 'excelHtml5',
                title: 'Excel',
                text: 'Export as excel',
                className: 'bg-info btn-xs border-0 m-1',
                exportOptions: {
                    columns: [0, 1, 2, 3, 4, 5, 6, 7]
                }
            },
            ]
        }).container().appendTo($('#buttons'));
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DataLib.Entities.TimeSpentOperations>> Html { get; private set; }
    }
}
#pragma warning restore 1591
