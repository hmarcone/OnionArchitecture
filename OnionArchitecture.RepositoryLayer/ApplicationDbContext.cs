using Microsoft.EntityFrameworkCore;
using OnionArchitecture.DomainLayer.EntityMapper;

namespace OnionArchitecture.RepositoryLayer
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomerMap());

            base.OnModelCreating(modelBuilder); 
        }
    }
}
