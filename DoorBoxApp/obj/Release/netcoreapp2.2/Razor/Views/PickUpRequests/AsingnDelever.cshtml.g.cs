#pragma checksum "D:\Project File\DroopBox\DoorBoxApp\Views\PickUpRequests\AsingnDelever.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89d2ba2f9b9f2d9d0cb0ae09d9abf6dd9ca4165f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PickUpRequests_AsingnDelever), @"mvc.1.0.view", @"/Views/PickUpRequests/AsingnDelever.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/PickUpRequests/AsingnDelever.cshtml", typeof(AspNetCore.Views_PickUpRequests_AsingnDelever))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89d2ba2f9b9f2d9d0cb0ae09d9abf6dd9ca4165f", @"/Views/PickUpRequests/AsingnDelever.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db0bb7675d3dc7f4369941d6c52fb8cf421deb36", @"/Views/_ViewImports.cshtml")]
    public class Views_PickUpRequests_AsingnDelever : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DoorBoxApp.Models.Package>>
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Project File\DroopBox\DoorBoxApp\Views\PickUpRequests\AsingnDelever.cshtml"
  
    ViewData["Title"] = "Asingn Delevery";

#line default
#line hidden
            DefineSection("Css", async() => {
                BeginContext(114, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 7 "D:\Project File\DroopBox\DoorBoxApp\Views\PickUpRequests\AsingnDelever.cshtml"
      await Html.RenderPartialAsync("_DataTableCssPartial");

#line default
#line hidden
            }
            );
            BeginContext(182, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Sole", async() => {
                BeginContext(199, 242, true);
                WriteLiteral("\r\n    <style>\r\n        .table tr th:last-child {\r\n            width: 100px;\r\n        }\r\n\r\n        .table tr th {\r\n            text-align: center;\r\n        }\r\n\r\n        .table tr td {\r\n            text-align: center;\r\n        }\r\n    </style>\r\n");
                EndContext();
            }
            );
            BeginContext(444, 824, true);
            WriteLiteral(@"<div class=""container-fluid mt-4"">
    <div class=""card animated fadeIn overflow-hidden"">
        <div class=""card-header p-3"">
            <div class=""row align-items-center"">
                <div class=""col"">
                    <h3 class=""mb-0 skewed skewed-yellow text-dark d-inline-block text-uppercase text-white ls-1"">Asingn Delevery</h3>
                </div>
            </div>
        </div>
        <div class=""card-body px-0 pb-2"">
            <div class=""table-responsive"">

                <table class=""table align-items-center table-responsive-sm table-striped table-bordered"" id=""datatable-basic"">
                    <thead class=""thead-light"">
                        <tr>
                            <th>
                                Merchant Name
                            </th>
");
            EndContext();
            BeginContext(1397, 1012, true);
            WriteLiteral(@"                            <th>
                                Client  Name
                            </th>
                            <th>
                                Client  Phone
                            </th>
                            <th>
                                Address
                            </th>
                            <th>
                                Location
                            </th>
                            <th>
                                Sub-Location
                            </th>

                            <th>
                                Price
                            </th>

                            <th>
                                Tracking NO
                            </th>
                            <th class=""text-center"">
                                Action
                            </th>
                        </tr>
                    </thead>
                    <tbody>
");
            EndContext();
#line 75 "D:\Project File\DroopBox\DoorBoxApp\Views\PickUpRequests\AsingnDelever.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
            BeginContext(2490, 34, true);
            WriteLiteral("                            <tr>\r\n");
            EndContext();
#line 78 "D:\Project File\DroopBox\DoorBoxApp\Views\PickUpRequests\AsingnDelever.cshtml"
                                 if (item.PickUpRequest.Merchant != null)
                                {

#line default
#line hidden
            BeginContext(2634, 82, true);
            WriteLiteral("                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(2717, 32, false);
#line 81 "D:\Project File\DroopBox\DoorBoxApp\Views\PickUpRequests\AsingnDelever.cshtml"
                                   Write(item.PickUpRequest.Merchant.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2749, 47, true);
            WriteLiteral("\r\n\r\n                                    </td>\r\n");
            EndContext();
#line 87 "D:\Project File\DroopBox\DoorBoxApp\Views\PickUpRequests\AsingnDelever.cshtml"
                                               

                                }
                                else
                                {

#line default
#line hidden
            BeginContext(3103, 260, true);
            WriteLiteral(@"                                    <td>
                                        N/A
                                    </td>
                                    <td>
                                        N/A
                                    </td>
");
            EndContext();
#line 98 "D:\Project File\DroopBox\DoorBoxApp\Views\PickUpRequests\AsingnDelever.cshtml"

                                }

#line default
#line hidden
            BeginContext(3400, 76, true);
            WriteLiteral("\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(3477, 15, false);
#line 102 "D:\Project File\DroopBox\DoorBoxApp\Views\PickUpRequests\AsingnDelever.cshtml"
                               Write(item.ClientName);

#line default
#line hidden
            EndContext();
            BeginContext(3492, 70, true);
            WriteLiteral("\r\n                                    <input type=\"hidden\" name=\"name\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3562, "\"", 3579, 1);
#line 103 "D:\Project File\DroopBox\DoorBoxApp\Views\PickUpRequests\AsingnDelever.cshtml"
WriteAttributeValue("", 3570, item.OTP, 3570, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3580, 120, true);
            WriteLiteral(" />\r\n                                </td>\r\n\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(3701, 16, false);
#line 107 "D:\Project File\DroopBox\DoorBoxApp\Views\PickUpRequests\AsingnDelever.cshtml"
                               Write(item.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(3717, 133, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td class=\"text-wrap\">\r\n                                    ");
            EndContext();
            BeginContext(3851, 12, false);
#line 110 "D:\Project File\DroopBox\DoorBoxApp\Views\PickUpRequests\AsingnDelever.cshtml"
                               Write(item.Address);

#line default
#line hidden
            EndContext();
            BeginContext(3863, 43, true);
            WriteLiteral("\r\n                                </td>\r\n\r\n");
            EndContext();
#line 113 "D:\Project File\DroopBox\DoorBoxApp\Views\PickUpRequests\AsingnDelever.cshtml"
                                 if (item.LocationTo != null)
                                {

#line default
#line hidden
            BeginContext(4004, 82, true);
            WriteLiteral("                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(4087, 20, false);
#line 116 "D:\Project File\DroopBox\DoorBoxApp\Views\PickUpRequests\AsingnDelever.cshtml"
                                   Write(item.LocationTo.Name);

#line default
#line hidden
            EndContext();
            BeginContext(4107, 47, true);
            WriteLiteral("\r\n\r\n                                    </td>\r\n");
            EndContext();
#line 119 "D:\Project File\DroopBox\DoorBoxApp\Views\PickUpRequests\AsingnDelever.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(4262, 130, true);
            WriteLiteral("                                    <td>\r\n                                        N/A\r\n                                    </td>\r\n");
            EndContext();
#line 125 "D:\Project File\DroopBox\DoorBoxApp\Views\PickUpRequests\AsingnDelever.cshtml"
                                }

#line default
#line hidden
#line 126 "D:\Project File\DroopBox\DoorBoxApp\Views\PickUpRequests\AsingnDelever.cshtml"
                                 if (item.SubLocation != null)
                                {

#line default
#line hidden
            BeginContext(4526, 82, true);
            WriteLiteral("                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(4609, 21, false);
#line 129 "D:\Project File\DroopBox\DoorBoxApp\Views\PickUpRequests\AsingnDelever.cshtml"
                                   Write(item.SubLocation.Name);

#line default
#line hidden
            EndContext();
            BeginContext(4630, 47, true);
            WriteLiteral("\r\n\r\n                                    </td>\r\n");
            EndContext();
#line 132 "D:\Project File\DroopBox\DoorBoxApp\Views\PickUpRequests\AsingnDelever.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(4785, 130, true);
            WriteLiteral("                                    <td>\r\n                                        N/A\r\n                                    </td>\r\n");
            EndContext();
#line 138 "D:\Project File\DroopBox\DoorBoxApp\Views\PickUpRequests\AsingnDelever.cshtml"
                                }

#line default
#line hidden
            BeginContext(4950, 94, true);
            WriteLiteral("\r\n                                <td class=\"text-wrap\">\r\n                                    ");
            EndContext();
            BeginContext(5045, 17, false);
#line 141 "D:\Project File\DroopBox\DoorBoxApp\Views\PickUpRequests\AsingnDelever.cshtml"
                               Write(item.ProductPrice);

#line default
#line hidden
            EndContext();
            BeginContext(5062, 117, true);
            WriteLiteral("\r\n                                </td>\r\n\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(5180, 19, false);
#line 145 "D:\Project File\DroopBox\DoorBoxApp\Views\PickUpRequests\AsingnDelever.cshtml"
                               Write(item.TrackingNumber);

#line default
#line hidden
            EndContext();
            BeginContext(5199, 162, true);
            WriteLiteral("\r\n                                </td>\r\n\r\n                                <td class=\"text-center\">\r\n                                    <div class=\"btn-group\">\r\n");
            EndContext();
#line 150 "D:\Project File\DroopBox\DoorBoxApp\Views\PickUpRequests\AsingnDelever.cshtml"
                                         if (item.Status == 2)
                                        {

#line default
#line hidden
            BeginContext(5468, 254, true);
            WriteLiteral("                                           <input type=\"button\" class=\"btn btn-info  btn-sm DeliveryMan\" value=\"Delivery Man\" />\r\n                                           <input type=\"button\" class=\"btn btn-default btn-sm  Vendor\" value=\"Vendor\" />  \r\n");
            EndContext();
#line 154 "D:\Project File\DroopBox\DoorBoxApp\Views\PickUpRequests\AsingnDelever.cshtml"
                                        }

#line default
#line hidden
            BeginContext(5765, 120, true);
            WriteLiteral("\r\n                                    </div>\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 159 "D:\Project File\DroopBox\DoorBoxApp\Views\PickUpRequests\AsingnDelever.cshtml"
                        }

#line default
#line hidden
            BeginContext(5912, 118, true);
            WriteLiteral("                    </tbody>\r\n\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(6048, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(6056, 119, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89d2ba2f9b9f2d9d0cb0ae09d9abf6dd9ca4165f17363", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
#line 171 "D:\Project File\DroopBox\DoorBoxApp\Views\PickUpRequests\AsingnDelever.cshtml"
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
                BeginContext(6175, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(6181, 123, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89d2ba2f9b9f2d9d0cb0ae09d9abf6dd9ca4165f19527", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
#line 172 "D:\Project File\DroopBox\DoorBoxApp\Views\PickUpRequests\AsingnDelever.cshtml"
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
                BeginContext(6304, 337, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
         $(document).ready(function () {
             $('.DeliveryMan').on('click', function () {
                var row = $(this).closest('tr');
                /*var id = row.find('.id').val();*/
                var dmData = '';
                var pmData = '';
                var url = '");
                EndContext();
                BeginContext(6642, 43, false);
#line 180 "D:\Project File\DroopBox\DoorBoxApp\Views\PickUpRequests\AsingnDelever.cshtml"
                      Write(Url.Action("GetDelivaryMen", "DeliveryMen"));

#line default
#line hidden
                EndContext();
                BeginContext(6685, 32, true);
                WriteLiteral("\';\r\n                var urls = \'");
                EndContext();
                BeginContext(6718, 37, false);
#line 181 "D:\Project File\DroopBox\DoorBoxApp\Views\PickUpRequests\AsingnDelever.cshtml"
                       Write(Url.Action("GetPackages", "Packages"));

#line default
#line hidden
                EndContext();
                BeginContext(6755, 3191, true);
                WriteLiteral(@"';
                dmData += '<option selected value=""0"">Delivary Man</option>';
                pmData += '<option selected value=""0""> Packages </option>';
                $.when(
                $.ajax({
                    type: ""POST"",
                    dataType: 'json',
                    url: url,
                    data: {
                    },
                    cache: false,
                    success: function (objects) {
                        $.each(objects, function (index, object) {

                            if (objects != null) {
                                dmData += '<option value=""' + object.id + '"">' + object.name + ' </option>';
                            }
                        });
                    }
                }),
                $.ajax({
                        type: ""POST"",
                        dataType: 'json',
                        url: urls,
                        data: {
                        },
                        cach");
                WriteLiteral(@"e: false,
                        success: function (objects) {
                            $.each(objects, function (index, object) {
                                if (objects != null) {
                                    pmData += '<option value=""' + object.id + '"">' + object.clientName + ' </option>';
                                }
                            });
                        }
                }),
                ).then(function () {

                $.confirm({
                    title: 'Assign Delivey Man !',
                    theme: 'modern',
                    animation: 'zoom',
                    closeAnimation: 'zoom',
                    backgroundDismiss: true,
                    backgroundDismissAnimation: 'shake',
                    closeIcon: true,
                    content: '' +

                        '<form action="""" class=""formName"">' +
                        '<div class=""form-group"">' +
                        '<label class=""text-danger"">Pl");
                WriteLiteral(@"ease select a Delivary Man</label>' +
                        '<select id = ""delivaryManId"" class=""form-control sectionId js-single"">' + dmData + '</select>'+
                        '</div>' +
                        '<div class=""form-group"">' +
                        '<label class=""text-danger"">Please select a Packeges </label>' +
                        '<select id = ""packagesId"" class=""form-control sectionId js-single"">' + pmData + '</select>' +
                        '</div>' +
                        '</form>',

                    buttons: {
                        formSubmit: {
                            text: 'Submit',
                            btnClass: 'btn-blue',
                            action: function () {
                                var delivaryManId = this.$content.find('#delivaryManId').val();
                                var packagesId = this.$content.find('#packagesId').val();
                                if (delivaryManId == 0 && packagesId == 0) {

   ");
                WriteLiteral("                             } else\r\n                                {\r\n                                    var url = \'");
                EndContext();
                BeginContext(9947, 50, false);
#line 250 "D:\Project File\DroopBox\DoorBoxApp\Views\PickUpRequests\AsingnDelever.cshtml"
                                          Write(Url.Action("AddDeleverDelivaryMan", "DeliveryMen"));

#line default
#line hidden
                EndContext();
                BeginContext(9997, 1596, true);
                WriteLiteral(@"';
                                    $.ajax({
                                        type: ""POST"",
                                        dataType: 'json',
                                        url: url,
                                        data: {
                                            delivaryManId: delivaryManId,
                                            packagesId: packagesId,
                                        },
                                        cache: false,
                                        success: function (result) {
                                            if (result) {
                                                location.href = '/PickUpRequests/AsingnDelever';
                                            }

                                        }
                                    });
                                }
                            // submit
                            }
                        },
                    canc");
                WriteLiteral(@"el: function () {
                        //close
                        },
                    },
                    backgroundDismiss: true,

                });

                });
            });
        });
    </script>

    <script type=""text/javascript"">
         $(document).ready(function () {
             $('.Vendor').on('click', function () {
               var row = $(this).closest('tr');
              /*  var id = row.find('.id').val();*/
                var vnData = '';
                var pmData = '';
                var url = '");
                EndContext();
                BeginContext(11594, 34, false);
#line 291 "D:\Project File\DroopBox\DoorBoxApp\Views\PickUpRequests\AsingnDelever.cshtml"
                      Write(Url.Action("GetVendor", "Vendors"));

#line default
#line hidden
                EndContext();
                BeginContext(11628, 32, true);
                WriteLiteral("\';\r\n                var urls = \'");
                EndContext();
                BeginContext(11661, 37, false);
#line 292 "D:\Project File\DroopBox\DoorBoxApp\Views\PickUpRequests\AsingnDelever.cshtml"
                       Write(Url.Action("GetPackages", "Packages"));

#line default
#line hidden
                EndContext();
                BeginContext(11698, 3163, true);
                WriteLiteral(@"';
                vnData += '<option selected value=""0""> Vendors </option>';
                pmData += '<option selected value=""0""> Packages </option>';
                $.when(
                $.ajax({
                    type: ""POST"",
                    dataType: 'json',
                    url: url,
                    data: {
                    },
                    cache: false,
                    success: function (objects) {
                        $.each(objects, function (index, object) {

                            if (objects != null) {
                                vnData += '<option value=""' + object.id + '"">' + object.name + ' </option>';
                            }
                        });
                    }
                }),
                $.ajax({
                        type: ""POST"",
                        dataType: 'json',
                        url: urls,
                        data: {
                        },
                        cache: ");
                WriteLiteral(@"false,
                        success: function (objects) {
                            $.each(objects, function (index, object) {
                                if (objects != null) {
                                    pmData += '<option value=""' + object.id + '"">' + object.clientName + ' </option>';
                                }
                            });
                        }
                }),
                ).then(function () {

                $.confirm({
                    title: 'Assign Vendor !',
                    theme: 'modern',
                    animation: 'zoom',
                    closeAnimation: 'zoom',
                    backgroundDismiss: true,
                    backgroundDismissAnimation: 'shake',
                    closeIcon: true,
                    content: '' +

                        '<form action="""" class=""formName"">' +
                        '<div class=""form-group"">' +
                        '<label class=""text-danger"">Please sel");
                WriteLiteral(@"ect a Vendors </label>' +
                        '<select id = ""vendorsId"" class=""form-control sectionId js-single"">' + vnData + '</select>'+
                        '</div>' +
                        '<div class=""form-group"">' +
                        '<label class=""text-danger"">Please select a Packeges </label>' +
                        '<select id = ""packagesId"" class=""form-control sectionId js-single"">' + pmData + '</select>' +
                        '</div>' +
                        '</form>',

                    buttons: {
                        formSubmit: {
                            text: 'Submit',
                            btnClass: 'btn-blue',
                            action: function () {
                                var vendorsId = this.$content.find('#vendorsId').val();
                                var packagesId = this.$content.find('#packagesId').val();
                                if (vendorsId == 0 && packagesId == 0) {

                               ");
                WriteLiteral(" } else\r\n                                {\r\n                                    var url = \'");
                EndContext();
                BeginContext(14862, 37, false);
#line 361 "D:\Project File\DroopBox\DoorBoxApp\Views\PickUpRequests\AsingnDelever.cshtml"
                                          Write(Url.Action("AssignVendor", "Vendors"));

#line default
#line hidden
                EndContext();
                BeginContext(14899, 1259, true);
                WriteLiteral(@"';
                                    $.ajax({
                                        type: ""POST"",
                                        dataType: 'json',
                                        url: url,
                                        data: {
                                            vendorsId: vendorsId,
                                            packagesId: packagesId,
                                        },
                                        cache: false,
                                        success: function (result) {
                                            if (result) {
                                                location.href = '/PickUpRequests/AsingnDelever';
                                            }

                                        }
                                    });
                                }
                            // submit
                            }
                        },
                    cancel: func");
                WriteLiteral("tion () {\r\n                        //close\r\n                        },\r\n                    },\r\n                    backgroundDismiss: true,\r\n\r\n                });\r\n\r\n                });\r\n            });\r\n        });\r\n    </script>\r\n\r\n");
                EndContext();
#line 395 "D:\Project File\DroopBox\DoorBoxApp\Views\PickUpRequests\AsingnDelever.cshtml"
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
