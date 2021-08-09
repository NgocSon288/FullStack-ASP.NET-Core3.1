using cShop.Utilities.Constants;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace cShop.AdminApp.Authenticates.Handlers
{
    public static class HandlerExtension
    {
        public static void AddPolicyAsRoleHandler(this AuthorizationOptions options)
        {
            var type = typeof(RoleNames);
            var fieldInfos = type.GetFields();
            var rolesName = fieldInfos.Select(c => c.Name);


            foreach (var pro in fieldInfos)
            {
                var a = pro.GetValue(null);

                options.AddPolicy(pro.Name, policy =>
                {
                    policy.RequireAssertion(context =>
                    {
                        var userRoles = context.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Role)?.Value;

                        var listRolesElements = userRoles.Split(';').ToList();

                        // test
                        var value = pro.GetValue(null);
                        var check = listRolesElements.Contains(pro.GetValue(null));

                        return listRolesElements.Contains(pro.GetValue(null));
                    });
                });
            }
        }
    }
}
