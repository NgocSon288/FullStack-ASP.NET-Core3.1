#pragma checksum "D:\Code\Project\FullStack-ASP.NET-Core3.1\cShop\cShop.Web\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "661b82ec2bfd70149d82d802ba75913e373e0445"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "D:\Code\Project\FullStack-ASP.NET-Core3.1\cShop\cShop.Web\Views\_ViewImports.cshtml"
using cShop.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Code\Project\FullStack-ASP.NET-Core3.1\cShop\cShop.Web\Views\_ViewImports.cshtml"
using cShop.AdminAppModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Code\Project\FullStack-ASP.NET-Core3.1\cShop\cShop.Web\Views\_ViewImports.cshtml"
using cShop.ViewModel.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Code\Project\FullStack-ASP.NET-Core3.1\cShop\cShop.Web\Views\_ViewImports.cshtml"
using cShop.ViewModel.System.Users;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Code\Project\FullStack-ASP.NET-Core3.1\cShop\cShop.Web\Views\_ViewImports.cshtml"
using cShop.ViewModel.System.Roles;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Code\Project\FullStack-ASP.NET-Core3.1\cShop\cShop.Web\Views\_ViewImports.cshtml"
using cShop.AdminApp.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Code\Project\FullStack-ASP.NET-Core3.1\cShop\cShop.Web\Views\_ViewImports.cshtml"
using cShop.Data.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Code\Project\FullStack-ASP.NET-Core3.1\cShop\cShop.Web\Views\_ViewImports.cshtml"
using cShop.Utilities.Options;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Code\Project\FullStack-ASP.NET-Core3.1\cShop\cShop.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Code\Project\FullStack-ASP.NET-Core3.1\cShop\cShop.Web\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Code\Project\FullStack-ASP.NET-Core3.1\cShop\cShop.Web\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Code\Project\FullStack-ASP.NET-Core3.1\cShop\cShop.Web\Views\_ViewImports.cshtml"
using System.Reflection;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"661b82ec2bfd70149d82d802ba75913e373e0445", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f96881368e94dd1b8695addb0e12246f0b559d2", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/libs/twitter-bootstrap/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/libs/twitter-bootstrap/js/bootstrap.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Header", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_LeftSideBar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/PaginationScript.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\n<html dir=\"ltr\" lang=\"en\">\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "661b82ec2bfd70149d82d802ba75913e373e04457615", async() => {
                WriteLiteral("\n    <meta charset=\"utf-8\">\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\n    <!-- Tell the browser to be responsive to screen width -->\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 300, "\"", 310, 0);
                EndWriteAttribute();
                WriteLiteral(">\n    <meta name=\"author\"");
                BeginWriteAttribute("content", " content=\"", 336, "\"", 346, 0);
                EndWriteAttribute();
                WriteLiteral(">\n\n\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "661b82ec2bfd70149d82d802ba75913e373e04458487", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "661b82ec2bfd70149d82d802ba75913e373e04459663", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"


    <!-- Favicon icon -->
    <link rel=""icon"" type=""image/png"" sizes=""16x16"" href=""/assets/images/favicon.png"">
    <title>Matrix Template - The Ultimate Multipurpose admin template</title>
    <!-- Custom CSS -->
    <link href=""/assets/libs/flot/css/float-chart.css"" rel=""stylesheet"">
    <!-- Custom CSS -->
    <link href=""/dist/css/style.min.css"" rel=""stylesheet"">
    <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
        <script src=""/https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js""></script>
        <script src=""/https://oss.maxcdn.com/libs/respond.js/1.4.2/respond.min.js""></script>
    <![endif]-->
");
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
            WriteLiteral("\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "661b82ec2bfd70149d82d802ba75913e373e044512245", async() => {
                WriteLiteral("\n    <div class=\"preloader\">\n        <div class=\"lds-ripple\">\n            <div class=\"lds-pos\"></div>\n            <div class=\"lds-pos\"></div>\n        </div>\n    </div>\n    <div id=\"main-wrapper\">\n\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "661b82ec2bfd70149d82d802ba75913e373e044512724", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "661b82ec2bfd70149d82d802ba75913e373e044513909", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
        <div class=""page-wrapper"">

            <div class=""page-breadcrumb"">
                <div class=""row"">
                    <div class=""col-12 d-flex no-block align-items-center"">
                        <h1 class=""page-title display-6"">
                            ");
#nullable restore
#line 50 "D:\Code\Project\FullStack-ASP.NET-Core3.1\cShop\cShop.Web\Views\Shared\_Layout.cshtml"
                       Write(RenderSection("Title", false));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        </h1>
                        <div class=""ml-auto text-right"">
                            <nav aria-label=""breadcrumb"">
                                <ol class=""breadcrumb"">
                                    <li class=""breadcrumb-item""><a href=""/#"">Home</a></li>
                                    <li class=""breadcrumb-item active"" aria-current=""page"">Library</li>
                                </ol>
                            </nav>
                        </div>
                    </div>
                </div>
            </div>

            ");
#nullable restore
#line 64 "D:\Code\Project\FullStack-ASP.NET-Core3.1\cShop\cShop.Web\Views\Shared\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
            <footer class=""footer text-center"">
                All Rights Reserved by Matrix-admin. Designed and Developed by <a href=""/https://wrappixel.com"">WrapPixel</a>.
            </footer>
        </div>
    </div>

    <script src=""/assets/libs/jquery/dist/jquery.min.js""></script>
    <!-- Bootstrap tether Core JavaScript -->
    <script src=""/assets/libs/popper.js/dist/umd/popper.min.js""></script>
    <script src=""/assets/libs/bootstrap/dist/js/bootstrap.min.js""></script>
    <script src=""/assets/libs/perfect-scrollbar/dist/perfect-scrollbar.jquery.min.js""></script>
    <script src=""/assets/extra-libs/sparkline/sparkline.js""></script>
    <!--Wave Effects -->
    <script src=""/dist/js/waves.js""></script>
    <!--Menu sidebar -->
    <script src=""/dist/js/sidebarmenu.js""></script>
    <!--Custom JavaScript -->
    <script src=""/dist/js/custom.min.js""></script>
    <!--This page JavaScript -->
    <!-- <script src=""/dist/js/pages/dashboards/dashboard1.js""></script> -->
    <!-- Charts js Files -->
  ");
                WriteLiteral(@"  <script src=""/assets/libs/flot/excanvas.js""></script>
    <script src=""/assets/libs/flot/jquery.flot.js""></script>
    <script src=""/assets/libs/flot/jquery.flot.pie.js""></script>
    <script src=""/assets/libs/flot/jquery.flot.time.js""></script>
    <script src=""/assets/libs/flot/jquery.flot.stack.js""></script>
    <script src=""/assets/libs/flot/jquery.flot.crosshair.js""></script>
    <script src=""/assets/libs/flot.tooltip/js/jquery.flot.tooltip.min.js""></script>
    <script src=""/dist/js/pages/chart/chart-page-init.js""></script>

    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "661b82ec2bfd70149d82d802ba75913e373e044518103", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    ");
#nullable restore
#line 96 "D:\Code\Project\FullStack-ASP.NET-Core3.1\cShop\cShop.Web\Views\Shared\_Layout.cshtml"
Write(RenderSection("Script", false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n");
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
            WriteLiteral("\n\n</html>");
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
