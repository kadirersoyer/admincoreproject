using AdminCoreProject.Demo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AdminCoreProject.Demo.Domains
{
    public class User: BaseEntity
    {
        public User()
        {
            UserRegistrations = new List<UserRegistration>();
        }

        public string name { get; set; }
        public string surname { get; set; }
        public string address { get; set; }
        public DateTime BirthDay { get; set; }
        public Gender? Gender { get; set; }

        [ForeignKey("UserRegistirationTypeId")]
        public int? UserRegistirationTypeId { get; set; }
        public IList<UserRegistration> UserRegistrations { get; set; }
    }
}
