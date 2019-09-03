using AdminCoreProject.Demo.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace AdminCoreProject.Demo.Repo
{
    public interface IRepository<T> where T : class
    {
        void Add(T t);
        void Update(T t);
        void Delete(T t);
        T Get(Expression<Func<T, bool>> expression);
        T Get(int id);

        IQueryable<T> GetList();
        IQueryable<T> GetList(Expression<Func<T, bool>> expression);
    }
}
