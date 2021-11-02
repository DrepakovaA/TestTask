using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication2.Entities;
using WebApplication2.Models.DTOs.Requests;
using WebApplication2.Repository.AuthorRepository;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorRepository _authorRepository;

        public AuthorController(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }

        [HttpGet]
        public ActionResult<List<Author>> GetAll()
        {
            var authors = _authorRepository.GetAll();
            return Ok(authors);
        }

        [HttpGet("{id}")]
        public ActionResult<List<Author>> GetById(int id)
        {
            var authors = _authorRepository.GetById(id);
            return Ok(authors);
        }

        [HttpPost]
        public async Task<IActionResult> AddNew([FromBody] AuthorRequest request)
        {
            var newAuthor = await _authorRepository.Add(request);
            return CreatedAtAction(nameof(GetById), new { id = newAuthor.Id });
        }


    }
}
