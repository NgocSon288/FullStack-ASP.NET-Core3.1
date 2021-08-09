using cShop.ApiIntegration.System.Users;
using cShop.Utilities.Constants;
using cShop.Utilities.Helpers;
using cShop.Utilities.Models;
using cShop.ViewModel.System.Users;
using cShop.AdminAppMail.Utilities;
using cShop.AdminAppUtilities.Mail.Dto;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Logging;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using cShop.AdminApp.Authenticates;

namespace cShop.AdminAppControllers
{
    public class LoginController : Controller
    {
        private readonly IUserApiClient _userApiClient;
        private readonly IWebSendMailHelper _webSendMailHelper;
        private readonly IConfiguration _configuration;
        private readonly IJwtHelper _jwtHelper;

        public LoginController(IUserApiClient userApiClient,
            IMailHelperService mailHelperService,
            IWebSendMailHelper webSendMailHelper,
            IConfiguration configuration,
            IJwtHelper jwtHelper)
        {
            _userApiClient = userApiClient;
            _webSendMailHelper = webSendMailHelper;
            _configuration = configuration;
            _jwtHelper = jwtHelper;
        }

        [HttpGet]

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserLoginRequest model)
        {
            if (!ModelState.IsValid)
            {
                return View(nameof(Index), model);
            }

            var result = await _userApiClient.Authenticate(model);

            if (!result.IsSuccessfully)
            {
                ModelState.AddModelError("", result.MessageError);
                return View(model);
            }

            var userPrincipal = await _jwtHelper.TokenToClaimsPrincipal(result.Data);
            var authProperties = new AuthenticationProperties
            {
                ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(10),
                IsPersistent = false
            };

            HttpContext.Session.SetString(SystemConstants.AppSettings.Token, result.Data);
            await HttpContext.SignInAsync(
                        CookieAuthenticationDefaults.AuthenticationScheme,
                        userPrincipal,
                        authProperties);



            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Register(string message = null)
        {
            ViewBag.message = message;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(UserRegisterRequest model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // Gọi API đăng ký -> nhận về [Code, UserId]
            var result = await _userApiClient.Register(model);

            if (!result.IsSuccessfully)
            {
                ModelState.AddModelError("", result.MessageError);
                return View(model);
            }

            // Gửi mail vào email đó -> a href= Code + UserId
            var input = new SendConfirmCreatedDto(model.Email, $"{model.FirstName} {model.LastName}", result.Data.Code, result.Data.UserId);
            await _webSendMailHelper.SendConfirmCreated(input);

            ViewBag.message = "Đăng ký thành công!";

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> ConfirmEmail(UserComfirmNewAccountRequest input)
        {
            // Gọi API truyền xuống [code,userId] để ConfirmEmail
            var result = await _userApiClient.ConfirmCreatedNewAccount(input);

            ViewBag.isSuccess = result.IsSuccessfully;
            ViewBag.message = result.MessageError;

            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            HttpContext.Session.Remove(SystemConstants.AppSettings.Token);

            return RedirectToAction("Index", "Home");
        }
    }
}
