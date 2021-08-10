using cShop.Utilities.Enums;
using cShop.Utilities.Options;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipelines;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace cShop.Application.Common
{
    public class FileStorageService : IFileStorageService
    {
        private readonly PathStatic _pathStatic;
        private readonly string _userContentFolder;

        //private const string USER_CONTENT_FOLDER_NAME = "user-content";

        public FileStorageService(IWebHostEnvironment webHostEnvironment,
            IOptions<PathStatic> options)
        {
            _pathStatic = options.Value;
            _userContentFolder = Path.Combine(webHostEnvironment.WebRootPath, _pathStatic.UploadStaticPath);
        }

        private async Task SaveFileAsync(Stream mediaBinaryStream, string fileName)
        {
            var filePath = Path.Combine(_userContentFolder, fileName);

            using var output = new FileStream(filePath, FileMode.Create);
            await mediaBinaryStream.CopyToAsync(output);
        }

        public async Task DeleteFileAsync(string fileName)
        {
            var filePath = Path.Combine(_userContentFolder, fileName);
            if (File.Exists(filePath))
            {
                await Task.Run(() => File.Delete(filePath));
            }
        }

        public async Task<string> SaveFileAsync(IFormFile file, SavePath savePath)
        {
            var privatePath = savePath switch
            {
                SavePath.Category => _pathStatic.CategoryPath,
                SavePath.Product => _pathStatic.ProductPath,
                _ => ""
            };
            var checkPath = Path.Combine(_userContentFolder, privatePath);

            if (!Directory.Exists(checkPath))
            {
                Directory.CreateDirectory(checkPath);
            }

            var originalFileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
            var fileName = Path.Combine(privatePath, Guid.NewGuid() + originalFileName);
            await SaveFileAsync(file.OpenReadStream(), fileName);
            return fileName;
        }
    }
}

