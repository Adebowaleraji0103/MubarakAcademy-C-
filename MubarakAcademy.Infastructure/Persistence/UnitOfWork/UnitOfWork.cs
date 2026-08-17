using MubarakAcademy.Application.Interfaces.IRepositories;
using MubarakAcademy.Application.Interfaces.IUnitOfWork;
using MubarakAcademy.Domain.Entities;
using MubarakAcademy.Infastructure.Persistence.Data;
using MubarakAcademy.Infastructure.Persistence.Repositories;


namespace MubarakAcademy.Infastructure.Persistence.UnitOfWork
{
   public class UnitOfWork:IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;

            Students = new GenericRepository<Student>(_context);
            Teachers = new GenericRepository<Teacher>(_context);
            Users = new GenericRepository<User>(_context);
        }

        public IGenericRepository<Student> Students { get; }
        public IGenericRepository<Teacher> Teachers { get; }
        public IGenericRepository<User> Users { get; }

        public async Task<int> SaveAsync() 
            {
            return await _context.SaveChangesAsync();
            }
    }
}
