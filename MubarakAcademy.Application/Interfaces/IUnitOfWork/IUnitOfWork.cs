using MubarakAcademy.Application.Interfaces.IRepositories;
using MubarakAcademy.Domain.Entities;

namespace MubarakAcademy.Application.Interfaces.IUnitOfWork
{
    public interface IUnitOfWork
    {
     IGenericRepository<Student> Students { get; }
     IGenericRepository<Teacher> Teachers { get; }
     IGenericRepository<User> Users { get; }
    Task<int> SaveAsync();  
    }
}

