using AdminCoreProject.Demo.Domains;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminCoreProject.Demo.Context
{
    public class CilCommerceDbContext: DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategoryMapping> ProductCategoryMappings { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRegistration> UserRegistrations { get; set; }

        public CilCommerceDbContext(DbContextOptions<CilCommerceDbContext> context): base(context)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
