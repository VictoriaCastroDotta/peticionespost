using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PeticionesPostPerros.Models;

namespace PeticionesPostPerros.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //Metodo GET:
        public IActionResult Index()
        {
            return View();
        }

        //////Ejemplo 1 sin modelos:
        //[HttpPost]
        //public IActionResult Index(String nombre, int edad, String raza, String descripcion)
        //{
        //    ViewData["nombre"] = nombre;
        //    ViewData["edad"] = edad;
        //    ViewData["raza"] = raza;
        //    ViewData["descripcion"] = descripcion;
        //    return View();
        //}

        //Ejemplo 2:
        //[HttpPost]
        //public IActionResult Index(String nombre, int edad, String raza, String descripcion)
        //{
        //    Perro perro = new Perro();
        //    perro.Edad = edad;
        //    perro.Nombre = nombre;
        //    perro.Descripcion = descripcion;
        //    perro.Raza = raza;
        //    return View(perro);
        //}

        //Ejemplo 3 con binding model:
        [HttpPost]
        public IActionResult Index(Perro perro)
        {

            return View(perro);
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
