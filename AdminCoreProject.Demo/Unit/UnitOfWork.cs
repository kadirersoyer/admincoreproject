using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminCoreProject.Demo.Context;
using AdminCoreProject.Demo.Repo;
using Microsoft.EntityFrameworkCore;

namespace AdminCoreProject.Demo.Unit
{
    public class UnitOfWork : IUnitOfWork
    {
        private CilCommerceDbContext context;

        public UnitOfWork(CilCommerceDbContext context)
        {
            this.context = context;
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public IRepository<T> GetRepository<T>() where T : class
        {
            return new Repository<T>(context);
        }

        public int SaveChanges()
        {
            return context.SaveChanges();
        }
    }
}
