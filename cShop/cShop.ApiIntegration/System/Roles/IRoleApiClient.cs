using cShop.ViewModel.Common;
using cShop.ViewModel.System.Roles;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace cShop.ApiIntegration.System.Roles
{
    public interface IRoleApiClient
    {
        Task<ApiResult<RoleCreateResponse>> Create(RoleCreateRequest request);
        Task<ApiResult<bool>> DeleteRoleById(Guid roleId);
        Task<ApiResult<List<RoleViewModel>>> GetAll();
        Task<ApiResult<RoleViewModel>> GetRoleById(Guid roleId);
        Task<ApiResult<bool>> Update(Guid roleId, RoleUpdateRequest request);
    }
}