using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using YAMS_Interface;
using YAMS_Repository;

namespace YAMS_Logic.API
{
    public class Auth : IJwtAuth
    {
        CoreDbContext dbContext = new CoreDbContext();
        private readonly string username1 = "ayush";
        private readonly string password1 = "ash123";
        private readonly string key;
        private readonly ILogger<Auth> _logger;
        private readonly CoreDbContext _database;

        public Auth(string key)
        {
            this.key = key;
        }

        public Auth( ILogger<Auth> logger, CoreDbContext context)
        {
            
            _logger = logger;
            _database = context;
        }

        

        public string Authentication(string username, string password)
        {

            //bool isValid = dbContext.userTables.Any(x => x.username == username && x.password == password);
            if(!(username.Equals(username1) && password.Equals(password1)))
            //if(!isValid)
            {
                return null;
            }

            var tokenHandler = new JwtSecurityTokenHandler();

            var tokenKey = Encoding.ASCII.GetBytes(key);

            var tokenDescriptor = new SecurityTokenDescriptor()
            {
                Subject = new ClaimsIdentity(
                    new Claim[]
                    {
                        new Claim(ClaimTypes.Name, username1)
                    }),
                Expires = DateTime.UtcNow.AddHours(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            
            return tokenHandler.WriteToken(token);
        }

    }
}
