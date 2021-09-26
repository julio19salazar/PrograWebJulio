using ActividadDos.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ActividadDos.Controllers
{
    public class Home : Controller
    {
        public string Index()
        {
            return "hola para acceder a la vista de calcular promedio ingrese Home/PaginaPromedio";
        } public IActionResult PaginaPromedio(PaginaPromedioViewModel vm)
        {
            return View(vm);
        }
    }
}
