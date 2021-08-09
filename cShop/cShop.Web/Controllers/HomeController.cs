using cShop.Utilities.Helpers;
using cShop.Utilities.Models;
using cShop.AdminAppModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using cShop.ApiIntegration.System.Users;
using cShop.AdminApp.Controllers;

namespace cShop.AdminAppControllers
{
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMailHelperService _mailHelperService;
        private readonly IJwtHelper _iJwtHelper;
        private readonly IUserApiClient _userApiClient;

        public HomeController(ILogger<HomeController> logger,
            IMailHelperService mailHelperService,
            IJwtHelper iJwtHelper,
            IUserApiClient userApiClient)
        {
            _logger = logger;
            _mailHelperService = mailHelperService;
            _iJwtHelper = iJwtHelper;
            _userApiClient = userApiClient;
        }

        [Authorize]
        public async Task<IActionResult> Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public IActionResult Error403()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Error404()
        {
            return View();
        }
    }
}
