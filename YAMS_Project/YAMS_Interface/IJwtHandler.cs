using Microsoft.IdentityModel.JsonWebTokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YAMS_Interface
{
    public interface IJwtHandler
    {
        JsonWebToken Create(string username);
    }
}
