using cShop.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;

namespace cShop.Data.Extensions
{
    public static class DataSeeding
    {
        public static void InitData(this ModelBuilder builder)
        {
            // Identity
            var roleId = new Guid("8A4C8842-5A87-41D5-A370-FFF933FDB65F");
            var adminId = new Guid("3CB2D29E-F243-45E8-A6BA-5D7DFB1572AE");

            builder.Entity<AppRole>().HasData(new AppRole
            {
                Id = roleId,
                Name = "admin",
                NormalizedName = "admin",
                Description = "Administrator role"
            });

            var hasher = new PasswordHasher<AppUser>();
            builder.Entity<AppUser>().HasData(new AppUser
            {
                Id = adminId,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "18521694@gm.uit.edu.vn",
                NormalizedEmail = "18521694@gm.uit.edu.vn",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "admin"),
                SecurityStamp = string.Empty,
                FirstName = "Huỳnh",
                LastName = "Sơn",
                Age = 21,
                Address = "Đồng Tháp",
                BirthDay = new DateTime(2000, 07, 29)
            });

            builder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleId,
                UserId = adminId
            });

            // Category
            builder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    Name = "Điện Thoại",
                    Description = "Điện thoại xịn nhất hệ mặt trời"
                },
                new Category()
                {
                    Id = 2,
                    Name = "Laptop",
                    Description = "Laptop xịn nhất hệ mặt trời"
                }
            );

            // Product
            builder.Entity<Product>().HasData(
                new Product()
                {
                    Id =  1,
                    Name = "Điện thoại Samsung Galaxy S20 FE (8GB/256GB)",
                    Description = "Samsung đã giới thiệu đến người dùng thành viên mới của dòng điện thoại thông minh S20 Series đó chính là Samsung Galaxy S20 FE.",
                    CategoryId = 1,
                    Content = "Đây là mẫu flagship cao cấp quy tụ nhiều tính năng mà Samfan yêu thích, hứa hẹn sẽ mang lại trải nghiệm cao cấp của dòng Galaxy S với mức giá dễ tiếp cận hơn.",
                    Price = 11990000,
                    Promotion = 15490000
                },
                new Product()
                {
                    Id = 2,
                    Name = "Laptop Lenovo IdeaPad Slim 5 15ITL05 i5 1135G7/8GB/512GB/Win10 (82FG001PVN)",
                    Description = "Sở hữu thiết kế mỏng nhẹ và thanh lịch, Lenovo IdeaPad Slim 5 15ITL05 i5 1135G7 (82FG001PVN) không chỉ là một mẫu laptop thời trang.",
                    CategoryId = 2,
                    Content = "Lenovo IdeaPad Slim 5 15ITL05 sở hữu một hiệu năng vượt trội nhờ việc trang bị con chip Intel Core i5 Tiger Lake 1135G7 sản xuất trên tiến trình 10 nm tiên tiến. Con chip thế hệ thứ 11 này mang đến một xung nhịp cơ sở là 2.4 GHz và được ép xung lên tối đa tới 4.2 GHz. Nhờ vậy tốc độ xử lý của máy nhanh vượt trội, đồng thời tiết kiệm được năng lượng, kéo dài tuổi thọ pin, giúp bạn đạt hiệu suất cao trong công việc.",
                    Price = 18090000,
                    Promotion = 18490000
                }
            );
        }
    }
}