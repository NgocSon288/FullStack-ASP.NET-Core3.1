using cShop.ApiIntegration.Enums;
using cShop.Utilities.Constants;
using cShop.ViewModel.Common;
using cShop.ViewModel.System.Roles;
using cShop.ViewModel.System.Users;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace cShop.ApiIntegration.System.Roles
{
    public class RoleApiClient : BaseApiClient, IRoleApiClient
    {

        public RoleApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration) : base(httpClientFactory, httpContextAccessor, configuration)
        {
        }

        public async Task<ApiResult<RoleCreateResponse>> Create(RoleCreateRequest request)
        {
            var url = "api/roles";
            var response = await SendRequestBase(url, HttpMethodType.POST, request, HttpContentType.StringContent, null);

            var body = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<ApiResult<RoleCreateResponse>>(body);
        }

        public async Task<ApiResult<List<RoleViewModel>>> GetAll()
        {
            var headers = new Dictionary<string, string>()
            {
                {SystemConstants.AppSettings.Token, "Bearer"}
            };
            var url = $"/api/roles/";
            var response = await SendRequestBase(url, headers);

            var body = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<ApiResult<List<RoleViewModel>>>(body);
        }

        public async Task<ApiResult<bool>> Update(Guid roleId, RoleUpdateRequest request)
        {
            var headers = new Dictionary<string, string>()
            {
                {SystemConstants.AppSettings.Token, "Bearer"}
            };
            var url = $"/api/roles/{roleId}";
            var response = await SendRequestBase(url, HttpMethodType.PUT, request, HttpContentType.StringContent, headers);

            var body = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<ApiResult<bool>>(body);
        }

        public async Task<ApiResult<RoleViewModel>> GetRoleById(Guid roleId)
        {
            var headers = new Dictionary<string, string>()
            {
                {SystemConstants.AppSettings.Token, "Bearer"}
            };
            var url = $"/api/roles/{roleId}";
            var response = await SendRequestBase(url, headers);

            var body = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<ApiResult<RoleViewModel>>(body);
        }

        public async Task<ApiResult<bool>> DeleteRoleById(Guid roleId)
        {
            var headers = new Dictionary<string, string>()
            {
                {SystemConstants.AppSettings.Token, "Bearer"}
            };
            var url = $"/api/roles/{roleId}";
            var response = await SendRequestBase(url, HttpMethodType.DELETE, 0, HttpContentType.StringContent, headers);

            var body = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<ApiResult<bool>>(body);
        }
    }
}