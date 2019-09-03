using AdminCoreProject.ApiClient;
using AdminCoreProject.Cookie;
using AdminCoreProject.Data;
using AdminCoreProject.Services;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdminCoreProject.IoC
{
    public class RegisterIoC
    {
        public static IContainer ApplicationContainer { get; private set; }

        public static IServiceProvider Register(IServiceCollection services )
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<MenuRepository>().As<IMenuRepository>().InstancePerLifetimeScope();
            builder.RegisterType<MenuService>().As<IMenuService>().InstancePerLifetimeScope();

            builder.RegisterType<CustomerRepository>().As<ICustomerRepository>().InstancePerLifetimeScope();
            builder.RegisterType<CustomerService>().As<ICustomerService>().InstancePerLifetimeScope();

            builder.RegisterType<ApiHelper>().As<IApiHelper>().InstancePerLifetimeScope();
            builder.RegisterType<ApiRepo>().As<IApiRepo>().InstancePerLifetimeScope();
            builder.RegisterType<CookieManager>().As<ICookieManager>().InstancePerLifetimeScope();

            builder.Populate(services);
            ApplicationContainer = builder.Build();

            return new AutofacServiceProvider(ApplicationContainer);
        }
    }
}
