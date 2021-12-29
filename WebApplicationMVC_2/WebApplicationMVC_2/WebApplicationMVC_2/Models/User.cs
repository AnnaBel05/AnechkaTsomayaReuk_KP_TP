using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationMVC_2.Models
{
    public class User
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Не указан Email")] 
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Не указан пароль")]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }
        [Display(Name = "Роль")]
        public int? RoleId { get; set; }
        [Display(Name = "Роль")] 
        public Role Role { get; set; }
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Пароль введен неверно")]
        [NotMapped]
        public string ConfirmPassword { get; set; }
    }
}
