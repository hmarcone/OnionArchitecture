﻿using Microsoft.EntityFrameworkCore;
using OnionArchitecture.DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;

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

        public void Delete(T entity)
        {
            if( entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            entities.Remove(entity);
            _applicationDbContext.SaveChanges();
        }

        public T GetById(int id)
        {
            return entities.SingleOrDefault(c => c.Id == id);
        }

        public IEnumerable<T> GetAll()
        {
            return entities.AsEnumerable();
        }

        public void Insert(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            
            entities.Add(entity);
            _applicationDbContext.SaveChanges();
        }

        public void Remove(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            entities.Remove(entity);
        }

        public void SaveChanges()
        {
            _applicationDbContext.SaveChanges();
        }

        public void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }

            entities.Update(entity);
            _applicationDbContext.SaveChanges();
        }
    }
}
