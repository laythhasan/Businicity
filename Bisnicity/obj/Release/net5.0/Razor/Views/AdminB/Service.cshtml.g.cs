#pragma checksum "C:\Users\Elite\Desktop\Bisnicity\Bisnicity\Views\AdminB\Service.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ec5524278a9a0ef8cf08bbdd56345c0e8cac5f5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminB_Service), @"mvc.1.0.view", @"/Views/AdminB/Service.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ec5524278a9a0ef8cf08bbdd56345c0e8cac5f5", @"/Views/AdminB/Service.cshtml")]
    public class Views_AdminB_Service : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BisnicityApp.Entites.Services>>
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
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Elite\Desktop\Bisnicity\Bisnicity\Views\AdminB\Service.cshtml"
  
    ViewData["Title"] = "Service";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""page-heading"">
    <div class=""page-title"">
        <div class=""row"">
            <div class=""col-12 col-md-6 order-md-1 order-last"">
                <h3>Service</h3>
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
                            <th>ServiceName</th>
                            <th>Paragraph</th>
                            <th>image</th>
                            <th>Name</th>
                            <th>Email</th>
                            <th>Acions</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 37 "C:\Users\Elite\Desktop\Bisnicity\Bisnicity\Views\AdminB\Service.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 40 "C:\Users\Elite\Desktop\Bisnicity\Bisnicity\Views\AdminB\Service.cshtml"
                           Write(Html.DisplayFor(modelItem => item.ServicesID));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                            <td>\r\n                                ");
#nullable restore
#line 43 "C:\Users\Elite\Desktop\Bisnicity\Bisnicity\Views\AdminB\Service.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Servicename));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 46 "C:\Users\Elite\Desktop\Bisnicity\Bisnicity\Views\AdminB\Service.cshtml"
                           Write(Html.DisplayFor(modelItem => item.paragraph));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1ec5524278a9a0ef8cf08bbdd56345c0e8cac5f55757", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
            WriteLiteral("~/Uploads/");
#nullable restore
#line 49 "C:\Users\Elite\Desktop\Bisnicity\Bisnicity\Views\AdminB\Service.cshtml"
                                        WriteLiteral(item.Image);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 51 "C:\Users\Elite\Desktop\Bisnicity\Bisnicity\Views\AdminB\Service.cshtml"
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
            WriteLiteral("\r\n\r\n\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 56 "C:\Users\Elite\Desktop\Bisnicity\Bisnicity\Views\AdminB\Service.cshtml"
                           Write(Html.DisplayFor(model => item.Info.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 59 "C:\Users\Elite\Desktop\Bisnicity\Bisnicity\Views\AdminB\Service.cshtml"
                           Write(Html.DisplayFor(model => item.Info.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                <a");
            BeginWriteAttribute("href", " href=", 2281, "", 2345, 1);
#nullable restore
#line 62 "C:\Users\Elite\Desktop\Bisnicity\Bisnicity\Views\AdminB\Service.cshtml"
WriteAttributeValue("", 2287, Url.Action("Editser", "AdminB",new {id=item.ServicesID }), 2287, 58, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"badge bg-success edithover\">Edit</a>\r\n                                <a");
            BeginWriteAttribute("href", " href=", 2425, "", 2492, 1);
#nullable restore
#line 63 "C:\Users\Elite\Desktop\Bisnicity\Bisnicity\Views\AdminB\Service.cshtml"
WriteAttributeValue("", 2431, Url.Action("Deleteserv", "AdminB",new {id=item.ServicesID }), 2431, 61, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"badge bg-danger deletehover\">Delete</a>\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 66 "C:\Users\Elite\Desktop\Bisnicity\Bisnicity\Views\AdminB\Service.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n\r\n    </section>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BisnicityApp.Entites.Services>> Html { get; private set; }
    }
}
#pragma warning restore 1591
