#pragma checksum "C:\Users\acer\Desktop\Bisnicitynew1\Bisnicity\Views\AdminB\Templete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac4ef961d8b23a7093328e0b3bc89452fc83fc7a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminB_Templete), @"mvc.1.0.view", @"/Views/AdminB/Templete.cshtml")]
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
#nullable restore
#line 2 "C:\Users\acer\Desktop\Bisnicitynew1\Bisnicity\Views\AdminB\Templete.cshtml"
using Infrastrucer.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\acer\Desktop\Bisnicitynew1\Bisnicity\Views\AdminB\Templete.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac4ef961d8b23a7093328e0b3bc89452fc83fc7a", @"/Views/AdminB/Templete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"867b26f07787ce3ed897daa89fe895608c099590", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminB_Templete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BisnicityApp.Entites.Templete>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:64px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\acer\Desktop\Bisnicitynew1\Bisnicity\Views\AdminB\Templete.cshtml"
  
    ViewData["Title"] = "Templete";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""page-heading"">
    <div class=""page-title"">
        <div class=""row"">
            <div class=""col-12 col-md-6 order-md-1 order-last"">
                <h3>Templet</h3>
                <!-- <p class=""text-subtitle text-muted"">For user to check they list</p> -->
            </div>

        </div>
    </div>
    <section class=""section"">
        <div class=""card"">

            <div class=""card-body"">
                <table class=""table table-striped"" id=""table1"">
                    <thead>
                        <tr>
                            <th>#</th>
                            <th>BackGroundTemp</th>
                            <th>LogoTemp</th>
                            <th>ChosePrice</th>
                            <th>TempleteName</th>
                            <th>Name</th>
                            <th>Email</th>
                            <th>Actions</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 38 "C:\Users\acer\Desktop\Bisnicitynew1\Bisnicity\Views\AdminB\Templete.cshtml"
                         foreach (var item in Model)
                        {



#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 44 "C:\Users\acer\Desktop\Bisnicitynew1\Bisnicity\Views\AdminB\Templete.cshtml"
                           Write(Html.DisplayFor(modelItem => item.TempleteID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n");
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ac4ef961d8b23a7093328e0b3bc89452fc83fc7a5868", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
            WriteLiteral("~/Uploads/");
#nullable restore
#line 48 "C:\Users\acer\Desktop\Bisnicitynew1\Bisnicity\Views\AdminB\Templete.cshtml"
                                        WriteLiteral(item.BackgroundTemp);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 50 "C:\Users\acer\Desktop\Bisnicitynew1\Bisnicity\Views\AdminB\Templete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n");
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ac4ef961d8b23a7093328e0b3bc89452fc83fc7a8458", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
            WriteLiteral("~/Uploads/");
#nullable restore
#line 54 "C:\Users\acer\Desktop\Bisnicitynew1\Bisnicity\Views\AdminB\Templete.cshtml"
                                        WriteLiteral(item.LogoTemp);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 56 "C:\Users\acer\Desktop\Bisnicitynew1\Bisnicity\Views\AdminB\Templete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </td>\r\n\r\n                            <td>\r\n                                ");
#nullable restore
#line 60 "C:\Users\acer\Desktop\Bisnicitynew1\Bisnicity\Views\AdminB\Templete.cshtml"
                           Write(Html.DisplayFor(modelItem => item.ChoesePrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 63 "C:\Users\acer\Desktop\Bisnicitynew1\Bisnicity\Views\AdminB\Templete.cshtml"
                           Write(Html.DisplayFor(modelItem => item.CatTemp.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 66 "C:\Users\acer\Desktop\Bisnicitynew1\Bisnicity\Views\AdminB\Templete.cshtml"
                           Write(Html.DisplayFor(modelItem => item.UserId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 70 "C:\Users\acer\Desktop\Bisnicitynew1\Bisnicity\Views\AdminB\Templete.cshtml"
                           Write(Html.DisplayFor(modelItem => item.UserId));

#line default
#line hidden
#nullable disable
            WriteLiteral(")\r\n\r\n                            </td>\r\n");
#nullable restore
#line 73 "C:\Users\acer\Desktop\Bisnicitynew1\Bisnicity\Views\AdminB\Templete.cshtml"
                             if (sigin.IsSignedIn(User) && User.IsInRole(BisnicityKey.Admin))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>\r\n                                    <a");
            BeginWriteAttribute("href", " href=", 3035, "", 3103, 1);
#nullable restore
#line 76 "C:\Users\acer\Desktop\Bisnicitynew1\Bisnicity\Views\AdminB\Templete.cshtml"
WriteAttributeValue("", 3041, Url.Action("EditTemp","AdminB", new { id = item.TempleteID }), 3041, 62, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"badge bg-success edithover\">Edit</a>\r\n                                    <a");
            BeginWriteAttribute("href", " href=", 3187, "", 3257, 1);
#nullable restore
#line 77 "C:\Users\acer\Desktop\Bisnicitynew1\Bisnicity\Views\AdminB\Templete.cshtml"
WriteAttributeValue("", 3193, Url.Action("Deletetemp","AdminB", new { id = item.TempleteID }), 3193, 64, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"badge bg-danger deletehover\">Delete</a>\r\n                                </td>\r\n");
#nullable restore
#line 79 "C:\Users\acer\Desktop\Bisnicitynew1\Bisnicity\Views\AdminB\Templete.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tr>\r\n");
#nullable restore
#line 81 "C:\Users\acer\Desktop\Bisnicitynew1\Bisnicity\Views\AdminB\Templete.cshtml"


                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n\r\n    </section>\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> sigin { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BisnicityApp.Entites.Templete>> Html { get; private set; }
    }
}
#pragma warning restore 1591
