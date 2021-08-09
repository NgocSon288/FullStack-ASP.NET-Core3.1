using cShop.ApiIntegration.System.Roles;
using cShop.ApiIntegration.System.Users;
using cShop.ViewModel.System.Roles;
using cShop.ViewModel.System.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cShop.AdminApp.Controllers
{
    public class UserController : BaseController
    {
        private readonly IUserApiClient _userApiClient;
        private readonly IRoleApiClient _roleApiClient;

        public UserController(IUserApiClient userApiClient,
            IRoleApiClient roleApiClient)
        {
            _userApiClient = userApiClient;
            _roleApiClient = roleApiClient;
        }

        [Authorize(Policy = "Editor")]
        public async Task<IActionResult> Index()
        {
            var result = await _userApiClient.GetAll();

            return View(result.Data);
        }

        [HttpGet]
        [Authorize(Policy = "Editor")]
        public async Task<IActionResult> Edit(Guid userId)
        {
            var result = await _userApiClient.GetUserById(userId);

            if (!result.IsSuccessfully)
            {
                return RedirectToAction("Error404", "Home");
            }

            var user = result.Data;

            return View(new UserUpdateRequest()
            {
                Address = user.Address,
                Age = user.Age,
                BirthDay = user.BirthDay,
                FirstName = user.FirstName,
                Id = user.Id,
                LastName = user.LastName,
                PhoneNumber = user.PhoneNumber
            });
        }

        [HttpPost]
        [Authorize(Policy = "Editor")]
        public async Task<IActionResult> Edit(UserUpdateRequest model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var result = await _userApiClient.UpdateUser(model.Id, model);

            ViewBag.isSuccess = result.IsSuccessfully;
            ViewBag.message = result.MessageError;

            return View();
        }

        [HttpGet]
        [Authorize(Policy = "Editor")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var result = await _userApiClient.DeleteUserById(id);

            return Json(result);
        }

        [HttpGet]
        [Authorize(Policy = "Editor")]
        public async Task<IActionResult> AssignRole(Guid userId)
        {
            var model = await GetRolesByUser(userId);

            return View(model);
        }

        [HttpPost]
        [Authorize(Policy = "Editor")]
        public async Task<IActionResult> AssignRole(RoleAssignRequest model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var result = await _userApiClient.AsignRole(model.Id, model);

            if (!result.IsSuccessfully)
            {
                ModelState.AddModelError("", result.MessageError);
                return View(model);
            }

            ViewBag.isSuccess = true;
            ViewBag.message = "Cập nhật quyền thành công!";

            return View(model);
        }

        #region Methods

        private async Task<RoleAssignRequest> GetRolesByUser(Guid userId)
        {
            var userResult = await _userApiClient.GetUserById(userId);
            var rolesResult = await _roleApiClient.GetAll();

            if (!userResult.IsSuccessfully || !rolesResult.IsSuccessfully)
            {
                return null;
            }

            var userRoles = userResult.Data.Roles;
            var roles = rolesResult.Data;

            var rolesSelect = roles.Select(r => new RoleSelect()
            {
                Id = r.Id,
                Name = r.Name,
                IsSelected = userRoles.Contains(r.Name)
            });

            return new RoleAssignRequest()
            {
                Id = userId,
                RoleAssignRequests = rolesSelect.ToList()
            };
        }

        #endregion
    }
}