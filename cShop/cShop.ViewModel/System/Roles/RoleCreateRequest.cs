using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace cShop.ViewModel.System.Roles
{
    public class RoleCreateRequest
    {
        [Display(Name = "Tên quyền")]
        [Required(ErrorMessage = "{0} không được bỏ trống!")]
        public string Name { get; set; }

        [Display(Name = "Mô tả")]
        [Required(ErrorMessage = "{0} không được bỏ trống!")]
        public string Description { get; set; }
    }
}
