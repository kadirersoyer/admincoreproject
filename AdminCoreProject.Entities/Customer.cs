using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AdminCoreProject.Entities
{
    public class Customer : BaseEntity.BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string guid { get; set; }
        public string password { get; set; }

        [NotMapped]
        public string Token { get; set; }
    }
}
