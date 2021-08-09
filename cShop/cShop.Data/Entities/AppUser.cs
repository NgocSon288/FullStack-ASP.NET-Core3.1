using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace cShop.Data.Entities
{
    public class AppUser : IdentityUser<Guid>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string Address { get; set; }

        public DateTime? BirthDay { get; set; }


        public List<Order> Orders { get; set; }
    }
}