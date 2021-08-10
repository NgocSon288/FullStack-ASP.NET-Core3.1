using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace cShop.ViewModel.Catalog.Categories
{
    public class CategoryUpdateRequest
    {
        public int Id { get; set; }

        [Display(Name = "Tên")]
        [Required(ErrorMessage = "{0} không được bỏ trống!")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        [Required(ErrorMessage = "{0} không được bỏ trống!")]
        public string Description { get; set; }

        [Display(Name = "Alt")]
        [Required(ErrorMessage = "{0} không được bỏ trống!")]
        public string Alt { get; set; }

        [Display(Name = "Hình ảnh")]
        public IFormFile ImageFile { get; set; }
    }
}
