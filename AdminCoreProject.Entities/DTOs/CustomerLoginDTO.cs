using System;
using System.Collections.Generic;
using System.Text;

namespace AdminCoreProject.Entities.DTOs
{
    public class CustomerLoginDTO
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string guid { get; set; }
        public string password { get; set; }
        public string Token { get; set; }
    }
}
