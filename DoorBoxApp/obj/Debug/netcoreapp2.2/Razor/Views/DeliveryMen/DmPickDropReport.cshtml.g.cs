#pragma checksum "D:\Project File\DroopBox\DoorBoxApp\Views\DeliveryMen\DmPickDropReport.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3760e203c5c5b776c8a155e0037205c13a09047a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DeliveryMen_DmPickDropReport), @"mvc.1.0.view", @"/Views/DeliveryMen/DmPickDropReport.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DeliveryMen/DmPickDropReport.cshtml", typeof(AspNetCore.Views_DeliveryMen_DmPickDropReport))]
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
#line 1 "D:\Project File\DroopBox\DoorBoxApp\Views\_ViewImports.cshtml"
using DoorBoxApp;

#line default
#line hidden
#line 2 "D:\Project File\DroopBox\DoorBoxApp\Views\_ViewImports.cshtml"
using DoorBoxApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3760e203c5c5b776c8a155e0037205c13a09047a", @"/Views/DeliveryMen/DmPickDropReport.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db0bb7675d3dc7f4369941d6c52fb8cf421deb36", @"/Views/_ViewImports.cshtml")]
    public class Views_DeliveryMen_DmPickDropReport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DoorBoxApp.Models.ViewModels.FromDateToDateViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DmPickDropReport", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/vendor/datatable/js/jquery.dataTables.min.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/vendor/datatable/js/dataTables.bootstrap4.min.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/vendor/bootstrap-datepicker/bootstrap-datepicker.min.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(61, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Project File\DroopBox\DoorBoxApp\Views\DeliveryMen\DmPickDropReport.cshtml"
  
    ViewData["Title"] = "Deliverymen";

