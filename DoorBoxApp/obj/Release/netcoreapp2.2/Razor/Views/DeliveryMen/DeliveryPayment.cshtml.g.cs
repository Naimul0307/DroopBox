#pragma checksum "C:\My Projects\DoorBoxApp\DoorBoxApp\Views\DeliveryMen\DeliveryPayment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "836e7e4d9cd8494d6dcbca810495038dbb4c546a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DeliveryMen_DeliveryPayment), @"mvc.1.0.view", @"/Views/DeliveryMen/DeliveryPayment.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DeliveryMen/DeliveryPayment.cshtml", typeof(AspNetCore.Views_DeliveryMen_DeliveryPayment))]
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
#line 1 "C:\My Projects\DoorBoxApp\DoorBoxApp\Views\_ViewImports.cshtml"
using DoorBoxApp;

#line default
#line hidden
#line 2 "C:\My Projects\DoorBoxApp\DoorBoxApp\Views\_ViewImports.cshtml"
using DoorBoxApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"836e7e4d9cd8494d6dcbca810495038dbb4c546a", @"/Views/DeliveryMen/DeliveryPayment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db0bb7675d3dc7f4369941d6c52fb8cf421deb36", @"/Views/_ViewImports.cshtml")]
    public class Views_DeliveryMen_DeliveryPayment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DoorBoxApp.Models.Package>>
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
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\My Projects\DoorBoxApp\DoorBoxApp\Views\DeliveryMen\DeliveryPayment.cshtml"
  
    ViewData["Title"] = "Delivery Payment";

