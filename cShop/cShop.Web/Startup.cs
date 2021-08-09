using cShop.AdminApp.Authenticates.Handlers;
using cShop.AdminApp.Middlewares;
using cShop.AdminAppMail.Utilities;
using cShop.ApiIntegration.System.Roles;
using cShop.ApiIntegration.System.Users;
using cShop.Utilities.Constants;
using cShop.Utilities.Helpers;
using cShop.Utilities.Options;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace cShop.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddHttpClient();

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    options.LoginPath = "/Login/Index";
                    options.AccessDeniedPath = "/Home/Error403";
                });

            //var result = AsyncContext.RunTask(MyAsyncMethod).Result;

            services.AddAuthorization(options =>
            {
                options.AddPolicyAsRoleHandler();
            });

            services.AddControllersWithViews();

            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(30);
            });

            // Mail
            services.Configure<MailSettings>(Configuration.GetSection(SystemConstants.AppSettings.MailSettings));
            services.AddTransient<IMailHelperService, MailHelperService>();

            // Delare Services
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddTransient<IUserApiClient, UserApiClient>();
            services.AddTransient<IRoleApiClient, RoleApiClient>();
            services.AddTransient<IWebSendMailHelper, WebSendMailHelper>();
            services.AddTransient<IJwtHelper, JwtHelper>();

            // Options
            services.Configure<PaginationSetting>(Configuration.GetSection(SystemConstants.AppSettings.PaginationSetting));

            // runtime compilation
            services.AddRazorPages()
                .AddRazorRuntimeCompilation();

            // Middlewares
            services.AddTransient<TokenMiddleware>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                //app.UseHsts();
            }
            //app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSession();

            app.UseTokenMiddleware();

            app.UseAuthentication();

            app.UseRouting();

            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}