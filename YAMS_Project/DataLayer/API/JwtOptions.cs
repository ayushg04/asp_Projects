using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YAMS_Data.API
{
    public class JwtOptions
    {
        public string SecretKey { get; set; }
        public int ExpiryMinutes { get; set; }
        public string Issuer { get; set; }
    }
}
