using MubarakAcademy.Application.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace MubarakAcademy.Application.Interfaces.IServices
{
    public interface ITeacherService
    {
        Task<IEnumerable<TeacherResponseDto>> GetAllTeacherAsync();
        Task<TeacherResponseDto> GetTeacherByIdAsync(Guid id);
        Task<TeacherResponseDto> AddTeacherAsync(TeacherDto dto);
        Task<TeacherResponseDto> Update(TeacherDto dto, Guid id);
        Task<bool> Delete(Guid id);
    }
}
