#pragma checksum "C:\Users\Diviya & Naimul\Desktop\DroopBox\DoorBoxApp\Views\Merchants\AdminPackagePayment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1fdc19e24f31932dd3cfe0d6558154ff81103c7d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Merchants_AdminPackagePayment), @"mvc.1.0.view", @"/Views/Merchants/AdminPackagePayment.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Merchants/AdminPackagePayment.cshtml", typeof(AspNetCore.Views_Merchants_AdminPackagePayment))]
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
#line 1 "C:\Users\Diviya & Naimul\Desktop\DroopBox\DoorBoxApp\Views\_ViewImports.cshtml"
using DoorBoxApp;

#line default
#line hidden
#line 2 "C:\Users\Diviya & Naimul\Desktop\DroopBox\DoorBoxApp\Views\_ViewImports.cshtml"
using DoorBoxApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fdc19e24f31932dd3cfe0d6558154ff81103c7d", @"/Views/Merchants/AdminPackagePayment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db0bb7675d3dc7f4369941d6c52fb8cf421deb36", @"/Views/_ViewImports.cshtml")]
    public class Views_Merchants_AdminPackagePayment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DoorBoxApp.Models.Package>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PackagePaymentMerchant", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Merchants", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/vendor/datatable/js/jquery.dataTables.min.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/vendor/datatable/js/dataTables.bootstrap4.min.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(49, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Diviya & Naimul\Desktop\DroopBox\DoorBoxApp\Views\Merchants\AdminPackagePayment.cshtml"
  
    ViewData["Title"] = "Package Payment";

#line default
#line hidden
            BeginContext(102, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Css", async() => {
                BeginContext(118, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 9 "C:\Users\Diviya & Naimul\Desktop\DroopBox\DoorBoxApp\Views\Merchants\AdminPackagePayment.cshtml"
      await Html.RenderPartialAsync("_DataTableCssPartial");

#line default
#line hidden
            }
            );
            BeginContext(186, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Sole", async() => {
                BeginContext(203, 246, true);
                WriteLiteral("\r\n    <style>\r\n\r\n\r\n        .table tr th:last-child {\r\n            width: 100px;\r\n        }\r\n\r\n        .table tr th {\r\n            text-align: center;\r\n        }\r\n\r\n        .table tr td {\r\n            text-align: center;\r\n        }\r\n    </style>\r\n");
                EndContext();
            }
            );
            BeginContext(452, 1904, true);
            WriteLiteral(@"
<div class=""container-fluid mt-4"">
    <div class=""card animated fadeIn overflow-hidden"">
        <div class=""card-header p-3"">
            <div class=""row align-items-center"">
                <div class=""col"">
                    <h3 class=""mb-0 skewed skewed-yellow  d-inline-block text-uppercase ls-1 text-white"">Package Payment</h3>
                </div>

            </div>
        </div>
        <div class=""card-body px-0 pb-2"">
            <div class=""table-responsive"">

                <table class=""table align-items-center table-responsive-sm table-striped table-bordered"" id=""datatable-basic"">
                    <thead class=""thead-light"">
                        <tr>
                            <th>
                                Merchant
                            </th>
                            <th>
                                From
                            </th>
                            <th>
                                To
                            </th>");
            WriteLiteral(@"
                            <th>
                                To Sub
                            </th>
                            <th>
                                Product Price
                            </th>
                            <th>
                                Delivery Charge
                            </th>

                            <th>
                                Payable
                            </th>

                            <th>
                                Paid
                            </th>
                            <th>
                                Due
                            </th>
                            <th>
                                Pay to Merchant
                            </th>
                        </tr>
                    </thead>
                    <tbody>
");
            EndContext();
#line 81 "C:\Users\Diviya & Naimul\Desktop\DroopBox\DoorBoxApp\Views\Merchants\AdminPackagePayment.cshtml"
                         foreach (var item in Model)
                        {
                            double payable = 0;

#line default
#line hidden
            BeginContext(2486, 34, true);
            WriteLiteral("                            <tr>\r\n");
            EndContext();
#line 85 "C:\Users\Diviya & Naimul\Desktop\DroopBox\DoorBoxApp\Views\Merchants\AdminPackagePayment.cshtml"
                                 if (item.PickUpRequest.Merchant != null)
                                {

#line default
#line hidden
            BeginContext(2630, 120, true);
            WriteLiteral("                                    <td>\r\n                                        <input type=\"hidden\" class=\"packageId\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2750, "\"", 2766, 1);
#line 88 "C:\Users\Diviya & Naimul\Desktop\DroopBox\DoorBoxApp\Views\Merchants\AdminPackagePayment.cshtml"
WriteAttributeValue("", 2758, item.Id, 2758, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2767, 45, true);
            WriteLiteral(" />\r\n                                        ");
            EndContext();
            BeginContext(2812, 159, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1fdc19e24f31932dd3cfe0d6558154ff81103c7d10102", async() => {
                BeginContext(2932, 2, true);
                WriteLiteral("  ");
                EndContext();
                BeginContext(2935, 32, false);
#line 89 "C:\Users\Diviya & Naimul\Desktop\DroopBox\DoorBoxApp\Views\Merchants\AdminPackagePayment.cshtml"
                                                                                                                                                             Write(item.PickUpRequest.Merchant.Name);

#line default
#line hidden
                EndContext();
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-merchantId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 89 "C:\Users\Diviya & Naimul\Desktop\DroopBox\DoorBoxApp\Views\Merchants\AdminPackagePayment.cshtml"
                                                                                                                    WriteLiteral(item.PickUpRequest.MerchantId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["merchantId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-merchantId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["merchantId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2971, 47, true);
            WriteLiteral("\r\n\r\n                                    </td>\r\n");
            EndContext();
#line 92 "C:\Users\Diviya & Naimul\Desktop\DroopBox\DoorBoxApp\Views\Merchants\AdminPackagePayment.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(3126, 134, true);
            WriteLiteral("                                    <td>\r\n                                        No Data\r\n                                    </td>\r\n");
            EndContext();
#line 98 "C:\Users\Diviya & Naimul\Desktop\DroopBox\DoorBoxApp\Views\Merchants\AdminPackagePayment.cshtml"
                                }

#line default
#line hidden
            BeginContext(3295, 74, true);
            WriteLiteral("                                <td>\r\n                                    ");
            EndContext();
            BeginContext(3370, 36, false);
#line 100 "C:\Users\Diviya & Naimul\Desktop\DroopBox\DoorBoxApp\Views\Merchants\AdminPackagePayment.cshtml"
                               Write(item.PickUpRequest.LocationFrom.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3406, 41, true);
            WriteLiteral("\r\n                                </td>\r\n");
            EndContext();
#line 102 "C:\Users\Diviya & Naimul\Desktop\DroopBox\DoorBoxApp\Views\Merchants\AdminPackagePayment.cshtml"
                                 if (item.LocationTo != null)
                                {

#line default
#line hidden
            BeginContext(3545, 82, true);
            WriteLiteral("                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(3628, 20, false);
#line 105 "C:\Users\Diviya & Naimul\Desktop\DroopBox\DoorBoxApp\Views\Merchants\AdminPackagePayment.cshtml"
                                   Write(item.LocationTo.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3648, 45, true);
            WriteLiteral("\r\n                                    </td>\r\n");
            EndContext();
#line 107 "C:\Users\Diviya & Naimul\Desktop\DroopBox\DoorBoxApp\Views\Merchants\AdminPackagePayment.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(3801, 134, true);
            WriteLiteral("                                    <td>\r\n                                        No Data\r\n                                    </td>\r\n");
            EndContext();
#line 113 "C:\Users\Diviya & Naimul\Desktop\DroopBox\DoorBoxApp\Views\Merchants\AdminPackagePayment.cshtml"
                                }

#line default
#line hidden
            BeginContext(3970, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 115 "C:\Users\Diviya & Naimul\Desktop\DroopBox\DoorBoxApp\Views\Merchants\AdminPackagePayment.cshtml"
                                 if (item.SubLocation != null)
                                {

#line default
#line hidden
            BeginContext(4071, 82, true);
            WriteLiteral("                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(4154, 21, false);
#line 118 "C:\Users\Diviya & Naimul\Desktop\DroopBox\DoorBoxApp\Views\Merchants\AdminPackagePayment.cshtml"
                                   Write(item.SubLocation.Name);

#line default
#line hidden
            EndContext();
            BeginContext(4175, 45, true);
            WriteLiteral("\r\n                                    </td>\r\n");
            EndContext();
#line 120 "C:\Users\Diviya & Naimul\Desktop\DroopBox\DoorBoxApp\Views\Merchants\AdminPackagePayment.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(4328, 134, true);
            WriteLiteral("                                    <td>\r\n                                        No Data\r\n                                    </td>\r\n");
            EndContext();
#line 126 "C:\Users\Diviya & Naimul\Desktop\DroopBox\DoorBoxApp\Views\Merchants\AdminPackagePayment.cshtml"
                                }

#line default
#line hidden
#line 127 "C:\Users\Diviya & Naimul\Desktop\DroopBox\DoorBoxApp\Views\Merchants\AdminPackagePayment.cshtml"
                                 if (item.ProductPrice != null)
                                {


#line default
#line hidden
            BeginContext(4599, 82, true);
            WriteLiteral("                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(4682, 17, false);
#line 131 "C:\Users\Diviya & Naimul\Desktop\DroopBox\DoorBoxApp\Views\Merchants\AdminPackagePayment.cshtml"
                                   Write(item.ProductPrice);

#line default
#line hidden
            EndContext();
            BeginContext(4699, 45, true);
            WriteLiteral("\r\n                                    </td>\r\n");
            EndContext();
#line 133 "C:\Users\Diviya & Naimul\Desktop\DroopBox\DoorBoxApp\Views\Merchants\AdminPackagePayment.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(4852, 128, true);
            WriteLiteral("                                    <td>\r\n                                        0\r\n                                    </td>\r\n");
            EndContext();
#line 139 "C:\Users\Diviya & Naimul\Desktop\DroopBox\DoorBoxApp\Views\Merchants\AdminPackagePayment.cshtml"
                                }

#line default
#line hidden
            BeginContext(5015, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 142 "C:\Users\Diviya & Naimul\Desktop\DroopBox\DoorBoxApp\Views\Merchants\AdminPackagePayment.cshtml"
                                 if (item.Price != null)
                                {


#line default
#line hidden
            BeginContext(5114, 82, true);
            WriteLiteral("                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(5197, 10, false);
#line 146 "C:\Users\Diviya & Naimul\Desktop\DroopBox\DoorBoxApp\Views\Merchants\AdminPackagePayment.cshtml"
                                   Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(5207, 45, true);
            WriteLiteral("\r\n                                    </td>\r\n");
            EndContext();
#line 148 "C:\Users\Diviya & Naimul\Desktop\DroopBox\DoorBoxApp\Views\Merchants\AdminPackagePayment.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(5360, 128, true);
            WriteLiteral("                                    <td>\r\n                                        0\r\n                                    </td>\r\n");
            EndContext();
#line 154 "C:\Users\Diviya & Naimul\Desktop\DroopBox\DoorBoxApp\Views\Merchants\AdminPackagePayment.cshtml"
                                }

#line default
#line hidden
#line 155 "C:\Users\Diviya & Naimul\Desktop\DroopBox\DoorBoxApp\Views\Merchants\AdminPackagePayment.cshtml"
                                 if (item.ProductPrice != null)
                                {
                                    payable = (double)(item.ProductPrice - item.Price);

#line default
#line hidden
            BeginContext(5712, 82, true);
            WriteLiteral("                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(5795, 7, false);
#line 159 "C:\Users\Diviya & Naimul\Desktop\DroopBox\DoorBoxApp\Views\Merchants\AdminPackagePayment.cshtml"
                                   Write(payable);

#line default
#line hidden
            EndContext();
            BeginContext(5802, 45, true);
            WriteLiteral("\r\n                                    </td>\r\n");
            EndContext();
#line 161 "C:\Users\Diviya & Naimul\Desktop\DroopBox\DoorBoxApp\Views\Merchants\AdminPackagePayment.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(5955, 128, true);
            WriteLiteral("                                    <td>\r\n                                        0\r\n                                    </td>\r\n");
            EndContext();
#line 167 "C:\Users\Diviya & Naimul\Desktop\DroopBox\DoorBoxApp\Views\Merchants\AdminPackagePayment.cshtml"
                                }

#line default
#line hidden
            BeginContext(6118, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 169 "C:\Users\Diviya & Naimul\Desktop\DroopBox\DoorBoxApp\Views\Merchants\AdminPackagePayment.cshtml"
                                 if (item.PaidAmount != null)
                                {

#line default
#line hidden
            BeginContext(6218, 82, true);
            WriteLiteral("                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(6301, 15, false);
#line 172 "C:\Users\Diviya & Naimul\Desktop\DroopBox\DoorBoxApp\Views\Merchants\AdminPackagePayment.cshtml"
                                   Write(item.PaidAmount);

#line default
#line hidden
            EndContext();
            BeginContext(6316, 45, true);
            WriteLiteral("\r\n                                    </td>\r\n");
            EndContext();
#line 174 "C:\Users\Diviya & Naimul\Desktop\DroopBox\DoorBoxApp\Views\Merchants\AdminPackagePayment.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(6469, 128, true);
            WriteLiteral("                                    <td>\r\n                                        0\r\n                                    </td>\r\n");
            EndContext();
#line 180 "C:\Users\Diviya & Naimul\Desktop\DroopBox\DoorBoxApp\Views\Merchants\AdminPackagePayment.cshtml"
                                }

#line default
#line hidden
#line 181 "C:\Users\Diviya & Naimul\Desktop\DroopBox\DoorBoxApp\Views\Merchants\AdminPackagePayment.cshtml"
                                 if (item.MerchantPaid)
                                {

#line default
#line hidden
            BeginContext(6724, 264, true);
            WriteLiteral(@"                                    <td>
                                        No Due
                                    </td>
                                    <td>
                                        Paid
                                    </td>
");
            EndContext();
#line 189 "C:\Users\Diviya & Naimul\Desktop\DroopBox\DoorBoxApp\Views\Merchants\AdminPackagePayment.cshtml"
                                }
                                else if (item.PaidAmount == 0 || item.PaidAmount == null)
                                {


#line default
#line hidden
            BeginContext(7151, 82, true);
            WriteLiteral("                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(7234, 7, false);
#line 194 "C:\Users\Diviya & Naimul\Desktop\DroopBox\DoorBoxApp\Views\Merchants\AdminPackagePayment.cshtml"
                                   Write(payable);

#line default
#line hidden
            EndContext();
            BeginContext(7241, 101, true);
            WriteLiteral("\r\n                                        <input disabled type=\"hidden\" class=\"dueAmount\" name=\"name\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 7342, "\"", 7358, 1);
#line 195 "C:\Users\Diviya & Naimul\Desktop\DroopBox\DoorBoxApp\Views\Merchants\AdminPackagePayment.cshtml"
WriteAttributeValue("", 7350, payable, 7350, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(7359, 244, true);
            WriteLiteral(" />\r\n                                    </td>\r\n                                    <td>\r\n                                        <input disabled class=\"form-control phoneNo border-0 border-radius-0 text-center text-wrap paidAmount\" type=\"text\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 7603, "\"", 7619, 1);
#line 198 "C:\Users\Diviya & Naimul\Desktop\DroopBox\DoorBoxApp\Views\Merchants\AdminPackagePayment.cshtml"
WriteAttributeValue("", 7611, payable, 7611, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(7620, 48, true);
            WriteLiteral(" />\r\n                                    </td>\r\n");
            EndContext();
#line 200 "C:\Users\Diviya & Naimul\Desktop\DroopBox\DoorBoxApp\Views\Merchants\AdminPackagePayment.cshtml"
                                }

#line default
#line hidden
            BeginContext(7703, 37, true);
            WriteLiteral("\r\n                            </tr>\r\n");
            EndContext();
#line 203 "C:\Users\Diviya & Naimul\Desktop\DroopBox\DoorBoxApp\Views\Merchants\AdminPackagePayment.cshtml"
                        }

#line default
#line hidden
            BeginContext(7767, 122, true);
            WriteLiteral("                    </tbody>\r\n                </table>\r\n\r\n\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(7907, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(7913, 119, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1fdc19e24f31932dd3cfe0d6558154ff81103c7d27554", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
#line 216 "C:\Users\Diviya & Naimul\Desktop\DroopBox\DoorBoxApp\Views\Merchants\AdminPackagePayment.cshtml"
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
                BeginContext(8032, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(8038, 123, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1fdc19e24f31932dd3cfe0d6558154ff81103c7d29736", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
#line 217 "C:\Users\Diviya & Naimul\Desktop\DroopBox\DoorBoxApp\Views\Merchants\AdminPackagePayment.cshtml"
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
                BeginContext(8161, 54, true);
                WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n    </script>\r\n");
                EndContext();
#line 220 "C:\Users\Diviya & Naimul\Desktop\DroopBox\DoorBoxApp\Views\Merchants\AdminPackagePayment.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DoorBoxApp.Models.Package>> Html { get; private set; }
    }
}
#pragma warning restore 1591
