using cShop.Application.Common;
using cShop.Data.EF;
using cShop.Data.Entities;
using cShop.Utilities.Enums;
using cShop.ViewModel.Catalog.Categories;
using cShop.ViewModel.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cShop.Application.Services.Catalog.Categories
{
    public class CategoryService : ICategoryService
    {
        private readonly AppDbContext _context;
        private readonly IFileStorageService _fileStorageService;

        public CategoryService(AppDbContext context,
            IFileStorageService fileStorageService)
        {
            _context = context;
            _fileStorageService = fileStorageService;
        }

        public async Task<ApiResult<List<CategoryViewModel>>> GetAll()
        {
            var categories = _context.Categories
                .Include(c => c.CategoryImage)
                .Select(c => new CategoryViewModel()
                {
                    Id = c.Id,
                    DateCreated = c.DateCreated,
                    Description = c.Description,
                    Name = c.Name,
                    Alt = c.CategoryImage.Alt,
                    ImagePath = c.CategoryImage.ImagePath
                });

            return new ApiResult<List<CategoryViewModel>>(true, "", await categories.ToListAsync());
        }

        public async Task<ApiResult<CategoryViewModel>> Create(CategoryCreateRequest request)
        {
            try
            {
                var categoryCheck = _context.Categories.Any(c => c.Name.Trim().ToLower() == request.Name.Trim().ToLower());

                if (categoryCheck)
                {
                    return new ApiResult<CategoryViewModel>(false, "Category name is already exists!");
                }

                var categoryImage = new CategoryImage()
                {
                    Alt = request.Alt,
                    DateCreated = DateTime.Now,
                    ImagePath = await _fileStorageService.SaveFileAsync(request.ImageFile, SavePath.Category)
                };

                var category = new Category()
                {
                    Name = request.Name,
                    DateCreated = DateTime.Now,
                    Description = request.Description,
                    CategoryImage = categoryImage
                };

                await _context.AddAsync(category);
                var result = await _context.SaveChangesAsync();

                if (result <= 0)
                {
                    return new ApiResult<CategoryViewModel>(false, "Create new category unsuccessfully!");
                }

                var categoryViewModel = new CategoryViewModel()
                {
                    Alt = categoryImage.Alt,
                    DateCreated = categoryImage.DateCreated,
                    Description = category.Description,
                    Id = category.Id,
                    ImagePath = categoryImage.ImagePath,
                    Name = category.Name
                };

                return new ApiResult<CategoryViewModel>(true, "Create new category successfully!", categoryViewModel);
            }
            catch (Exception ex)
            {
                return new ApiResult<CategoryViewModel>(false, ex.Message.ToString());
            }
        }

        public async Task<ApiResult<bool>> Delete(int categoryId)
        {
            try
            {
                var category = await _context.Categories.FirstOrDefaultAsync(c => c.Id == categoryId);

                if (category == null)
                {
                    return new ApiResult<bool>(false, "Category not found!");
                }

                var categoryImage = await _context.CategoryImages.FirstOrDefaultAsync(ci => ci.CategoryId == categoryId);

                if (categoryImage != null)
                {
                    await _fileStorageService.DeleteFileAsync(categoryImage.ImagePath);
                    _context.CategoryImages.Remove(categoryImage);
                }

                _context.Categories.Remove(category);
                var result = await _context.SaveChangesAsync();

                if (result <= 0)
                {
                    return new ApiResult<bool>(false, "Delete category unsuccessfully!");
                }

                return new ApiResult<bool>(true, "Delete category successfully!");
            }
            catch (Exception ex)
            {
                return new ApiResult<bool>(false, ex.Message.ToString());
            }
        }

        public async Task<ApiResult<bool>> Update(int categoryId, CategoryUpdateRequest request)
        {
            try
            {
                var category = await _context.Categories.FirstOrDefaultAsync(c => c.Id == categoryId);

                if (category == null)
                {
                    return new ApiResult<bool>(false, "Category not found!");
                }

                var categoryCheckName = _context.Categories.Any(c => c.Name.Trim().ToLower() == request.Name.Trim().ToLower() && c.Id != categoryId);

                if (categoryCheckName)
                {
                    return new ApiResult<bool>(false, "Category name is already exists!");
                }

                category.Description = request.Description;
                category.Name = request.Name;


                var categoryImage = await _context.CategoryImages.FirstOrDefaultAsync(ci => ci.CategoryId == categoryId);
                categoryImage.Alt = request.Alt;

                if (request.ImageFile != null && request.ImageFile.Length > 0)
                {

                    if (categoryImage != null)
                    {
                        await _fileStorageService.DeleteFileAsync(categoryImage.ImagePath);
                        categoryImage.ImagePath = await _fileStorageService.SaveFileAsync(request.ImageFile, SavePath.Category);
                    }
                }

                var result = await _context.SaveChangesAsync();

                if(result <= 0)
                {
                    return new ApiResult<bool>(false, "Update category unsuccessfully!");
                }

                return new ApiResult<bool>(true, "Update category successfully!");
            }
            catch (Exception ex)
            {
                return new ApiResult<bool>(false, ex.Message.ToString());
            }
        }
    }
}
