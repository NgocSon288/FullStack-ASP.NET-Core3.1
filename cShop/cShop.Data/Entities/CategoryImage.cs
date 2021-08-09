using System;
using System.Collections.Generic;
using System.Text;

namespace cShop.Data.Entities
{
    public class CategoryImage
    {
        public int Id { get; set; }

        public string ImagePath { get; set; }

        public string Alt { get; set; }

        public DateTime DateCreated { get; set; }


        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
