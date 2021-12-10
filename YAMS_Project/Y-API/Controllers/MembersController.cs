using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YAMS_Data.API;
using YAMS_Interface;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Y_API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class MembersController : ControllerBase
    {
        private readonly IJwtAuth jwtAuth;
        private readonly List<Member> lstMember = new List<Member>()
        {
            new Member{Id=1, Name="ayush" },
            new Member {Id=2, Name="gaur" },
            new Member{Id=3, Name="pankaj"}
        };
        public MembersController(IJwtAuth jwtAuth)
        {
            this.jwtAuth = jwtAuth;
        }
        // GET: api/<MembersController>
        [HttpGet]
        public IEnumerable<Member> AllMembers()
        {
            return lstMember;
        }

        // GET api/<MembersController>/5
        [HttpGet("{id}")]
        public Member MemberById(int id)
        {
            return lstMember.Find(x => x.Id == id);
        }

        [AllowAnonymous]
        [HttpPost("authentication")]
        public IActionResult Authentication(UserCredential usercredential)
        {
            var token = jwtAuth.Authentication(usercredential.username, usercredential.password);
            if (token == null)
            {
                return Unauthorized();
            }
            return Ok(token);
        }
    }
}
