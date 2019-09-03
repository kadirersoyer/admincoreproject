using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace AdminCoreProject.Data
{
    public interface IRepository<T> where T: class
    {
        bool Add(T t);
        bool Update(T t);
        bool Remove(T t);

        bool SaveChanges();
        T GetById(object id);
        List<T> GetList(Expression<Func<T, bool>> expression);
        List<T> GetList();
    }
}
