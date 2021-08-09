using cShop.ViewModel.System.Roles;
using System;
using System.Collections.Generic;
using System.Text;

namespace cShop.ViewModel.System.Users
{
    public class RoleAssignRequest
    {
        public Guid Id { get; set; }

        public List<RoleSelect> RoleAssignRequests { get; set; }
    }
}
