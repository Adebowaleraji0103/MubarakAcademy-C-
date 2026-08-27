using MubarakAcademy.Application.DTO;
using MubarakAcademy.Application.Interfaces.IServices;
using MubarakAcademy.Application.Interfaces.IUnitOfWork;
using MubarakAcademy.Domain.Entities;


namespace MubarakAcademy.Application.Services
{
    public class StudentService : IStudentService
    {
        private readonly IUnitOfWork _unitOfWork;
        public StudentService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<StudentDto?> AddStudentAsync(StudentDto dto)
        {
    
            var student = new Student
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                PhoneNumber = dto.PhoneNumber,
                DepartmentId = dto.DepartmentId,
            };
            await _unitOfWork.Students.AddAsync(student);
            await _unitOfWork.SaveAsync();

            return new StudentDto
            {
                FirstName = student.FirstName,
                LastName = student.LastName,
                PhoneNumber = student.PhoneNumber,
                DepartmentName = student?.Department?.DepartmentName
            };


        }
           

        public Task<bool> DeleteStudentAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<StudentDto>> GetAllStudentAsync()
        {
            var students =  await _unitOfWork.Students.GetAllAsync();

           return students.Select(s => new StudentDto
            {
                FirstName = s.FirstName,
                LastName = s.LastName,
                DepartmentId = s.DepartmentId,
                DepartmentName = s?.Department?.DepartmentName
            }).ToList();
        }

        public async Task<StudentDto?> GetStudentByIdAsync(Guid Id)
        {
            var student =  await _unitOfWork.Students.GetById(Id);

            if(student == null)
            {
                return null;
            }

            return new StudentDto
            {
                FirstName = student.FirstName,
                LastName = student.LastName,
                DepartmentId = student.DepartmentId,
                DepartmentName = student.Department?.DepartmentName
            };

        }

        public Task<StudentDto> UpdateStudentAsync(Guid id, StudentDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
