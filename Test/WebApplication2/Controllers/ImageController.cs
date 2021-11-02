using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Entities;
using WebApplication2.Models.DTOs.Requests;
using WebApplication2.Repository.ImageRepository;
using WebApplication2.Services.ImageService;

namespace WebApplication2.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class ImageController : ControllerBase
    {
        private readonly IImageService _imageService;

        public ImageController(IImageService imageService)
        {
            _imageService = imageService;
        }

        [HttpPost]
        public async Task<IActionResult> AddNewImage([FromForm] ImageRequest request)
        {
            var newImage = await _imageService.UploadFileAsync(request.Image);
            return Ok(newImage);
        }

        [HttpGet]
        public ActionResult<List<Image>> GetAll()
        {
            var images = _imageService.GetAllAsync();
            return Ok(images);
        }

        [HttpGet("{id}")]
        public ActionResult<List<Image>> GetAll(int id)
        {
            var images = _imageService.GetByIdAsync(id);
            return Ok(images);
        }
    }
}
