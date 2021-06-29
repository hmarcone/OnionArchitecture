using Microsoft.EntityFrameworkCore;
using OnionArchitecture.DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnionArchitecture.RepositoryLayer.RespositoryPattern
{
    public class Repository<T>: IRepository<T> where T : BaseEntity
    {
        #region property  
        private readonly ApplicationDbContext _applicationDbContext;
        private DbSet<T> entities;
        #endregion

        #region Constructor  
        public Repository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
            entities = _applicationDbContext.Set<T>();
        }
        #endregion

        public async Task Delete(T entity)
        {
            if( entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            entities.Remove(entity);
            await _applicationDbContext.SaveChangesAsync();
        }

        public async Task<T> FindAsync(int id)
        {
            return await entities.AsNoTracking().SingleOrDefaultAsync(c => c.Id == id);
        }

        public async Task<IEnumerable<T>> FindAllAsync()
        {
            return await entities.ToListAsync();
        }

        public async Task Insert(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            
             entities.Add(entity);

            await _applicationDbContext.SaveChangesAsync();
        }

        public void Remove(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            entities.Remove(entity);
        }

        public async Task SaveChanges()
        {
            await _applicationDbContext.SaveChangesAsync();
        }

        public async Task Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }

            entities.Update(entity);
            await _applicationDbContext.SaveChangesAsync();
        }
    }
}
