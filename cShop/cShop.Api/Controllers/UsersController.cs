using cShop.Application.Services.System.Users;
using cShop.ViewModel.Common;
using cShop.ViewModel.System.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cShop.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        //[Authorize(Roles = "admin")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _userService.GetUsers();
            return Ok(result);
        }

        [HttpGet("{id}")]
        [Authorize]
        public async Task<IActionResult> GetById(Guid id)
        {
            var result = await _userService.GetById(id);
            return Ok(result);
        }

        [HttpGet("search")]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> Search([FromQuery] UserSearchRequest request)
        {
            var result = await _userService.Search(request);

            return Ok(result);
        }

        [HttpGet("confirm")]
        public async Task<IActionResult> Comfirm([FromQuery] UserComfirmNewAccountRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new ApiResult<string>(false, ModelState.ToString()));
            }

            var result = await _userService.ConfirmCreatedNewAccount(request);

            if (!result.IsSuccessfully)
            {
                return BadRequest(result);
            }

            return Ok(result);
        }

        [HttpPost("authenticate")]
        public async Task<IActionResult> Authenticate([FromBody] UserLoginRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new ApiResult<string>(false, ModelState.ToString()));
            }

            var result = await _userService.Authenticate(request);

            if (!result.IsSuccessfully)
            {
                return BadRequest(result);
            }

            return Ok(result);
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] UserRegisterRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new ApiResult<string>(false, ModelState.ToString()));
            }

            var result = await _userService.Register(request);

            if (!result.IsSuccessfully)
            {
                return BadRequest(result);
            }

            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] UserUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new ApiResult<bool>(false, ModelState.ToString()));
            }

            var result = await _userService.Update(id, request);

            if (!result.IsSuccessfully)
            {
                return BadRequest(result);
            }

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var result = await _userService.Delete(id);

            if (!result.IsSuccessfully)
            {
                return BadRequest(result);
            }

            return Ok(result);
        }

        [HttpPut("{id}/roles")]
        public async Task<IActionResult> AssignRole(Guid id, RoleAssignRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new ApiResult<bool>(false, ModelState.ToString()));
            }

            var result = await _userService.AssignRole(id, request);

            if (!result.IsSuccessfully)
            {
                return BadRequest(result);
            }

            return Ok(result);
        }
    }
}
