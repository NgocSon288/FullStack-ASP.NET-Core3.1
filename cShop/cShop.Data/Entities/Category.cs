using System;
using System.Collections.Generic;

namespace cShop.Data.Entities
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime DateCreated { get; set; }


        public List<Product> Products { get; set; }

        public CategoryImage CategoryImage { get; set; }

        public List<Brand> Brands { get; set; }
    }
}