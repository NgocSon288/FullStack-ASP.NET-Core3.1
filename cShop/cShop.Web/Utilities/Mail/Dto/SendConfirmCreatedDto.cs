using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cShop.AdminAppUtilities.Mail.Dto
{
    public class SendConfirmCreatedDto
    {
        public SendConfirmCreatedDto(string to, string name, string code, Guid userId)
        {
            To = to;
            Name = name;
            Code = code;
            UserId = userId;
        }

        public string To { get; set; }

        public string Name { get; set; }

        public string Code { get; set; }

        public Guid UserId { get; set; }
    }
}
