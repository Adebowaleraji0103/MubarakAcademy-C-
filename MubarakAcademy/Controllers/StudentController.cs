using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MubarakAcademy.Application.DTO;
using MubarakAcademy.Application.Interfaces.IServices;

namespace MubarakAcademy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllStudentAsync()
        {
            var students = await _studentService.GetAllStudentAsync();
            return Ok(students);
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetStudentByIdAsync(Guid Id)
        {
            var student = await _studentService.GetStudentByIdAsync(Id);
            return Ok(student);
        }

        [HttpPost]
        public async Task<IActionResult> AddStudentAsync(StudentDto dto)
        {
            var student = await _studentService.AddStudentAsync(dto);
            return Ok(student);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateStudentAsync(Guid Id, StudentDto dto)
        {
            var student = await _studentService.UpdateStudentAsync(Id, dto);
            return Ok(student);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteStudentAsync(Guid Id)
        {
            var student = _studentService.DeleteStudentAsync(Id);
            return Ok(student);
        }

    }
}
