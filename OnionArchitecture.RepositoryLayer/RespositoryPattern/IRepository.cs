using OnionArchitecture.DomainLayer.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnionArchitecture.RepositoryLayer.RespositoryPattern
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);  

        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Remove(T entity);
        void SaveChanges();
    }
}
