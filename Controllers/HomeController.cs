using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using prac2.Models;

namespace prac2.Controllers
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
        

        public IActionResult registro()
        {
            return View();
        }


[HttpPost]
        public IActionResult registro(string nombres, string apellido_paterno, string apellido_materno, string mascota, string descripcion, string telefono,string distrito, string direccion)
        {
            Console.WriteLine(nombres, apellido_paterno, apellido_materno, mascota,descripcion,telefono, distrito, direccion);
            return RedirectToAction("confirmacion");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
