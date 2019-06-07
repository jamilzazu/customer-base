using CustomerBase.Domain.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CustomerBase.Domain.Interfaces
{
    public interface IRepository<TEntity> : IDisposable where TEntity : Entity<TEntity>
    {
        void Insert(TEntity obj);
        void Update(TEntity obj);
        void Delete(Guid id);
        int Save();
        TEntity GetById(Guid id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Search(Expression<Func<TEntity, bool>> predicate);

    }
}
