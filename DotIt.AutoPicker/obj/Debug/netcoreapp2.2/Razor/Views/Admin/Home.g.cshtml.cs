#pragma checksum "D:\Project\Steve\Dotit\DotIt.AutoPicker\Views\Admin\Home.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7368974366312b91053a91994b69bcf5114da66"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Home), @"mvc.1.0.view", @"/Views/Admin/Home.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/Home.cshtml", typeof(AspNetCore.Views_Admin_Home))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7368974366312b91053a91994b69bcf5114da66", @"/Views/Admin/Home.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bffac357899d226b4f9d8a5207455291a367109", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Home : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/AddProfile"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info-grey"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/GetEpicoreOrder"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/GetItemWithBinLocation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 8, true);
            WriteLiteral("<html>\r\n");
            EndContext();
            BeginContext(8, 104, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a7368974366312b91053a91994b69bcf5114da664892", async() => {
                BeginContext(14, 91, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n   \r\n    <title>Home</title>\r\n");
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
            BeginContext(112, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(114, 2374, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a7368974366312b91053a91994b69bcf5114da666173", async() => {
                BeginContext(120, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(126, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a7368974366312b91053a91994b69bcf5114da666558", async() => {
                    BeginContext(155, 3, true);
                    WriteLiteral("Add");
                    EndContext();
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
                BeginContext(162, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(168, 83, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a7368974366312b91053a91994b69bcf5114da667932", async() => {
                    BeginContext(228, 19, true);
                    WriteLiteral("Go For Order Assign");
                    EndContext();
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
                BeginContext(251, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(257, 88, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a7368974366312b91053a91994b69bcf5114da669410", async() => {
                    BeginContext(324, 17, true);
                    WriteLiteral("Show Binlocation ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(345, 64, true);
                WriteLiteral("\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n");
                EndContext();
                BeginContext(530, 607, true);
                WriteLiteral(@"                <th>
                    Pickers
                </th>
                <th>
                    Email
                </th>
                <th>
                    Role
                </th>
                <th>
                    Company
                </th>

                <th>
                    Max lines
                </th>
                <th>
                    Max Weight
                </th>
                <th>
                    Line per hour
                </th>
                <th></th>
            </tr>
        </thead>
        <tbody>
");
                EndContext();
#line 44 "D:\Project\Steve\Dotit\DotIt.AutoPicker\Views\Admin\Home.cshtml"
             foreach (var item in ViewBag.Pickers as List<DotIt.AutoPicker.Models.PickerModel>)
            {

#line default
#line hidden
                BeginContext(1350, 74, true);
                WriteLiteral("                <tr>\r\n                    <td>\r\n\r\n                        ");
                EndContext();
                BeginContext(1425, 9, false);
#line 49 "D:\Project\Steve\Dotit\DotIt.AutoPicker\Views\Admin\Home.cshtml"
                   Write(item.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1434, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(1514, 17, false);
#line 52 "D:\Project\Steve\Dotit\DotIt.AutoPicker\Views\Admin\Home.cshtml"
                   Write(item.EMailAddress);

#line default
#line hidden
                EndContext();
                BeginContext(1531, 159, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <div style=\"width:200px;overflow-wrap:break-word\">\r\n                            ");
                EndContext();
                BeginContext(1691, 14, false);
#line 56 "D:\Project\Steve\Dotit\DotIt.AutoPicker\Views\Admin\Home.cshtml"
                       Write(item.Grouplist);

#line default
#line hidden
                EndContext();
                BeginContext(1705, 113, true);
                WriteLiteral("\r\n                        </div>\r\n\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(1819, 12, false);
#line 61 "D:\Project\Steve\Dotit\DotIt.AutoPicker\Views\Admin\Home.cshtml"
                   Write(item.Company);

#line default
#line hidden
                EndContext();
                BeginContext(1831, 81, true);
                WriteLiteral("\r\n                    </td>\r\n\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(1913, 13, false);
#line 65 "D:\Project\Steve\Dotit\DotIt.AutoPicker\Views\Admin\Home.cshtml"
                   Write(item.MaxLines);

#line default
#line hidden
                EndContext();
                BeginContext(1926, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(2006, 14, false);
#line 68 "D:\Project\Steve\Dotit\DotIt.AutoPicker\Views\Admin\Home.cshtml"
                   Write(item.MaxWeight);

#line default
#line hidden
                EndContext();
                BeginContext(2020, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(2100, 21, false);
#line 71 "D:\Project\Steve\Dotit\DotIt.AutoPicker\Views\Admin\Home.cshtml"
                   Write(item.AdminlineperHour);

#line default
#line hidden
                EndContext();
                BeginContext(2121, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(2200, 71, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a7368974366312b91053a91994b69bcf5114da6615209", async() => {
                    BeginContext(2263, 4, true);
                    WriteLiteral("Edit");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 2209, "~/Admin/EditProfile/", 2209, 20, true);
#line 74 "D:\Project\Steve\Dotit\DotIt.AutoPicker\Views\Admin\Home.cshtml"
AddHtmlAttributeValue("", 2229, Constant.Encode(item.DcdUserID), 2229, 32, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2271, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(2384, 50, true);
                WriteLiteral("                    </td>\r\n                </tr>\r\n");
                EndContext();
#line 78 "D:\Project\Steve\Dotit\DotIt.AutoPicker\Views\Admin\Home.cshtml"
            }

#line default
#line hidden
                BeginContext(2449, 32, true);
                WriteLiteral("        </tbody>\r\n    </table>\r\n");
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
            BeginContext(2488, 13, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
