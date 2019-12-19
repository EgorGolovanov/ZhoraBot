using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using SchoolApplication.DataBase;

namespace ZhoraBot.Repository
{
    class SQLRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private DbContext context;

        private bool disposed = false;

        public SQLRepository(DbContext context)
        {
            this.context = context;
        }

        public void Create(TEntity item)
        {
            context.Set<TEntity>().Add(item);
        }

        public void Delete(Guid id)
        {
            TEntity item = context.Set<TEntity>().Find(id);
            if (item != null)
                context.Set<TEntity>().Remove(item);
        }

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public TEntity Get(Guid id)
        {
            return context.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return context.Set<TEntity>().ToList();
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(TEntity item)
        {
            context.Entry<TEntity>(item).State = EntityState.Modified;
        }
    }
}
