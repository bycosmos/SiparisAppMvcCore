#pragma checksum "C:\Users\EXPER\Desktop\Yeni klasör\ShopApp-master\SiparisApp.Web\Views\Bayi\Bayiler.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d617cd7cd5c46d2aa19d4bd94bb80f9b46fd4ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bayi_Bayiler), @"mvc.1.0.view", @"/Views/Bayi/Bayiler.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d617cd7cd5c46d2aa19d4bd94bb80f9b46fd4ea", @"/Views/Bayi/Bayiler.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a447b2cf400eb9451f2dc99fda0628bdada63aa7", @"/Views/_ViewImports.cshtml")]
    public class Views_Bayi_Bayiler : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SiparisApp.Web.Models.BayiListeleEkleDuzenle>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\EXPER\Desktop\Yeni klasör\ShopApp-master\SiparisApp.Web\Views\Bayi\Bayiler.cshtml"
  
    ViewData["Title"] = "BayiListesi";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container-fluid\">\r\n\r\n\r\n    <div class=\" row mt-30\">\r\n        <select class=\"col-md-2 offset-5 text-center\" id=\"sel1\">\r\n");
#nullable restore
#line 13 "C:\Users\EXPER\Desktop\Yeni klasör\ShopApp-master\SiparisApp.Web\Views\Bayi\Bayiler.cshtml"
             foreach (var i in Model.illers)
            {



#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d617cd7cd5c46d2aa19d4bd94bb80f9b46fd4ea3884", async() => {
#nullable restore
#line 17 "C:\Users\EXPER\Desktop\Yeni klasör\ShopApp-master\SiparisApp.Web\Views\Bayi\Bayiler.cshtml"
                                 Write(i.Isim);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 17 "C:\Users\EXPER\Desktop\Yeni klasör\ShopApp-master\SiparisApp.Web\Views\Bayi\Bayiler.cshtml"
                   WriteLiteral(i.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 18 "C:\Users\EXPER\Desktop\Yeni klasör\ShopApp-master\SiparisApp.Web\Views\Bayi\Bayiler.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


        </select>
        <!-- ? Preloader Start -->
        <div id=""loading"" style=""display:none;height:200px"">
            <div class=""preloader d-flex align-items-center justify-content-center"">
                <div class=""preloader-inner position-relative"">
                    <div class=""preloader-circle""></div>
                    <div class=""preloader-img pere-text"">
                        <img src=""../../img/logo/loder.png""");
            BeginWriteAttribute("alt", " alt=\"", 868, "\"", 874, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                </div>
            </div>
        </div>
        <!-- Preloader end -->


    </div>


</div>

<hr />

<div class=""container-fluid "" style=""height:700px"">

    <table class=""table table-bordered table-hover"" id=""list""></table>

</div>
<script src=""http://code.jquery.com/jquery-latest.min.js"" type=""text/javascript""></script>

<script>
    $(document).ready(function () {
        var id = $('#sel1 option:selected').val();
        $.get(""/Bayi/_bayilerlistesi/"", { id: id }, function (d) {
            $(""#list"").show();
            $(""#list"").html(d);
        });
        $('#sel1').change(function () {
            $(""#list"").hide();
            $(""#loading"").show(700, function () {
                var id = $('#sel1 option:selected').val();
                $.get(""/Bayi/_bayilerlistesi/"", { id: id }, function (d) {
                    $(""#list"").show();
                    $(""#list"").html(d);
                    $(""#loading"").hide();
 ");
            WriteLiteral("               });\r\n            });\r\n        });\r\n    });\r\n</script>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SiparisApp.Web.Models.BayiListeleEkleDuzenle> Html { get; private set; }
    }
}
#pragma warning restore 1591