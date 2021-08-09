using cShop.Data.EF;
using cShop.Data.Entities;
using cShop.Utilities.Constants;
using cShop.Utilities.Helpers;
using cShop.ViewModel.Common;
using cShop.ViewModel.System.Roles;
using cShop.ViewModel.System.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace cShop.Application.Services.System.Users
{
    public class UserService : IUserService
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<AppRole> _roleManager;
        private readonly IConfiguration _configuration;
        private readonly IJwtHelper _jwtHelper;

        public UserService(AppDbContext context,
            UserManager<AppUser> userManager,
            SignInManager<AppUser> signInManager,
            RoleManager<AppRole> roleManager,
            IConfiguration configuration,
            IJwtHelper jwtHelper)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _configuration = configuration;
            _jwtHelper = jwtHelper;
        }

        public async Task<ApiResult<string>> Authenticate(UserLoginRequest request)
        {
            var user = await _userManager.FindByNameAsync(request.UserName);

            if (user == null)
            {
                return new ApiResult<string>(false, "UserName is incorrect!");
            }

            var result = await _signInManager.PasswordSignInAsync(user, request.Password, request.IsPersistent, false);

            if (result.IsNotAllowed)
            {
                return new ApiResult<string>(false, "Email not confirmed");
            }
            else if (result.IsLockedOut)
            {
                return new ApiResult<string>(false, "Account has been locked");
            }
            else if (!result.Succeeded)
            {
                return new ApiResult<string>(false, "Password is incorrect!");
            }

            return new ApiResult<string>(true, "", await _jwtHelper.IdentityUserToToken(new UserClaimViewModel()
            {
                FullName = $"{user.FirstName} {user.LastName}",
                UserId = user.Id,
                Roles = string.Join(';', await _userManager.GetRolesAsync(user)),
                Email = user.Email
            }));
        }

        public async Task<ApiResult<UserViewModel>> GetById(Guid userId)
        {
            var user = await _userManager.FindByIdAsync(userId.ToString());

            if (user == null)
            {
                return new ApiResult<UserViewModel>(false, "User is not found!");
            }

            var roles = await _userManager.GetRolesAsync(user);

            var userVm = new UserViewModel()
            {
                Address = user.Address,
                Age = user.Age,
                BirthDay = user.BirthDay,
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Id = user.Id,
                PhoneNumber = user.PhoneNumber,
                UserName = user.UserName,
                Roles = roles.ToList()
            };

            return new ApiResult<UserViewModel>(true, "", userVm);
        }

        public async Task<ApiResult<List<UserViewModel>>> GetUsers()
        {
            var users = _userManager.Users.Select(u => new UserViewModel()
            {
                UserName = u.UserName,
                Id = u.Id,
                Address = u.Address,
                Age = u.Age,
                BirthDay = u.BirthDay,
                FirstName = u.FirstName,
                LastName = u.LastName,
                PhoneNumber = u.PhoneNumber,
                Email = u.Email
            });

            return new ApiResult<List<UserViewModel>>(true, "", await users.ToListAsync());
        }

        public async Task<ApiResult<UserRegisterResponse>> Register(UserRegisterRequest request)
        {
            try
            {
                var userCheck = await _userManager.FindByNameAsync(request.UserName);

                if (userCheck != null)
                {
                    return new ApiResult<UserRegisterResponse>(false, "UserName already exists!");
                }

                var user = new AppUser()
                {
                    Address = request.Address,
                    Age = request.Age,
                    BirthDay = request.BirthDay,
                    Email = request.Email,
                    FirstName = request.FirstName,
                    LastName = request.LastName,
                    PhoneNumber = request.PhoneNumber,
                    UserName = request.UserName
                };

                var result = await _userManager.CreateAsync(user, request.PassWord);

                if (!result.Succeeded)
                {
                    return new ApiResult<UserRegisterResponse>(false, string.Join('\n', result.Errors.ToList()));
                }

                // Gửi mail
                var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);

                var response = new UserRegisterResponse()
                {
                    Code = code,
                    UserId = user.Id
                };

                return new ApiResult<UserRegisterResponse>(true, "", response);
            }
            catch (Exception ex)
            {
                return new ApiResult<UserRegisterResponse>(false, ex.Message);
            }
        }

        public async Task<ApiResult<bool>> ConfirmCreatedNewAccount(UserComfirmNewAccountRequest request)
        {
            try
            {
                var user = await _userManager.FindByIdAsync(request.UserId);

                if (user == null)
                {
                    return new ApiResult<bool>(false, "Invalid User!");
                }

                var code = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(request.Code));
                var result = await _userManager.ConfirmEmailAsync(user, code);

                if (!result.Succeeded)
                {
                    return new ApiResult<bool>(false, string.Join(',', result.Errors));
                }

                return new ApiResult<bool>(true, "Verify successfully");
            }
            catch (Exception ex)
            {
                return new ApiResult<bool>(false, ex.Message);
            }
        }

        public async Task<ApiResult<List<UserViewModel>>> Search(UserSearchRequest request)
        {
            var users = _userManager.Users;

            if (!string.IsNullOrEmpty(request.Name))
            {
                users = users.Where(u => u.FirstName.ToLower().Contains(request.Name.ToLower())
                    || u.LastName.ToLower().Contains(request.Name.ToLower()));
            }

            if (!string.IsNullOrEmpty(request.UserName))
            {
                users = users.Where(u => u.UserName.ToLower().Contains(request.UserName.ToLower()));
            }

            if (!string.IsNullOrEmpty(request.Address))
            {
                users = users.Where(u => u.Address.ToLower().Contains(request.Address.ToLower()));
            }

            var result = users.Select(u => new UserViewModel()
            {
                UserName = u.UserName,
                Id = u.Id,
                Address = u.Address,
                Age = u.Age,
                BirthDay = u.BirthDay,
                FirstName = u.FirstName,
                LastName = u.LastName,
                PhoneNumber = u.PhoneNumber,
                Email = u.Email
            });

            return new ApiResult<List<UserViewModel>>(true, "", await result.ToListAsync());
        }

        public async Task<ApiResult<bool>> Update(Guid userId, UserUpdateRequest request)
        {
            try
            {
                var user = await _userManager.FindByIdAsync(userId.ToString());

                if(user == null)
                {
                    return new ApiResult<bool>(false, "User not found!");
                }

                user.FirstName = request.FirstName;
                user.LastName = request.LastName;
                user.Age = request.Age;
                user.Address = request.Address;
                user.BirthDay = request.BirthDay;
                user.PhoneNumber = request.PhoneNumber;

                var result = await _userManager.UpdateAsync(user);

                if (!result.Succeeded)
                {
                    return new ApiResult<bool>(false, "Update user unsuccessfully!");
                }

                return new ApiResult<bool>(true, "Update user successfully!");
            }
            catch (Exception)
            {
                return new ApiResult<bool>(false, "Update user unsuccessfully!");
            }
        }

        public async Task<ApiResult<bool>> AssignRole(Guid userId, RoleAssignRequest request)
        {
            try
            {
                var user = await _userManager.FindByIdAsync(userId.ToString());

                if (user == null)
                {
                    return new ApiResult<bool>(false, "User not found!");
                }

                var rolesRequest = request.RoleAssignRequests.Where(r => r.IsSelected).Select(r=>r.Name);
                var roles = await _userManager.GetRolesAsync(user);

                var removeRoles = roles.Where(r => !rolesRequest.Contains(r));
                var addRoles = rolesRequest.Where(r => !roles.Contains(r));

                foreach (var item in removeRoles)
                {
                    if(await _userManager.IsInRoleAsync(user, item))
                    {
                        await _userManager.RemoveFromRoleAsync(user, item);
                    }
                }

                foreach (var item in addRoles)
                {
                    if (!(await _userManager.IsInRoleAsync(user, item)))
                    {
                        await _userManager.AddToRoleAsync(user, item);
                    }
                }

                return new ApiResult<bool>(true, "Assign Role successfully!");
            }
            catch (Exception)
            {
                return new ApiResult<bool>(false, "Assign Role unsuccessfully!");
            }
        }

        public async Task<ApiResult<bool>> Delete(Guid userId)
        {
            try
            {
                var user = await _userManager.FindByIdAsync(userId.ToString());

                if (user == null)
                {
                    return new ApiResult<bool>(false, "User not found!");
                }

                var result = await _userManager.DeleteAsync(user);

                if (!result.Succeeded)
                {
                    return new ApiResult<bool>(false, "Delete user unsuccessfully!");
                }

                return new ApiResult<bool>(true, "Delete user successfully!");
            }
            catch (Exception)
            {
                return new ApiResult<bool>(false, "Update user unsuccessfully!");
            }
        }
    }
}