#pragma checksum "D:\Project\Steve\Dotit\DotIt.AutoPicker\Views\Admin\AddProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c9deae3c905960b857106b9e2e899fc8220a0d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_AddProfile), @"mvc.1.0.view", @"/Views/Admin/AddProfile.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/AddProfile.cshtml", typeof(AspNetCore.Views_Admin_AddProfile))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c9deae3c905960b857106b9e2e899fc8220a0d1", @"/Views/Admin/AddProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bffac357899d226b4f9d8a5207455291a367109", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_AddProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DotIt.AutoPicker.Models.PickerModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(83, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "D:\Project\Steve\Dotit\DotIt.AutoPicker\Views\Admin\AddProfile.cshtml"
  
    ViewData["Title"] = "AddProfile";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(178, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(207, 558, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c9deae3c905960b857106b9e2e899fc8220a0d14912", async() => {
                BeginContext(213, 93, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Profile</title>\r\n    ");
                EndContext();
                BeginContext(306, 39, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c9deae3c905960b857106b9e2e899fc8220a0d15393", async() => {
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
                BeginContext(345, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(351, 52, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8c9deae3c905960b857106b9e2e899fc8220a0d16646", async() => {
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
                BeginContext(403, 355, true);
                WriteLiteral(@"
    <style>
        .PickerTable {
            max-width: 75%;
            align-content: center;
        }

        thead {
            text-align: center;
            font-size: xx-large;
        }

        tbody th {
            text-align: right;
        }

        tbody td {
            text-align: left;
        }
    </style>
");
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
            BeginContext(765, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(767, 5375, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c9deae3c905960b857106b9e2e899fc8220a0d19129", async() => {
                BeginContext(773, 31, true);
                WriteLiteral("\r\n    <div class=\"container\">\r\n");
                EndContext();
                BeginContext(1110, 2721, true);
                WriteLiteral(@"        <table class=""PickerTable"">
            <thead>
                <tr>
                    <th colspan=""2"" align=""center"">Picker Information</th>

                </tr>
            </thead>
            <tbody>
                <tr>
                    <th align=""right"">Name :</th>
                    <td>
                       
                        <input type=""text"" class=""emprole"" name=""Name"" id=""NameTextBox""  />
                    </td>
                </tr>
                <tr>
                    <th align=""right"">Email :</th>
                    <td>
                        <input type=""text"" name=""Email"" id=""EmailTextBox"" class=""emprole"" value="""" />
                    </td>
                </tr>

                <tr>
                    <th align=""right"">Max Lines :</th>
                    <td>
                        <input type=""number"" name=""TxtMaxLines"" id=""TxtMaxLines"" class=""emprole"" value="""" />
                    </td>
                </tr>
              ");
                WriteLiteral(@"  <tr>
                    <th align=""right"">Max Weight :</th>
                    <td>
                        <input type=""number"" name=""TxtMaxWeight"" id=""TxtMaxWeight"" class=""emprole"" value="""" />
                    </td>
                </tr>
                <tr>
                    <th align=""right"">Adminlineper Hour :</th>
                    <td>
                        <input type=""number"" name=""TxtAdminLinePerHour"" id=""TxtAdminLinePerHour"" class=""emprole"" value="""" />
                    </td>
                </tr>
                <tr>
                    <th align=""right"">User Height :</th>
                    <td>
                        <input type=""text"" name=""TxtUserHeight"" id=""TxtUserHeight"" class=""emprole"" value="""" />
                    </td>
                </tr>
                <tr style=""display:none;"">
                    <th align=""right"">Weight Capacity :</th>
                    <td>
                        <input type=""number"" name=""TxtWeightCapacity"" id=""TxtWeight");
                WriteLiteral(@"Capacity"" class=""emprole"" value="""" />
                    </td>
                </tr>
                <tr>
                    <th align=""right"">Role :</th>
                    <td>
                       
                    </td>
                </tr>
                <tr>
                    <td> <button class=""btn-info-grey"" onclick=""Cancel()"">CANCEL</button></td>
                    <td>
                        <button class=""btn-style-grey"" style=""margin-left:10px"" onclick=""AddProfile()"">SAVE</button>
                    </td>
                </tr>
            </tbody>
        </table>


        <br /><br />


    </div>

    <script>
");
                EndContext();
                BeginContext(4188, 1947, true);
                WriteLiteral(@"        var AddProfile = function () {
            debugger;
            var name = $(""#NameTextBox"").val();
            var email = $(""#EmailTextBox"").val();
            var role = $(""#RoleSelect"").children(""option:selected"").val();
            var NCCO = $(""#NCCOCheckbox"").prop(""checked"");
            var DotIt = $(""#DotItCheckbox"").prop(""checked"");
            var maxLines = $(""#TxtMaxLines"").val();
            var maxWeight = $(""#TxtMaxWeight"").val();
            var LinesPerHour = $(""#TxtAdminLinePerHour"").val();
            var dcdUserID = $(""#DcdUserID"").val();
            var UserHeight = $(""#TxtUserHeight"").val();
            var WeightCapacity = '';// $(""#TxtWeightCapacity"").val();
            //var Id =model.Empid;
            var Id = """";
            $.ajax('../../Admin/AddProfileData',
                {
                   
                    data: {
                        Empid:Id,
                        Name: name,
                        EMailAddress: email,
           ");
                WriteLiteral(@"             Grouplist: role,
                        Pickncco: NCCO,
                        Pickdotit: DotIt,
                        MaxLines: maxLines,
                        MaxWeight: maxWeight,
                        AdminlineperHour: LinesPerHour,
                        DcdUserID: dcdUserID,
                        UserHeight: UserHeight,
                        WeightCapacity: maxWeight
                    },
                    success: function (result) {
                        console.log(result);
                        if (result == ""Profile Add"") {
                            alert(""Profile Add"");
                            window.location.href = ""/Admin/Home"";
                        }
                    }, error: function (errorMsg)
                    {
                        console.log(errorMsg);
                    }
                })
        }
    </script>
");
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
            BeginContext(6142, 13, true);
            WriteLiteral("\r\n</html>\r\n\r\n");
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
