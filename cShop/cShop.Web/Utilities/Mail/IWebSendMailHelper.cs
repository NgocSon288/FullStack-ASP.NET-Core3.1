using cShop.AdminAppUtilities.Mail.Dto;
using System.Threading.Tasks;

namespace cShop.AdminAppMail.Utilities
{
    public interface IWebSendMailHelper
    {
        Task SendConfirmCreated(SendConfirmCreatedDto input);
    }
}