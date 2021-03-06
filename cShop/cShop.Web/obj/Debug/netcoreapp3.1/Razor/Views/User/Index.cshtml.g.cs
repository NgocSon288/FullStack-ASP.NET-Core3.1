#pragma checksum "D:\Code\Project\FullStack-ASP.NET-Core3.1\cShop\cShop.Web\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33b6163a3faf8bb6b283547001a40dee80ec48f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33b6163a3faf8bb6b283547001a40dee80ec48f0", @"/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09afc6fb804c515a2215bda5946047f6b74397d0", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<UserViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            DefineSection("Title", async() => {
                WriteLiteral("\r\n    Qu???n l?? th??nh vi??n\r\n");
            }
            );
            WriteLiteral("\r\n<div class=\"container-fluid\">\r\n    <div class=\"row\">\r\n        <div class=\"col-12\">\r\n            <div class=\"card\">\r\n                <div class=\"card-body\">\r\n                    <h5 class=\"card-title\">Danh s??ch th??nh vi??n</h5>\r\n\r\n");
#nullable restore
#line 14 "D:\Code\Project\FullStack-ASP.NET-Core3.1\cShop\cShop.Web\Views\User\Index.cshtml"
                      
                        var modifiedButtons = new List<ListPagination.ModifiedButton>
                                                {
                            new ListPagination.ModifiedButton()
                            {
                                Classes = "btn btn-info",
                                Text = "C???p nh???t",
                                ControllerName = "User",
                                ActionName="Edit",
                                RouteDatas = new Dictionary<string, ListPagination.UrlButton>()
                                                        {
                                    {"userId",  new ListPagination.UrlButton(){ PropertyName = nameof(UserViewModel.Id)} }
                                }
                            },
                            new ListPagination.ModifiedButton()
                            {
                                Url="/user/delete",
                                Classes = "btn btn-danger btn-delete-row",
                                Text = "X??a",
                                RouteDatas=new Dictionary<string, ListPagination.UrlButton>()
                                                        {
                                    {"id",  new ListPagination.UrlButton(){PropertyName = nameof(UserViewModel.Id)} }
                                }
                            },
                            new ListPagination.ModifiedButton()
                            {
                                Classes = "btn btn-info",
                                Text = "Roles",
                                ControllerName = "User",
                                ActionName = "AssignRole",
                                RouteDatas=new Dictionary<string, ListPagination.UrlButton>()
                                                        {
                                    {"userId",  new ListPagination.UrlButton(){PropertyName = nameof(UserViewModel.Id)} }
                                }
                            }
                        };
                        var displayNameValues = new Dictionary<string, ListPagination.DisplayValue>()
                                                {
                            {"T??n", new ListPagination.DisplayValue(nameof(UserViewModel.LastName))},
                            {"T??i kho???n" , new ListPagination.DisplayValue(nameof(UserViewModel.UserName))},
                            {"?????a ch???" , new ListPagination.DisplayValue(nameof(UserViewModel.Address))},
                            {"Email" , new ListPagination.DisplayValue(nameof(UserViewModel.Email))},
                            {"Ng??y sinh", new ListPagination.DisplayValue(nameof(UserViewModel.BirthDay))},
                            {"Tu???i", new ListPagination.DisplayValue(nameof(UserViewModel.Age))}
                        };

                        var modelPagination = new ListPagination.PaginationModel
                        {
                            Data = Model.Select(m => (object)m).ToList(),
                            Type = typeof(UserViewModel),
                            DisplayNameValuess = displayNameValues,
                            ModifiedButtons = modifiedButtons
                        };
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
#nullable restore
#line 68 "D:\Code\Project\FullStack-ASP.NET-Core3.1\cShop\cShop.Web\Views\User\Index.cshtml"
               Write(await Component.InvokeAsync("ListPagination", modelPagination));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Script", async() => {
                WriteLiteral("\r\n    <script>\r\n        paginationObj.init();\r\n    </script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<UserViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
