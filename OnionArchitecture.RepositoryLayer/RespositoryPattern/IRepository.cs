using OnionArchitecture.DomainLayer.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnionArchitecture.RepositoryLayer.RespositoryPattern
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<IEnumerable<T>> FindAllAsync();
        Task<T> FindAsync(int id);

        Task<int> Insert(T entity);
        Task Update(T entity);
        Task Delete(T entity);
        void Remove(T entity);
        Task SaveChanges();
    }
}
