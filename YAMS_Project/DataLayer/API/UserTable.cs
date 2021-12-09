using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Y_API.DBlayer;

namespace Y_API.Models
{
    public class UserTable
    {
        private DatabaseConnection dbconn;
        public int id { get; set; }
        [Required(ErrorMessage ="Name Required")]
        public string username { get; set; }
        [Required(ErrorMessage ="Password Required")]
        public string password { get; set; }
    }
}
