using System;
using System.Collections.Generic;
using System.Text;

namespace cShop.Data.Entities
{
    public class ProductImage
    {
        public int Id { get; set; }

        public string ImagePath { get; set; }

        public string Alt { get; set; }

        public string Description { get; set; }

        public int DisplayOrder { get; set; }

        public DateTime DateCreated { get; set; }


        public int ProductId { get; set; }

        public Product Product { get; set; }
    }
}
