#pragma checksum "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Packages\GeneratedBill.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f91e200a9f3741ee216210db4b1c5b4b84695cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Packages_GeneratedBill), @"mvc.1.0.view", @"/Views/Packages/GeneratedBill.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Packages/GeneratedBill.cshtml", typeof(AspNetCore.Views_Packages_GeneratedBill))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f91e200a9f3741ee216210db4b1c5b4b84695cd", @"/Views/Packages/GeneratedBill.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db0bb7675d3dc7f4369941d6c52fb8cf421deb36", @"/Views/_ViewImports.cshtml")]
    public class Views_Packages_GeneratedBill : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DoorBoxApp.Models.Package>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/vendor/datatable/js/jquery.dataTables.min.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/vendor/datatable/js/dataTables.bootstrap4.min.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(34, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Packages\GeneratedBill.cshtml"
  
    ViewData["Title"] = "Bill";

#line default
#line hidden
            BeginContext(76, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Css", async() => {
                BeginContext(92, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 8 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Packages\GeneratedBill.cshtml"
      await Html.RenderPartialAsync("_DataTableCssPartial");

#line default
#line hidden
            }
            );
            BeginContext(160, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("Sole", async() => {
                BeginContext(179, 631, true);
                WriteLiteral(@"
    <style>
        .topActionFallbackUrl {
            display: none;
        }

        #table_1 thead:first-child tr th:first-child {
            width: 90%
        }

        div.dt-loading {
            display: none;
        }

        .cddl-logo {
            width: 100px;
        }

        .bn-logo {
            width: 75px;
        }

        .cash-pay {
            border: 1px solid #000;
            padding: 0 5px 0 5px;
        }

        .bottom-info {
            padding-left: 10px
        }

        .received-by {
            border: 1px solid #000;
        }
    </style>
");
                EndContext();
            }
            );
            BeginContext(813, 218, true);
            WriteLiteral("\r\n<div class=\"card-body px-0 pb-2 pt-3\" id=\"main_content\">\r\n    <div class=\"col-lg-12\">\r\n        <div class=\"row justify-content-center\">\r\n            <div class=\"col-lg-3\">\r\n                <div class=\"text-center\">\r\n");
            EndContext();
            BeginContext(1117, 577, true);
            WriteLiteral(@"                </div>
            </div>
            <div class=""col-lg-6 text-center"">
                <h2 class=""h2 text-center text-uppercase mb-0 print-style5"">Door Box</h2>
                <p class=""text-center mb-0 print-style5"">(Delivers excellence)</p>
                <p class=""text-center mb-0 print-style5"">ChawkBazar, Chattogram</p>
                <h2 class=""h2 text-center text-uppercase mb-3 mt-2 print-style6 cash-pay d-inline-block"">Automated Bill</h2>
            </div>
            <div class=""col-lg-3"">
                <div class=""text-center"">
");
            EndContext();
            BeginContext(1780, 224, true);
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"container\">\r\n        <div class=\"row mx-0\">\r\n            <div class=\"col-lg-12 text-right\">\r\n                <div class=\"mt-0 mb-4\">\r\n");
            EndContext();
            BeginContext(2086, 79, true);
            WriteLiteral("                    <h5 class=\"mb-0 mt-0\" style=\"font-weight:400\">Invoice No : ");
            EndContext();
            BeginContext(2166, 36, false);
#line 76 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Packages\GeneratedBill.cshtml"
                                                                          Write(Model.PickUpRequest.RequestDate.Year);

#line default
#line hidden
            EndContext();
            BeginContext(2203, 24, false);
#line 76 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Packages\GeneratedBill.cshtml"
                                                                                                               Write(Model.ShippingDate.Month);

#line default
#line hidden
            EndContext();
            BeginContext(2228, 22, false);
#line 76 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Packages\GeneratedBill.cshtml"
                                                                                                                                        Write(Model.ShippingDate.Day);

#line default
#line hidden
            EndContext();
            BeginContext(2251, 23, false);
#line 76 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Packages\GeneratedBill.cshtml"
                                                                                                                                                               Write(Model.ShippingDate.Hour);

#line default
#line hidden
            EndContext();
            BeginContext(2275, 25, false);
#line 76 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Packages\GeneratedBill.cshtml"
                                                                                                                                                                                       Write(Model.ShippingDate.Minute);

#line default
#line hidden
            EndContext();
            BeginContext(2301, 25, false);
#line 76 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Packages\GeneratedBill.cshtml"
                                                                                                                                                                                                                 Write(Model.ShippingDate.Second);

#line default
#line hidden
            EndContext();
            BeginContext(2327, 30, false);
#line 76 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Packages\GeneratedBill.cshtml"
                                                                                                                                                                                                                                           Write(Model.ShippingDate.Millisecond);

#line default
#line hidden
            EndContext();
            BeginContext(2357, 81, true);
            WriteLiteral(" </h5>\r\n                    <h5 class=\"mb-0 mt-0\" style=\"font-weight:400\">Date : ");
            EndContext();
            BeginContext(2439, 51, false);
#line 77 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Packages\GeneratedBill.cshtml"
                                                                    Write(String.Format("{0:dd-MM-yyyy}", Model.ShippingDate));

#line default
#line hidden
            EndContext();
            BeginContext(2490, 427, true);
            WriteLiteral(@"</h5>
                </div>
            </div>
        </div>
    </div>

    <div class=""table-responsive"">
        <table id=""tabl"" class=""table align-items-center table-hover table-striped table-bordered"">
            <thead class=""thead-light"">
                <tr>
                    <th colspan=""5"">To</th>
                    <th>Taka</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 92 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Packages\GeneratedBill.cshtml"
                  
                    double? total = Model.Price + Model.ProductPrice;
                

#line default
#line hidden
            BeginContext(3027, 97, true);
            WriteLiteral("                <tr>\r\n                    <td colspan=\"5\">Pay To, <span class=\"font-weight-bold\">");
            EndContext();
            BeginContext(3125, 22, false);
#line 96 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Packages\GeneratedBill.cshtml"
                                                                      Write(Model.DeliveryMan.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3147, 83, true);
            WriteLiteral("</span></td>\r\n                    <td rowspan=\"3\" class=\"text-center align-middle\">");
            EndContext();
            BeginContext(3231, 5, false);
#line 97 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Packages\GeneratedBill.cshtml"
                                                                Write(total);

#line default
#line hidden
            EndContext();
            BeginContext(3236, 150, true);
            WriteLiteral(" BDT</td>\r\n                </tr>\r\n                <tr>\r\n                    <td colspan=\"5\" class=\"text-wrap\">Sum of , <span class=\"font-weight-bold\">");
            EndContext();
            BeginContext(3387, 15, false);
#line 100 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Packages\GeneratedBill.cshtml"
                                                                                         Write(ViewBag.InWords);

#line default
#line hidden
            EndContext();
            BeginContext(3402, 840, true);
            WriteLiteral(@" Only</span></td>
                </tr>
                <tr>
                    <td colspan=""5"" class=""text-wrap"">On account of, <span class=""font-weight-bold"">Parcel Delivary</span></td>
                </tr>
            </tbody>
            <thead class=""thead-light"">
                <tr>
                    <th colspan=""6"" class=""text-center border-bottom ac-head-title"">Bill Details</th>
                </tr>
                <tr>
                    <th>From</th>
                    <th>To</th>
                    <th>Delivary Man</th>
                    <th>Shipping Date</th>
                    <th>Particular</th>
                    <th>Taka</th>
                </tr>
            </thead>
            <tbody>

                <tr>
                    <td class=""text-center"">
                        ");
            EndContext();
            BeginContext(4243, 37, false);
#line 123 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Packages\GeneratedBill.cshtml"
                   Write(Model.PickUpRequest.LocationFrom.Name);

#line default
#line hidden
            EndContext();
            BeginContext(4280, 99, true);
            WriteLiteral("\r\n                    </td>\r\n\r\n                    <td class=\"text-wrap\">\r\n                        ");
            EndContext();
            BeginContext(4380, 21, false);
#line 127 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Packages\GeneratedBill.cshtml"
                   Write(Model.LocationTo.Name);

#line default
#line hidden
            EndContext();
            BeginContext(4401, 97, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"text-wrap\">\r\n                        ");
            EndContext();
            BeginContext(4499, 22, false);
#line 130 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Packages\GeneratedBill.cshtml"
                   Write(Model.DeliveryMan.Name);

#line default
#line hidden
            EndContext();
            BeginContext(4521, 81, true);
            WriteLiteral("\r\n\r\n                    </td>\r\n\r\n\r\n\r\n                    <td class=\"text-center\">");
            EndContext();
            BeginContext(4603, 51, false);
#line 136 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Packages\GeneratedBill.cshtml"
                                       Write(String.Format("{0:dd-MM-yyyy}", Model.ShippingDate));

#line default
#line hidden
            EndContext();
            BeginContext(4654, 164, true);
            WriteLiteral("</td>\r\n                    <td class=\"text-wrap\">\r\n                        Product Amount\r\n\r\n                    </td>\r\n                    <td class=\"text-center\">");
            EndContext();
            BeginContext(4819, 11, false);
#line 141 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Packages\GeneratedBill.cshtml"
                                       Write(Model.Price);

#line default
#line hidden
            EndContext();
            BeginContext(4830, 221, true);
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td colspan=\"4\" class=\"border-left-0 border-bottom-0\"></td>\r\n                    <td>Parcel Amount</td>\r\n                    <td class=\"text-center\">");
            EndContext();
            BeginContext(5052, 18, false);
#line 146 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Packages\GeneratedBill.cshtml"
                                       Write(Model.ProductPrice);

#line default
#line hidden
            EndContext();
            BeginContext(5070, 243, true);
            WriteLiteral("</td>\r\n                </tr>\r\n\r\n                <tr>\r\n                    <td colspan=\"4\" class=\"border-left-0 border-bottom-0\"></td>\r\n                    <td>Total Amount</td>\r\n                 \r\n\r\n                    <td class=\"text-center\">");
            EndContext();
            BeginContext(5314, 5, false);
#line 154 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Packages\GeneratedBill.cshtml"
                                       Write(total);

#line default
#line hidden
            EndContext();
            BeginContext(5319, 371, true);
            WriteLiteral(@"</td>
                </tr>


            </tbody>
        </table>
    </div>
    <div class=""container"">
        <div class=""row mx-0"">
            <div class=""col-lg-4"">
                <div class=""mt-4"">
                    <h5 class=""mb-0 mt-0"" style=""font-weight:400"">Tracking No </h5>
                    <h5 class=""mb-0 mt-0"" style=""font-weight:400""> ");
            EndContext();
            BeginContext(5691, 20, false);
#line 166 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Packages\GeneratedBill.cshtml"
                                                              Write(Model.TrackingNumber);

#line default
#line hidden
            EndContext();
            BeginContext(5711, 274, true);
            WriteLiteral(@"</h5>
                </div>
            </div>
            <div class=""col-lg-4"">
                <div class=""mt-4"">
                    <h5 class=""mb-0 mt-0"" style=""font-weight:400"">Request Date</h5>
                    <h5 class=""mb-0 mt-0"" style=""font-weight:400"">");
            EndContext();
            BeginContext(5986, 64, false);
#line 172 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Packages\GeneratedBill.cshtml"
                                                             Write(String.Format("{0:dd-MM-yyyy}", Model.PickUpRequest.RequestDate));

#line default
#line hidden
            EndContext();
            BeginContext(6050, 1373, true);
            WriteLiteral(@"</h5>
                </div>
            </div>
            <div class=""col-lg-4"">
                <div class=""mt-4 text-center"">
                    <div class=""received-by"">
                        <h5 class=""mb-0 mt-0"" style=""font-weight:400"">Received By:</h5>
                        <h5 class=""mb-1 mt-5"" style=""font-weight:400"">Signature</h5>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""container mt-6"">
        <div class=""row mx-0"">
            <div class=""col-lg-4"">
                <div class=""mt-4 text-left"">
                    <h4 class=""mb-0"" style=""font-weight:400"">Delivary Man</h4>
                </div>
            </div>
          
            <div class=""col-lg-4"">
                <div class=""mt-4 text-center"">
                    <h4 class=""mb-0"" style=""font-weight:400"">Admin</h4>
                </div>
            </div>
            <div class=""col-lg-4"">
                <div class=""mt-4 text-right"">");
            WriteLiteral(@"
                    <h4 class=""mb-0"" style=""font-weight:400"">Marchent</h4>
                </div>
            </div>
        </div>
    </div>


</div>
<div class=""col-lg-12"">
    <div class=""text-center my-3"">
        <button class=""btn btn-info"" onclick=""pop_print()""><i class=""fa fa-print mr-2""></i>Print</button>
    </div>
</div>
");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(7441, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(7447, 119, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f91e200a9f3741ee216210db4b1c5b4b84695cd20913", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
#line 214 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Packages\GeneratedBill.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(7566, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(7572, 123, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f91e200a9f3741ee216210db4b1c5b4b84695cd23084", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
#line 215 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Packages\GeneratedBill.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(7695, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
#line 217 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Packages\GeneratedBill.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DoorBoxApp.Models.Package> Html { get; private set; }
    }
}
#pragma warning restore 1591
