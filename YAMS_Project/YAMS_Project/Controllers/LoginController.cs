﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YAMS_Project.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult login()
        {
            return View();
        }
    }
}
