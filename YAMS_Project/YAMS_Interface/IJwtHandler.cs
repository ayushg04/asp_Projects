using Microsoft.IdentityModel.JsonWebTokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Y_API.Models
{
    public interface IJwtHandler
    {
        JsonWebToken Create(string username);
    }
}
