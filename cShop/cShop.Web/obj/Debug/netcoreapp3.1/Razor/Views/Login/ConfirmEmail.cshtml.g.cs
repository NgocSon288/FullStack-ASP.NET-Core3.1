#pragma checksum "D:\Code\Project\FullStack-ASP.NET-Core3.1\cShop\cShop.Web\Views\Login\ConfirmEmail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0cde7923120006b11b3574f4f566224150071a50"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_ConfirmEmail), @"mvc.1.0.view", @"/Views/Login/ConfirmEmail.cshtml")]
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
using cShop.ViewModel.Catalog.Categories;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Code\Project\FullStack-ASP.NET-Core3.1\cShop\cShop.Web\Views\_ViewImports.cshtml"
using cShop.Utilities.Constants;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Code\Project\FullStack-ASP.NET-Core3.1\cShop\cShop.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Code\Project\FullStack-ASP.NET-Core3.1\cShop\cShop.Web\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Code\Project\FullStack-ASP.NET-Core3.1\cShop\cShop.Web\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Code\Project\FullStack-ASP.NET-Core3.1\cShop\cShop.Web\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Code\Project\FullStack-ASP.NET-Core3.1\cShop\cShop.Web\Views\_ViewImports.cshtml"
using System.Reflection;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0cde7923120006b11b3574f4f566224150071a50", @"/Views/Login/ConfirmEmail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09afc6fb804c515a2215bda5946047f6b74397d0", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_ConfirmEmail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger btn-rounded waves-effect waves-light m-b-40"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Code\Project\FullStack-ASP.NET-Core3.1\cShop\cShop.Web\Views\Login\ConfirmEmail.cshtml"
  
    Layout = null;

    bool isSuccess = ViewBag.isSuccess;
    var classHtml = isSuccess ? "success" : "danger";
    var message = ((string)ViewBag.message).ToUpper();
    var til = isSuccess ? "Successfully" : "Unsuccessfully";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html dir=\"ltr\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0cde7923120006b11b3574f4f566224150071a507429", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n    <!-- Tell the browser to be responsive to screen width -->\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 541, "\"", 551, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n    <meta name=\"author\"");
                BeginWriteAttribute("content", " content=\"", 578, "\"", 588, 0);
                EndWriteAttribute();
                WriteLiteral(@">
    <!-- Favicon icon -->
    <link rel=""icon"" type=""image/png"" sizes=""16x16"" href=""/assets/images/favicon.png"">
    <title>Matrix Template - The Ultimate Multipurpose admin template</title>
    <!-- Custom CSS -->
    <link href=""/dist/css/style.min.css"" rel=""stylesheet"">
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0cde7923120006b11b3574f4f566224150071a509309", async() => {
                WriteLiteral(@"
    <div class=""main-wrapper"">
        <div class=""preloader"">
            <div class=""lds-ripple"">
                <div class=""lds-pos""></div>
                <div class=""lds-pos""></div>
            </div>
        </div>
        <div class=""error-box"">
            <div class=""error-body text-center"">
                <h1");
                BeginWriteAttribute("class", " class=\"", 1221, "\"", 1256, 3);
                WriteAttributeValue("", 1229, "error-title", 1229, 11, true);
                WriteAttributeValue(" ", 1240, "text-", 1241, 6, true);
#nullable restore
#line 36 "D:\Code\Project\FullStack-ASP.NET-Core3.1\cShop\cShop.Web\Views\Login\ConfirmEmail.cshtml"
WriteAttributeValue("", 1246, classHtml, 1246, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 36 "D:\Code\Project\FullStack-ASP.NET-Core3.1\cShop\cShop.Web\Views\Login\ConfirmEmail.cshtml"
                                                   Write(til);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n                <h3 class=\"text-uppercase error-subtitle\">");
#nullable restore
#line 37 "D:\Code\Project\FullStack-ASP.NET-Core3.1\cShop\cShop.Web\Views\Login\ConfirmEmail.cshtml"
                                                     Write(message);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n                <p class=\"text-muted m-t-30 m-b-30\">YOU SEEM TO BE TRYING TO FIND HIS WAY HOME</p>\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0cde7923120006b11b3574f4f566224150071a5011193", async() => {
                    WriteLiteral("Về trang chủ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
            </div>
        </div>
    </div>
    <script src=""/assets/libs/jquery/dist/jquery.min.js""></script>
    <!-- Bootstrap tether Core JavaScript -->
    <script src=""/assets/libs/popper.js/dist/umd/popper.min.js""></script>
    <script src=""/assets/libs/bootstrap/dist/js/bootstrap.min.js""></script>
    <script>
        $('[data-toggle=""tooltip""]').tooltip();
        $("".preloader"").fadeOut();
    </script>
");
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
            WriteLiteral("\r\n\r\n</html>\r\n\r\n<p");
            BeginWriteAttribute("class", " class=\"", 2040, "\"", 2058, 1);
#nullable restore
#line 55 "D:\Code\Project\FullStack-ASP.NET-Core3.1\cShop\cShop.Web\Views\Login\ConfirmEmail.cshtml"
WriteAttributeValue("", 2048, classHtml, 2048, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    ");
#nullable restore
#line 56 "D:\Code\Project\FullStack-ASP.NET-Core3.1\cShop\cShop.Web\Views\Login\ConfirmEmail.cshtml"
Write(message);

#line default
#line hidden
#nullable disable
            WriteLiteral(", trở lại ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0cde7923120006b11b3574f4f566224150071a5014498", async() => {
                WriteLiteral("trang chủ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>");
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
