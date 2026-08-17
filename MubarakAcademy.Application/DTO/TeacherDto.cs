using System;
using System.Collections.Generic;
using System.Text;

namespace MubarakAcademy.Application.DTO
{
    public class TeacherDto
    {
        public string? FullName { get; set; }
        public string? PhoneNumber { get; set; }
        public Guid DepartmentId { get; set; }
    }
}
