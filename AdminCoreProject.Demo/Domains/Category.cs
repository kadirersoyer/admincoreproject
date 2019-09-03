using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AdminCoreProject.Demo.Domains
{
    [Table("Category")]
    public class Category: BaseEntity
    {
        public string name { get; set; }
        public string description { get; set; }
        public DateTime createddate { get; set; }
        public DateTime updateddate { get; set; }

        public ICollection<ProductCategoryMapping> productCategories { get; set; }
    } 
}
