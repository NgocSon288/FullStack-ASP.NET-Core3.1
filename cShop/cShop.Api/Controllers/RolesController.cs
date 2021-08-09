using cShop.Application.Services.System.Roles;
using cShop.ViewModel.Common;
using cShop.ViewModel.System.Roles;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace cShop.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        private readonly IRoleService _roleService;

        public RolesController(IRoleService roleService)
        {
            _roleService = roleService;
        }

        [HttpGet]
        //[Authorize(Roles = "admin")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _roleService.GetRoles();
            return Ok(result);
        }

        [HttpGet("{id}")]
        //[Authorize]
        public async Task<IActionResult> GetById(Guid id)
        {
            var result = await _roleService.GetById(id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Register([FromBody] RoleCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new ApiResult<string>(false, ModelState.ToString()));
            }

            var result = await _roleService.Create(request);

            if (!result.IsSuccessfully)
            {
                return BadRequest(result);
            }

            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] RoleUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new ApiResult<bool>(false, ModelState.ToString()));
            }

            var result = await _roleService.Update(id, request);

            if (!result.IsSuccessfully)
            {
                return BadRequest(result);
            }

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var result = await _roleService.Delete(id);

            if (!result.IsSuccessfully)
            {
                return BadRequest(result);
            }

            return Ok(result);
        }
    }
}