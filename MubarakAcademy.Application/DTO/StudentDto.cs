using MubarakAcademy.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MubarakAcademy.Application.DTO
{
    public class StudentDto
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? PhoneNumber { get; set; }

        public Guid DepartmentId { get; set; }
        public string? DepartmentName { get; set; }
        //public Department? DepartmentName { get => DepartmentName; set => DepartmentName = value; }
    }
}
