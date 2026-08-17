using MubarakAcademy.Domain.Common;
using System;
using System.ComponentModel.DataAnnotations;

namespace MubarakAcademy.Domain.Entities
{
   public class Student:BaseEntity
    {
        [Key]
        public Guid StudentId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? PhoneNumber { get; set; }

        public Guid UserId { get; set; }    
        public User? User { get; set; }
        public Guid DepartmentId { get; set; }
        public Department? Department { get; set; }
    }
}
