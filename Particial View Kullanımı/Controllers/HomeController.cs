using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Particial_View_Kullanımı.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Particial_View_Kullanımı.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
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
        public ActionResult Login(Models.User veri)
        {
            var data = new Models.User();
            data.Ad = "Habibe";
            data.Soyad = "Beggi";
            data.Yas = 19;
            data.Meslek = "Ogrenci";
            return View(data);
        }
        
    }
}
