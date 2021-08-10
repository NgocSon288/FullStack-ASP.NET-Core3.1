using cShop.Utilities.Enums;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace cShop.Application.Common
{
    public interface IFileStorageService
    {
        Task DeleteFileAsync(string fileName);
        Task<string> SaveFileAsync(IFormFile file, SavePath savePath);
    }
}