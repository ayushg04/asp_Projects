using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Y_API.Models
{
    public class Register
    {
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string confirm_password { get; set; }
        public string email { get; set; }
    }
}
