using AdminCoreProject.Demo.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminCoreProject.Demo.Models
{
    public class CategoryModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public DateTime createddate { get; set; }
        public DateTime updateddate { get; set; }

        public ICollection<ProductCategoryMapping> productCategories { get; set; }
    }
}
