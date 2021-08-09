using cShop.Utilities.Constants;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cShop.AdminApp.Middlewares
{
    public class TokenMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                var JWToken = context.Session.GetString(SystemConstants.AppSettings.Token);
                //if (string.IsNullOrEmpty(JWToken))
                //{
                //    context.Request.Headers.Add("Authorization", "Bearer " + JWToken);
                //}
            }
            catch (Exception ex)
            {

            }

            await next(context);
        }
    }
}
