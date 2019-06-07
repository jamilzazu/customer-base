using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using CustomerBase.Domain.Core.Models;
using CustomerBase.Domain.Interfaces;
using CustomerBase.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace CustomerBase.Infra.Data.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity<TEntity>
    {
        protected CustomerContext Db;
        protected DbSet<TEntity> DbSet;

        public Repository(CustomerContext context)
        {
            Db = context;
            DbSet = Db.Set<TEntity>();
        }

        public virtual void Insert(TEntity obj)
        {
            DbSet.Add(obj);
        }

        public virtual void Update(TEntity obj)
        {
            DbSet.Update(obj);
        }

        public void Delete(Guid id)
        {
            DbSet.Remove(DbSet.Find(id));
        }

        public virtual IEnumerable<TEntity> Search(Expression<Func<TEntity, bool>> predicate)
        {
            return DbSet.AsNoTracking().Where(predicate);
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return DbSet.ToList();
        }

        public virtual TEntity GetById(Guid id)
        {
            return DbSet.AsNoTracking().FirstOrDefault(t => t.Id == id);
        }

        public int Save()
        {
            return Db.SaveChanges();
        }

        public void Dispose()
        {
            Db.Dispose();
        }
    }
}
