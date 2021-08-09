using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace cShop.ViewModel.System.Users
{
    public class UserUpdateRequest
    {
        public Guid Id { get; set; }

        [Display(Name = "Họ")]
        [Required(ErrorMessage = "{0} không được bỏ trống!")]
        public string FirstName { get; set; }

        [Display(Name = "Tên")]
        [Required(ErrorMessage = "{0} không được bỏ trống!")]
        public string LastName { get; set; }

        [Display(Name = "Tuổi")]
        [Required(ErrorMessage = "{0} không được bỏ trống!")]
        public int Age { get; set; }

        [Display(Name = "Địa chỉ")]
        [Required(ErrorMessage = "{0} không được bỏ trống!")]
        public string Address { get; set; }

        [Display(Name = "Ngày sinh")]
        [Required(ErrorMessage = "{0} không được bỏ trống!")]
        [DataType(DataType.Date)]
        public DateTime? BirthDay { get; set; }

        [Display(Name = "Số điện thoại")]
        [Required(ErrorMessage = "{0} không được bỏ trống!")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
    }
}
