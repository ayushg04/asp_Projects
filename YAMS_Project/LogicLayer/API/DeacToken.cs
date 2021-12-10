using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YAMS_Interface;

namespace YAMS_Logic.API
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
