#pragma checksum "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Merchants\PackagePayment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b3e18077e58bd969e79c746857d9887365014d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Merchants_PackagePayment), @"mvc.1.0.view", @"/Views/Merchants/PackagePayment.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Merchants/PackagePayment.cshtml", typeof(AspNetCore.Views_Merchants_PackagePayment))]
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
#line 1 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\_ViewImports.cshtml"
using DoorBoxApp;

#line default
#line hidden
#line 2 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\_ViewImports.cshtml"
using DoorBoxApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b3e18077e58bd969e79c746857d9887365014d4", @"/Views/Merchants/PackagePayment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db0bb7675d3dc7f4369941d6c52fb8cf421deb36", @"/Views/_ViewImports.cshtml")]
    public class Views_Merchants_PackagePayment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DoorBoxApp.Models.Package>>
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
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Merchants\PackagePayment.cshtml"
  
    ViewData["Title"] = "Package Payment";

#line default
#line hidden
            BeginContext(100, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Css", async() => {
                BeginContext(116, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 8 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Merchants\PackagePayment.cshtml"
      await Html.RenderPartialAsync("_DataTableCssPartial");

#line default
#line hidden
            }
            );
            BeginContext(184, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Sole", async() => {
                BeginContext(201, 246, true);
                WriteLiteral("\r\n    <style>\r\n\r\n\r\n        .table tr th:last-child {\r\n            width: 100px;\r\n        }\r\n\r\n        .table tr th {\r\n            text-align: center;\r\n        }\r\n\r\n        .table tr td {\r\n            text-align: center;\r\n        }\r\n    </style>\r\n");
                EndContext();
            }
            );
            BeginContext(450, 2033, true);
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
                            <th class=""text-center"">
                                Action
                            </th>
                        </tr>
                    </thead>
                    <tbody>
");
            EndContext();
