using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace AdminCoreProject.Data
{
    public class Repository<T>: IRepository<T> where T: class
    {
        private DbContext context;
        private DbSet<T> dbSet; 

        public Repository(DbContext context)
        {
            this.context = context;
            this.dbSet = context.Set<T>();
        }

        public bool Add(T t)
        {
            dbSet.Add(t);
            return SaveChanges();
        }

        public T GetById(object id)
        {
            return dbSet.Find(id);
        }

        public List<T> GetList(Expression<Func<T, bool>> expression)
        {
            return dbSet.Where(expression).ToList();
        }

        public List<T> GetList()
        {
            return dbSet.ToList();
        }

        public bool Remove(T t)
        {
            dbSet.Remove(t);
            return SaveChanges();
        }

        public bool SaveChanges()
        {
            return context.SaveChanges() == 1 ? true : false;
        }

        public bool Update(T t)
        {
            dbSet.Attach(t);
            context.Attach(t).State = EntityState.Modified;
            return SaveChanges();
        }
    }
}
