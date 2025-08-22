using Blazor.Domain.DTOs;
using Blazor.Domain.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Blazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {


        private readonly IStudentRepository _studentRepository;
        private readonly IWebHostEnvironment _env;

        public StudentsController(IStudentRepository studentRepository , IWebHostEnvironment env)
        {
            _studentRepository = studentRepository;
            _env = env;

        }


        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] string? search)
        {
            var students = await _studentRepository.GetAllAsync(search);
            return Ok(students);
        }

        
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] StudentCreateDto dto)
        {
           

            var studentDto = await _studentRepository.CreateAsync(dto);
            return Ok(studentDto);
        }






    }
}
