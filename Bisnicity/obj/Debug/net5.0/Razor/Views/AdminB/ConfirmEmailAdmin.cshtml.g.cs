#pragma checksum "C:\Users\acer\Desktop\Bisnicitynew1\Bisnicity\Views\AdminB\ConfirmEmailAdmin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c80e4442441d050352d7682320612fdb87b23ac5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminB_ConfirmEmailAdmin), @"mvc.1.0.view", @"/Views/AdminB/ConfirmEmailAdmin.cshtml")]
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
#line 2 "C:\Users\acer\Desktop\Bisnicitynew1\Bisnicity\Views\_ViewImports.cshtml"
using Bisnicity.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c80e4442441d050352d7682320612fdb87b23ac5", @"/Views/AdminB/ConfirmEmailAdmin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"867b26f07787ce3ed897daa89fe895608c099590", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminB_ConfirmEmailAdmin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>ConfirmEmail</h1>\r\n<h3>Thank you for confirming your email</h3>\r\n<h3>");
#nullable restore
#line 4 "C:\Users\acer\Desktop\Bisnicitynew1\Bisnicity\Views\AdminB\ConfirmEmailAdmin.cshtml"
Write(ViewBag.ErrorTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h3>\r\n<h3>  ");
#nullable restore
#line 5 "C:\Users\acer\Desktop\Bisnicitynew1\Bisnicity\Views\AdminB\ConfirmEmailAdmin.cshtml"
 Write(ViewBag.ErrorMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h3>\r\n\r\n");
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
