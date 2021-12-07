using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Authentication
{
    public class RegisterModel
    {
        [Required(ErrorMessage ="UserName Required")]
        public string username { get; set; }
        [Required(ErrorMessage = "Password Required")]
        public string password { get; set; }
        [Required(ErrorMessage = "Password Required")]
        public string confirm_password { get; set; }
        [Required(ErrorMessage = "MailId Required")]
        public string email { get; set; }
    }
}
