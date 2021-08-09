using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace cShop.ViewModel.System.Users
{
    public class UserLoginRequest
    {
        [Display(Name = "Tài khoản")]
        [Required(ErrorMessage = "{0} không được bỏ trống")]
        public string UserName { get; set; }

        [Display(Name = "Mật khẩu")]
        [Required(ErrorMessage = "{0} không được bỏ trống")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool IsPersistent { get; set; }
    }
}