#line 83 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Merchants\PackagePayment.cshtml"
                         foreach (var item in Model)
                        {
                            double payable = 0;

#line default
#line hidden
            BeginContext(2613, 30, true);
            WriteLiteral("                        <tr>\r\n");
            EndContext();
#line 87 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Merchants\PackagePayment.cshtml"
                             if (item.PickUpRequest.Merchant != null)
                            {

#line default
#line hidden
            BeginContext(2745, 112, true);
            WriteLiteral("                                <td>\r\n                                    <input type=\"hidden\" class=\"packageId\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2857, "\"", 2873, 1);
#line 90 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Merchants\PackagePayment.cshtml"
WriteAttributeValue("", 2865, item.Id, 2865, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2874, 41, true);
            WriteLiteral(" />\r\n                                    ");
            EndContext();
            BeginContext(2915, 159, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b3e18077e58bd969e79c746857d9887365014d410016", async() => {
                BeginContext(3035, 2, true);
                WriteLiteral("  ");
                EndContext();
                BeginContext(3038, 32, false);
#line 91 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Merchants\PackagePayment.cshtml"
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
#line 91 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Merchants\PackagePayment.cshtml"
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
            BeginContext(3074, 43, true);
            WriteLiteral("\r\n\r\n                                </td>\r\n");
            EndContext();
#line 94 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Merchants\PackagePayment.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(3213, 122, true);
            WriteLiteral("                                <td>\r\n                                    No Data\r\n                                </td>\r\n");
            EndContext();
#line 100 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Merchants\PackagePayment.cshtml"
                            }

#line default
#line hidden
            BeginContext(3366, 66, true);
            WriteLiteral("                            <td>\r\n                                ");
            EndContext();
            BeginContext(3433, 36, false);
#line 102 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Merchants\PackagePayment.cshtml"
                           Write(item.PickUpRequest.LocationFrom.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3469, 37, true);
            WriteLiteral("\r\n                            </td>\r\n");
            EndContext();
#line 104 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Merchants\PackagePayment.cshtml"
                             if (item.LocationTo != null)
                            {

#line default
#line hidden
            BeginContext(3596, 74, true);
            WriteLiteral("                                <td>\r\n                                    ");
            EndContext();
            BeginContext(3671, 20, false);
#line 107 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Merchants\PackagePayment.cshtml"
                               Write(item.LocationTo.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3691, 41, true);
            WriteLiteral("\r\n                                </td>\r\n");
            EndContext();
#line 109 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Merchants\PackagePayment.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(3828, 122, true);
            WriteLiteral("                                <td>\r\n                                    No Data\r\n                                </td>\r\n");
            EndContext();
#line 115 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Merchants\PackagePayment.cshtml"
                            }

#line default
#line hidden
            BeginContext(3981, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 117 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Merchants\PackagePayment.cshtml"
                             if (item.SubLocation != null)
                            {

#line default
#line hidden
            BeginContext(4074, 74, true);
            WriteLiteral("                                <td>\r\n                                    ");
            EndContext();
            BeginContext(4149, 21, false);
#line 120 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Merchants\PackagePayment.cshtml"
                               Write(item.SubLocation.Name);

#line default
#line hidden
            EndContext();
            BeginContext(4170, 41, true);
            WriteLiteral("\r\n                                </td>\r\n");
            EndContext();
#line 122 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Merchants\PackagePayment.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(4307, 122, true);
            WriteLiteral("                                <td>\r\n                                    No Data\r\n                                </td>\r\n");
            EndContext();
#line 128 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Merchants\PackagePayment.cshtml"
                            }

#line default
#line hidden
#line 129 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Merchants\PackagePayment.cshtml"
                             if (item.ProductPrice != null)
                            {


#line default
#line hidden
            BeginContext(4554, 74, true);
            WriteLiteral("                                <td>\r\n                                    ");
            EndContext();
            BeginContext(4629, 17, false);
#line 133 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Merchants\PackagePayment.cshtml"
                               Write(item.ProductPrice);

#line default
#line hidden
            EndContext();
            BeginContext(4646, 41, true);
            WriteLiteral("\r\n                                </td>\r\n");
            EndContext();
#line 135 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Merchants\PackagePayment.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(4783, 116, true);
            WriteLiteral("                                <td>\r\n                                    0\r\n                                </td>\r\n");
            EndContext();
#line 141 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Merchants\PackagePayment.cshtml"
                            }

#line default
#line hidden
            BeginContext(4930, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 144 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Merchants\PackagePayment.cshtml"
                             if (item.Price != null)
                            {


#line default
#line hidden
            BeginContext(5021, 74, true);
            WriteLiteral("                                <td>\r\n                                    ");
            EndContext();
            BeginContext(5096, 10, false);
#line 148 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Merchants\PackagePayment.cshtml"
                               Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(5106, 41, true);
            WriteLiteral("\r\n                                </td>\r\n");
            EndContext();
#line 150 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Merchants\PackagePayment.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(5243, 116, true);
            WriteLiteral("                                <td>\r\n                                    0\r\n                                </td>\r\n");
            EndContext();
#line 156 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Merchants\PackagePayment.cshtml"
                            }

#line default
#line hidden
#line 157 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Merchants\PackagePayment.cshtml"
                             if (item.ProductPrice != null)
                            {
                                payable = (double)(item.ProductPrice - item.Price);

#line default
#line hidden
            BeginContext(5567, 74, true);
            WriteLiteral("                                <td>\r\n                                    ");
            EndContext();
            BeginContext(5642, 7, false);
#line 161 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Merchants\PackagePayment.cshtml"
                               Write(payable);

#line default
#line hidden
            EndContext();
            BeginContext(5649, 41, true);
            WriteLiteral("\r\n                                </td>\r\n");
            EndContext();
#line 163 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Merchants\PackagePayment.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(5786, 116, true);
            WriteLiteral("                                <td>\r\n                                    0\r\n                                </td>\r\n");
            EndContext();
#line 169 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Merchants\PackagePayment.cshtml"
                            }

#line default
#line hidden
            BeginContext(5933, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 171 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Merchants\PackagePayment.cshtml"
                             if (item.PaidAmount != null)
                            {
                                

#line default
#line hidden
            BeginContext(6268, 74, true);
            WriteLiteral("                                <td>\r\n                                    ");
            EndContext();
            BeginContext(6343, 15, false);
#line 177 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Merchants\PackagePayment.cshtml"
                               Write(item.PaidAmount);

#line default
#line hidden
            EndContext();
            BeginContext(6358, 41, true);
            WriteLiteral("\r\n                                </td>\r\n");
            EndContext();
#line 179 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Merchants\PackagePayment.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(6495, 116, true);
            WriteLiteral("                                <td>\r\n                                    0\r\n                                </td>\r\n");
            EndContext();
#line 185 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Merchants\PackagePayment.cshtml"
                            }

#line default
#line hidden
#line 186 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Merchants\PackagePayment.cshtml"
                             if (item.MerchantPaid)
                            {

#line default
#line hidden
            BeginContext(6726, 559, true);
            WriteLiteral(@"                                <td>
                                    No Due
                                </td>
                                <td>
                                    N/A
                                </td>
                                <td class=""text-center"">
                                    <div class=""btn-group"">
                                        <input disabled class=""btn btn-success btn-sm"" type=""button"" value=""Paid"" />
                                    </div>
                                </td>
");
            EndContext();
#line 199 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Merchants\PackagePayment.cshtml"
                            }
                            else if (item.PaidAmount == 0 || item.PaidAmount == null)
                            {


#line default
#line hidden
            BeginContext(7436, 74, true);
            WriteLiteral("                                <td>\r\n                                    ");
            EndContext();
            BeginContext(7511, 7, false);
#line 204 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Merchants\PackagePayment.cshtml"
                               Write(payable);

#line default
#line hidden
            EndContext();
            BeginContext(7518, 88, true);
            WriteLiteral("\r\n                                    <input type=\"hidden\" class=\"dueAmount\" name=\"name\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 7606, "\"", 7622, 1);
#line 205 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Merchants\PackagePayment.cshtml"
WriteAttributeValue("", 7614, payable, 7614, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(7623, 223, true);
            WriteLiteral(" />\r\n                                </td>\r\n                                <td>\r\n                                    <input class=\"form-control phoneNo border-0 border-radius-0 text-center text-wrap paidAmount\" type=\"text\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 7846, "\"", 7862, 1);
#line 208 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Merchants\PackagePayment.cshtml"
WriteAttributeValue("", 7854, payable, 7854, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(7863, 44, true);
            WriteLiteral(" />\r\n                                </td>\r\n");
            EndContext();
            BeginContext(7909, 322, true);
            WriteLiteral(@"                                <td class=""text-center"">
                                    <div class=""btn-group"">
                                        <input class=""btn btn-success btn-sm saveButton"" type=""button"" value=""Save"" />
                                    </div>
                                </td>
");
            EndContext();
#line 216 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Merchants\PackagePayment.cshtml"


                            }
                            else if (item.PaidAmount < payable)
                            {
                                double due = (double)(payable - item.PaidAmount);


#line default
#line hidden
            BeginContext(8447, 124, true);
            WriteLiteral("                                <td>\r\n                                    <input type=\"hidden\" class=\"dueAmount\" name=\"name\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 8571, "\"", 8583, 1);
#line 224 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Merchants\PackagePayment.cshtml"
WriteAttributeValue("", 8579, due, 8579, 4, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(8584, 41, true);
            WriteLiteral(" />\r\n                                    ");
            EndContext();
            BeginContext(8626, 3, false);
#line 225 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Merchants\PackagePayment.cshtml"
                               Write(due);

#line default
#line hidden
            EndContext();
            BeginContext(8629, 220, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    <input class=\"form-control phoneNo border-0 border-radius-0 text-center text-wrap paidAmount\" type=\"text\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 8849, "\"", 8862, 1);
#line 228 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Merchants\PackagePayment.cshtml"
WriteAttributeValue(" ", 8857, due, 8858, 4, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(8863, 44, true);
            WriteLiteral(" />\r\n                                </td>\r\n");
            EndContext();
            BeginContext(8909, 322, true);
            WriteLiteral(@"                                <td class=""text-center"">
                                    <div class=""btn-group"">
                                        <input class=""btn btn-success btn-sm saveButton"" type=""button"" value=""Save"" />
                                    </div>
                                </td>
");
            EndContext();
#line 236 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Merchants\PackagePayment.cshtml"

                            }
                            else
                            {

#line default
#line hidden
            BeginContext(9329, 559, true);
            WriteLiteral(@"                                <td>
                                    No Due
                                </td>
                                <td>
                                    N/A
                                </td>
                                <td class=""text-center"">
                                    <div class=""btn-group"">
                                        <input disabled class=""btn btn-success btn-sm"" type=""button"" value=""Paid"" />
                                    </div>
                                </td>
");
            EndContext();
#line 251 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Merchants\PackagePayment.cshtml"

                            }

#line default
#line hidden
            BeginContext(9921, 33, true);
            WriteLiteral("\r\n                        </tr>\r\n");
            EndContext();
#line 255 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Merchants\PackagePayment.cshtml"
                        }

#line default
#line hidden
            BeginContext(9981, 116, true);
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(10115, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(10121, 119, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b3e18077e58bd969e79c746857d9887365014d430838", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
#line 265 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Merchants\PackagePayment.cshtml"
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
                BeginContext(10240, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(10246, 123, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b3e18077e58bd969e79c746857d9887365014d433013", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
#line 266 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Merchants\PackagePayment.cshtml"
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
                BeginContext(10369, 1898, true);
                WriteLiteral(@"
    <script type=""text/javascript"">

        $(document).ready(function () {
            $('.saveButton').on('click', function () {

                var row = $(this).closest('tr');
                var paidAmount = row.find('.paidAmount').val();
                var dueAmount = row.find('.dueAmount').val();
                var packageId = row.find('.packageId').val();

                if (paidAmount == """" || paidAmount == null || (eval(dueAmount) < eval(paidAmount))) {

                         $.notify({
                             title: 'Prompt!',
                             icon: 'fa fa-times',
                             html: true,
                             message: 'Fill Up Amount Correctly !!!'
                         },
                             {
                                 type: 'warning',
                                 animate: {
                                     enter: 'animated fadeInDown'
                                 },
                           ");
                WriteLiteral(@"      placement: {
                                     from: ""top"",
                                     align: ""center""
                                 },
                                 spacing: 10,
                                 z_index: 1031,
                                 delay: 1000,
                                 template: '<div data-notify=""container"" class=""alert alert-dismissible alert-{0} alert-notify"" role=""alert""><span class=""alert-icon"" data-notify=""icon""></span> <div class=""alert-text""</div> <span class=""alert-title"" data-notify=""title"">{1}</span> <span data-notify=""message"">{2}</span></div><button type=""button"" class=""close"" data-notify=""dismiss"" aria-label=""Close""><span aria-hidden=""true"">&times;</span></button></div>'
                             });
                 }
                 else {
                     var url = '");
                EndContext();
                BeginContext(12268, 44, false);
#line 301 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Merchants\PackagePayment.cshtml"
                           Write(Url.Action("SavePackagePayment", "Packages"));

#line default
#line hidden
                EndContext();
                BeginContext(12312, 593, true);
                WriteLiteral(@"';
                     $.ajax({
                         type: ""POST"",
                         dataType: 'json',
                         url: url,
                         data: {
                             packageId: packageId,
                             paidAmount: paidAmount,
                         },
                         cache: false,
                         success: function (result) {
                             location.reload();
                         }

                     });

                 }

            });
        });
    </script>
");
                EndContext();
#line 322 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Merchants\PackagePayment.cshtml"
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
