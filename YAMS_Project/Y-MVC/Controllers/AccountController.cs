using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using YAMS_Data.MVC;
using YAMS_Interface;
using YAMS_Repository;
using YAMS_Data.API;
using YAMS_Repository.YAMS_Repository;

namespace Y_MVC.Controllers
{
    public class AccountController : Controller
    {
        private readonly ILogger<AccountController> _logger;
        private readonly INotyfService _notyf;
        private readonly IJwtAuth jwtAuth;
        public AccountController(IJwtAuth jwtAuth, ILogger<AccountController> logger, INotyfService notyf)
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
        public IActionResult Login(string username,string password)
        {
            var token = jwtAuth.Authentication(username, password);
            if (token == null)
            {
                _notyf.Error("Wrong Username or Password", 3);
                return View();
            }
            
            return RedirectToAction("Index", "Dashboard");
        }
        [HttpGet]
        public IActionResult Create()
        {
            _notyf.Information("Fill All the Details Correctly.", 3);
            return View();
        }
        [HttpPost]
        public IActionResult Create(YAMS_Repository.YAMS_Repository.Register register)
        {
            using(var context = new YAMSContext())
            {
                if(register.Password != register.ConfirmPassword)
                {
                    _notyf.Error("Different Password Given, Please make the password same", 3);
                    return View();
                }
                context.Registers.Add(register);
                context.SaveChanges();
                return RedirectToAction("Login");
            }
        }
        public IActionResult Logout()
        {
            
            //dt.CancelAccessToken();
            return RedirectToAction("Login", "Account");
        }
        
    }
}
