using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Entities;
using WebApplication2.Models.DTOs.Requests;
using WebApplication2.Models.DTOs.Responses;
using WebApplication2.Repository.ImageRepository;
using WebApplication2.UnitOfWorkPattern;

namespace WebApplication2.Services.ImageService
{
    public class ImageService : BaseService<ImageResponse, ImageRequest, Image>, IImageService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IImageRepository _imageRepository;

        public ImageService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _imageRepository = unitOfWork.ImageRepository;
        }

        public async Task<int> UploadFileAsync(IFormFile file)
        {
            using var ms = new MemoryStream();
            file.CopyTo(ms);
            var imageBytes = ms.ToArray();

            var image = new Image
            {
                ImageData = imageBytes,
                ImageTitle = file.FileName
            };

            _imageRepository.Add(image);
            await _unitOfWork.SaveAsync();
            return image.Id;
        }
        public override async Task<ImageResponse> CreateAsync(ImageRequest image)
        {
            _imageRepository.Add(image);
            await _unitOfWork.SaveAsync();
            return await _imageRepository.GetByIdAsync(image.ImageId);
        }

    }
}
