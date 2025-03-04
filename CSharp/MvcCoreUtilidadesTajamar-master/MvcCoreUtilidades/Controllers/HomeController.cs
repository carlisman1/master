﻿using Microsoft.AspNetCore.Mvc;
using MvcCoreUtilidades.Models;
using System.Diagnostics;

namespace MvcCoreUtilidades.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string usuario)
        {
            HttpContext.Session.SetString("USUARIO", usuario);
            return RedirectToAction("Index");
        }

        public IActionResult CerrarSesion()
        {
            HttpContext.Session.Remove("USUARIO");
            return RedirectToAction("Index");
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
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