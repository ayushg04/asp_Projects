using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Y_MVC.Controllers
{
    public class DashboardController : Controller
    {

        private readonly INotyfService _notyf;
        public DashboardController(INotyfService notyfService)
        {
            _notyf = notyfService;
        }
        public IActionResult Index()
        {
            _notyf.Success("Successfully Logged In", 3);
            return View();
        }
    }
}
