using System;
using System.Collections.Generic;
using System.Text;

namespace cShop.Data.Entities
{
    public class Brand
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime DateCreated { get; set; }


        public int? CategoryId { get; set; }

        public BrandImage BrandImage { get; set; }

        public Category Category { get; set; }

        public List<Product> Products { get; set; }
    }
}
