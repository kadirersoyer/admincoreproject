using AdminCoreProject.Demo.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminCoreProject.Demo.Domains
{
    public class Product: BaseEntity
    {
        public string name { get; set; }
        public string description { get; set; }
        public decimal price { get; set; }
        public int maxcount { get; set; }

        public ICollection<ProductCategoryMapping> productCategories { get; set; }
    }
}
