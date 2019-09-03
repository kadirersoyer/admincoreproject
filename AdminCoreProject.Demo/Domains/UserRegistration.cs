using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminCoreProject.Demo.Domains
{
    public class UserRegistration : BaseEntity
    {
        public string name { get; set; }
        public string registirationtype { get; set; }
    }
}
