using cShop.Data.Entities;
using cShop.ViewModel.Common;
using cShop.ViewModel.System.Roles;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cShop.Application.Services.System.Roles
{
    public class RoleService : IRoleService
    {
        private readonly RoleManager<AppRole> _roleManager;

        public RoleService(RoleManager<AppRole> roleManager)
        {
            _roleManager = roleManager;
        }

        public async Task<ApiResult<RoleViewModel>> GetById(Guid id)
        {
            var role = await _roleManager.FindByIdAsync(id.ToString());

            if (role == null)
            {
                return new ApiResult<RoleViewModel>(false, "Role is not found!");
            }

            var roleVm = new RoleViewModel()
            {
                Id = role.Id,
                Description = role.Description,
                Name = role.Name
            };

            return new ApiResult<RoleViewModel>(true, "", roleVm);
        }

        public async Task<ApiResult<List<RoleViewModel>>> GetRoles()
        {
            var roles = _roleManager.Roles.Select(u => new RoleViewModel()
            {
                Id = u.Id,
                Description = u.Description,
                Name = u.Name
            });

            return new ApiResult<List<RoleViewModel>>(true, "", await roles.ToListAsync());
        }

        public async Task<ApiResult<RoleCreateResponse>> Create(RoleCreateRequest request)
        {
            try
            {
                if (await _roleManager.RoleExistsAsync(request.Name))
                {
                    return new ApiResult<RoleCreateResponse>(false, "RoleName already exists!");
                }

                var role = new AppRole()
                {
                    Name = request.Name,
                    Description = request.Description
                };

                var result = await _roleManager.CreateAsync(role);

                var roleVm = new RoleCreateResponse()
                {
                    Id = role.Id,
                    Description = role.Description,
                    Name = role.Name
                };

                if (!result.Succeeded)
                {
                    return new ApiResult<RoleCreateResponse>(false, string.Join('\n', result.Errors.ToList()));
                }

                return new ApiResult<RoleCreateResponse>(true, "", roleVm);
            }
            catch (Exception ex)
            {
                return new ApiResult<RoleCreateResponse>(false, ex.Message);
            }
        }

        public async Task<ApiResult<bool>> Update(Guid roleId, RoleUpdateRequest request)
        {
            try
            {
                var role = await _roleManager.FindByIdAsync(roleId.ToString());

                if (role == null)
                {
                    return new ApiResult<bool>(false, "Role not found!");
                }


                var checkNameRole = await _roleManager.FindByNameAsync(request.Name);
                if(checkNameRole !=null && checkNameRole.Name != role.Name)
                {
                    return new ApiResult<bool>(false, "Role name is already exists!");
                }

                role.Name = request.Name;
                role.Description = request.Description;

                var result = await _roleManager.UpdateAsync(role);

                if (!result.Succeeded)
                {
                    return new ApiResult<bool>(false, "Update Role unsuccessfully!");
                }

                return new ApiResult<bool>(true, "Update Role successfully!");
            }
            catch (Exception)
            {
                return new ApiResult<bool>(false, "Update Role unsuccessfully!");
            }
        }

        public async Task<ApiResult<bool>> Delete(Guid roleId)
        {
            try
            {
                var role = await _roleManager.FindByIdAsync(roleId.ToString());

                if (role == null)
                {
                    return new ApiResult<bool>(false, "Role not found!");
                }

                var result = await _roleManager.DeleteAsync(role);

                if (!result.Succeeded)
                {
                    return new ApiResult<bool>(false, "Delete Role unsuccessfully!");
                }

                return new ApiResult<bool>(true, "Delete Role successfully!");
            }
            catch (Exception)
            {
                return new ApiResult<bool>(false, "Update Role unsuccessfully!");
            }
        }
    }
}