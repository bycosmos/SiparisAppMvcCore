#pragma checksum "C:\Users\EXPER\Desktop\Yeni klasör\ShopApp-master\SiparisApp.Web\Views\Account\ConfirmEmail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61c8bcd9c5d22d7f218295a6fb49210027ee325a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_ConfirmEmail), @"mvc.1.0.view", @"/Views/Account/ConfirmEmail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61c8bcd9c5d22d7f218295a6fb49210027ee325a", @"/Views/Account/ConfirmEmail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a447b2cf400eb9451f2dc99fda0628bdada63aa7", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_ConfirmEmail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 2 "C:\Users\EXPER\Desktop\Yeni klasör\ShopApp-master\SiparisApp.Web\Views\Account\ConfirmEmail.cshtml"
  
    ViewData["Title"] = "ConfirmEmail";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Confirm Email</h1>\n<hr />\n\n<div class=\"alert alert-warning\">\n");
#nullable restore
#line 10 "C:\Users\EXPER\Desktop\Yeni klasör\ShopApp-master\SiparisApp.Web\Views\Account\ConfirmEmail.cshtml"
     if (TempData["message"] != null)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\EXPER\Desktop\Yeni klasör\ShopApp-master\SiparisApp.Web\Views\Account\ConfirmEmail.cshtml"
   Write(TempData["message"]);

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\EXPER\Desktop\Yeni klasör\ShopApp-master\SiparisApp.Web\Views\Account\ConfirmEmail.cshtml"
                            
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n\n");
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
