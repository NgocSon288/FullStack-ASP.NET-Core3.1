using cShop.ViewModel.Common;
using cShop.ViewModel.System.Roles;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace cShop.Application.Services.System.Roles
{
    public interface IRoleService
    {
        Task<ApiResult<RoleCreateResponse>> Create(RoleCreateRequest request);
        Task<ApiResult<bool>> Delete(Guid roleId);
        Task<ApiResult<RoleViewModel>> GetById(Guid id);
        Task<ApiResult<List<RoleViewModel>>> GetRoles();
        Task<ApiResult<bool>> Update(Guid roleId, RoleUpdateRequest request);
    }
}