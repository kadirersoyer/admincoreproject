using AdminCoreProject.Demo.Repo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminCoreProject.Demo.Unit
{
    public interface IUnitOfWork
    {
        IRepository<T> GetRepository<T>() where T: class;
        int SaveChanges();
    }
}
