using Microsoft.IdentityModel.JsonWebTokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Y_API.Models
{
    public class IAccountService
    {
        void SignUp(string username, string password);
        JsonWebToken SignIn(string username, string password);
        JsonWebToken RefreshAccessToken(string token);
        void RevokeRefreshToken(string token);
    }
}
