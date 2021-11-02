using Microsoft.AspNetCore.Http;

namespace WebApplication2.Models.DTOs.Requests
{
    public class AuthorRequest
    {
        public string Name { get; set; }
        public IFormFile Image { get; set; }
    }
}
