#pragma checksum "D:\Project\Steve\Dotit\DotIt.AutoPicker\Views\Admin\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "162bfbeaec2cf5e208a27382f5a8cb42266f407d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Profile), @"mvc.1.0.view", @"/Views/Admin/Profile.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/Profile.cshtml", typeof(AspNetCore.Views_Admin_Profile))]
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
#line 1 "D:\Project\Steve\Dotit\DotIt.AutoPicker\Views\_ViewImports.cshtml"
using DotIt.AutoPicker;

#line default
#line hidden
#line 2 "D:\Project\Steve\Dotit\DotIt.AutoPicker\Views\_ViewImports.cshtml"
using DotIt.AutoPicker.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"162bfbeaec2cf5e208a27382f5a8cb42266f407d", @"/Views/Admin/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bffac357899d226b4f9d8a5207455291a367109", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DotIt.AutoPicker.Models.PickerModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "BAS", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "EXP", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "SEN", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "NCC", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Project\Steve\Dotit\DotIt.AutoPicker\Views\Admin\Profile.cshtml"
  
    //Layout = null;

#line default
#line hidden
            BeginContext(75, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(104, 294, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "162bfbeaec2cf5e208a27382f5a8cb42266f407d6127", async() => {
                BeginContext(110, 93, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Profile</title>\r\n    ");
                EndContext();
                BeginContext(203, 39, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "162bfbeaec2cf5e208a27382f5a8cb42266f407d6608", async() => {
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
                EndContext();
                BeginContext(242, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(248, 52, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "162bfbeaec2cf5e208a27382f5a8cb42266f407d7861", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(300, 91, true);
                WriteLiteral("\r\n    <style>\r\n        .emprole {\r\n            max-width: 250px;\r\n        }\r\n    </style>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(398, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(400, 3800, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "162bfbeaec2cf5e208a27382f5a8cb42266f407d10090", async() => {
                BeginContext(406, 31, true);
                WriteLiteral("\r\n    <div class=\"container\">\r\n");
                EndContext();
                BeginContext(743, 103, true);
                WriteLiteral("        <label>Name : </label>\r\n        <input type=\"text\" class=\"emprole\" name=\"Name\" id=\"NameTextBox\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 846, "\"", 883, 1);
#line 31 "D:\Project\Steve\Dotit\DotIt.AutoPicker\Views\Admin\Profile.cshtml"
WriteAttributeValue("", 854, ViewBag.EmployeeDetails.Name, 854, 29, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(884, 123, true);
                WriteLiteral(" /><br /><br />\r\n        <label>Email : </label>\r\n        <input type=\"text\" name=\"Email\" id=\"EmailTextBox\" class=\"emprole\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1007, "\"", 1045, 1);
#line 33 "D:\Project\Steve\Dotit\DotIt.AutoPicker\Views\Admin\Profile.cshtml"
WriteAttributeValue("", 1015, ViewBag.EmployeeDetails.Email, 1015, 30, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1046, 125, true);
                WriteLiteral(" /><br /><br />\r\n        <label>\r\n            Role :  <select class=\"form-control emprole\" id=\"RoleSelect\">\r\n                ");
                EndContext();
                BeginContext(1171, 41, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "162bfbeaec2cf5e208a27382f5a8cb42266f407d11843", async() => {
                    BeginContext(1191, 12, true);
                    WriteLiteral("Basic Picker");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1212, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(1230, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "162bfbeaec2cf5e208a27382f5a8cb42266f407d13332", async() => {
                    BeginContext(1250, 18, true);
                    WriteLiteral("Experienced Picker");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1277, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(1295, 42, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "162bfbeaec2cf5e208a27382f5a8cb42266f407d14827", async() => {
                    BeginContext(1315, 13, true);
                    WriteLiteral("Senior Picker");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1337, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(1355, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "162bfbeaec2cf5e208a27382f5a8cb42266f407d16317", async() => {
                    BeginContext(1375, 11, true);
                    WriteLiteral("NCCO Picker");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1395, 333, true);
                WriteLiteral(@"
            </select>
        </label>
        <br /><br />
        <label>Pick : </label>

        <input type=""checkbox"" id=""NCCOCheckbox"" value=""NCCO"" />NCCO
        <input type=""checkbox"" id=""DotItCheckbox"" value=""DotIt"" />DotIt<br /><br />
        <label>Max Lines : </label>
        <input type=""number"" id=""MaxLines""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1728, "\"", 1769, 1);
#line 48 "D:\Project\Steve\Dotit\DotIt.AutoPicker\Views\Admin\Profile.cshtml"
WriteAttributeValue("", 1736, ViewBag.EmployeeDetails.Maxlines, 1736, 33, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1770, 97, true);
                WriteLiteral(" /><br /><br />\r\n        <label>Max Weight :</label>\r\n        <input type=\"number\" id=\"MaxWeight\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1867, "\"", 1909, 1);
#line 50 "D:\Project\Steve\Dotit\DotIt.AutoPicker\Views\Admin\Profile.cshtml"
WriteAttributeValue("", 1875, ViewBag.EmployeeDetails.Maxweight, 1875, 34, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1910, 105, true);
                WriteLiteral(" /><br /><br />\r\n        <label>Lines per Hour : </label>\r\n        <input type=\"number\" id=\"LinesPerHour\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2015, "\"", 2064, 1);
#line 52 "D:\Project\Steve\Dotit\DotIt.AutoPicker\Views\Admin\Profile.cshtml"
WriteAttributeValue("", 2023, ViewBag.EmployeeDetails.Adminlineperhour, 2023, 41, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2065, 268, true);
                WriteLiteral(@" />

        <br /><br />
        <button class=""btn-info-grey"" onclick=""Cancel()"">CANCEL</button>
        <button class=""btn-style-grey"" style=""margin-left:10px"" onclick=""UpdateProfile()"">SAVE</button>
    </div>

    <script>
        $(""select option[value='");
                EndContext();
                BeginContext(2334, 28, false);
#line 60 "D:\Project\Steve\Dotit\DotIt.AutoPicker\Views\Admin\Profile.cshtml"
                           Write(ViewBag.EmployeeDetails.Role);

#line default
#line hidden
                EndContext();
                BeginContext(2362, 49, true);
                WriteLiteral("\']\").attr(\"selected\", \"selected\");\r\n        if (\'");
                EndContext();
                BeginContext(2412, 32, false);
#line 61 "D:\Project\Steve\Dotit\DotIt.AutoPicker\Views\Admin\Profile.cshtml"
        Write(ViewBag.EmployeeDetails.Pickncco);

#line default
#line hidden
                EndContext();
                BeginContext(2444, 94, true);
                WriteLiteral("\'== \"True\") {\r\n            $(\"#NCCOCheckbox\").prop(\'checked\', true);\r\n        }\r\n        if (\'");
                EndContext();
                BeginContext(2539, 33, false);
#line 64 "D:\Project\Steve\Dotit\DotIt.AutoPicker\Views\Admin\Profile.cshtml"
        Write(ViewBag.EmployeeDetails.Pickdotit);

#line default
#line hidden
                EndContext();
                BeginContext(2572, 626, true);
                WriteLiteral(@"'== ""True"") {
            $(""#DotItCheckbox"").prop('checked', true);
        }
        var UpdateProfile = function () {
            debugger;
            var name = $(""#NameTextBox"").val();
            var email = $(""#EmailTextBox"").val();
            var role = $(""#RoleSelect"").children(""option:selected"").val();
            var NCCO = $(""#NCCOCheckbox"").prop(""checked"");
            var DotIt = $(""#DotItCheckbox"").prop(""checked"");
            var maxLines = $(""#MaxLines"").val();
            var maxWeight = $(""#MaxWeight"").val();
            var LinesPerHour = $(""#LinesPerHour"").val();
            var Id =");
                EndContext();
                BeginContext(3199, 29, false);
#line 77 "D:\Project\Steve\Dotit\DotIt.AutoPicker\Views\Admin\Profile.cshtml"
               Write(ViewBag.EmployeeDetails.Empid);

#line default
#line hidden
                EndContext();
                BeginContext(3228, 782, true);
                WriteLiteral(@";
            $.ajax('../../Admin/SaveProfile',
                {
                    data: {
                        Empid:Id,
                        Name: name,
                        Email: email,
                        Role: role,
                        Pickncco: NCCO,
                        Pickdotit: DotIt,
                        Maxlines: maxLines,
                        Maxweight: maxWeight,
                        Adminlineperhour: LinesPerHour,
                    },
                    success: function (result) {
                        console.log(result);
                        if (result == ""Profile updated"") {
                            window.location.href = """";
                            window.location.href = ""/Admin/Home"";
");
                EndContext();
                BeginContext(4097, 96, true);
                WriteLiteral("                        }\r\n                    }\r\n                })\r\n        }\r\n    </script>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4200, 11, true);
            WriteLiteral("\r\n</html>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DotIt.AutoPicker.Models.PickerModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
