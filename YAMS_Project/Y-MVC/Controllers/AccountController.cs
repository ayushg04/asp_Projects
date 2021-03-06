using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Y_API;
using Y_MVC.Models;

namespace Y_MVC.Controllers
{
    public class AccountController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly INotyfService _notyf;
        private readonly IJwtAuth jwtAuth;
        public AccountController(IJwtAuth jwtAuth, ILogger<HomeController> logger, INotyfService notyf)
        {
            this.jwtAuth = jwtAuth;
            _logger = logger;
            _notyf = notyf;
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginModel loginModel)
        {
            var token = jwtAuth.Authentication(loginModel.username, loginModel.password);
            if (token == null)
            {
                _notyf.Error("Wrong Username or Password", 3);
                //return Unauthorized();
                return View();
            }
            _notyf.Success("Successfully Logged In", 3);
            //return Ok(token);
            ViewBag.data = token;
            return RedirectToAction("Home", "Account",token);

        }
        
        public IActionResult Home()
        {
            
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
