#pragma checksum "D:\Project File\DoorBoxApp\DoorBoxApp\Views\DeliveryMen\AdminPickupPaymentFixed.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "148400bcd64f0f5504f99a91cf9f24ff64c7d40d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DeliveryMen_AdminPickupPaymentFixed), @"mvc.1.0.view", @"/Views/DeliveryMen/AdminPickupPaymentFixed.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DeliveryMen/AdminPickupPaymentFixed.cshtml", typeof(AspNetCore.Views_DeliveryMen_AdminPickupPaymentFixed))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"148400bcd64f0f5504f99a91cf9f24ff64c7d40d", @"/Views/DeliveryMen/AdminPickupPaymentFixed.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db0bb7675d3dc7f4369941d6c52fb8cf421deb36", @"/Views/_ViewImports.cshtml")]
    public class Views_DeliveryMen_AdminPickupPaymentFixed : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DoorBoxApp.Models.PickUpRequest>>
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
            BeginContext(53, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Project File\DoorBoxApp\DoorBoxApp\Views\DeliveryMen\AdminPickupPaymentFixed.cshtml"
  
    ViewData["Title"] = "Pickup Payment";

#line default
#line hidden
            BeginContext(105, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Css", async() => {
                BeginContext(121, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 8 "D:\Project File\DoorBoxApp\DoorBoxApp\Views\DeliveryMen\AdminPickupPaymentFixed.cshtml"
      await Html.RenderPartialAsync("_DataTableCssPartial");

#line default
#line hidden
            }
            );
            BeginContext(189, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Sole", async() => {
                BeginContext(206, 246, true);
                WriteLiteral("\r\n    <style>\r\n\r\n\r\n        .table tr th:last-child {\r\n            width: 100px;\r\n        }\r\n\r\n        .table tr th {\r\n            text-align: center;\r\n        }\r\n\r\n        .table tr td {\r\n            text-align: center;\r\n        }\r\n    </style>\r\n");
                EndContext();
            }
            );
            BeginContext(455, 340, true);
            WriteLiteral(@"
<div class=""container-fluid mt-4"">
    <div class=""card animated fadeIn overflow-hidden"">
        <div class=""card-header p-3"">
            <div class=""row align-items-center"">
                <div class=""col"">
                    <h3 class=""mb-0 skewed skewed-yellow  d-inline-block text-uppercase ls-1 text-white"">Pickup Payment : ");
            EndContext();
            BeginContext(796, 24, false);
#line 34 "D:\Project File\DoorBoxApp\DoorBoxApp\Views\DeliveryMen\AdminPickupPaymentFixed.cshtml"
                                                                                                                     Write(ViewBag.DeliveryMan.Name);

#line default
#line hidden
            EndContext();
            BeginContext(820, 893, true);
            WriteLiteral(@"</h3>
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
                                Address
                            </th>

                            <th>
                                Pay
                            </th>
                        </tr>
                    </thead>
                    <tbody>
");
            EndContext();
#line 62 "D:\Project File\DoorBoxApp\DoorBoxApp\Views\DeliveryMen\AdminPickupPaymentFixed.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
            BeginContext(1794, 34, true);
            WriteLiteral("                            <tr>\r\n");
            EndContext();
#line 65 "D:\Project File\DoorBoxApp\DoorBoxApp\Views\DeliveryMen\AdminPickupPaymentFixed.cshtml"
                                 if (item.Merchant != null)
                                {

#line default
#line hidden
            BeginContext(1924, 126, true);
            WriteLiteral("                                    <td>\r\n                                        <input type=\"hidden\" class=\"pickupRequestId\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2050, "\"", 2066, 1);
#line 68 "D:\Project File\DoorBoxApp\DoorBoxApp\Views\DeliveryMen\AdminPickupPaymentFixed.cshtml"
WriteAttributeValue("", 2058, item.Id, 2058, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2067, 45, true);
            WriteLiteral(" />\r\n                                        ");
            EndContext();
            BeginContext(2113, 18, false);
#line 69 "D:\Project File\DoorBoxApp\DoorBoxApp\Views\DeliveryMen\AdminPickupPaymentFixed.cshtml"
                                   Write(item.Merchant.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2131, 45, true);
            WriteLiteral("\r\n                                    </td>\r\n");
            EndContext();
#line 71 "D:\Project File\DoorBoxApp\DoorBoxApp\Views\DeliveryMen\AdminPickupPaymentFixed.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(2284, 134, true);
            WriteLiteral("                                    <td>\r\n                                        No Data\r\n                                    </td>\r\n");
            EndContext();
#line 77 "D:\Project File\DoorBoxApp\DoorBoxApp\Views\DeliveryMen\AdminPickupPaymentFixed.cshtml"
                                }

#line default
#line hidden
            BeginContext(2453, 76, true);
            WriteLiteral("\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(2530, 22, false);
#line 80 "D:\Project File\DoorBoxApp\DoorBoxApp\Views\DeliveryMen\AdminPickupPaymentFixed.cshtml"
                               Write(item.LocationFrom.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2552, 117, true);
            WriteLiteral("\r\n                                </td>\r\n\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(2670, 18, false);
#line 84 "D:\Project File\DoorBoxApp\DoorBoxApp\Views\DeliveryMen\AdminPickupPaymentFixed.cshtml"
                               Write(item.PickupAddress);

#line default
#line hidden
            EndContext();
            BeginContext(2688, 321, true);
            WriteLiteral(@"
                                </td>

                                <td>
                                    <input disabled class=""form-control phoneNo border-0 border-radius-0 text-center text-wrap paidAmount"" type=""text"" value=""10"" />
                                </td>
                            </tr>
");
            EndContext();
#line 91 "D:\Project File\DoorBoxApp\DoorBoxApp\Views\DeliveryMen\AdminPickupPaymentFixed.cshtml"
                        }

#line default
#line hidden
            BeginContext(3036, 122, true);
            WriteLiteral("                    </tbody>\r\n                </table>\r\n\r\n\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3176, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(3182, 119, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "148400bcd64f0f5504f99a91cf9f24ff64c7d40d11896", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
#line 104 "D:\Project File\DoorBoxApp\DoorBoxApp\Views\DeliveryMen\AdminPickupPaymentFixed.cshtml"
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
                BeginContext(3301, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(3307, 123, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "148400bcd64f0f5504f99a91cf9f24ff64c7d40d14069", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
#line 105 "D:\Project File\DoorBoxApp\DoorBoxApp\Views\DeliveryMen\AdminPickupPaymentFixed.cshtml"
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
                BeginContext(3430, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 106 "D:\Project File\DoorBoxApp\DoorBoxApp\Views\DeliveryMen\AdminPickupPaymentFixed.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DoorBoxApp.Models.PickUpRequest>> Html { get; private set; }
    }
}
#pragma warning restore 1591
