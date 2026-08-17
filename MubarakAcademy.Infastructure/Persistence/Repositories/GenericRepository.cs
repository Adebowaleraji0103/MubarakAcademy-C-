using Microsoft.EntityFrameworkCore;
using MubarakAcademy.Application.Interfaces.IRepositories;
using MubarakAcademy.Infastructure.Persistence.Data;
using System.Collections;


namespace MubarakAcademy.Infastructure.Persistence.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
        }

        public void DeleteAsync(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetById(Guid Id)
        {
            return await _context.Set<T>().FindAsync(Id);

        }

        void IGenericRepository<T>.UpdateAsync(T entity)
        {
            _context.Set<T>().Update(entity);
        }
    }
}
