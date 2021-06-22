using OnionArchitecture.DomainLayer.Models;
using System.Collections.Generic;

namespace OnionArchitecture.RepositoryLayer.RespositoryPattern
{
    public interface IRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();
        T GetById(int id);  
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Remove(T entity);
        void SaveChanges();
    }
}
