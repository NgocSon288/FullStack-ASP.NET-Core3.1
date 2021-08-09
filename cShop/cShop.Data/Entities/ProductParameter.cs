using System;
using System.Collections.Generic;
using System.Text;

namespace cShop.Data.Entities
{
    public class ProductParameter
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Content { get; set; }

        public int? ProductId { get; set; }

        public Product Product { get; set; }
    }
}
