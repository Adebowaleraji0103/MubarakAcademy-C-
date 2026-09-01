using MubarakAcademy.Application.DTO;
using MubarakAcademy.Application.Interfaces.IServices;
using MubarakAcademy.Application.Interfaces.IUnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace MubarakAcademy.Application.Services
{
    public class TeacherServices : ITeacherService
    {
        private readonly IUnitOfWork _unitOfWork;
        public TeacherServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<TeacherResponseDto> AddTeacherAsync(TeacherDto dto)
        {
            var teacher = new TeacherDto
            {
               FullName = dto.FullName,
               PhoneNumber = dto.PhoneNumber,
               DepartmentId = dto.DepartmentId,
            };

            await _unitOfWork.SaveAsync();

            return new TeacherResponseDto
            {
                FullName = teacher.FullName,
                PhoneNumber = teacher.PhoneNumber,
            };
        }

        public Task<TeacherResponseDto> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TeacherResponseDto>> GetAllTeacherAsync()
        {
            throw new NotImplementedException();
        }

        public Task<TeacherResponseDto> GetTeacherByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<TeacherResponseDto> Update(TeacherDto dto, Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
