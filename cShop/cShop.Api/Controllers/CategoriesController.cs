using cShop.Application.Services.Catalog.Categories;
using cShop.Application.Services.System.Roles;
using cShop.ViewModel.Catalog.Categories;
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
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _categoryService.GetAll();

            return Ok(result);
        }

        [HttpPost]
        [Authorize(Roles =  "Admin")]
        public async Task<IActionResult> Create([FromForm]CategoryCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new ApiResult<CategoryViewModel>(false, ModelState.ToString()));
            }

            var result = await _categoryService.Create(request);

            if (!result.IsSuccessfully)
            {
                return BadRequest(result);
            }

            return Ok(result);
        }

        [HttpDelete("{categoryId}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int categoryId)
        {
            var result = await _categoryService.Delete(categoryId);

            if (!result.IsSuccessfully)
            {
                return BadRequest(result);
            }

            return Ok(result);
        }

        [HttpPut("{categoryId}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Update(int categoryId, [FromForm]CategoryUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new ApiResult<bool>(false, ModelState.ToString()));
            }

            var result = await _categoryService.Update(categoryId, request);

            if (!result.IsSuccessfully)
            {
                return BadRequest(result);
            }

            return Ok(result);
        }
    }
}
