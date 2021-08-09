using System;
using System.Collections.Generic;

namespace cShop.Data.Entities
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Content { get; set; }

        public decimal Price { get; set; }

        public decimal Promotion { get; set; }

        public DateTime DateCreated { get; set; }

        public bool IsFreeship { get; set; }

        public bool IsInstallment { get; set; }

        public int ViewCount { get; set; }

        public float Rating { get; set; }

        public int? CategoryId { get; set; }

        public Category Category { get; set; }

        public int? BrandId { get; set; }

        public Brand Brand { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }

        public List<ProductImage> ProductImages { get; set; }

        public List<ProductParameter> ProductParameters { get; set; }
    }
}