using AdminCoreProject.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdminCoreProject.DataContext
{
    public class AdminCoreDBContext : DbContext
    {
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Customer> Customers { get; set; }

        public AdminCoreDBContext(DbContextOptions<AdminCoreDBContext> options): base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
