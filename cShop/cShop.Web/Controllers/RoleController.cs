using cShop.ApiIntegration.System.Roles;
using cShop.ViewModel.System.Roles;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cShop.AdminApp.Controllers
{
    public class RoleController : Controller
    {
        private readonly IRoleApiClient _roleApiClient;

        public RoleController(IRoleApiClient roleApiClient)
        {
            _roleApiClient = roleApiClient;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var result = await _roleApiClient.GetAll();

            return View(result.Data);
        }

        [HttpGet]
        [Authorize(Policy = ("Administrator"))]
        public IActionResult Create(bool isSuccess, string message)
        {
            ViewBag.isSuccess = isSuccess;
            ViewBag.message = message;

            return View();
        }

        [HttpPost]
        [Authorize(Policy = ("Administrator"))]
        public async Task<IActionResult> Create(RoleCreateRequest model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var result = await _roleApiClient.Create(model);

            if (!result.IsSuccessfully)
            {
                ViewBag.isSuccess = false;
                ViewBag.message = result.MessageError;
                return View(model);
            }
            ModelState.Clear();

            ViewBag.isSuccess = result.IsSuccessfully;
            ViewBag.message = "Tạo thành công!";

            return View();
        }


        [HttpGet]
        [Authorize(Policy = ("Administrator"))]
        public async Task<IActionResult> Edit(Guid roleId)
        {
            var result = await _roleApiClient.GetRoleById(roleId);

            if (!result.IsSuccessfully)
            {
                return RedirectToAction("Error404", "Home");
            }

            var role = result.Data;

            return View(new RoleUpdateRequest()
            {
                Description = role.Description,
                Name = role.Name,
                Id = role.Id
            });
        }

        [HttpPost]
        [Authorize(Policy = ("Administrator"))]
        public async Task<IActionResult> Edit(RoleUpdateRequest model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var result = await _roleApiClient.Update(model.Id, model);

            ViewBag.isSuccess = result.IsSuccessfully;
            ViewBag.message = result.MessageError;

            return View();
        }

        [HttpGet]
        [Authorize(Policy = ("Administrator"))]
        public async Task<IActionResult> Delete(Guid id)
        {
            var result = await _roleApiClient.DeleteRoleById(id);

            return Json(result);
        }
    }
}
