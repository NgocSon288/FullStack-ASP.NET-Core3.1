using cShop.Utilities.Constants;
using cShop.Utilities.Helpers;
using cShop.Utilities.Models;
using cShop.AdminAppUtilities.Mail.Dto;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cShop.AdminAppMail.Utilities
{
    public class WebSendMailHelper : IWebSendMailHelper
    {
        private readonly IMailHelperService _mailHelperService;
        private readonly IConfiguration _configuration;

        public WebSendMailHelper(IMailHelperService mailHelperService,
            IConfiguration configuration)
        {
            _mailHelperService = mailHelperService;
            _configuration = configuration;
        }

        public async Task SendConfirmCreated(SendConfirmCreatedDto input)
        {
            var  code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(input.Code));
            var url = _configuration.GetValue<string>(SystemConstants.AppSettings.BaseAddressWeb) + _configuration.GetValue<string>(SystemConstants.Host.CallbackComfirmCreateAccount);
            var callbackUrl = string.Format(url, input.UserId.ToString(), code);
            string subject = "XÁC NHẬN TÀI KHOẢN";
            string fileName = "ConfirmCreatedNewUser.html";
            var bodyKeyValues = new Dictionary<string, string>()
            {
                {"Name", input.Name },
                {"Url", callbackUrl }
            };

            // Gửi mail vào email đó -> a href= Code + UserId
            var mailContent = new MailContent(input.To, subject, fileName, bodyKeyValues);
            await _mailHelperService.SendMail(mailContent);
        }
    }
}
