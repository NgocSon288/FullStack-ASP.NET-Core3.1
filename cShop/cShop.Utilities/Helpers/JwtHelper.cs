using cShop.Utilities.Constants;
using cShop.ViewModel.System.Users;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Logging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Identity;

namespace cShop.Utilities.Helpers
{
    public interface IJwtHelper
    {
        Task<string> ClaimsPrincipalToToken(Claim[] claims);

        Task<string> GetUserIdFromClient();

        Task<string> IdentityUserToToken(UserClaimViewModel info);

        Task<ClaimsPrincipal> TokenToClaimsPrincipal(string jwtToken);
    }

    public class JwtHelper : IJwtHelper
    {
        private readonly IConfiguration _configuration;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public JwtHelper(IConfiguration configuration,
            IHttpContextAccessor httpContextAccessor)
        {
            _configuration = configuration;
            _httpContextAccessor = httpContextAccessor;
        }

        /// <summary>
        /// Get ClaimsPrincipal để giúp đăng nhập trên Client
        /// </summary>
        /// <param name="jwtToken"></param>
        /// <returns></returns>
        public async Task<ClaimsPrincipal> TokenToClaimsPrincipal(string jwtToken)
        {
            IdentityModelEventSource.ShowPII = true;

            SecurityToken validatedToken;
            TokenValidationParameters validationParameters = new TokenValidationParameters();

            validationParameters.ValidateLifetime = true;

            validationParameters.ValidAudience = _configuration[SystemConstants.AppSettings.TokensIssuer];
            validationParameters.ValidIssuer = _configuration[SystemConstants.AppSettings.TokensIssuer];
            validationParameters.IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration[SystemConstants.AppSettings.TokensKey]));

            ClaimsPrincipal principal = new JwtSecurityTokenHandler().ValidateToken(jwtToken, validationParameters, out validatedToken);

            return await Task.FromResult(principal);

        }

        /// <summary>
        /// Get Token để chuyển về Client
        /// </summary>
        /// <param name="claims"></param>
        /// <returns></returns>
        public async Task<string> ClaimsPrincipalToToken(Claim[] claims)
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Tokens:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var jwtToken = new JwtSecurityToken(_configuration["Tokens:Issuer"],
                _configuration["Tokens:Issuer"],
                claims,
                expires: DateTime.Now.AddHours(3),
                signingCredentials: creds);
            var token = new JwtSecurityTokenHandler().WriteToken(jwtToken);

            return await Task.FromResult(token);
        }

        public async Task<string> IdentityUserToToken(UserClaimViewModel info)
        {
            var claims = new[]
            {
                new Claim(ClaimTypes.Email,info.Email),
                new Claim(ClaimTypes.Role, info.Roles),
                new Claim(ClaimTypes.Name, info.FullName),
                new Claim(SystemConstants.AppSettings.Id, info.UserId.ToString())
            };

            return await ClaimsPrincipalToToken(claims);
        }

        /// <summary>
        /// Get UserClaimViewModel ở phía Client
        /// Phía Client có lưu Token ở Session
        /// </summary>
        /// <returns></returns>
        public async Task<string> GetUserIdFromClient()
        {
            return await Task.FromResult(_httpContextAccessor.HttpContext.User.FindFirst(SystemConstants.AppSettings.Id).Value);
        }
    }
}
