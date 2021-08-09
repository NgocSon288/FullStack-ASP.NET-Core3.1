using cShop.ViewModel.Common;
using cShop.ViewModel.System.Users;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace cShop.ApiIntegration.System.Users
{
    public interface IUserApiClient
    {
        Task<ApiResult<bool>> AsignRole(Guid userId, RoleAssignRequest request);
        Task<ApiResult<string>> Authenticate(UserLoginRequest model);
        Task<ApiResult<UserRegisterResponse>> ConfirmCreatedNewAccount(UserComfirmNewAccountRequest input);
        Task<ApiResult<bool>> DeleteUserById(Guid userId);
        Task<ApiResult<List<UserViewModel>>> GetAll();
        Task<ApiResult<UserViewModel>> GetUserById(Guid userId);
        Task<ApiResult<UserRegisterResponse>> Register(UserRegisterRequest request);
        Task<ApiResult<bool>> UpdateUser(Guid userId, UserUpdateRequest request);
    }
}