#line default
#line hidden
            BeginContext(110, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Css", async() => {
                BeginContext(126, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 8 "D:\Project File\DroopBox\DoorBoxApp\Views\DeliveryMen\DmPickDropReport.cshtml"
      await Html.RenderPartialAsync("_DataTableCssPartial");

#line default
#line hidden
            }
            );
            BeginContext(194, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Sole", async() => {
                BeginContext(211, 279, true);
                WriteLiteral(@"
    <style>


        .table tr th:last-child {
            width: 160px;
        }

        .table tr th {
            text-align: center;
        }

        .table tr td {
            text-align: center;
            text-wrap: initial;
        }
    </style>
");
                EndContext();
            }
            );
            BeginContext(493, 104, true);
            WriteLiteral("\r\n<div class=\"container-fluid mt-4\">\r\n    <div class=\"card animated fadeIn overflow-hidden\">\r\n\r\n        ");
            EndContext();
            BeginContext(597, 1116, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3760e203c5c5b776c8a155e0037205c13a09047a7423", async() => {
                BeginContext(633, 97, true);
                WriteLiteral("\r\n            <div class=\"card-header \">\r\n                <div class=\"row\">\r\n                    ");
                EndContext();
                BeginContext(730, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3760e203c5c5b776c8a155e0037205c13a09047a7908", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 36 "D:\Project File\DroopBox\DoorBoxApp\Views\DeliveryMen\DmPickDropReport.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(796, 277, true);
                WriteLiteral(@"
                    <label class="" form-control shadow-none--hover skewed skewed-yellow hover btn btn-greenyellow text-center col-lg-2"">From</label>
                    <input name=""FromDate"" readonly class=""form-control form-control-sm mr-2 datepicker text-center col-lg-3""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1073, "\"", 1131, 1);
#line 38 "D:\Project File\DroopBox\DoorBoxApp\Views\DeliveryMen\DmPickDropReport.cshtml"
WriteAttributeValue("", 1081, String.Format("{0:yyyy-MM-dd}", ViewBag.FromDate), 1081, 50, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1132, 296, true);
                WriteLiteral(@" placeholder=""From"" />
                    <label class=""form-control shadow-none--hover hover  skewed skewed-yellow  btn btn-greenyellow text-center col-lg-2"">To</label>
                    <input name=""ToDate"" readonly class=""form-control form-control-sm mr-2 datepicker text-center col-lg-3""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1428, "\"", 1484, 1);
#line 40 "D:\Project File\DroopBox\DoorBoxApp\Views\DeliveryMen\DmPickDropReport.cshtml"
WriteAttributeValue("", 1436, String.Format("{0:yyyy-MM-dd}", ViewBag.ToDate), 1436, 48, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1485, 221, true);
                WriteLiteral(" placeholder=\"To\" />\r\n\r\n                    <button type=\"submit\" class=\"form-control btn btn-primary btn-sm col-lg-1\">Search<i class=\"fa fa-search ml-1\"></i></button>\r\n                </div>\r\n            </div>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1713, 1046, true);
            WriteLiteral(@"
        <div class=""card-body px-0 pb-2"">
            <div class=""table-responsive"">

                <table class=""table align-items-center  table-striped table-bordered"" id=""datatable-basic"">
                    <thead class=""thead-light"">
                        <tr>

                            <th>
                                Name
                            </th>
                            <th>
                                Id
                            </th>
                            <th>
                                Total Picked
                            </th>
                            <th>
                                Total Delivered
                            </th>
                            <th>
                                Total Cancel
                            </th>
                            <th>
                                Total Earned
                            </th>
                        </tr>
                    </thead>
       ");
            WriteLiteral("             <tbody>\r\n");
            EndContext();
#line 74 "D:\Project File\DroopBox\DoorBoxApp\Views\DeliveryMen\DmPickDropReport.cshtml"
                         foreach (var item in ViewBag.DeliveryMan)
                        {

#line default
#line hidden
            BeginContext(2854, 110, true);
            WriteLiteral("                            <tr>\r\n\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(2965, 21, false);
#line 79 "D:\Project File\DroopBox\DoorBoxApp\Views\DeliveryMen\DmPickDropReport.cshtml"
                               Write(item.DeliveryMan.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2986, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(3102, 32, false);
#line 82 "D:\Project File\DroopBox\DoorBoxApp\Views\DeliveryMen\DmPickDropReport.cshtml"
                               Write(item.DeliveryMan.DeliveryManIdNo);

#line default
#line hidden
            EndContext();
            BeginContext(3134, 117, true);
            WriteLiteral("\r\n                                </td>\r\n\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(3252, 14, false);
#line 86 "D:\Project File\DroopBox\DoorBoxApp\Views\DeliveryMen\DmPickDropReport.cshtml"
                               Write(item.TotalPick);

#line default
#line hidden
            EndContext();
            BeginContext(3266, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(3382, 14, false);
#line 89 "D:\Project File\DroopBox\DoorBoxApp\Views\DeliveryMen\DmPickDropReport.cshtml"
                               Write(item.TotalDrop);

#line default
#line hidden
            EndContext();
            BeginContext(3396, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(3512, 16, false);
#line 92 "D:\Project File\DroopBox\DoorBoxApp\Views\DeliveryMen\DmPickDropReport.cshtml"
                               Write(item.TotalCancel);

#line default
#line hidden
            EndContext();
            BeginContext(3528, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(3644, 14, false);
#line 95 "D:\Project File\DroopBox\DoorBoxApp\Views\DeliveryMen\DmPickDropReport.cshtml"
                               Write(item.TotalPaid);

#line default
#line hidden
            EndContext();
            BeginContext(3658, 78, true);
            WriteLiteral("\r\n                                </td>\r\n\r\n                            </tr>\r\n");
            EndContext();
#line 99 "D:\Project File\DroopBox\DoorBoxApp\Views\DeliveryMen\DmPickDropReport.cshtml"
                        }

#line default
#line hidden
            BeginContext(3763, 122, true);
            WriteLiteral("                    </tbody>\r\n                </table>\r\n\r\n\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3903, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(3909, 119, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3760e203c5c5b776c8a155e0037205c13a09047a17599", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
#line 112 "D:\Project File\DroopBox\DoorBoxApp\Views\DeliveryMen\DmPickDropReport.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4028, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(4034, 123, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3760e203c5c5b776c8a155e0037205c13a09047a19763", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
#line 113 "D:\Project File\DroopBox\DoorBoxApp\Views\DeliveryMen\DmPickDropReport.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4157, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(4163, 107, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3760e203c5c5b776c8a155e0037205c13a09047a21927", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
#line 114 "D:\Project File\DroopBox\DoorBoxApp\Views\DeliveryMen\DmPickDropReport.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4270, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 115 "D:\Project File\DroopBox\DoorBoxApp\Views\DeliveryMen\DmPickDropReport.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DoorBoxApp.Models.ViewModels.FromDateToDateViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
