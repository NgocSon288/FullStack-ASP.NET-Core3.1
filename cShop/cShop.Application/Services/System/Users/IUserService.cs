using cShop.ViewModel.Common;
using cShop.ViewModel.System.Users;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace cShop.Application.Services.System.Users
{
    public interface IUserService
    {
        Task<ApiResult<List<UserViewModel>>> GetUsers();

        Task<ApiResult<UserViewModel>> GetById(Guid id);

        Task<ApiResult<List<UserViewModel>>> Search(UserSearchRequest request);

        Task<ApiResult<bool>> ConfirmCreatedNewAccount(UserComfirmNewAccountRequest input);

        Task<ApiResult<string>> Authenticate(UserLoginRequest request);

        Task<ApiResult<UserRegisterResponse>> Register(UserRegisterRequest request);

        Task<ApiResult<bool>> Update(Guid userId, UserUpdateRequest request);

        Task<ApiResult<bool>> Delete(Guid userId);
        Task<ApiResult<bool>> AssignRole(Guid userId, RoleAssignRequest request);
    }
}