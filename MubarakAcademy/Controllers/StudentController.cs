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
        public async Task<IActionResult> GetAllStudentAsync()
        {

        }
    }
}
