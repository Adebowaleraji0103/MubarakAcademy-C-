using Microsoft.EntityFrameworkCore;
using MubarakAcademy.Domain.Entities;

namespace MubarakAcademy.Infastructure.Persistence.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions <ApplicationDbContext> options): base(options) 
        { 
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<User> Users { get; set; }
    }
}

