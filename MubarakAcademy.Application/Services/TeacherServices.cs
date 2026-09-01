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

        public async Task<bool> Delete(Guid id)
        {
            var teacher = await _unitOfWork.Teachers.GetById(id);

            if (teacher == null)
            {
                return false;
            }
             _unitOfWork.Teachers.DeleteAsync(teacher);
            await _unitOfWork.SaveAsync();

            return true;
        }

        public async Task<IEnumerable<TeacherResponseDto>> GetAllTeacherAsync()
        {
            var teachers = await _unitOfWork.Teachers.GetAllAsync();

            return teachers.Select(t => new TeacherResponseDto
            {
                FullName = t.FullName,
                PhoneNumber = t.PhoneNumber,
                DepartmentName = t.Department?.DepartmentName
            }).ToList();
        }

        public async Task<TeacherResponseDto> GetTeacherByIdAsync(Guid id)
        {
            var teacher = await _unitOfWork.Teachers.GetById(id);

            if(teacher == null)
            {
                return null;
            }

            return new TeacherResponseDto
            {
                FullName = teacher.FullName,
                PhoneNumber = teacher.PhoneNumber,
                DepartmentName = teacher?.Department?.DepartmentName
            };
        }

        public async Task<TeacherResponseDto> Update(TeacherDto dto, Guid id)
        {
            var teacher = await _unitOfWork.Teachers.GetById(id);

            if(teacher == null)
            {
                return null;
            }
           dto.FullName = dto.FullName;
           dto.PhoneNumber = dto.PhoneNumber;

            _unitOfWork.Teachers.UpdateAsync(teacher);
            await _unitOfWork.SaveAsync();

            return new TeacherResponseDto
            {
                TeacherId = teacher.TeacherId,
                FullName = teacher.FullName,
                PhoneNumber = teacher.PhoneNumber,
                DepartmentName = teacher?.Department?.DepartmentName
            };
        
        }
    }
}
