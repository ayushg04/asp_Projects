using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Y_API.Models;

namespace Y_API
{
    public class deacToken
    {
        private readonly ITokenManager _tokenManager;
        public deacToken(ITokenManager tokenManager)
        {
            _tokenManager = tokenManager;
        }
        public async void CancelAccessToken()
        {
            await _tokenManager.DeactivateCurrentAsync();
        }
    }
}
