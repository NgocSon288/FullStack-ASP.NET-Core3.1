using cShop.ApiIntegration.Enums;
using cShop.Utilities.Constants;
using cShop.ViewModel.Catalog.Categories;
using cShop.ViewModel.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace cShop.ApiIntegration.Catalog.Categories
{
    public class CategoryApiClient : BaseApiClient, ICategoryApiClient
    {
        private const string BaseUrl = "api/categories";
        public CategoryApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration) : base(httpClientFactory, httpContextAccessor, configuration)
        {
        }

        public async Task<ApiResult<List<CategoryViewModel>>> GetAll()
        {
            var url = $"{BaseUrl}";
            var response = await SendRequestBase(url);

            var body = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<ApiResult<List<CategoryViewModel>>>(body);
        }

        public async Task<ApiResult<List<CategoryViewModel>>> Create(CategoryCreateRequest request)
        {
            var headers = new Dictionary<string, string>()
            {
                {SystemConstants.AppSettings.Token, "Bearer"}
            };
            var url = $"{BaseUrl}";
            var response = await SendRequestBase(url, HttpMethodType.POST, request, HttpContentType.MultipartFormDataContent, headers);

            var body = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<ApiResult<List<CategoryViewModel>>>(body);
        }

        public async Task<ApiResult<List<bool>>> Delete(int categoryId)
        {
            var headers = new Dictionary<string, string>()
            {
                {SystemConstants.AppSettings.Token, "Bearer"}
            };
            var url = $"{BaseUrl}/{categoryId}";
            var response = await SendRequestBase(url, HttpMethodType.DELETE, 0, HttpContentType.StringContent, headers);

            var body = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<ApiResult<List<bool>>>(body);
        }

        public async Task<ApiResult<List<bool>>> Update(int categoryId, CategoryUpdateRequest request)
        {
            var headers = new Dictionary<string, string>()
            {
                {SystemConstants.AppSettings.Token, "Bearer"}
            };
            var url = $"{BaseUrl}/{categoryId}";
            var response = await SendRequestBase(url, HttpMethodType.PUT, request, HttpContentType.MultipartFormDataContent, headers);

            var body = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<ApiResult<List<bool>>>(body);
        }
    }
}
