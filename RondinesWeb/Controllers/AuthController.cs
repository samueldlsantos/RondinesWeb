﻿using Microsoft.AspNetCore.Mvc;

namespace RondinesWeb.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
