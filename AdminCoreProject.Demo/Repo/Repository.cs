using AdminCoreProject.Demo.Domains;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace AdminCoreProject.Demo.Repo
{
    public class Repository<T> : IRepository<T> where T: class
    {
        private DbContext context;
        private DbSet<T> dbSet;

        public Repository(DbContext context)
        {
            this.context = context;
            this.dbSet = context.Set<T>();
        }

        public void Add(T t)
        {
            dbSet.Add(t);
        }

        public void Delete(T t)
        {
            dbSet.Remove(t);
        }

      
        public T Get(int id)
        {
            return dbSet.Find(id);
        }

        public T Get(Expression<Func<T, bool>> expression)
        {
            return dbSet.Where(expression).FirstOrDefault();
        }

        public IQueryable<T> GetList()
        {
            return dbSet;
        }

        public IQueryable<T> GetList(Expression<Func<T, bool>> expression)
        {
            return dbSet.Where(expression);
        }

        public void Update(T t)
        {
            dbSet.Attach(t);
            context.Attach(t).State = EntityState.Modified;
        }
    }
}
