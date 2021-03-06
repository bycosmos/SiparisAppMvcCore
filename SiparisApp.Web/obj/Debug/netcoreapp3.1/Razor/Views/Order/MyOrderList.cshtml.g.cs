#pragma checksum "C:\Users\EXPER\Desktop\Yeni klasör\ShopApp-master\SiparisApp.Web\Views\Order\MyOrderList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac9ab11c0d7a51c9e452d632aec9277dd805820c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_MyOrderList), @"mvc.1.0.view", @"/Views/Order/MyOrderList.cshtml")]
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
#line 1 "C:\Users\EXPER\Desktop\Yeni klasör\ShopApp-master\SiparisApp.Web\Views\_ViewImports.cshtml"
using SiparisApp.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\EXPER\Desktop\Yeni klasör\ShopApp-master\SiparisApp.Web\Views\_ViewImports.cshtml"
using SiparisApp.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac9ab11c0d7a51c9e452d632aec9277dd805820c", @"/Views/Order/MyOrderList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a447b2cf400eb9451f2dc99fda0628bdada63aa7", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_MyOrderList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<OrderListModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\EXPER\Desktop\Yeni klasör\ShopApp-master\SiparisApp.Web\Views\Order\MyOrderList.cshtml"
  
    ViewData["Title"] = "MyOrderList";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>MyOrderList</h1>\n<hr />\n");
#nullable restore
#line 9 "C:\Users\EXPER\Desktop\Yeni klasör\ShopApp-master\SiparisApp.Web\Views\Order\MyOrderList.cshtml"
 foreach (var order in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table table-bordered table-sm mb-3\">\n    <thead class=\"bg-primary\">\n        <tr>\n            <td colspan=\"2\">Order Id: #");
#nullable restore
#line 14 "C:\Users\EXPER\Desktop\Yeni klasör\ShopApp-master\SiparisApp.Web\Views\Order\MyOrderList.cshtml"
                                  Write(order.OrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <th>Price</th>\n            <th>Quantity</th>\n        </tr>\n\n    </thead>\n    <tbody>\n");
#nullable restore
#line 21 "C:\Users\EXPER\Desktop\Yeni klasör\ShopApp-master\SiparisApp.Web\Views\Order\MyOrderList.cshtml"
         foreach (var orderDetail in order.OrderDetails)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td style=\"width:60px;\">\n                    <img");
            BeginWriteAttribute("src", " src=\"", 579, "\"", 606, 1);
#nullable restore
#line 25 "C:\Users\EXPER\Desktop\Yeni klasör\ShopApp-master\SiparisApp.Web\Views\Order\MyOrderList.cshtml"
WriteAttributeValue("", 585, orderDetail.ImageUrl, 585, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"50\" />\n                </td>\n                <td>\n                    ");
#nullable restore
#line 28 "C:\Users\EXPER\Desktop\Yeni klasör\ShopApp-master\SiparisApp.Web\Views\Order\MyOrderList.cshtml"
               Write(orderDetail.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 31 "C:\Users\EXPER\Desktop\Yeni klasör\ShopApp-master\SiparisApp.Web\Views\Order\MyOrderList.cshtml"
               Write(orderDetail.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 34 "C:\Users\EXPER\Desktop\Yeni klasör\ShopApp-master\SiparisApp.Web\Views\Order\MyOrderList.cshtml"
               Write(orderDetail.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n            </tr>\n");
#nullable restore
#line 37 "C:\Users\EXPER\Desktop\Yeni klasör\ShopApp-master\SiparisApp.Web\Views\Order\MyOrderList.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n    </tbody>\n    <tfoot>\n        <tr>\n            <td colspan=\"2\">\n                Customer Name:\n            </td>\n            <td>\n                ");
#nullable restore
#line 49 "C:\Users\EXPER\Desktop\Yeni klasör\ShopApp-master\SiparisApp.Web\Views\Order\MyOrderList.cshtml"
           Write(order.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 49 "C:\Users\EXPER\Desktop\Yeni klasör\ShopApp-master\SiparisApp.Web\Views\Order\MyOrderList.cshtml"
                            Write(order.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td><strong>Total: ");
#nullable restore
#line 51 "C:\Users\EXPER\Desktop\Yeni klasör\ShopApp-master\SiparisApp.Web\Views\Order\MyOrderList.cshtml"
                          Write(order.TotalPrice());

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></td>\n        </tr>\n      \n    </tfoot>\n\n\n</table>\n");
#nullable restore
#line 58 "C:\Users\EXPER\Desktop\Yeni klasör\ShopApp-master\SiparisApp.Web\Views\Order\MyOrderList.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<OrderListModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
