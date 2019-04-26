using Protectos.Domain.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
namespace Protectos.Domain.Generics.Interfaces
{
    public interface IRepository<T> : IDisposable where T : Entity<T>
    {
        T Add(T obj);
        T Update(T obj);
        void Delete(Guid id);
        T GetbyId(Guid id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Search(Expression<Func<T, bool>> predicate);
        int SaveChanges();
    }
}
