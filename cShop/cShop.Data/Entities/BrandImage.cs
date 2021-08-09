using System;
using System.Collections.Generic;
using System.Text;

namespace cShop.Data.Entities
{
    public class BrandImage
    {
        public int Id { get; set; }

        public string ImagePath { get; set; }

        public string Alt { get; set; }

        public DateTime DateCreated { get; set; }


        public int BrandId { get; set; }

        public Brand Brand { get; set; }
    }
}
