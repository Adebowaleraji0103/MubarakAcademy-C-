using MubarakAcademy.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace MubarakAcademy.Domain.Entities
{
   public class Teacher: BaseEntity
    {
        [Key]
        public Guid TeacherId { get; set; }
        public string? FullName { get; set; }
        public string? PhoneNumber { get; set; }

        public Guid UserId { get; set; }
        public User? User { get; set; }
        public Guid DepartmentId { get; set; }
        public Department? Department { get; set; }
    }
}
