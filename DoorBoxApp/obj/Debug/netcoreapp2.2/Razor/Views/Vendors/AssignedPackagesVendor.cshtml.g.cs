#pragma checksum "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Vendors\AssignedPackagesVendor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db6d65dc4f2929e32086a8d0513129dbd880ad76"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vendors_AssignedPackagesVendor), @"mvc.1.0.view", @"/Views/Vendors/AssignedPackagesVendor.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Vendors/AssignedPackagesVendor.cshtml", typeof(AspNetCore.Views_Vendors_AssignedPackagesVendor))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db6d65dc4f2929e32086a8d0513129dbd880ad76", @"/Views/Vendors/AssignedPackagesVendor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db0bb7675d3dc7f4369941d6c52fb8cf421deb36", @"/Views/_ViewImports.cshtml")]
    public class Views_Vendors_AssignedPackagesVendor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DoorBoxApp.Models.Package>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleveredByVendor", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ReturnedByVendor", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/vendor/datatable/js/jquery.dataTables.min.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/vendor/datatable/js/dataTables.bootstrap4.min.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Vendors\AssignedPackagesVendor.cshtml"
  
    ViewData["Title"] = "Vendor Packages";

#line default
#line hidden
            BeginContext(100, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Css", async() => {
                BeginContext(116, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 8 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Vendors\AssignedPackagesVendor.cshtml"
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
            BeginContext(450, 332, true);
            WriteLiteral(@"
<div class=""container-fluid mt-4"">
    <div class=""card animated fadeIn overflow-hidden"">
        <div class=""card-header p-3"">
            <div class=""row align-items-center"">
                <div class=""col"">
                    <h3 class=""mb-0 skewed skewed-yellow text-dark d-inline-block text-uppercase text-white ls-1"">");
            EndContext();
            BeginContext(783, 19, false);
#line 34 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Vendors\AssignedPackagesVendor.cshtml"
                                                                                                             Write(ViewBag.Vendor.Name);

#line default
#line hidden
            EndContext();
            BeginContext(802, 137, true);
            WriteLiteral(" Packages</h3>\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n        <div class=\"card-body px-0 pb-2\">\r\n            <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 939, "\"", 947, 0);
            EndWriteAttribute();
            BeginContext(948, 997, true);
            WriteLiteral(@">

                <table class=""table align-items-center table-responsive-sm table-striped table-bordered"" id=""datatable-basic"">
                    <thead class=""thead-light"">
                        <tr>
                            <th>
                                Merchant name
                            </th>

                            <th>
                                Client Name
                            </th>
                            <th>
                                Phone
                            </th>
                            <th>
                                Address
                            </th>
                            <th>
                                Tracking ID
                            </th>
                            <th class=""text-center"">
                                Action
                            </th>
                        </tr>
                    </thead>

                    <tbody>
");
            EndContext();
#line 68 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Vendors\AssignedPackagesVendor.cshtml"
                         foreach (var item in Model)
                        {


#line default
#line hidden
            BeginContext(2028, 108, true);
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(2137, 32, false);
#line 73 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Vendors\AssignedPackagesVendor.cshtml"
                               Write(item.PickUpRequest.Merchant.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2169, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(2285, 15, false);
#line 76 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Vendors\AssignedPackagesVendor.cshtml"
                               Write(item.ClientName);

#line default
#line hidden
            EndContext();
            BeginContext(2300, 70, true);
            WriteLiteral("\r\n                                    <input type=\"hidden\" name=\"name\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2370, "\"", 2387, 1);
#line 77 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Vendors\AssignedPackagesVendor.cshtml"
WriteAttributeValue("", 2378, item.OTP, 2378, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2388, 118, true);
            WriteLiteral(" />\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(2507, 16, false);
#line 80 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Vendors\AssignedPackagesVendor.cshtml"
                               Write(item.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(2523, 133, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td class=\"text-wrap\">\r\n                                    ");
            EndContext();
            BeginContext(2657, 12, false);
#line 83 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Vendors\AssignedPackagesVendor.cshtml"
                               Write(item.Address);

#line default
#line hidden
            EndContext();
            BeginContext(2669, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(2785, 19, false);
#line 86 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Vendors\AssignedPackagesVendor.cshtml"
                               Write(item.TrackingNumber);

#line default
#line hidden
            EndContext();
            BeginContext(2804, 160, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td class=\"text-center\">\r\n                                    <div class=\"btn-group\">\r\n");
            EndContext();
#line 90 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Vendors\AssignedPackagesVendor.cshtml"
                                         if (item.Status == 4)
                                        {

#line default
#line hidden
            BeginContext(3071, 44, true);
            WriteLiteral("                                            ");
            EndContext();
            BeginContext(3115, 136, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db6d65dc4f2929e32086a8d0513129dbd880ad7613396", async() => {
                BeginContext(3240, 7, true);
                WriteLiteral("Deliver");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 92 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Vendors\AssignedPackagesVendor.cshtml"
                                                                                                               WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 92 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Vendors\AssignedPackagesVendor.cshtml"
                                                                                                                                             WriteLiteral(item.VendorId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["vendorId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-vendorId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["vendorId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3251, 46, true);
            WriteLiteral("\r\n                                            ");
            EndContext();
            BeginContext(3297, 133, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db6d65dc4f2929e32086a8d0513129dbd880ad7616738", async() => {
                BeginContext(3420, 6, true);
                WriteLiteral("Return");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 93 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Vendors\AssignedPackagesVendor.cshtml"
                                                                                                             WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 93 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Vendors\AssignedPackagesVendor.cshtml"
                                                                                                                                           WriteLiteral(item.VendorId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["vendorId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-vendorId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["vendorId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3430, 3, true);
            WriteLiteral(" \r\n");
            EndContext();
#line 94 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Vendors\AssignedPackagesVendor.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
            BeginContext(3565, 104, true);
            WriteLiteral("                                            <a class=\"btn btn-warning btn-sm text-white\">No Action</a>\r\n");
            EndContext();
#line 98 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Vendors\AssignedPackagesVendor.cshtml"
                                        }

#line default
#line hidden
            BeginContext(3712, 122, true);
            WriteLiteral("                                    </div>\r\n\r\n                                </td>\r\n\r\n                            </tr>\r\n");
            EndContext();
#line 104 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Vendors\AssignedPackagesVendor.cshtml"

                        }

#line default
#line hidden
            BeginContext(3863, 120, true);
            WriteLiteral("                    </tbody>\r\n                </table>\r\n\r\n\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(4001, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(4009, 119, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db6d65dc4f2929e32086a8d0513129dbd880ad7621513", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
#line 118 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Vendors\AssignedPackagesVendor.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
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
                BeginContext(4128, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(4134, 123, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db6d65dc4f2929e32086a8d0513129dbd880ad7623692", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
#line 119 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Vendors\AssignedPackagesVendor.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4257, 54, true);
                WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n    </script>\r\n");
                EndContext();
#line 122 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Vendors\AssignedPackagesVendor.cshtml"
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
