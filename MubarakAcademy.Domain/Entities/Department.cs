using System.ComponentModel.DataAnnotations;

namespace MubarakAcademy.Domain.Entities
{
   public class Department
    {
        [Key]
        public Guid DepartmentId { get; set; }
        public string? DepartmentName { get; set; }

        public ICollection<Student> Students { get; set; } = new List<Student>();
        public ICollection<Teacher> Teachers { get; set; } = new List<Teacher>();
    }
}
