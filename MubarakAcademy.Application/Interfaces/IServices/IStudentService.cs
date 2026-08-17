using MubarakAcademy.Application.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace MubarakAcademy.Application.Interfaces.IServices
{
    public interface IStudentService
    {
        Task<IEnumerable<StudentDto>> GetAllStudentAsync();
        Task<StudentDto?> GetStudentByIdAsync(Guid id);
        Task<StudentDto> UpdateStudentAsync(Guid id, StudentDto dto);
        Task<bool> DeleteStudentAsync(Guid id);
    }
}
