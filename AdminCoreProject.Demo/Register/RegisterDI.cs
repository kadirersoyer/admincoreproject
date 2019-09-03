
using AdminCoreProject.Demo.Context;
using AdminCoreProject.Demo.Service;
using AdminCoreProject.Demo.Unit;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace AdminCoreProject.Demo.Register
{
    public class RegisterDI
    {
        public static IContainer ApplicationContainer { get; private set; }

        public static IServiceProvider Register(IServiceCollection services)
        {
            var builder = new ContainerBuilder();

            //builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly()).Where(a => a.Name.EndsWith("Repository"))
            //                            .Where(a=>a.Name.EndsWith("Service")).AsImplementedInterfaces();
            //builder.RegisterType<CilCommerceDbContext>().As<DbContext>().InstancePerLifetimeScope();
            //builder.RegisterType<CilCommerceDbContext2>().As<DbContext>().InstancePerLifetimeScope();

            builder.RegisterType<CategoryService>().As<ICategoryService>().InstancePerLifetimeScope();
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerLifetimeScope();
          
            builder.Populate(services);

            ApplicationContainer = builder.Build();

            return new AutofacServiceProvider(ApplicationContainer);
        }
    }
}
