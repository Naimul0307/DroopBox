#pragma checksum "D:\Project File\DoorBoxApp\DoorBoxApp\Views\DeliveryMen\PickUpReportDM.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79a4d4397c77d11a689a4fd7cd5cd33a6fc58645"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DeliveryMen_PickUpReportDM), @"mvc.1.0.view", @"/Views/DeliveryMen/PickUpReportDM.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DeliveryMen/PickUpReportDM.cshtml", typeof(AspNetCore.Views_DeliveryMen_PickUpReportDM))]
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
#line 1 "D:\Project File\DoorBoxApp\DoorBoxApp\Views\_ViewImports.cshtml"
using DoorBoxApp;

#line default
#line hidden
#line 2 "D:\Project File\DoorBoxApp\DoorBoxApp\Views\_ViewImports.cshtml"
using DoorBoxApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79a4d4397c77d11a689a4fd7cd5cd33a6fc58645", @"/Views/DeliveryMen/PickUpReportDM.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db0bb7675d3dc7f4369941d6c52fb8cf421deb36", @"/Views/_ViewImports.cshtml")]
    public class Views_DeliveryMen_PickUpReportDM : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DoorBoxApp.Models.ViewModels.FromDateToDateViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PickUpReportDM", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/vendor/datatable/js/jquery.dataTables.min.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/vendor/datatable/js/dataTables.bootstrap4.min.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/vendor/bootstrap-datepicker/bootstrap-datepicker.min.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(61, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Project File\DoorBoxApp\DoorBoxApp\Views\DeliveryMen\PickUpReportDM.cshtml"
  
    ViewData["Title"] = "All Packages";

