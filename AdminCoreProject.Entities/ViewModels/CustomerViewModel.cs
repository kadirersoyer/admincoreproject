using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AdminCoreProject.Entities.ViewModels
{
    public class CustomerViewModel
    {
        [Display(Name = "Kullanıcı Adı : ")]
        [Required(ErrorMessage = "Kullanıcı Adı Girmediniz.")]
        [MaxLength(20,ErrorMessage = "Max 20 Karakter Olabilir")]
        [MinLength(3, ErrorMessage = "Min 6 Karakter Olabilir")]
        public string Name { get; set; }

        public string Surname { get; set; }
        public string guid { get; set; }

        [Display(Name = "Kullanıcı Şifre : ")]
        [Required(ErrorMessage = "Kullanıcı Adı Girmediniz.")]
        [MaxLength(20, ErrorMessage = "Max 10 Karakter Olabilir")]
        [MinLength(3, ErrorMessage = "Min 6 Karakter Olabilir")]
        public string password { get; set; }

        public string Token { get; set; }
    }
}
