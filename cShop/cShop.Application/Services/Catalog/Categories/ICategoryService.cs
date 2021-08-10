using cShop.ViewModel.Catalog.Categories;
using cShop.ViewModel.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace cShop.Application.Services.Catalog.Categories
{
    public interface ICategoryService
    {
        Task<ApiResult<CategoryViewModel>> Create(CategoryCreateRequest request);
        Task<ApiResult<bool>> Delete(int categoryId);
        Task<ApiResult<List<CategoryViewModel>>> GetAll();
        Task<ApiResult<bool>> Update(int categoryId, CategoryUpdateRequest request);
    }
}