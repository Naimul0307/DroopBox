#pragma checksum "D:\Project File\DroopBox\DoorBoxApp\Views\PickUpRequests\DeliveryManIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64fe4117e80a5f8cb06e372ba713be1f94388727"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PickUpRequests_DeliveryManIndex), @"mvc.1.0.view", @"/Views/PickUpRequests/DeliveryManIndex.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/PickUpRequests/DeliveryManIndex.cshtml", typeof(AspNetCore.Views_PickUpRequests_DeliveryManIndex))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64fe4117e80a5f8cb06e372ba713be1f94388727", @"/Views/PickUpRequests/DeliveryManIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db0bb7675d3dc7f4369941d6c52fb8cf421deb36", @"/Views/_ViewImports.cshtml")]
    public class Views_PickUpRequests_DeliveryManIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DoorBoxApp.Models.PickUpRequest>>
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
#line 3 "D:\Project File\DroopBox\DoorBoxApp\Views\PickUpRequests\DeliveryManIndex.cshtml"
  
    ViewData["Title"] = "Requests";

#line default
#line hidden
            BeginContext(99, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Css", async() => {
                BeginContext(115, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 8 "D:\Project File\DroopBox\DoorBoxApp\Views\PickUpRequests\DeliveryManIndex.cshtml"
      await Html.RenderPartialAsync("_DataTableCssPartial");

#line default
#line hidden
            }
            );
            BeginContext(183, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Sole", async() => {
                BeginContext(200, 242, true);
                WriteLiteral("\r\n    <style>\r\n        .table tr th:last-child {\r\n            width: 160px;\r\n        }\r\n\r\n        .table tr th {\r\n            text-align: center;\r\n        }\r\n\r\n        .table tr td {\r\n            text-align: center;\r\n        }\r\n    </style>\r\n");
                EndContext();
            }
            );
            BeginContext(445, 1499, true);
            WriteLiteral(@"
<div class=""container-fluid mt-4"">
    <div class=""card animated fadeIn overflow-hidden"">
        <div class=""card-header p-3"">
            <div class=""row align-items-center"">
                <div class=""col"">
                    <h3 class=""mb-0 skewed skewed-yellow text-white d-inline-block text-uppercase ls-1"">Requests</h3>
                </div>

            </div>
        </div>
        <div class=""card-body px-0 pb-2"">
            <div class=""table-responsive"">

                <table class=""table align-items-center  table-striped table-bordered"" id=""datatable-basic"">
                    <thead class=""thead-light"">
                        <tr>

                            <th>
                                Marchant Name
                            </th>
                            <th>
                                Marchant Phone
                            </th>
                            <th>
                                Marchant Address
                            <");
            WriteLiteral(@"/th>

                            <th>
                                Pickup Address Address
                            </th>
                            <th>
                                Number of Packages
                            </th>

                            <th class=""text-center"">
                                Action
                            </th>
                        </tr>
                    </thead>
                    <tbody>
");
            EndContext();
#line 67 "D:\Project File\DroopBox\DoorBoxApp\Views\PickUpRequests\DeliveryManIndex.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
            BeginContext(2025, 36, true);
            WriteLiteral("                            <tr>\r\n\r\n");
            EndContext();
#line 71 "D:\Project File\DroopBox\DoorBoxApp\Views\PickUpRequests\DeliveryManIndex.cshtml"
                                 if (item.Merchant != null)
                                {

#line default
#line hidden
            BeginContext(2157, 58, true);
            WriteLiteral("                                    <td class=\"text-wrap\">");
            EndContext();
            BeginContext(2216, 18, false);
#line 73 "D:\Project File\DroopBox\DoorBoxApp\Views\PickUpRequests\DeliveryManIndex.cshtml"
                                                     Write(item.Merchant.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2234, 65, true);
            WriteLiteral("</td>\r\n                                    <td class=\"text-wrap\">");
            EndContext();
            BeginContext(2300, 41, false);
#line 74 "D:\Project File\DroopBox\DoorBoxApp\Views\PickUpRequests\DeliveryManIndex.cshtml"
                                                     Write(item.Merchant.ApplicationUser.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(2341, 65, true);
            WriteLiteral("</td>\r\n                                    <td class=\"text-wrap\">");
            EndContext();
            BeginContext(2407, 21, false);
#line 75 "D:\Project File\DroopBox\DoorBoxApp\Views\PickUpRequests\DeliveryManIndex.cshtml"
                                                     Write(item.Merchant.Address);

#line default
#line hidden
            EndContext();
            BeginContext(2428, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 76 "D:\Project File\DroopBox\DoorBoxApp\Views\PickUpRequests\DeliveryManIndex.cshtml"

                                }
                                else
                                {

#line default
#line hidden
            BeginContext(2545, 50, true);
            WriteLiteral("                                    <td>N/A</td>\r\n");
            EndContext();
#line 81 "D:\Project File\DroopBox\DoorBoxApp\Views\PickUpRequests\DeliveryManIndex.cshtml"

                                }

#line default
#line hidden
            BeginContext(2632, 92, true);
            WriteLiteral("                                <td class=\"text-wrap\">\r\n                                    ");
            EndContext();
            BeginContext(2725, 18, false);
#line 84 "D:\Project File\DroopBox\DoorBoxApp\Views\PickUpRequests\DeliveryManIndex.cshtml"
                               Write(item.PickupAddress);

#line default
#line hidden
            EndContext();
            BeginContext(2743, 117, true);
            WriteLiteral("\r\n                                </td>\r\n\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(2861, 23, false);
#line 88 "D:\Project File\DroopBox\DoorBoxApp\Views\PickUpRequests\DeliveryManIndex.cshtml"
                               Write(item.TotalPackageNumber);

#line default
#line hidden
            EndContext();
            BeginContext(2884, 245, true);
            WriteLiteral("\r\n                                </td>\r\n\r\n                                <td class=\"text-center\">\r\n                                    <div class=\"btn-group\">\r\n                                        <input type=\"hidden\" class=\"id\" name=\"name\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3129, "\"", 3146, 1);
#line 93 "D:\Project File\DroopBox\DoorBoxApp\Views\PickUpRequests\DeliveryManIndex.cshtml"
WriteAttributeValue(" ", 3137, item.Id, 3138, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3147, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
#line 94 "D:\Project File\DroopBox\DoorBoxApp\Views\PickUpRequests\DeliveryManIndex.cshtml"
                                         if (item.Status == 3)
                                        {

#line default
#line hidden
            BeginContext(3259, 128, true);
            WriteLiteral("                                            <input type=\"button\" class=\"btn btn-success btn-sm pickupButton\" value=\"PickUp\" />\r\n");
            EndContext();
#line 97 "D:\Project File\DroopBox\DoorBoxApp\Views\PickUpRequests\DeliveryManIndex.cshtml"
                                        }


                                        else if (item.Status == 4)
                                        {

#line default
#line hidden
            BeginContext(3545, 104, true);
            WriteLiteral("                                            <a class=\"btn btn-success btn-sm text-white\">Picked Up</a>\r\n");
            EndContext();
#line 103 "D:\Project File\DroopBox\DoorBoxApp\Views\PickUpRequests\DeliveryManIndex.cshtml"
                                        }

#line default
#line hidden
            BeginContext(3692, 124, true);
            WriteLiteral("\r\n\r\n\r\n                                    </div>\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 110 "D:\Project File\DroopBox\DoorBoxApp\Views\PickUpRequests\DeliveryManIndex.cshtml"
                        }

#line default
#line hidden
            BeginContext(3843, 122, true);
            WriteLiteral("                    </tbody>\r\n                </table>\r\n\r\n\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3983, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(3989, 119, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64fe4117e80a5f8cb06e372ba713be1f9438872713652", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
#line 123 "D:\Project File\DroopBox\DoorBoxApp\Views\PickUpRequests\DeliveryManIndex.cshtml"
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
                BeginContext(4108, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(4114, 123, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64fe4117e80a5f8cb06e372ba713be1f9438872715819", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
#line 124 "D:\Project File\DroopBox\DoorBoxApp\Views\PickUpRequests\DeliveryManIndex.cshtml"
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
                BeginContext(4237, 303, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
         $(document).ready(function () {
             $('.pickupButton').on('click', function () {
                var row = $(this).closest('tr');
                var id = row.find('.id').val();
                var totalPacks = 0;
                var url = '");
                EndContext();
                BeginContext(4541, 43, false);
#line 131 "D:\Project File\DroopBox\DoorBoxApp\Views\PickUpRequests\DeliveryManIndex.cshtml"
                      Write(Url.Action("GetPackageDetails", "Packages"));

#line default
#line hidden
                EndContext();
                BeginContext(4584, 2146, true);
                WriteLiteral(@"';
                $.when(
                $.ajax({
                    type: ""POST"",
                    dataType: 'json',
                    url: url,
                    data: {
                        id: id,
                    },
                    cache: false,
                    success: function (objects) {
                        $.each(objects, function (index, object) {
                            if (objects != false && objects != null) {
                                totalPacks = objects.totalPackageNumber
                            }
                        });
                    }
                }),
                ).then(function () {
                $.confirm({
                    title: 'Pick up Packages!',
                    theme: 'modern',
                    animation: 'zoom',
                    closeAnimation: 'zoom',
                    backgroundDismiss: true,
                    backgroundDismissAnimation: 'shake',
                    closeIcon: t");
                WriteLiteral(@"rue,
                    content: '' +
                        '<form action="""" class=""formName"">' +
                        '<div class=""form-group"">' +
                        '<label class=""text-success"">Total Requested Package is :' + totalPacks + ' </label></br>' +
                        '<label class=""text-dark font-weight-400"">Picked Up : </label>' +
                        '<input id = ""pickedUpPackageNumber"" class=""form-control pickedUpPackageNumber "" type=""number""/>' +
                        '</div>' +
                        '</form>',
                    buttons: {
                        formSubmit: {
                            text: 'Submit',
                            btnClass: 'btn-blue',
                            action: function () {
                                var pickedUpPackageNumber = this.$content.find('#pickedUpPackageNumber').val();
                                if (pickedUpPackageNumber == 0 && pickedUpPackageNumber > totalPacks) {
                        ");
                WriteLiteral("        } else\r\n                                {\r\n                                    var url = \'");
                EndContext();
                BeginContext(6731, 46, false);
#line 175 "D:\Project File\DroopBox\DoorBoxApp\Views\PickUpRequests\DeliveryManIndex.cshtml"
                                          Write(Url.Action("AddDeliveryManPickUp", "Packages"));

#line default
#line hidden
                EndContext();
                BeginContext(6777, 1233, true);
                WriteLiteral(@"';
                                    $.ajax({
                                        type: ""POST"",
                                        dataType: 'json',
                                        url: url,
                                        data: {
                                            id: id,
                                            pickedUpPackageNumber: pickedUpPackageNumber,
                                        },
                                        cache: false,
                                        success: function (result) {
                                            if (result) {
                                                location.reload();
                                            }
                                        }
                                    });
                                }
                            // submit
                            }
                        },
                    cancel: function () {
             ");
                WriteLiteral("           //close\r\n                        },\r\n                    },\r\n                    backgroundDismiss: true,\r\n                });\r\n                    });\r\n            });\r\n        });\r\n    </script>\r\n");
                EndContext();
#line 205 "D:\Project File\DroopBox\DoorBoxApp\Views\PickUpRequests\DeliveryManIndex.cshtml"
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
