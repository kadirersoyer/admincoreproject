using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdminCoreProject.Demo.Models
{
    public class UserModel
    {
        public UserModel()
        {
            UserRegistrations = new List<UserRegistration>();
        }

        public int Id { get; set; }
        [Display(Name = "Ad : ")]
        [Required(ErrorMessage = "Ad Alanı Zorunludur.")]
        public string name { get; set; }

        [Display(Name = "Soyad : ")]
        [Required(ErrorMessage = "Soyad Alanı Zorunludur.")]
        public string surname { get; set; }

        [Display(Name = "Adress : ")]
        [Required(ErrorMessage = "Adress Alanı Zorunludur.")]
        public string address { get; set; }

        [Display(Name = "Doğum Tarihi : ")]
        [Required(ErrorMessage = "Doğum Tarihi Zorunludur.")]
        [DataType(DataType.Date)]
        public DateTime BirthDay { get; set; }

        [Display(Name = "Cinsiyet : ")]
        [Required(ErrorMessage = "Cinsiyet Zorunludur.")]
        public Gender? Gender { get; set; }

        [Display(Name = "Registiration Type : ")]
        [Required(ErrorMessage = "Registiration Type Zorunludur.")]
        public int? UserRegistirationTypeId{ get; set; }

        public IList<UserRegistration> UserRegistrations { get; set; }

        public class UserRegistration
        {
            public int id { get; set; }
            public string name { get; set; }
            public string registirationtype { get; set; }
        }
    }

    public enum Gender
    {
        Male = 0,
        Female = 1
    }
}
