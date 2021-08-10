using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace cShop.ViewModel.Catalog.Categories
{
    public class CategoryCreateRequest
    {
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
        [Required(ErrorMessage = "{0} không được bỏ trống!")]
        public IFormFile ImageFile { get; set; }
    }
}