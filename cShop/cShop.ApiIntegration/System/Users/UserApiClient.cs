using cShop.ApiIntegration.Enums;
using cShop.Utilities.Constants;
using cShop.ViewModel.Common;
using cShop.ViewModel.System.Users;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace cShop.ApiIntegration.System.Users
{
    public class UserApiClient : BaseApiClient, IUserApiClient
    {
        private const string BaseUrl = "api/users";

        public UserApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration) : base(httpClientFactory, httpContextAccessor, configuration)
        {
        }

        public async Task<ApiResult<string>> Authenticate(UserLoginRequest request)
        {
            var url = $"{BaseUrl}/authenticate";
            var response = await SendRequestBase(url, HttpMethodType.POST, request, HttpContentType.StringContent, null);

            var body = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<ApiResult<string>>(body);
        }

        public async Task<ApiResult<UserRegisterResponse>> Register(UserRegisterRequest request)
        {
            var url = $"{BaseUrl}/register";
            var response = await SendRequestBase(url, HttpMethodType.POST, request, HttpContentType.StringContent, null);

            var body = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<ApiResult<UserRegisterResponse>>(body);
        }

        public async Task<ApiResult<UserRegisterResponse>> ConfirmCreatedNewAccount(UserComfirmNewAccountRequest request)
        {
            var url = $"{BaseUrl}/confirm?UserId={request.UserId}&Code={request.Code}";
            var response = await SendRequestBase(url, HttpMethodType.GET, request, HttpContentType.StringContent, null);

            var body = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<ApiResult<UserRegisterResponse>>(body);
        }

        public async Task<ApiResult<List<UserViewModel>>> GetAll()
        {
            var headers = new Dictionary<string, string>()
            {
                {SystemConstants.AppSettings.Token, "Bearer"}
            };
            var url = $"{BaseUrl}";
            var response = await SendRequestBase(url, headers);

            var body = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<ApiResult<List<UserViewModel>>>(body);
        }

        public async Task<ApiResult<bool>> UpdateUser(Guid userId, UserUpdateRequest request)
        {
            var headers = new Dictionary<string, string>()
            {
                {SystemConstants.AppSettings.Token, "Bearer"}
            };
            var url = $"{BaseUrl}/{userId}";
            var response = await SendRequestBase(url, HttpMethodType.PUT, request, HttpContentType.StringContent, headers);

            var body = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<ApiResult<bool>>(body);
        }

        public async Task<ApiResult<UserViewModel>> GetUserById(Guid userId)
        {
            var headers = new Dictionary<string, string>()
            {
                {SystemConstants.AppSettings.Token, "Bearer"}
            };
            var url = $"{BaseUrl}/{userId}";
            var response = await SendRequestBase(url, headers);

            var body = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<ApiResult<UserViewModel>>(body);
        }

        public async Task<ApiResult<bool>> DeleteUserById(Guid userId)
        {
            var headers = new Dictionary<string, string>()
            {
                {SystemConstants.AppSettings.Token, "Bearer"}
            };
            var url = $"{BaseUrl}/{userId}";
            var response = await SendRequestBase(url, HttpMethodType.DELETE, 0, HttpContentType.StringContent, headers);

            var body = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<ApiResult<bool>>(body);
        }

        public async Task<ApiResult<bool>> AsignRole(Guid userId, RoleAssignRequest request)
        {
            var headers = new Dictionary<string, string>()
            {
                {SystemConstants.AppSettings.Token, "Bearer"}
            };
            var url = $"{BaseUrl}/{userId}/roles";
            var response = await SendRequestBase(url, HttpMethodType.PUT, request, HttpContentType.StringContent, headers);

            var body = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<ApiResult<bool>>(body);
        }
    }
}