#pragma checksum "E:\Projects\MMS\MMS\MealManagementSytem\MealManagementSytem\Views\Schedule\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "932a9ab7e74e44509212c8f0612863b05eb78c4f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Schedule_Index), @"mvc.1.0.view", @"/Views/Schedule/Index.cshtml")]
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
#nullable restore
#line 1 "E:\Projects\MMS\MMS\MealManagementSytem\MealManagementSytem\Views\_ViewImports.cshtml"
using MealManagementSytem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Projects\MMS\MMS\MealManagementSytem\MealManagementSytem\Views\_ViewImports.cshtml"
using MealManagementSytem.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Projects\MMS\MMS\MealManagementSytem\MealManagementSytem\Views\Schedule\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"932a9ab7e74e44509212c8f0612863b05eb78c4f", @"/Views/Schedule/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40d483ef90318bd996d551e8b23acc48c5bf4e96", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Schedule_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MealManagementSytem.Entities.ViewName>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Schedule/Schedule.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Views/Partial/_CDN.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "E:\Projects\MMS\MMS\MealManagementSytem\MealManagementSytem\Views\Schedule\Index.cshtml"
  
    ViewData["Title"] = "Index";
    var dt = System.DateTime.Now;
    ViewBag.month = dt.Month;
    ViewBag.year = dt.Year;
    ViewBag.days = DateTime.DaysInMonth(dt.Year, dt.Month);
    var checkLogintype = @HttpContextAccessor.HttpContext.Session.GetString("UserType"); ;


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<style>\r\n    #checkbox {\r\n        display: inline-block;\r\n    }\r\n\r\n    .div-schedule {\r\n        margin-left: 0px;\r\n        margin-top: 200px;\r\n    }\r\n\r\n    .calender {\r\n        margin-top: 400px;\r\n    }\r\n</style>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "932a9ab7e74e44509212c8f0612863b05eb78c4f5407", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "932a9ab7e74e44509212c8f0612863b05eb78c4f6446", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<div class=\"row\" style=\"margin-top:200px;\">\r\n");
#nullable restore
#line 34 "E:\Projects\MMS\MMS\MealManagementSytem\MealManagementSytem\Views\Schedule\Index.cshtml"
     foreach (var value in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-sm-3\">\r\n            <div class=\"card\">\r\n");
            WriteLiteral("                <div class=\"card-body\">\r\n                    <blockquote class=\"blockquote mb-0\">\r\n                        <p>");
#nullable restore
#line 43 "E:\Projects\MMS\MMS\MealManagementSytem\MealManagementSytem\Views\Schedule\Index.cshtml"
                      Write(value.MemberName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <footer class=\"blockquote-footer\">\r\n                            <span class=\"badge badge-primary\">");
#nullable restore
#line 45 "E:\Projects\MMS\MMS\MealManagementSytem\MealManagementSytem\Views\Schedule\Index.cshtml"
                                                         Write(value.Date.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </footer>\r\n                    </blockquote>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 51 "E:\Projects\MMS\MMS\MealManagementSytem\MealManagementSytem\Views\Schedule\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n<div class=\"row div-schedule\">\r\n    <div class=\"col-sm-4\">\r\n        <div class=\"mt-5 mr-lg-5\">\r\n            <select style=\"width:50%\" class=\"form-control\" id=\"ddlNameList\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "932a9ab7e74e44509212c8f0612863b05eb78c4f9359", async() => {
                WriteLiteral("Select Name");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </select>
        </div>
        <table id=""div_func"" class=""table table-striped table-responsive mt-5"">
            <thead>
                <tr style=""width:400px"">
                    <th>
                        Select
                    </th>
                    <th>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</th>
                    <th>
                        Date
                    </th>
                </tr>
            </thead>
");
#nullable restore
#line 73 "E:\Projects\MMS\MMS\MealManagementSytem\MealManagementSytem\Views\Schedule\Index.cshtml"
             for (int i = 1; i <= @ViewBag.days; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <tbody>
                    <tr>
                        <td>
                            <input id=""checkbox"" class=""check"" name=""lang"" type=""checkbox"" />
                        </td>
                        <td></td>
                        <td>
                            ");
#nullable restore
#line 82 "E:\Projects\MMS\MMS\MealManagementSytem\MealManagementSytem\Views\Schedule\Index.cshtml"
                       Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("-");
#nullable restore
#line 82 "E:\Projects\MMS\MMS\MealManagementSytem\MealManagementSytem\Views\Schedule\Index.cshtml"
                          Write(ViewBag.month);

#line default
#line hidden
#nullable disable
            WriteLiteral("-");
#nullable restore
#line 82 "E:\Projects\MMS\MMS\MealManagementSytem\MealManagementSytem\Views\Schedule\Index.cshtml"
                                         Write(ViewBag.year);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n                </tbody>\r\n");
#nullable restore
#line 86 "E:\Projects\MMS\MMS\MealManagementSytem\MealManagementSytem\Views\Schedule\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n    </div>\r\n    <div class=\"calender mt-5 col-sm-8\" style=\"font-size:40px\" ;>\r\n        <div id=\"txtDate\"></div>\r\n");
#nullable restore
#line 91 "E:\Projects\MMS\MMS\MealManagementSytem\MealManagementSytem\Views\Schedule\Index.cshtml"
         if (checkLogintype == "Admin")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <button type=\"submit\" class=\"btn btn-sm btn-primary ml-5\" style=\"margin-left:300px!important;\" onclick=\"SaveSchedule()\">Confirm</button>\r\n");
#nullable restore
#line 94 "E:\Projects\MMS\MMS\MealManagementSytem\MealManagementSytem\Views\Schedule\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>
</div>

<script>
    $(function () {
        $(""#txtDate"").datepicker({
            showOn: 'button',
            buttonImageOnly: true,
            buttonImage: 'images/calendar.gif',
            dateFormat: 'dd/mm/yy',
            minDate: new Date()
        });
    });

    var array = [];
    $('.table tbody').on('click', '.check', function () {
        var mId = $('#ddlNameList option:selected').val();
        if (mId == 0) {
            all = document.getElementsByName('lang');
            for (var a = 0; a < all.length; a++) {
                all[a].checked = false;
            }
            alert(""Select Name First!!!!"");
        }
        else {
            var currow = $(this).closest('tr');
            var col1 = currow.find('td:eq(0)').text();
            var col2 = currow.find('td:eq(2)').text();
            var obj = {
                memberId: mId,
                date: col2.trim(),
            }
            array.push(obj);
        }

    });
    ");
            WriteLiteral(@"var ScheduleDate = [];
    function findAlreadyEntryDate() {
        $.ajax({
            url: ""/Schedule/FindAlreadyEntryDate"",
            type: 'GET',
            dataType: 'json',
            success: function (data) {
                ScheduleDate = data;
                console.warn(ScheduleDate);
            }
        });
    }
    function SaveSchedule() {
        var data = array;
        $.ajax({
            url: '/Schedule/AddSchedule',
            data: { ""prm"": data },
            type: ""POST"",
            dataType: ""json"",
            async: true,
            success: function (result) {
                array = [];
                $('#ddlNameList').val(0);
                all = document.getElementsByName('lang');
                for (var a = 0; a < all.length; a++) {
                    all[a].checked = false;
                }
                toastr.success(result);
            },
            error: function () {
                toastr.success(result);
            ");
            WriteLiteral("}\r\n        });\r\n\r\n    }\r\n\r\n</script>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor HttpContextAccessor { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MealManagementSytem.Entities.ViewName>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591