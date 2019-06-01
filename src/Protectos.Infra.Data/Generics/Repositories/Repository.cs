using Protectos.Domain.Core.Models;
using Protectos.Domain.Generics.Interfaces;
using Protectos.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
namespace Protectos.Infra.Data.Generics.Repositories
{
    public class Repository<T> : IRepository<T> where T : Entity<T>
    {     
        protected readonly ProtectosContext _protectosContext;
        protected DbSet<T> _dbSet;
        public Repository(ProtectosContext protectosContext)
        {
            _protectosContext = protectosContext;
            _dbSet = _protectosContext.Set<T>();
        }
        public T Add(T obj)
        {
            _dbSet.Add(obj);
            return obj;
        }
        public void Delete(Guid id)
        {
            _dbSet.Remove(_dbSet.Find(id));
        }
        public void Dispose()
        {
            _protectosContext.Dispose();
        }
        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }
        public T GetbyId(Guid id)
        {
            return _dbSet.Find(id);
        }
        public int SaveChanges()
        {
            return _protectosContext.SaveChanges();
        }
        public IEnumerable<T> Search(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.Where(predicate);
        }
        public T Update(T obj)
        {
            var entry = _protectosContext.Entry(obj);
            _dbSet.Attach(obj);
            entry.State = EntityState.Modified;
            return obj;
        }
    }
}
