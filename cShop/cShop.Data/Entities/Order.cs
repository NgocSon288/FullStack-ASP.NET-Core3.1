using System;
using System.Collections.Generic;

namespace cShop.Data.Entities
{
    public class Order
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public DateTime? CreatedDate { get; set; }


        public Guid? AppUserId { get; set; }

        public AppUser AppUser { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
    }
}