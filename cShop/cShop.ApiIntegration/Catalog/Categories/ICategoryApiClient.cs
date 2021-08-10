using cShop.ViewModel.Catalog.Categories;
using cShop.ViewModel.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace cShop.ApiIntegration.Catalog.Categories
{
    public interface ICategoryApiClient
    {
        Task<ApiResult<List<CategoryViewModel>>> Create(CategoryCreateRequest request);
        Task<ApiResult<List<bool>>> Delete(int categoryId);
        Task<ApiResult<List<CategoryViewModel>>> GetAll();
        Task<ApiResult<List<bool>>> Update(int categoryId, CategoryUpdateRequest request);
    }
}