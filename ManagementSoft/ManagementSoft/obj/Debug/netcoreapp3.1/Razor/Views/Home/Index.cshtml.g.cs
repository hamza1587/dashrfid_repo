#pragma checksum "C:\Users\hamza\Desktop\dashrfid_repo\dashrfid_repo\ManagementSoft\ManagementSoft\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "291f5d01fbc02f48772efe9d2ba60f613201fc57"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"291f5d01fbc02f48772efe9d2ba60f613201fc57", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8de362d898c9bd1205613fe9357ea2d9015e2e01", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DataLib.Entities.TimeSpentOperations>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("quickForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\hamza\Desktop\dashrfid_repo\dashrfid_repo\ManagementSoft\ManagementSoft\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Tablero principal";
    Layout = "~/Views/Shared/adminlayout.cshtml";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\hamza\Desktop\dashrfid_repo\dashrfid_repo\ManagementSoft\ManagementSoft\Views\Home\Index.cshtml"
  
    int reserve = Model.Count();

    List<DataLib.Entities.TimeSpentOperations> list = Model.ToList();
    int[] ids = new int[] { 31, 2, 3, 4, 5, 6, 7, 8, 9,
        10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 32, 24, 25, 26, 27, 28, 29, 30 };

#line default
#line hidden
#nullable disable
            WriteLiteral("<meta http-equiv=\"refresh\" content=\"120\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "291f5d01fbc02f48772efe9d2ba60f613201fc575107", async() => {
                WriteLiteral("\r\n    <div class=\"card-body\">\r\n        <div class=\"row col-md-12\">\r\n            <!-- Parking Area -->\r\n");
#nullable restore
#line 18 "C:\Users\hamza\Desktop\dashrfid_repo\dashrfid_repo\ManagementSoft\ManagementSoft\Views\Home\Index.cshtml"
              int i = 1; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\hamza\Desktop\dashrfid_repo\dashrfid_repo\ManagementSoft\ManagementSoft\Views\Home\Index.cshtml"
             foreach (int id in ids)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\hamza\Desktop\dashrfid_repo\dashrfid_repo\ManagementSoft\ManagementSoft\Views\Home\Index.cshtml"
                 if (reserve > 0 && list.Exists(x => x.location_id == id))
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div");
                BeginWriteAttribute("id", " id=\"", 823, "\"", 885, 2);
                WriteAttributeValue("", 828, "GetClass-", 828, 9, true);
#nullable restore
#line 23 "C:\Users\hamza\Desktop\dashrfid_repo\dashrfid_repo\ManagementSoft\ManagementSoft\Views\Home\Index.cshtml"
WriteAttributeValue("", 837, list.Find(x => x.location_id == id).location_id, 837, 48, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" data-id=\"");
#nullable restore
#line 23 "C:\Users\hamza\Desktop\dashrfid_repo\dashrfid_repo\ManagementSoft\ManagementSoft\Views\Home\Index.cshtml"
                                                                                            Write(list.Find(x => x.location_id == id).location_id);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" data-toggle=\"tooltip\"");
                BeginWriteAttribute("title", " title=\"", 967, "\"", 975, 0);
                EndWriteAttribute();
                BeginWriteAttribute("onclick", " onclick=\"", 976, "\"", 1099, 5);
                WriteAttributeValue("", 986, "DataTooltip(\'", 986, 13, true);
#nullable restore
#line 23 "C:\Users\hamza\Desktop\dashrfid_repo\dashrfid_repo\ManagementSoft\ManagementSoft\Views\Home\Index.cshtml"
WriteAttributeValue("", 999, list.Find(x => x.location_id == id).asset_id, 999, 45, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1044, "\',\'", 1044, 3, true);
#nullable restore
#line 23 "C:\Users\hamza\Desktop\dashrfid_repo\dashrfid_repo\ManagementSoft\ManagementSoft\Views\Home\Index.cshtml"
WriteAttributeValue("", 1047, list.Find(x => x.location_id == id).location_name, 1047, 50, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1097, "\')", 1097, 2, true);
                EndWriteAttribute();
                WriteLiteral("></div>\r\n");
