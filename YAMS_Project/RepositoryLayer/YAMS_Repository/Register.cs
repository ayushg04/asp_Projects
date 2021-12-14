using System;
using System.Collections.Generic;

#nullable disable

namespace YAMS_Repository.YAMS_Repository
{
    public partial class Register
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Email { get; set; }
    }
}
