using MubarakAcademy.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MubarakAcademy.Application.DTO
{
    public class DepartmentDto
    {
        public string? DepartmentName { get; set; }
        public ICollection<Student> Students { get; set; } = new List<Student>();
        public ICollection<Teacher> Teachers { get; set; } = new List<Teacher>();
    }
}
