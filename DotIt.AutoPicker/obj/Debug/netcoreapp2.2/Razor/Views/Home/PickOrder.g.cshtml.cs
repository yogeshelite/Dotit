#pragma checksum "E:\yogesh\Steve\AutomatedOrderPicking\DotIt.AutoPicker\Views\Home\PickOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "892e3904c3e159341f26b0de753174a435fed99e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_PickOrder), @"mvc.1.0.view", @"/Views/Home/PickOrder.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/PickOrder.cshtml", typeof(AspNetCore.Views_Home_PickOrder))]
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
#line 1 "E:\yogesh\Steve\AutomatedOrderPicking\DotIt.AutoPicker\Views\_ViewImports.cshtml"
using DotIt.AutoPicker;

#line default
#line hidden
#line 2 "E:\yogesh\Steve\AutomatedOrderPicking\DotIt.AutoPicker\Views\_ViewImports.cshtml"
using DotIt.AutoPicker.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"892e3904c3e159341f26b0de753174a435fed99e", @"/Views/Home/PickOrder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bffac357899d226b4f9d8a5207455291a367109", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_PickOrder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DotIt.AutoPicker.Models.OrderHedModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("float:left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-top:2%;margin-top:2%;background-color:yellow;color:black"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\yogesh\Steve\AutomatedOrderPicking\DotIt.AutoPicker\Views\Home\PickOrder.cshtml"
  
    ViewData["Title"] = "PickOrder";

#line default
#line hidden
            BeginContext(91, 1543, true);
            WriteLiteral(@"<script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery/3.4.0/jquery.js"" type=""text/javascript""></script>
<style>
    .div3 {
        width: 500px;
        height: 300px;
        border: 1px solid blue;
    }

    .div1 {
        border: 2px solid green;
    }

    .div2 {
        width: 500px;
        height: 300px;
        padding: 50px;
        border: 1px solid red;
    }

    .button {
        background-color: Crimson;
        border-radius: 5px;
        color: white;
        padding: .5em;
        text-decoration: none;
    }

        .button:focus,
        .button:hover {
            background-color: FireBrick;
            color: White;
        }

    .content {
        display: none;
        margin: 1em 0;
    }

        .content.active,
        .no-js .content {
            display: block;
        }
</style>
<meta name=""viewport"" content=""width=device-width, initial-scale=1"">
<style>
    .block {
        display: block;
        width: 100%;
       ");
            WriteLiteral(@" height: 100%;
        border: none;
        background-color: #4CAF50;
        color: white;
        padding: 14px 28px;
        font-size: 16px;
        cursor: pointer;
        text-align: center;
    }

        .block:hover {
            background-color: #ddd;
            color: black;
        }
</style>
<link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/css/bootstrap.min.css"">

<h1>Pick Order</h1>
<h1>Order contains the folowing line items : </h1>
<br />
<br />
");
            EndContext();
#line 74 "E:\yogesh\Steve\AutomatedOrderPicking\DotIt.AutoPicker\Views\Home\PickOrder.cshtml"
 foreach (var Orders in ViewBag.OrderDetails as IEnumerable<DotIt.AutoPicker.Models.OrderHedModel> )
{

#line default
#line hidden
            BeginContext(1739, 8, true);
            WriteLiteral("    <div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1747, "\"", 1788, 2);
            WriteAttributeValue("", 1752, "OrderLineContainer+", 1752, 19, true);
#line 76 "E:\yogesh\Steve\AutomatedOrderPicking\DotIt.AutoPicker\Views\Home\PickOrder.cshtml"
WriteAttributeValue("", 1771, Orders.OrderLine, 1771, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1789, 148, true);
            WriteLiteral(" class=\"container\" style=\"border-style:solid;color:green\">\r\n        <div style=\"width:70%;float:left\">\r\n            <b>Order Line:</b>\r\n            ");
            EndContext();
            BeginContext(1938, 16, false);
#line 79 "E:\yogesh\Steve\AutomatedOrderPicking\DotIt.AutoPicker\Views\Home\PickOrder.cshtml"
       Write(Orders.OrderLine);

#line default
#line hidden
            EndContext();
            BeginContext(1954, 29, true);
            WriteLiteral("<pre><b>Customer Number:</b> ");
            EndContext();
            BeginContext(1984, 14, false);
#line 79 "E:\yogesh\Steve\AutomatedOrderPicking\DotIt.AutoPicker\Views\Home\PickOrder.cshtml"
                                                     Write(Orders.CustNum);

#line default
#line hidden
            EndContext();
            BeginContext(1998, 54, true);
            WriteLiteral("</pre>\r\n            <pre><b>Alloc Priority Code: </b> ");
            EndContext();
            BeginContext(2053, 24, false);
#line 80 "E:\yogesh\Steve\AutomatedOrderPicking\DotIt.AutoPicker\Views\Home\PickOrder.cshtml"
                                         Write(Orders.AllocPriorityCode);

#line default
#line hidden
            EndContext();
            BeginContext(2077, 56, true);
            WriteLiteral("</pre>\r\n            <pre><b>Reserve Priority Code: </b> ");
            EndContext();
            BeginContext(2134, 26, false);
#line 81 "E:\yogesh\Steve\AutomatedOrderPicking\DotIt.AutoPicker\Views\Home\PickOrder.cshtml"
                                           Write(Orders.ReservePriorityCode);

#line default
#line hidden
            EndContext();
            BeginContext(2160, 45, true);
            WriteLiteral("</pre>\r\n            <pre><b>Order Date: </b> ");
            EndContext();
            BeginContext(2206, 20, false);
#line 82 "E:\yogesh\Steve\AutomatedOrderPicking\DotIt.AutoPicker\Views\Home\PickOrder.cshtml"
                                Write(Orders.OrderDateTime);

#line default
#line hidden
            EndContext();
            BeginContext(2226, 42, true);
            WriteLiteral("</pre>\r\n            <pre><b>Company: </b> ");
            EndContext();
            BeginContext(2269, 14, false);
#line 83 "E:\yogesh\Steve\AutomatedOrderPicking\DotIt.AutoPicker\Views\Home\PickOrder.cshtml"
                             Write(Orders.Company);

#line default
#line hidden
            EndContext();
            BeginContext(2283, 46, true);
            WriteLiteral("</pre>\r\n            <pre><b>Line Status: </b> ");
            EndContext();
            BeginContext(2330, 17, false);
#line 84 "E:\yogesh\Steve\AutomatedOrderPicking\DotIt.AutoPicker\Views\Home\PickOrder.cshtml"
                                 Write(Orders.LineStatus);

#line default
#line hidden
            EndContext();
            BeginContext(2347, 44, true);
            WriteLiteral("</pre>\r\n            <pre><b>Line Type: </b> ");
            EndContext();
            BeginContext(2392, 15, false);
#line 85 "E:\yogesh\Steve\AutomatedOrderPicking\DotIt.AutoPicker\Views\Home\PickOrder.cshtml"
                               Write(Orders.LineType);

#line default
#line hidden
            EndContext();
            BeginContext(2407, 47, true);
            WriteLiteral("</pre>\r\n            <pre><b>Need By Date: </b> ");
            EndContext();
            BeginContext(2455, 17, false);
#line 86 "E:\yogesh\Steve\AutomatedOrderPicking\DotIt.AutoPicker\Views\Home\PickOrder.cshtml"
                                  Write(Orders.NeedByDate);

#line default
#line hidden
            EndContext();
            BeginContext(2472, 45, true);
            WriteLiteral("</pre>\r\n            <pre><b>Net Weight: </b> ");
            EndContext();
            BeginContext(2518, 18, false);
#line 87 "E:\yogesh\Steve\AutomatedOrderPicking\DotIt.AutoPicker\Views\Home\PickOrder.cshtml"
                                Write(Orders.NetWeight_c);

#line default
#line hidden
            EndContext();
            BeginContext(2536, 43, true);
            WriteLiteral("</pre>\r\n            <pre><b>Quantity: </b> ");
            EndContext();
            BeginContext(2580, 15, false);
#line 88 "E:\yogesh\Steve\AutomatedOrderPicking\DotIt.AutoPicker\Views\Home\PickOrder.cshtml"
                              Write(Orders.OrderQty);

#line default
#line hidden
            EndContext();
            BeginContext(2595, 47, true);
            WriteLiteral("</pre>\r\n            <pre><b>Request Date: </b> ");
            EndContext();
            BeginContext(2643, 18, false);
#line 89 "E:\yogesh\Steve\AutomatedOrderPicking\DotIt.AutoPicker\Views\Home\PickOrder.cshtml"
                                  Write(Orders.RequestDate);

#line default
#line hidden
            EndContext();
            BeginContext(2661, 8, true);
            WriteLiteral("</pre>\r\n");
            EndContext();
            BeginContext(2746, 150, true);
            WriteLiteral("        </div>\r\n        <div style=\"width:30%;float:right;\">\r\n            <a class=\"block\" style=\"float:right;margin-top:20%\" href=\"javascript:void()\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2896, "\"", 2929, 2);
            WriteAttributeValue("", 2901, "PickButton+", 2901, 11, true);
#line 93 "E:\yogesh\Steve\AutomatedOrderPicking\DotIt.AutoPicker\Views\Home\PickOrder.cshtml"
WriteAttributeValue("", 2912, Orders.OrderLine, 2912, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 2930, "\"", 2971, 3);
            WriteAttributeValue("", 2940, "PickLineItem(", 2940, 13, true);
#line 93 "E:\yogesh\Steve\AutomatedOrderPicking\DotIt.AutoPicker\Views\Home\PickOrder.cshtml"
WriteAttributeValue("", 2953, Orders.OrderLine, 2953, 17, false);

#line default
#line hidden
            WriteAttributeValue("", 2970, ")", 2970, 1, true);
            EndWriteAttribute();
            BeginContext(2972, 39, true);
            WriteLiteral(">Pick</a>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 96 "E:\yogesh\Steve\AutomatedOrderPicking\DotIt.AutoPicker\Views\Home\PickOrder.cshtml"
}

#line default
#line hidden
            BeginContext(3014, 68, true);
            WriteLiteral("<br />\r\n<div style=\"margin-bottom:20%\">\r\n    <div class=\"container\">");
            EndContext();
            BeginContext(3082, 114, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "892e3904c3e159341f26b0de753174a435fed99e13476", async() => {
                BeginContext(3181, 11, true);
                WriteLiteral("Cancel Pick");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3091, "~/Home/CancelOrderPick/", 3091, 23, true);
#line 99 "E:\yogesh\Steve\AutomatedOrderPicking\DotIt.AutoPicker\Views\Home\PickOrder.cshtml"
AddHtmlAttributeValue("", 3114, Constant.Encode(Model.OrderNum), 3114, 32, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3196, 45, true);
            WriteLiteral("</div>\r\n    <div class=\"container\">\r\n        ");
            EndContext();
            BeginContext(3241, 175, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "892e3904c3e159341f26b0de753174a435fed99e15441", async() => {
                BeginContext(3394, 18, true);
                WriteLiteral("Move to Quarantine");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3250, "~/Home/MoveToQuarantine/", 3250, 24, true);
#line 101 "E:\yogesh\Steve\AutomatedOrderPicking\DotIt.AutoPicker\Views\Home\PickOrder.cshtml"
AddHtmlAttributeValue("", 3274, Constant.Encode(Model.OrderNum), 3274, 32, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3416, 1190, true);
            WriteLiteral(@"
    </div>
    <div class=""container"">
        <a id=""CompletePick"" href=""javascript:void()"" class=""block"" style=""background-color:red;margin-top:2%"">Pick All Line Items to Complete Order</a>
    </div>
</div>

<script>
    var ShowOrderDetails = function (orderline) {
        var Details = document.getElementById(orderline);
        console.log('Show order details called');
        Details.className = ""collapse"";
        if (Details.style.display == ""block"") { Details.style.display = ""none"" }
        else { Details.style.display = ""block""; }
    }

</script>

<script>
    var TotalLines = 0;
var PickLineItem = function (orderline) {
    console.log(orderline);
    var orderlinebutton = document.getElementById('PickButton+' + orderline);
    console.log(orderlinebutton);
    if (orderlinebutton.innerText == ""Picked"")
    {
        orderlinebutton.style.backgroundColor = ""green"";
        orderlinebutton.innerText = ""Pick"";
        TotalLines--;
        console.log(TotalLines);
  ");
            WriteLiteral("      if (TotalLines == 0)\r\n        {\r\n            $.ajax({\r\n                type: \"POST\",\r\n                url: \"/Home/UnPickLineItem/\",\r\n                data: { id:");
            EndContext();
            BeginContext(4607, 14, false);
#line 136 "E:\yogesh\Steve\AutomatedOrderPicking\DotIt.AutoPicker\Views\Home\PickOrder.cshtml"
                      Write(Model.OrderNum);

#line default
#line hidden
            EndContext();
            BeginContext(4621, 436, true);
            WriteLiteral(@",orderline:orderline},
                success: function (response) {
                    console.log('Unprocessing  Successful');
                }
            });
        }
    }
    else {
        orderlinebutton.style.backgroundColor = ""#87CEEB"";
        orderlinebutton.innerText = ""Picked"";

        $.ajax({
            type: ""POST"",
            url: ""/Home/PickLineItem/"",
            data: {
                id: ");
            EndContext();
            BeginContext(5058, 14, false);
#line 151 "E:\yogesh\Steve\AutomatedOrderPicking\DotIt.AutoPicker\Views\Home\PickOrder.cshtml"
               Write(Model.OrderNum);

#line default
#line hidden
            EndContext();
            BeginContext(5072, 396, true);
            WriteLiteral(@",
                orderline: orderline
            },

            success: function (response) {

            },
            failure: function (response) {
                alert(response.responseText);
            },
            error: function (response) {
                alert(response.responseText);
            }
        });
        TotalLines++;
    }
    if (TotalLines ==");
            EndContext();
            BeginContext(5469, 16, false);
#line 167 "E:\yogesh\Steve\AutomatedOrderPicking\DotIt.AutoPicker\Views\Home\PickOrder.cshtml"
                Write(Model.TotalLines);

#line default
#line hidden
            EndContext();
            BeginContext(5485, 228, true);
            WriteLiteral(")\r\n    {\r\n        console.log(\'Total Lines are\');\r\n        console.log(TotalLines); \'\'\r\n        var completepickbutton = document.getElementById(\"CompletePick\");\r\n        completepickbutton.setAttribute(\'onclick\',\'CompleteOrder(");
            EndContext();
            BeginContext(5714, 14, false);
#line 172 "E:\yogesh\Steve\AutomatedOrderPicking\DotIt.AutoPicker\Views\Home\PickOrder.cshtml"
                                                            Write(Model.OrderNum);

#line default
#line hidden
            EndContext();
            BeginContext(5728, 497, true);
            WriteLiteral(@");');
        completepickbutton.textContent = ""Complete Pick"";
        completepickbutton.style.backgroundColor = ""#4BB050"";
    }
}
</script>

<script>
    var CompleteOrder = function (id) {
        console.log(""Complete Order button clicked"");
        console.log(window.btoa(id));
        window.location.href = ""../CompleteOrder/"" + window.btoa(id);
    }
</script>
<script type=""text/javascript"" src=""https://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js""></script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DotIt.AutoPicker.Models.OrderHedModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
