using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Services.ImageService
{
    public interface IImageService
    {
        Task<int> UploadFileAsync(IFormFile file);
    }
}
