#pragma checksum "C:\Users\acer\Desktop\Bisnicity\Bisnicity\Views\Home\IndexAR.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a4fdae36bbd90bee846f3d891cdb713a320bef6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_IndexAR), @"mvc.1.0.view", @"/Views/Home/IndexAR.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a4fdae36bbd90bee846f3d891cdb713a320bef6", @"/Views/Home/IndexAR.cshtml")]
    public class Views_Home_IndexAR : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\acer\Desktop\Bisnicity\Bisnicity\Views\Home\IndexAR.cshtml"
   Layout = "_LayoutAR"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .hero-image {
        background-image: url(""../assets/images/walkingBusinessMan.png"");
        background-color: #cccccc;
        height: 500px;
        background-position: center;
        background-repeat: no-repeat;
        background-size: cover;
        position: relative;
        margin-bottom: 1%;
        margin-top: -2%;
    }

    .hero-text {
        text-align: center;
        position: absolute;
        top: 50%;
        left: 50%;
        transform: translate(-50%, -50%);
        color: white;
    }
</style>

<section class=""my-5"">
    <div class=""container-fluid"">

        <div class=""hero-image"">
            <div class=""hero-text"">
                <h1 style=""font-size:50px"" dir=""rtl"" lang=""ar"">مرحبا بك في مدينة الأعمال </h1>
                <div class=""input-group"">
                    <input class=""form-control border-0 mr-2"" type=""search"" placeholder=""Search""
                           aria-label=""Search"">
                    <button class=""btn btn-success border-0"" style=""back");
            WriteLiteral(@"ground-color: #2c8d97;""
                            type=""submit"" dir=""rtl"" lang=""ar"">
                        بحث
                    </button>

                </div>
                <!-- <h3>And I'm a Photographer</h3> -->
                <!-- <button>Hire me</button> -->
            </div>
        </div>
        <!-- Information -->
        <section class=""information"">
            <div class=""container-fluid"">
                <div class=""row"">
                    <div class=""col-lg-4 text-center p-5 text-white""
                         style=""background-color:white"">

                        <h4 class=""py-3 text-dark"" dir=""rtl"" lang=""ar"">  خدمات الأعمال  </h4>
                        <p class=""para-light text-dark"" style=""font-size:large"">
                            خدمات و حلول فريدة نقدمها للاعمال التجارية, المحال و الشركات على اختلافالتخصصات للمساهمة معكم في تطوير أعمالكم و أعطائكم القيمة المضافة التيترغبون بها
                        </p>
                        <div class=""d-grid gap-2"">
          ");
            WriteLiteral("                  <a class=\"btn text-white mt-2\" style=\"background-color: #2c8d97;\"");
            BeginWriteAttribute("href", " href=", 2212, "", 2247, 1);
#nullable restore
#line 59 "C:\Users\acer\Desktop\Bisnicity\Bisnicity\Views\Home\IndexAR.cshtml"
WriteAttributeValue("", 2218, Url.Action("Login","SignUp"), 2218, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" dir=""rtl"" lang=""ar"">أنضم </a>
                        </div>

                    </div>

                    <div class=""col-lg-4 text-center p-5""
                         style=""background-color:white"">

                        <h4 class=""py-3 text-dark"" dir=""rtl"" lang=""ar""> خدمات الافراد</h4>
                        <p class=""para-light text-dark"" style=""font-size:large"">
                            باقات خدمية خاصة بالأفراد نشمل التدريب و التوظيف و البحث عن شواغر من خلال محرك البث المصممخصيصا لهذه الغايات
                        </p>
                        <div class=""d-grid gap-2"">
                            <a class=""btn text-white mt-2"" style=""background-color: #2c8d97;""");
            BeginWriteAttribute("href", "\n                               href=", 2936, "", 3006, 1);
#nullable restore
#line 73 "C:\Users\acer\Desktop\Bisnicity\Bisnicity\Views\Home\IndexAR.cshtml"
WriteAttributeValue("", 2973, Url.Action("TraAndJobAR","Home"), 2973, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" dir=""rtl"" lang=""ar"">أنضم </a>
                        </div>
                    </div>
                    <div class=""col-lg-4 text-center p-5 text-dark""
                         style=""background-color:white"">

                        <h4 class=""py-3 text-dark"" dir=""rtl"" lang=""ar"">خدمات الريادة</h4>
                        <p class=""para-light text-dark"" style=""font-size:large"">
                            مجموعة كبيرة من الخدمات الريادية الجديدة التي يبحث اصحابها عن ممولين و شركاء أعمال لأشاء او لتطوير افكارهم و ترجمتها على ارض الواقع
                        </p>
                        <div class=""d-grid gap-2"">

                            <a class=""btn text-white mt-2"" style=""background-color: #2c8d97;""");
            BeginWriteAttribute("href", " href=", 3726, "", 3764, 1);
#nullable restore
#line 85 "C:\Users\acer\Desktop\Bisnicity\Bisnicity\Views\Home\IndexAR.cshtml"
WriteAttributeValue("", 3732, Url.Action("IdeashowAR","Home"), 3732, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" dir=""rtl"" lang=""ar"">أنضم</a>
                        </div>
                    </div>

                </div>
            </div> <!-- end of container -->
        </section> <!-- end of information -->

    </div>
</section>



<link rel=""stylesheet"" href=""./css/client.css"">
<div class=""container h-100 mb-3"">
    <div class=""row align-items-center h-100"">
        <div class=""container rounded"">
            <div class=""slider"">
                <div class=""logos"">
                    <i class=""fab fa-js fa-4x""></i>
                    <i class=""fab fa-linkedin-in fa-4x""></i>
                    <i class=""fab fa-dribbble fa-4x""></i>
                    <i class=""fab fa-medium-m fa-4x""></i>
                    <i class=""fab fa-github fa-4x""></i>
                    <i class=""fab fa-js fa-4x""></i>
                    <i class=""fab fa-linkedin-in fa-4x""></i>
                    <i class=""fab fa-dribbble fa-4x""></i>
                    <i class=""fab fa-medium-m fa-4x""></i>
                    <i class=""fab fa-gith");
            WriteLiteral("ub fa-4x\"></i>\n                </div>\n            </div>\n        </div>\n    </div>\n</div>");
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