#line default
#line hidden
            BeginContext(111, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Css", async() => {
                BeginContext(127, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 8 "D:\Project File\DoorBoxApp\DoorBoxApp\Views\DeliveryMen\PickUpReportDM.cshtml"
      await Html.RenderPartialAsync("_DataTableCssPartial");

#line default
#line hidden
            }
            );
            BeginContext(195, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Sole", async() => {
                BeginContext(212, 279, true);
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
            BeginContext(494, 104, true);
            WriteLiteral("\r\n<div class=\"container-fluid mt-4\">\r\n    <div class=\"card animated fadeIn overflow-hidden\">\r\n\r\n        ");
            EndContext();
            BeginContext(598, 1218, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "79a4d4397c77d11a689a4fd7cd5cd33a6fc586457896", async() => {
                BeginContext(632, 97, true);
                WriteLiteral("\r\n            <div class=\"card-header \">\r\n                <div class=\"row\">\r\n                    ");
                EndContext();
                BeginContext(729, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "79a4d4397c77d11a689a4fd7cd5cd33a6fc586458381", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 36 "D:\Project File\DoorBoxApp\DoorBoxApp\Views\DeliveryMen\PickUpReportDM.cshtml"
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
                BeginContext(795, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(817, 82, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "79a4d4397c77d11a689a4fd7cd5cd33a6fc5864510183", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 37 "D:\Project File\DoorBoxApp\DoorBoxApp\Views\DeliveryMen\PickUpReportDM.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
#line 37 "D:\Project File\DoorBoxApp\DoorBoxApp\Views\DeliveryMen\PickUpReportDM.cshtml"
                                                               WriteLiteral(ViewBag.DeliveryMan.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(899, 277, true);
                WriteLiteral(@"
                    <label class="" form-control shadow-none--hover skewed skewed-yellow hover btn btn-greenyellow text-center col-lg-2"">From</label>
                    <input name=""FromDate"" readonly class=""form-control form-control-sm mr-2 datepicker text-center col-lg-3""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1176, "\"", 1234, 1);
#line 39 "D:\Project File\DoorBoxApp\DoorBoxApp\Views\DeliveryMen\PickUpReportDM.cshtml"
WriteAttributeValue("", 1184, String.Format("{0:yyyy-MM-dd}", ViewBag.FromDate), 1184, 50, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1235, 296, true);
                WriteLiteral(@" placeholder=""From"" />
                    <label class=""form-control shadow-none--hover hover  skewed skewed-yellow  btn btn-greenyellow text-center col-lg-2"">To</label>
                    <input name=""ToDate"" readonly class=""form-control form-control-sm mr-2 datepicker text-center col-lg-3""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1531, "\"", 1587, 1);
#line 41 "D:\Project File\DoorBoxApp\DoorBoxApp\Views\DeliveryMen\PickUpReportDM.cshtml"
WriteAttributeValue("", 1539, String.Format("{0:yyyy-MM-dd}", ViewBag.ToDate), 1539, 48, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1588, 221, true);
                WriteLiteral(" placeholder=\"To\" />\r\n\r\n                    <button type=\"submit\" class=\"form-control btn btn-primary btn-sm col-lg-1\">Search<i class=\"fa fa-search ml-1\"></i></button>\r\n                </div>\r\n            </div>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1816, 1713, true);
            WriteLiteral(@"
        <div class=""card-body px-0 pb-2"">
            <div class=""table-responsive"">

                <table class=""table align-items-center  table-striped table-bordered"" id=""datatable-basic"">
                    <thead class=""thead-light"">
                        <tr>

                            <th>
                                Catagory
                            </th>
                            <th>
                                Merchant Name
                            </th>
                            <th>
                                Merchant ID
                            </th>
                            <th>
                                From
                            </th>
                            <th>
                                To
                            </th>

                            <th>
                                Sub(To)
                            </th>
                             <th>
                                Tracking NO");
            WriteLiteral(@"
                            </th>

                            <th>
                                Client
                            </th>
                            <th>
                                Phone
                            </th>
                            <th>
                                Address
                            </th>


                            <th>
                                Weight
                            </th>

                            <th>
                                Product Price
                            </th>

                        </tr>
                    </thead>
                    <tbody>
");
            EndContext();
#line 99 "D:\Project File\DoorBoxApp\DoorBoxApp\Views\DeliveryMen\PickUpReportDM.cshtml"
                         foreach (var item in ViewBag.Packages)
                        {

#line default
#line hidden
            BeginContext(3621, 98, true);
            WriteLiteral("                        <tr>\r\n\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(3720, 25, false);
#line 104 "D:\Project File\DoorBoxApp\DoorBoxApp\Views\DeliveryMen\PickUpReportDM.cshtml"
                           Write(item.PackageCatagory.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3745, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(3849, 32, false);
#line 107 "D:\Project File\DoorBoxApp\DoorBoxApp\Views\DeliveryMen\PickUpReportDM.cshtml"
                           Write(item.PickUpRequest.Merchant.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3881, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(3985, 40, false);
#line 110 "D:\Project File\DoorBoxApp\DoorBoxApp\Views\DeliveryMen\PickUpReportDM.cshtml"
                           Write(item.PickUpRequest.Merchant.MerchantIdNo);

#line default
#line hidden
            EndContext();
            BeginContext(4025, 107, true);
            WriteLiteral("\r\n                            </td>\r\n\r\n\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(4133, 36, false);
#line 115 "D:\Project File\DoorBoxApp\DoorBoxApp\Views\DeliveryMen\PickUpReportDM.cshtml"
                           Write(item.PickUpRequest.LocationFrom.Name);

#line default
#line hidden
            EndContext();
            BeginContext(4169, 37, true);
            WriteLiteral("\r\n                            </td>\r\n");
            EndContext();
#line 117 "D:\Project File\DoorBoxApp\DoorBoxApp\Views\DeliveryMen\PickUpReportDM.cshtml"
                             if (item.LocationTo != null)
                            {

#line default
#line hidden
            BeginContext(4296, 74, true);
            WriteLiteral("                                <td>\r\n                                    ");
            EndContext();
            BeginContext(4371, 20, false);
#line 120 "D:\Project File\DoorBoxApp\DoorBoxApp\Views\DeliveryMen\PickUpReportDM.cshtml"
                               Write(item.LocationTo.Name);

#line default
#line hidden
            EndContext();
            BeginContext(4391, 41, true);
            WriteLiteral("\r\n                                </td>\r\n");
            EndContext();
#line 122 "D:\Project File\DoorBoxApp\DoorBoxApp\Views\DeliveryMen\PickUpReportDM.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(4528, 46, true);
            WriteLiteral("                                <td>N/A</td>\r\n");
            EndContext();
#line 126 "D:\Project File\DoorBoxApp\DoorBoxApp\Views\DeliveryMen\PickUpReportDM.cshtml"
                            }

#line default
#line hidden
            BeginContext(4605, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 128 "D:\Project File\DoorBoxApp\DoorBoxApp\Views\DeliveryMen\PickUpReportDM.cshtml"
                             if (item.SubLocation != null)
                            {


#line default
#line hidden
            BeginContext(4700, 74, true);
            WriteLiteral("                                <td>\r\n                                    ");
            EndContext();
            BeginContext(4775, 21, false);
#line 132 "D:\Project File\DoorBoxApp\DoorBoxApp\Views\DeliveryMen\PickUpReportDM.cshtml"
                               Write(item.SubLocation.Name);

#line default
#line hidden
            EndContext();
            BeginContext(4796, 41, true);
            WriteLiteral("\r\n                                </td>\r\n");
            EndContext();
#line 134 "D:\Project File\DoorBoxApp\DoorBoxApp\Views\DeliveryMen\PickUpReportDM.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(4933, 46, true);
            WriteLiteral("                                <td>N/A</td>\r\n");
            EndContext();
#line 138 "D:\Project File\DoorBoxApp\DoorBoxApp\Views\DeliveryMen\PickUpReportDM.cshtml"
                            }

#line default
#line hidden
#line 139 "D:\Project File\DoorBoxApp\DoorBoxApp\Views\DeliveryMen\PickUpReportDM.cshtml"
                             if (item.TrackingNumber != null)
                            {


#line default
#line hidden
            BeginContext(5106, 74, true);
            WriteLiteral("                                <td>\r\n                                    ");
            EndContext();
            BeginContext(5181, 19, false);
#line 143 "D:\Project File\DoorBoxApp\DoorBoxApp\Views\DeliveryMen\PickUpReportDM.cshtml"
                               Write(item.TrackingNumber);

#line default
#line hidden
            EndContext();
            BeginContext(5200, 41, true);
            WriteLiteral("\r\n                                </td>\r\n");
            EndContext();
#line 145 "D:\Project File\DoorBoxApp\DoorBoxApp\Views\DeliveryMen\PickUpReportDM.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(5337, 46, true);
            WriteLiteral("                                <td>N/A</td>\r\n");
            EndContext();
#line 149 "D:\Project File\DoorBoxApp\DoorBoxApp\Views\DeliveryMen\PickUpReportDM.cshtml"
                            }

#line default
#line hidden
            BeginContext(5414, 70, true);
            WriteLiteral("\r\n\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(5485, 15, false);
#line 153 "D:\Project File\DoorBoxApp\DoorBoxApp\Views\DeliveryMen\PickUpReportDM.cshtml"
                           Write(item.ClientName);

#line default
#line hidden
            EndContext();
            BeginContext(5500, 105, true);
            WriteLiteral("\r\n                            </td>\r\n\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(5606, 16, false);
#line 157 "D:\Project File\DoorBoxApp\DoorBoxApp\Views\DeliveryMen\PickUpReportDM.cshtml"
                           Write(item.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(5622, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(5726, 12, false);
#line 160 "D:\Project File\DoorBoxApp\DoorBoxApp\Views\DeliveryMen\PickUpReportDM.cshtml"
                           Write(item.Address);

#line default
#line hidden
            EndContext();
            BeginContext(5738, 43, true);
            WriteLiteral("\r\n                            </td>\r\n\r\n\r\n\r\n");
            EndContext();
#line 165 "D:\Project File\DoorBoxApp\DoorBoxApp\Views\DeliveryMen\PickUpReportDM.cshtml"
                             if (item.Weight != null)
                            {

#line default
#line hidden
            BeginContext(5867, 36, true);
            WriteLiteral("                                <td>");
            EndContext();
            BeginContext(5904, 11, false);
#line 167 "D:\Project File\DoorBoxApp\DoorBoxApp\Views\DeliveryMen\PickUpReportDM.cshtml"
                               Write(item.Weight);

#line default
#line hidden
            EndContext();
            BeginContext(5915, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 168 "D:\Project File\DoorBoxApp\DoorBoxApp\Views\DeliveryMen\PickUpReportDM.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(6018, 46, true);
            WriteLiteral("                                <td>N/A</td>\r\n");
            EndContext();
#line 172 "D:\Project File\DoorBoxApp\DoorBoxApp\Views\DeliveryMen\PickUpReportDM.cshtml"
                            }

#line default
#line hidden
            BeginContext(6095, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
#line 176 "D:\Project File\DoorBoxApp\DoorBoxApp\Views\DeliveryMen\PickUpReportDM.cshtml"
                             if (item.ProductPrice != null)
                            {

#line default
#line hidden
            BeginContext(6193, 36, true);
            WriteLiteral("                                <td>");
            EndContext();
            BeginContext(6230, 17, false);
#line 178 "D:\Project File\DoorBoxApp\DoorBoxApp\Views\DeliveryMen\PickUpReportDM.cshtml"
                               Write(item.ProductPrice);

#line default
#line hidden
            EndContext();
            BeginContext(6247, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 179 "D:\Project File\DoorBoxApp\DoorBoxApp\Views\DeliveryMen\PickUpReportDM.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(6350, 46, true);
            WriteLiteral("                                <td>N/A</td>\r\n");
            EndContext();
#line 183 "D:\Project File\DoorBoxApp\DoorBoxApp\Views\DeliveryMen\PickUpReportDM.cshtml"
                            }

#line default
#line hidden
            BeginContext(6427, 35, true);
            WriteLiteral("\r\n\r\n                        </tr>\r\n");
            EndContext();
#line 187 "D:\Project File\DoorBoxApp\DoorBoxApp\Views\DeliveryMen\PickUpReportDM.cshtml"
                        }

#line default
#line hidden
            BeginContext(6489, 122, true);
            WriteLiteral("                    </tbody>\r\n                </table>\r\n\r\n\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(6629, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(6635, 119, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "79a4d4397c77d11a689a4fd7cd5cd33a6fc5864528682", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
#line 200 "D:\Project File\DoorBoxApp\DoorBoxApp\Views\DeliveryMen\PickUpReportDM.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
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
                BeginContext(6754, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(6760, 123, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "79a4d4397c77d11a689a4fd7cd5cd33a6fc5864530846", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
#line 201 "D:\Project File\DoorBoxApp\DoorBoxApp\Views\DeliveryMen\PickUpReportDM.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(6883, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(6889, 107, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "79a4d4397c77d11a689a4fd7cd5cd33a6fc5864533010", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
#line 202 "D:\Project File\DoorBoxApp\DoorBoxApp\Views\DeliveryMen\PickUpReportDM.cshtml"
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
                BeginContext(6996, 1605, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
        $('.paymentButton').on('click', function () {
            var row = $(this).closest('tr');
            var packageId = row.find('.packageId').val();
            var dueAmount = row.find('.dueAmount').val();
            var payAmount = row.find('.paymentNew').val();

            if (eval(dueAmount) < eval(payAmount)) {
                $.notify({
                    title: 'Prompt!',
                    icon: 'fa fa-times',
                    html: true,
                    message: 'Paid amount can not be more than due amount'
                },
                    {
                        type: 'warning',
                        animate: {
                            enter: 'animated fadeInDown'
                        },
                        placement: {
                            from: ""top"",
                            align: ""center""
                        },
                        spacing: 10,
                        z_index: 1");
                WriteLiteral(@"031,
                        delay: 1000,
                        template: '<div data-notify=""container"" class=""alert alert-dismissible alert-{0} alert-notify"" role=""alert""><span class=""alert-icon"" data-notify=""icon""></span> <div class=""alert-text""</div> <span class=""alert-title"" data-notify=""title"">{1}</span> <span data-notify=""message"">{2}</span></div><button type=""button"" class=""close"" data-notify=""dismiss"" aria-label=""Close""><span aria-hidden=""true"">&times;</span></button></div>'
                    });
            }
            else {
                 var url = '");
                EndContext();
                BeginContext(8602, 36, false);
#line 233 "D:\Project File\DoorBoxApp\DoorBoxApp\Views\DeliveryMen\PickUpReportDM.cshtml"
                       Write(Url.Action("AddPayment", "Packages"));

#line default
#line hidden
                EndContext();
                BeginContext(8638, 2207, true);
                WriteLiteral(@"';
                     $.ajax({
                         type: ""POST"",
                         dataType: 'json',
                         url: url,
                         data: {
                             packageId: packageId,
                             payAmount: payAmount,

                         },
                         cache: false,
                         success: function (result) {
                             if (result) {
                                 location.reload();
                             }
                             else {
                                 $.notify({
                                     title: 'Prompt!',
                                     icon: 'fa fa-times',
                                     html: true,
                                     message: 'Something went wrong !!!'
                                 },
                                     {
                                         type: 'warning',
                   ");
                WriteLiteral(@"                      animate: {
                                             enter: 'animated fadeInDown'
                                         },
                                         placement: {
                                             from: ""top"",
                                             align: ""center""
                                         },
                                         spacing: 10,
                                         z_index: 1031,
                                         delay: 1000,
                                         template: '<div data-notify=""container"" class=""alert alert-dismissible alert-{0} alert-notify"" role=""alert""><span class=""alert-icon"" data-notify=""icon""></span> <div class=""alert-text""</div> <span class=""alert-title"" data-notify=""title"">{1}</span> <span data-notify=""message"">{2}</span></div><button type=""button"" class=""close"" data-notify=""dismiss"" aria-label=""Close""><span aria-hidden=""true"">&times;</span></button></div>'
                ");
                WriteLiteral("                     });\r\n                             }\r\n                         }\r\n\r\n                     });\r\n            }\r\n\r\n        });\r\n    </script>\r\n");
                EndContext();
#line 277 "D:\Project File\DoorBoxApp\DoorBoxApp\Views\DeliveryMen\PickUpReportDM.cshtml"
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
