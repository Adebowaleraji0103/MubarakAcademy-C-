using MubarakAcademy.Application.DTO;
using MubarakAcademy.Application.Interfaces.IServices;
using MubarakAcademy.Application.Interfaces.IUnitOfWork;
using System.Linq;

namespace MubarakAcademy.Application.Services
{
    public class StudentServicess : IStudentService
    {
        private readonly IUnitOfWork _unitOfWork;
        public StudentServicess(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<StudentDto>> GetAllStudentAsync()
        {
            var students = await _unitOfWork.Students.GetAllAsync();

            return students.Select(student => new StudentDto
            {
                FirstName = student.FirstName,
                LastName = student.LastName,
                PhoneNumber = student.PhoneNumber,
                DepartmentId = student.DepartmentId,
                //DepartmentName = student.Department.DepartmentName
            }).ToList();
        }

        public Task<bool> DeleteStudentAsync(Guid id)
        {
            throw new NotImplementedException();
        }


        public Task<StudentDto?> GetStudentByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<StudentDto> UpdateStudentAsync(Guid id, StudentDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
