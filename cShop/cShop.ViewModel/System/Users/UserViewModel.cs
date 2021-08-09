using System;
using System.Collections.Generic;
using System.Text;

namespace cShop.ViewModel.System.Users
{
    public class UserViewModel
    {
        public Guid Id { get; set; }

        public string UserName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string Address { get; set; }

        public DateTime? BirthDay { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public List<string> Roles { get; set; }
    }
}
