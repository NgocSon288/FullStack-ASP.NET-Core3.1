using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cShop.AdminApp.Middlewares
{
    public static class MiddlewareExtensions
    {
        public static void UseTokenMiddleware(this IApplicationBuilder app)
        {
            app.UseMiddleware<TokenMiddleware>();
        }
    }
}