#line default
#line hidden
            BeginContext(101, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Css", async() => {
                BeginContext(117, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 8 "C:\My Projects\DoorBoxApp\DoorBoxApp\Views\DeliveryMen\DeliveryPayment.cshtml"
      await Html.RenderPartialAsync("_DataTableCssPartial");

#line default
#line hidden
            }
            );
            BeginContext(185, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Sole", async() => {
                BeginContext(202, 246, true);
                WriteLiteral("\r\n    <style>\r\n\r\n\r\n        .table tr th:last-child {\r\n            width: 100px;\r\n        }\r\n\r\n        .table tr th {\r\n            text-align: center;\r\n        }\r\n\r\n        .table tr td {\r\n            text-align: center;\r\n        }\r\n    </style>\r\n");
                EndContext();
            }
            );
            BeginContext(451, 342, true);
            WriteLiteral(@"
<div class=""container-fluid mt-4"">
    <div class=""card animated fadeIn overflow-hidden"">
        <div class=""card-header p-3"">
            <div class=""row align-items-center"">
                <div class=""col"">
                    <h3 class=""mb-0 skewed skewed-yellow  d-inline-block text-uppercase ls-1 text-white"">Delivery Payment : ");
            EndContext();
            BeginContext(794, 24, false);
#line 34 "C:\My Projects\DoorBoxApp\DoorBoxApp\Views\DeliveryMen\DeliveryPayment.cshtml"
                                                                                                                       Write(ViewBag.DeliveryMan.Name);

#line default
#line hidden
            EndContext();
            BeginContext(818, 1236, true);
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
                                Tracking Id
                            </th>
                            <th>
                                From
                            </th>
                            <th>
                                To
                            </th>
                            <th>
                                To Sub
                            </th>
                            <th>
                                Pay
                            </th>
       ");
            WriteLiteral("                     <th class=\"text-center\">\r\n                                Action\r\n                            </th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
            EndContext();
#line 69 "C:\My Projects\DoorBoxApp\DoorBoxApp\Views\DeliveryMen\DeliveryPayment.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
            BeginContext(2135, 34, true);
            WriteLiteral("                            <tr>\r\n");
            EndContext();
#line 72 "C:\My Projects\DoorBoxApp\DoorBoxApp\Views\DeliveryMen\DeliveryPayment.cshtml"
                                 if (item.PickUpRequest.Merchant != null)
                                {

#line default
#line hidden
            BeginContext(2279, 120, true);
            WriteLiteral("                                    <td>\r\n                                        <input type=\"hidden\" class=\"packageId\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2399, "\"", 2415, 1);
#line 75 "C:\My Projects\DoorBoxApp\DoorBoxApp\Views\DeliveryMen\DeliveryPayment.cshtml"
WriteAttributeValue("", 2407, item.Id, 2407, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2416, 45, true);
            WriteLiteral(" />\r\n                                        ");
            EndContext();
            BeginContext(2462, 32, false);
#line 76 "C:\My Projects\DoorBoxApp\DoorBoxApp\Views\DeliveryMen\DeliveryPayment.cshtml"
                                   Write(item.PickUpRequest.Merchant.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2494, 45, true);
            WriteLiteral("\r\n                                    </td>\r\n");
            EndContext();
#line 78 "C:\My Projects\DoorBoxApp\DoorBoxApp\Views\DeliveryMen\DeliveryPayment.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(2647, 134, true);
            WriteLiteral("                                    <td>\r\n                                        No Data\r\n                                    </td>\r\n");
            EndContext();
#line 84 "C:\My Projects\DoorBoxApp\DoorBoxApp\Views\DeliveryMen\DeliveryPayment.cshtml"
                                }

#line default
#line hidden
#line 85 "C:\My Projects\DoorBoxApp\DoorBoxApp\Views\DeliveryMen\DeliveryPayment.cshtml"
                                 if (item.TrackingNumber != null)
                                {

#line default
#line hidden
            BeginContext(2918, 82, true);
            WriteLiteral("                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(3001, 19, false);
#line 88 "C:\My Projects\DoorBoxApp\DoorBoxApp\Views\DeliveryMen\DeliveryPayment.cshtml"
                                   Write(item.TrackingNumber);

#line default
#line hidden
            EndContext();
            BeginContext(3020, 45, true);
            WriteLiteral("\r\n                                    </td>\r\n");
            EndContext();
#line 90 "C:\My Projects\DoorBoxApp\DoorBoxApp\Views\DeliveryMen\DeliveryPayment.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(3173, 134, true);
            WriteLiteral("                                    <td>\r\n                                        No Data\r\n                                    </td>\r\n");
            EndContext();
#line 96 "C:\My Projects\DoorBoxApp\DoorBoxApp\Views\DeliveryMen\DeliveryPayment.cshtml"
                                }

#line default
#line hidden
            BeginContext(3342, 76, true);
            WriteLiteral("\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(3419, 36, false);
#line 99 "C:\My Projects\DoorBoxApp\DoorBoxApp\Views\DeliveryMen\DeliveryPayment.cshtml"
                               Write(item.PickUpRequest.LocationFrom.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3455, 41, true);
            WriteLiteral("\r\n                                </td>\r\n");
            EndContext();
#line 101 "C:\My Projects\DoorBoxApp\DoorBoxApp\Views\DeliveryMen\DeliveryPayment.cshtml"
                                 if (item.LocationTo != null)
                                {

#line default
#line hidden
            BeginContext(3594, 82, true);
            WriteLiteral("                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(3677, 20, false);
#line 104 "C:\My Projects\DoorBoxApp\DoorBoxApp\Views\DeliveryMen\DeliveryPayment.cshtml"
                                   Write(item.LocationTo.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3697, 45, true);
            WriteLiteral("\r\n                                    </td>\r\n");
            EndContext();
#line 106 "C:\My Projects\DoorBoxApp\DoorBoxApp\Views\DeliveryMen\DeliveryPayment.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(3850, 134, true);
            WriteLiteral("                                    <td>\r\n                                        No Data\r\n                                    </td>\r\n");
            EndContext();
#line 112 "C:\My Projects\DoorBoxApp\DoorBoxApp\Views\DeliveryMen\DeliveryPayment.cshtml"
                                }

#line default
#line hidden
            BeginContext(4019, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 114 "C:\My Projects\DoorBoxApp\DoorBoxApp\Views\DeliveryMen\DeliveryPayment.cshtml"
                                 if (item.SubLocation != null)
                                {

#line default
#line hidden
            BeginContext(4120, 82, true);
            WriteLiteral("                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(4203, 21, false);
#line 117 "C:\My Projects\DoorBoxApp\DoorBoxApp\Views\DeliveryMen\DeliveryPayment.cshtml"
                                   Write(item.SubLocation.Name);

#line default
#line hidden
            EndContext();
            BeginContext(4224, 45, true);
            WriteLiteral("\r\n                                    </td>\r\n");
            EndContext();
#line 119 "C:\My Projects\DoorBoxApp\DoorBoxApp\Views\DeliveryMen\DeliveryPayment.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(4377, 134, true);
            WriteLiteral("                                    <td>\r\n                                        No Data\r\n                                    </td>\r\n");
            EndContext();
#line 125 "C:\My Projects\DoorBoxApp\DoorBoxApp\Views\DeliveryMen\DeliveryPayment.cshtml"
                                }

#line default
#line hidden
            BeginContext(4546, 190, true);
            WriteLiteral("\r\n                                <td>\r\n                                    <input disabled class=\"form-control phoneNo border-0 border-radius-0 text-center text-wrap paidAmount\" type=\"text\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 4736, "\"", 4777, 1);
#line 128 "C:\My Projects\DoorBoxApp\DoorBoxApp\Views\DeliveryMen\DeliveryPayment.cshtml"
WriteAttributeValue("", 4744, ViewBag.DeliveryMan.DeliveryRate, 4744, 33, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4778, 419, true);
            WriteLiteral(@" />
                                </td>



                                <td class=""text-center"">
                                    <div class=""btn-group"">


                                        <input class=""btn btn-success btn-sm saveButton"" type=""button"" value=""Save"" />




                                    </div>
                                </td>
                            </tr>
");
            EndContext();
#line 145 "C:\My Projects\DoorBoxApp\DoorBoxApp\Views\DeliveryMen\DeliveryPayment.cshtml"
                        }

#line default
#line hidden
            BeginContext(5224, 122, true);
            WriteLiteral("                    </tbody>\r\n                </table>\r\n\r\n\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(5364, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(5370, 119, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "836e7e4d9cd8494d6dcbca810495038dbb4c546a16972", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
#line 158 "C:\My Projects\DoorBoxApp\DoorBoxApp\Views\DeliveryMen\DeliveryPayment.cshtml"
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
                BeginContext(5489, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(5495, 123, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "836e7e4d9cd8494d6dcbca810495038dbb4c546a19136", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
#line 159 "C:\My Projects\DoorBoxApp\DoorBoxApp\Views\DeliveryMen\DeliveryPayment.cshtml"
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
                BeginContext(5618, 1786, true);
                WriteLiteral(@"
    <script type=""text/javascript"">

        $(document).ready(function () {
            $('.saveButton').on('click', function () {

                var row = $(this).closest('tr');
                var paidAmount = row.find('.paidAmount').val();
                var packageId = row.find('.packageId').val();

                if (paidAmount == """" || paidAmount == null ) {

                         $.notify({
                             title: 'Prompt!',
                             icon: 'fa fa-times',
                             html: true,
                             message: 'Fill Up Amount !!!'
                         },
                             {
                                 type: 'warning',
                                 animate: {
                                     enter: 'animated fadeInDown'
                                 },
                                 placement: {
                                     from: ""top"",
                                     alig");
                WriteLiteral(@"n: ""center""
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
                BeginContext(7405, 45, false);
#line 193 "C:\My Projects\DoorBoxApp\DoorBoxApp\Views\DeliveryMen\DeliveryPayment.cshtml"
                           Write(Url.Action("SaveDeliveryPayment", "Packages"));

#line default
#line hidden
                EndContext();
                BeginContext(7450, 593, true);
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
#line 214 "C:\My Projects\DoorBoxApp\DoorBoxApp\Views\DeliveryMen\DeliveryPayment.cshtml"
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