#nullable restore
#line 24 "C:\Users\hamza\Desktop\dashrfid_repo\dashrfid_repo\ManagementSoft\ManagementSoft\Views\Home\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div");
                BeginWriteAttribute("id", " id=\"", 1193, "\"", 1207, 2);
                WriteAttributeValue("", 1198, "Booked-", 1198, 7, true);
#nullable restore
#line 27 "C:\Users\hamza\Desktop\dashrfid_repo\dashrfid_repo\ManagementSoft\ManagementSoft\Views\Home\Index.cshtml"
WriteAttributeValue("", 1205, i, 1205, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" data-id=\"");
#nullable restore
#line 27 "C:\Users\hamza\Desktop\dashrfid_repo\dashrfid_repo\ManagementSoft\ManagementSoft\Views\Home\Index.cshtml"
                                            Write(i);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" data-toggle=\"tooltip\"");
                BeginWriteAttribute("title", " title=\"", 1243, "\"", 1251, 0);
                EndWriteAttribute();
                WriteLiteral(" onclick=\"DataTooltip()\"></div>\r\n");
#nullable restore
#line 28 "C:\Users\hamza\Desktop\dashrfid_repo\dashrfid_repo\ManagementSoft\ManagementSoft\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\hamza\Desktop\dashrfid_repo\dashrfid_repo\ManagementSoft\ManagementSoft\Views\Home\Index.cshtml"
                 
                i++;
            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        </div>

    </div>

    <!-- Modals -->
    <div class=""modal fade"" id=""AccountModel"" tabindex=""-1"" role=""dialog"" aria-labelledby=""AccountModel"" aria-hidden=""true"">
        <div class=""modal-dialog modal-dialog-centered"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""AccountModel"">Detalles del Activo</h5>
                    <button class=""close"" type=""button"" data-dismiss=""modal"" aria-label=""Close""><span aria-hidden=""true"">×</span></button>
                </div>
                <div class=""modal-body"">
                    <div class=""form-group"">
                        <label for=""txtLocation"" class=""control-label"">Ubicación</label>
                        <input type=""text"" id=""txtLocation"" class=""form-control"" />
                    </div>
                    <div class=""form-group"">
                        <label for=""txtAssetId"" class=""control-label"">ID del Activo</label>
  ");
                WriteLiteral("                      <input type=\"text\" id=\"txtAssetId\" class=\"form-control\" />\r\n                    </div>\r\n                </div>\r\n                <div class=\"modal-footer\">\r\n");
                WriteLiteral(@"                    <span class=""btn btn-warning"" id=""occupied"">Occupied</span>
                </div>
            </div>
        </div>
    </div>

    </div>
    <div class=""table-responsive"">
        <table id=""tbllayout"" class=""table table-bordered table-hover"">
            <thead>
                <tr>
                    <th>Place</th>
                    <th>Area</th>
                    <th>Body</th>
                    <th>Seq</th>
                    <th>Offline Time</th>
                    <th>OTD</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 77 "C:\Users\hamza\Desktop\dashrfid_repo\dashrfid_repo\ManagementSoft\ManagementSoft\Views\Home\Index.cshtml"
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
                WriteLiteral("                    <tr");
                BeginWriteAttribute("style", " style=\'", 4341, "\'", 4402, 3);
                WriteAttributeValue("", 4349, "background-color:", 4349, 17, true);
#nullable restore
#line 97 "C:\Users\hamza\Desktop\dashrfid_repo\dashrfid_repo\ManagementSoft\ManagementSoft\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 4366, hour >= 2 ? "#ffcccb" : "white", 4367, 34, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 4401, ";", 4401, 1, true);
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <td>");
#nullable restore
#line 98 "C:\Users\hamza\Desktop\dashrfid_repo\dashrfid_repo\ManagementSoft\ManagementSoft\Views\Home\Index.cshtml"
                       Write(item.asset_id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td><span class=\"badge badge-primary\">");
#nullable restore
#line 99 "C:\Users\hamza\Desktop\dashrfid_repo\dashrfid_repo\ManagementSoft\ManagementSoft\Views\Home\Index.cshtml"
                                                         Write(item.location_name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></td>\r\n                        <td>MKDHH98421</td>\r\n                        <td>123</td>\r\n                        <td>");
#nullable restore
#line 102 "C:\Users\hamza\Desktop\dashrfid_repo\dashrfid_repo\ManagementSoft\ManagementSoft\Views\Home\Index.cshtml"
                       Write(minutes);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>0 hrs 33 min</td>\r\n                    </tr>\r\n");
#nullable restore
#line 105 "C:\Users\hamza\Desktop\dashrfid_repo\dashrfid_repo\ManagementSoft\ManagementSoft\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </tbody>\r\n        </table>\r\n        <!-- /.card -->\r\n    </div>\r\n");
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
            WriteLiteral(@"
<style>
    .ParkingPlace {
        height: 70px;
        width: 32px;
        margin-left: 5px;
        background-color: #555;
    }

    .ParkingPlaceOccupie {
        height: 70px;
        width: 32px;
        margin-left: 5px;
        background-color: #126fa5;
    }

    .ParkingArea {
        height: 140px;
        width: 110px;
        margin-left: 5px;
        background-color: #555;
    }

    .ParkingAreaOccupie {
        height: 140px;
        width: 110px;
        margin-left: 5px;
        background-color: #3ca0da;
    }

    .ParkingAreaHorizontal {
        height: 70px;
        width: 125px;
        background-color: #555;
    }

    .ParkingAreaHorizontalOccupie {
        height: 70px;
        width: 125px;
        background-color: #3ca0da;
    }

    .ParkingPlaceHorizontal {
        margin-top: 5px;
        height: 32px;
        width: 80px;
        margin-left: 45px;
        background-color: #555;
    }

    .ParkingPlaceHorizontalOccupi");
            WriteLiteral("e {\r\n        margin-top: 5px;\r\n        height: 32px;\r\n        width: 80px;\r\n        margin-left: 45px;\r\n        background-color: #126fa5;\r\n    }\r\n</style>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            if ($(""#GetClass-31"").attr(""data-id"") == 31) {
                $(""#GetClass-31"").addClass(""ParkingAreaOccupie"");
            } 
            if ($(""#GetClass-1"").attr(""data-id"") == 1) {
                $(""#GetClass-1"").addClass(""ParkingPlaceOccupie"");
            }
            if ($(""#GetClass-2"").attr(""data-id"") == 2) {
                $(""#GetClass-2"").addClass(""ParkingPlaceOccupie"");
            }
            if ($(""#GetClass-3"").attr(""data-id"") == 3) {
                $(""#GetClass-3"").addClass(""ParkingPlaceOccupie"");
            }
            if ($(""#GetClass-4"").attr(""data-id"") == 4) {
                $(""#GetClass-4"").addClass(""ParkingPlaceOccupie"");
            }
            if ($(""#GetClass-5"").attr(""data-id"") == 5) {
                $(""#GetClass-5"").addClass(""ParkingPlaceOccupie"");
            }
            if ($(""#GetClass-6"").attr(""data-id"") == 6) {
                $(""#GetClass-6"").addClass(""ParkingPlaceOccupie"");");
                WriteLiteral(@"
            }
            if ($(""#GetClass-7"").attr(""data-id"") == 7) {
                $(""#GetClass-7"").addClass(""ParkingPlaceOccupie"");
            }
            if ($(""#GetClass-8"").attr(""data-id"") == 8) {
                $(""#GetClass-8"").addClass(""ParkingPlaceOccupie"");
            }
            if ($(""#GetClass-9"").attr(""data-id"") == 9) {
                $(""#GetClass-9"").addClass(""ParkingPlaceOccupie"");
            }
            if ($(""#GetClass-10"").attr(""data-id"") == 10) {
                $(""#GetClass-10"").addClass(""ParkingPlaceOccupie"");
            }
            if ($(""#GetClass-11"").attr(""data-id"") == 11) {
                $(""#GetClass-11"").addClass(""ParkingPlaceOccupie"");
            }
            if ($(""#GetClass-12"").attr(""data-id"") == 12) {
                $(""#GetClass-12"").addClass(""ParkingPlaceOccupie"");
            }
            if ($(""#GetClass-13"").attr(""data-id"") == 13) {
                $(""#GetClass-13"").addClass(""ParkingPlaceOccupie"");
            }
            if (");
                WriteLiteral(@"$(""#GetClass-14"").attr(""data-id"") == 14) {
                $(""#GetClass-14"").addClass(""ParkingPlaceOccupie"");
            }
            if ($(""#GetClass-15"").attr(""data-id"") == 15) {
                $(""#GetClass-15"").addClass(""ParkingPlaceOccupie"");
            }
            if ($(""#GetClass-16"").attr(""data-id"") == 16) {
                $(""#GetClass-16"").addClass(""ParkingPlaceOccupie"");
            }
            if ($(""#GetClass-17"").attr(""data-id"") == 17) {
                $(""#GetClass-17"").addClass(""ParkingPlaceOccupie"");
            }
            if ($(""#GetClass-18"").attr(""data-id"") == 18) {
                $(""#GetClass-18"").addClass(""ParkingPlaceOccupie"");
            }
            if ($(""#GetClass-19"").attr(""data-id"") == 19) {
                $(""#GetClass-19"").addClass(""ParkingPlaceOccupie"");
            }
            if ($(""#GetClass-20"").attr(""data-id"") == 20) {
                $(""#GetClass-20"").addClass(""ParkingPlaceOccupie"");
            }
            if ($(""#GetClass-21"").attr(");
                WriteLiteral(@"""data-id"") == 21) {
                $(""#GetClass-21"").addClass(""ParkingPlaceOccupie"");
            }
            if ($(""#GetClass-22"").attr(""data-id"") == 22) {
                $(""#GetClass-22"").addClass(""ParkingPlaceOccupie"");
            }
            if ($(""#GetClass-23"").attr(""data-id"") == 23) {
                $(""#GetClass-23"").addClass(""ParkingPlaceOccupie"");
            }
            if ($(""#GetClass-24"").attr(""data-id"") == 24) {
                $(""#GetClass-24"").addClass(""ParkingPlaceOccupie"");
            }
            if ($(""#GetClass-25"").attr(""data-id"") == 25) {
                $(""#GetClass-25"").addClass(""ParkingPlaceOccupie"");
            }
            if ($(""#GetClass-26"").attr(""data-id"") == 26) {
                $(""#GetClass-26"").addClass(""ParkingPlaceOccupie"");
            }
            if ($(""#GetClass-27"").attr(""data-id"") == 27) {
                $(""#GetClass-27"").addClass(""ParkingPlaceOccupie"");
            }
            if ($(""#GetClass-28"").attr(""data-id"") == 28) {
  ");
                WriteLiteral(@"              $(""#GetClass-28"").addClass(""ParkingPlaceOccupie"");
            }
            if ($(""#GetClass-29"").attr(""data-id"") == 29) {
                $(""#GetClass-29"").addClass(""ParkingPlaceOccupie"");
            }
            if ($(""#GetClass-30"").attr(""data-id"") == 30) {
                $(""#GetClass-30"").addClass(""ParkingPlaceOccupie"");
            }
            ///////////////////////////////////////////////////////////////
            if ($(""#Booked-2"").attr(""data-id"") == 2) {
                $(""#Booked-2"").addClass(""ParkingPlace"");
            } 
            if ($(""#Booked-3"").attr(""data-id"") == 3) {
                $(""#Booked-3"").addClass(""ParkingPlace"");
            }
            if ($(""#Booked-4"").attr(""data-id"") == 4) {
                $(""#Booked-4"").addClass(""ParkingPlace"");
            }
            if ($(""#Booked-5"").attr(""data-id"") == 5) {
                $(""#Booked-5"").addClass(""ParkingPlace"");
            }
            if ($(""#Booked-6"").attr(""data-id"") == 6) {
       ");
                WriteLiteral(@"         $(""#Booked-6"").addClass(""ParkingPlace"");
            }
            if ($(""#Booked-7"").attr(""data-id"") == 7) {
                $(""#Booked-7"").addClass(""ParkingPlace"");
            }
            if ($(""#Booked-8"").attr(""data-id"") == 8) {
                $(""#Booked-8"").addClass(""ParkingPlace"");
            } 
            if ($(""#Booked-9"").attr(""data-id"") == 9) {
                $(""#Booked-9"").addClass(""ParkingPlace"");
            }
            if ($(""#Booked-10"").attr(""data-id"") == 10) {
                $(""#Booked-10"").addClass(""ParkingPlace"");
            }
            if ($(""#Booked-11"").attr(""data-id"") == 11) {
                $(""#Booked-11"").addClass(""ParkingPlace"");
            }
            if ($(""#Booked-12"").attr(""data-id"") == 12) {
                $(""#Booked-12"").addClass(""ParkingPlace"");
            }
            if ($(""#Booked-13"").attr(""data-id"") == 13) {
                $(""#Booked-13"").addClass(""ParkingPlace"");
            }
            if ($(""#Booked-14"").attr(""data");
                WriteLiteral(@"-id"") == 14) {
                $(""#Booked-14"").addClass(""ParkingPlace"");
            } 
            if ($(""#Booked-15"").attr(""data-id"") == 15) {
                $(""#Booked-15"").addClass(""ParkingPlace"");
            } 
            if ($(""#Booked-16"").attr(""data-id"") == 16) {
                $(""#Booked-16"").addClass(""ParkingPlace"");
            } 
            if ($(""#Booked-17"").attr(""data-id"") == 17) {
                $(""#Booked-17"").addClass(""ParkingPlace"");
            } 
            if ($(""#Booked-18"").attr(""data-id"") == 18) {
                $(""#Booked-18"").addClass(""ParkingPlace"");
            } 
            if ($(""#Booked-19"").attr(""data-id"") == 19) {
                $(""#Booked-19"").addClass(""ParkingPlace"");
            } 
            if ($(""#Booked-20"").attr(""data-id"") == 20) {
                $(""#Booked-20"").addClass(""ParkingPlace"");
            } 
            if ($(""#Booked-21"").attr(""data-id"") == 21) {
                $(""#Booked-21"").addClass(""ParkingPlace"");
            } 
  ");
                WriteLiteral(@"          if ($(""#Booked-22"").attr(""data-id"") == 22) {
                $(""#Booked-22"").addClass(""ParkingPlace"");
            } 
            if ($(""#Booked-23"").attr(""data-id"") == 23) {
                $(""#Booked-23"").addClass(""ParkingPlace"");
            } 
            if ($(""#Booked-24"").attr(""data-id"") == 24) {
                $(""#Booked-24"").addClass(""ParkingPlace"");
            } 
            if ($(""#Booked-25"").attr(""data-id"") == 25) {
                $(""#Booked-25"").addClass(""ParkingPlace"");
            } 
            if ($(""#Booked-26"").attr(""data-id"") == 26) {
                $(""#Booked-26"").addClass(""ParkingPlace"");
            } 
            if ($(""#Booked-27"").attr(""data-id"") == 27) {
                $(""#Booked-27"").addClass(""ParkingPlace"");
            } 
            if ($(""#Booked-28"").attr(""data-id"") == 28) {
                $(""#Booked-28"").addClass(""ParkingPlace"");
            } 
            if ($(""#Booked-29"").attr(""data-id"") == 29) {
                $(""#Booked-29"").addCl");
                WriteLiteral(@"ass(""ParkingPlace"");
            } 
            if ($(""#Booked-30"").attr(""data-id"") == 30) {
                $(""#Booked-30"").addClass(""ParkingPlace"");
            } 
        })
        function DataTooltip(AssetID, LocationName) {
            if (AssetID == undefined) {
                $('#txtAssetId').val('');
                $('#txtLocation').val('');
                $('#save').show('fast');
                $('#close').show('fast');
                $('#occupied').hide('fast');
                $('#AccountModel').modal('show');
            } else {
                $('#txtAssetId').val(AssetID);
                $('#txtLocation').val(LocationName);
                $('#occupied').show('fast');
                $('#save').hide('fast');
                $('#close').hide('fast');
                $('#AccountModel').modal('show');
            }
        }
        $(function () {
            $('#tbllayout').DataTable({
                ""paging"": true,
                ""lengthChange"": false,
     ");
                WriteLiteral("           \"searching\": false,\r\n                \"ordering\": true,\r\n                \"info\": true,\r\n                \"autoWidth\": false,\r\n                \"responsive\": true,\r\n            });\r\n        });\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DataLib.Entities.TimeSpentOperations>> Html { get; private set; }
    }
}
#pragma warning restore 1591
