#pragma checksum "D:\Project\Steve\Dotit\DotIt.AutoPicker\Views\Admin\GetItemWithBinLocation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70867b2f2a2daedbc87232fbd87374d96de1613a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_GetItemWithBinLocation), @"mvc.1.0.view", @"/Views/Admin/GetItemWithBinLocation.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/GetItemWithBinLocation.cshtml", typeof(AspNetCore.Views_Admin_GetItemWithBinLocation))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70867b2f2a2daedbc87232fbd87374d96de1613a", @"/Views/Admin/GetItemWithBinLocation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bffac357899d226b4f9d8a5207455291a367109", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_GetItemWithBinLocation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\Project\Steve\Dotit\DotIt.AutoPicker\Views\Admin\GetItemWithBinLocation.cshtml"
  
    ViewData["Title"] = "GetItemWithBinLocation";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(107, 52, true);
            WriteLiteral("\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n");
            EndContext();
            BeginContext(252, 487, true);
            WriteLiteral(@"            <th>
                Pickers
            </th>
            <th>
                UserId
            </th>
            <th>
                Order No
            </th>
            <th>
                bin Loc
            </th>

            <th>
                part No
            </th>
            <th>
                Order line
            </th>
            <th>
                Order qty
            </th>


        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 41 "D:\Project\Steve\Dotit\DotIt.AutoPicker\Views\Admin\GetItemWithBinLocation.cshtml"
         foreach (var item in ViewBag.PickersItemBinLoc as List<DotIt.AutoPicker.Models.ItemAssignDetailModel> )
        {

#line default
#line hidden
            BeginContext(961, 50, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n\r\n                ");
            EndContext();
            BeginContext(1012, 15, false);
#line 46 "D:\Project\Steve\Dotit\DotIt.AutoPicker\Views\Admin\GetItemWithBinLocation.cshtml"
           Write(item.PickerName);

#line default
#line hidden
            EndContext();
            BeginContext(1027, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1083, 14, false);
#line 49 "D:\Project\Steve\Dotit\DotIt.AutoPicker\Views\Admin\GetItemWithBinLocation.cshtml"
           Write(item.DcdUserID);

#line default
#line hidden
            EndContext();
            BeginContext(1097, 57, true);
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1155, 12, false);
#line 53 "D:\Project\Steve\Dotit\DotIt.AutoPicker\Views\Admin\GetItemWithBinLocation.cshtml"
           Write(item.OrderNo);

#line default
#line hidden
            EndContext();
            BeginContext(1167, 57, true);
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1225, 16, false);
#line 57 "D:\Project\Steve\Dotit\DotIt.AutoPicker\Views\Admin\GetItemWithBinLocation.cshtml"
           Write(item.BinLocation);

#line default
#line hidden
            EndContext();
            BeginContext(1241, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1297, 12, false);
#line 60 "D:\Project\Steve\Dotit\DotIt.AutoPicker\Views\Admin\GetItemWithBinLocation.cshtml"
           Write(item.PartNum);

#line default
#line hidden
            EndContext();
            BeginContext(1309, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1365, 14, false);
#line 63 "D:\Project\Steve\Dotit\DotIt.AutoPicker\Views\Admin\GetItemWithBinLocation.cshtml"
           Write(item.OrderLine);

#line default
#line hidden
            EndContext();
            BeginContext(1379, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1435, 13, false);
#line 66 "D:\Project\Steve\Dotit\DotIt.AutoPicker\Views\Admin\GetItemWithBinLocation.cshtml"
           Write(item.OrderQty);

#line default
#line hidden
            EndContext();
            BeginContext(1448, 38, true);
            WriteLiteral("\r\n            </td>\r\n\r\n        </tr>\r\n");
            EndContext();
#line 70 "D:\Project\Steve\Dotit\DotIt.AutoPicker\Views\Admin\GetItemWithBinLocation.cshtml"
        }

#line default
#line hidden
            BeginContext(1497, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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