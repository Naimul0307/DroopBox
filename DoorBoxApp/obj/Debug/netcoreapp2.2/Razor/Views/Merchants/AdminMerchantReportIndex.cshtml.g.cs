#pragma checksum "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Merchants\AdminMerchantReportIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "273ac95367c8564e936a79d318b13da8bd3fa3fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Merchants_AdminMerchantReportIndex), @"mvc.1.0.view", @"/Views/Merchants/AdminMerchantReportIndex.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Merchants/AdminMerchantReportIndex.cshtml", typeof(AspNetCore.Views_Merchants_AdminMerchantReportIndex))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"273ac95367c8564e936a79d318b13da8bd3fa3fe", @"/Views/Merchants/AdminMerchantReportIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db0bb7675d3dc7f4369941d6c52fb8cf421deb36", @"/Views/_ViewImports.cshtml")]
    public class Views_Merchants_AdminMerchantReportIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DoorBoxApp.Models.Merchant>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Merchants", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AdminMerchantReport", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/vendor/datatable/js/jquery.dataTables.min.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/vendor/datatable/js/dataTables.bootstrap4.min.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(48, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Merchants\AdminMerchantReportIndex.cshtml"
  
    ViewData["Title"] = "Active Merchants";

#line default
#line hidden
            BeginContext(102, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Css", async() => {
                BeginContext(118, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 8 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Merchants\AdminMerchantReportIndex.cshtml"
      await Html.RenderPartialAsync("_DataTableCssPartial");

#line default
#line hidden
            }
            );
            BeginContext(186, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Sole", async() => {
                BeginContext(203, 169, true);
                WriteLiteral("\r\n    <style>\r\n\r\n        .table tr th {\r\n            text-align: center;\r\n        }\r\n\r\n        .table tr td {\r\n            text-align: center;\r\n        }\r\n    </style>\r\n");
                EndContext();
            }
            );
            BeginContext(375, 1684, true);
            WriteLiteral(@"
<div class=""container-fluid mt-4"">
    <div class=""card animated fadeIn overflow-hidden"">
        <div class=""card-header p-3"">
            <div class=""row align-items-center"">
                <div class=""col"">
                    <h3 class=""mb-0 skewed skewed-yellow  d-inline-block text-uppercase ls-1 text-white"">Active Merchants</h3>
                </div>

            </div>
        </div>
        <div class=""card-body px-0 pb-2"">
            <div class=""table-responsive"">

                <table class=""table align-items-center  table-striped table-bordered"" id=""datatable-basic"">
                    <thead class=""thead-light"">
                        <tr>
                            <th>
                                Id No
                            </th>
                            <th>
                                Name
                            </th>
                            <th>
                                User Name
                            </th>
            ");
            WriteLiteral(@"                <th>
                                Phone No
                            </th>
                            <th>
                                Email
                            </th>

                            <th>
                                Address
                            </th>
                            <th>
                                Payment Details
                            </th>


                            <th class=""text-center"">
                                Action
                            </th>
                        </tr>
                    </thead>
                    <tbody>
");
            EndContext();
#line 70 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Merchants\AdminMerchantReportIndex.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
            BeginContext(2140, 110, true);
            WriteLiteral("                            <tr>\r\n\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(2251, 17, false);
#line 75 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Merchants\AdminMerchantReportIndex.cshtml"
                               Write(item.MerchantIdNo);

#line default
#line hidden
            EndContext();
            BeginContext(2268, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(2384, 9, false);
#line 78 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Merchants\AdminMerchantReportIndex.cshtml"
                               Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2393, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(2509, 29, false);
#line 81 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Merchants\AdminMerchantReportIndex.cshtml"
                               Write(item.ApplicationUser.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(2538, 117, true);
            WriteLiteral("\r\n                                </td>\r\n\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(2656, 32, false);
#line 85 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Merchants\AdminMerchantReportIndex.cshtml"
                               Write(item.ApplicationUser.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(2688, 117, true);
            WriteLiteral("\r\n                                </td>\r\n\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(2806, 26, false);
#line 89 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Merchants\AdminMerchantReportIndex.cshtml"
                               Write(item.ApplicationUser.Email);

#line default
#line hidden
            EndContext();
            BeginContext(2832, 117, true);
            WriteLiteral("\r\n                                </td>\r\n\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(2950, 12, false);
#line 93 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Merchants\AdminMerchantReportIndex.cshtml"
                               Write(item.Address);

#line default
#line hidden
            EndContext();
            BeginContext(2962, 41, true);
            WriteLiteral("\r\n                                </td>\r\n");
            EndContext();
#line 95 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Merchants\AdminMerchantReportIndex.cshtml"
                                 if (item.ApplicationUser.PaymentMethod == "Bank")
                                {

#line default
#line hidden
            BeginContext(3122, 107, true);
            WriteLiteral("                                    <td class=\"text-wrap\">\r\n                                        Name : ");
            EndContext();
            BeginContext(3230, 37, false);
#line 98 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Merchants\AdminMerchantReportIndex.cshtml"
                                          Write(item.ApplicationUser.BankCustomerName);

#line default
#line hidden
            EndContext();
            BeginContext(3267, 49, true);
            WriteLiteral("\r\n                                        Bank : ");
            EndContext();
            BeginContext(3317, 29, false);
#line 99 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Merchants\AdminMerchantReportIndex.cshtml"
                                          Write(item.ApplicationUser.BankName);

#line default
#line hidden
            EndContext();
            BeginContext(3346, 2, true);
            WriteLiteral(" (");
            EndContext();
            BeginContext(3349, 31, false);
#line 99 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Merchants\AdminMerchantReportIndex.cshtml"
                                                                          Write(item.ApplicationUser.BranchName);

#line default
#line hidden
            EndContext();
            BeginContext(3380, 49, true);
            WriteLiteral(")\r\n                                        A/C : ");
            EndContext();
            BeginContext(3430, 34, false);
#line 100 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Merchants\AdminMerchantReportIndex.cshtml"
                                         Write(item.ApplicationUser.AccountNumber);

#line default
#line hidden
            EndContext();
            BeginContext(3464, 45, true);
            WriteLiteral("\r\n                                    </td>\r\n");
            EndContext();
#line 102 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Merchants\AdminMerchantReportIndex.cshtml"
                                }
                                else
                                {
                                    

#line default
#line hidden
#line 105 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Merchants\AdminMerchantReportIndex.cshtml"
                                     if (@item.ApplicationUser.PaymentMethod == null)
                                    {

#line default
#line hidden
            BeginContext(3743, 142, true);
            WriteLiteral("                                        <td>\r\n                                            N/A\r\n                                        </td>\r\n");
            EndContext();
#line 110 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Merchants\AdminMerchantReportIndex.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
            BeginContext(4005, 99, true);
            WriteLiteral("                                        <td>\r\n                                            Method : ");
            EndContext();
            BeginContext(4105, 34, false);
#line 114 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Merchants\AdminMerchantReportIndex.cshtml"
                                                Write(item.ApplicationUser.PaymentMethod);

#line default
#line hidden
            EndContext();
            BeginContext(4139, 2, true);
            WriteLiteral(" (");
            EndContext();
            BeginContext(4142, 40, false);
#line 114 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Merchants\AdminMerchantReportIndex.cshtml"
                                                                                     Write(item.ApplicationUser.MobileBankingNumber);

#line default
#line hidden
            EndContext();
            BeginContext(4182, 50, true);
            WriteLiteral(")\r\n                                        </td>\r\n");
            EndContext();
#line 116 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Merchants\AdminMerchantReportIndex.cshtml"
                                    }

#line default
#line hidden
#line 116 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Merchants\AdminMerchantReportIndex.cshtml"
                                     

                                }

#line default
#line hidden
            BeginContext(4308, 159, true);
            WriteLiteral("                                <td class=\"text-center\">\r\n                                    <div class=\"btn-group\">\r\n                                        ");
            EndContext();
            BeginContext(4467, 151, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "273ac95367c8564e936a79d318b13da8bd3fa3fe17176", async() => {
                BeginContext(4604, 10, true);
                WriteLiteral("See Report");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-userId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 121 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Merchants\AdminMerchantReportIndex.cshtml"
                                                                                                                                            WriteLiteral(item.ApplicationUserId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-userId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4618, 120, true);
            WriteLiteral("\r\n                                    </div>\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 125 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Merchants\AdminMerchantReportIndex.cshtml"
                        }

#line default
#line hidden
            BeginContext(4765, 122, true);
            WriteLiteral("                    </tbody>\r\n                </table>\r\n\r\n\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(4905, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(4911, 119, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "273ac95367c8564e936a79d318b13da8bd3fa3fe20669", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
#line 138 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Merchants\AdminMerchantReportIndex.cshtml"
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
                BeginContext(5030, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(5036, 123, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "273ac95367c8564e936a79d318b13da8bd3fa3fe22852", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
#line 139 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Merchants\AdminMerchantReportIndex.cshtml"
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
                BeginContext(5159, 56, true);
                WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n\r\n    </script>\r\n");
                EndContext();
#line 143 "D:\Project File\DoorBoxApp\DoorBoxApp\DoorBoxApp\Views\Merchants\AdminMerchantReportIndex.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DoorBoxApp.Models.Merchant>> Html { get; private set; }
    }
}
#pragma warning restore 1591
