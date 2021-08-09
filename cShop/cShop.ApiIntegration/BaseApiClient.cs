using cShop.ApiIntegration.Enums;
using cShop.Utilities.Constants;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace cShop.ApiIntegration
{
    public class BaseApiClient
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;
        private readonly IHttpContextAccessor _httpContextAccessor;

        protected BaseApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
        {
            _configuration = configuration;
            _httpContextAccessor = httpContextAccessor;
            _httpClientFactory = httpClientFactory;
        }

        protected async Task<HttpResponseMessage> SendRequestBase<T>(string url, HttpMethodType method, T data, HttpContentType contentType, Dictionary<string, string> headers)
        {
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration[SystemConstants.AppSettings.BaseAddressServer]);

            if (headers != null && headers.Count > 0)
            {
                foreach (var (keySession, headerName) in headers)
                {
                    var sessions = _httpContextAccessor.HttpContext.Session.GetString(keySession);
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(headerName, sessions);
                }
            }

            var response = new HttpResponseMessage();
            var content = ConvertObjectToHttpContent(data, contentType);

            switch (method)
            {
                case HttpMethodType.GET:
                    response = await client.GetAsync(url);
                    break;

                case HttpMethodType.POST:
                    response = await client.PostAsync(url, content);
                    break;

                case HttpMethodType.PUT:
                    response = await client.PutAsync(url, content);
                    break;

                case HttpMethodType.PATCH:
                    response = await client.PatchAsync(url, content);
                    break;

                default:
                    response = await client.DeleteAsync(url);
                    break;
            }
            return response;
        }

        protected async Task<HttpResponseMessage> SendRequestBase(string url, Dictionary<string, string> headers = null)
        {
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration[SystemConstants.AppSettings.BaseAddressServer]);

            if (headers != null && headers.Count > 0)
            {
                foreach (var (keySession, headerName) in headers)
                {
                    var sessions = _httpContextAccessor.HttpContext.Session.GetString(keySession);
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(headerName, sessions);
                }
            }

            return await client.GetAsync(url); ;
        }


        #region Convert to HttpContent

        private HttpContent ConvertObjectToHttpContent<T>(T data, HttpContentType contentType)
        {
            switch (contentType)
            {
                case HttpContentType.StringContent:
                    return ConvertToStringContent(data);

                default:
                    return ConvertToMultipartFormDataContent(data);
            }
        }

        private MultipartFormDataContent ConvertToMultipartFormDataContent<T>(T data)
        {
            return null;
        }

        private StringContent ConvertToStringContent<T>(T data)
        {
            var json = JsonConvert.SerializeObject(data);
            return new StringContent(json, Encoding.UTF8, "application/json");
        }

        #endregion Convert to HttpContent
    }
}