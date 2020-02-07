using System;
using System.Collections.Generic;
using System.Diagnostics;
//using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RelatoriosJorge.Models;
using RelatoriosJorge.Models.Cliente;
using RelatoriosJorge.Models.ContaPagar;

namespace RelatoriosJorge.Controllers
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult Buscar(string filtro, string ordem)
        {
            return Ok(ContaPagar.Exemplos().Where(filtro).OrderBy(ordem));
        }
        // !!!
        public IActionResult ClienteJspdf()
        {
            return View("ClienteJSPDF");
        }

        // !!!
        public IActionResult ClientePDFmake()
        {
            return View("ClientePDFmake");
        }


        [HttpPost]
        public IActionResult BuscarConta()
        {
            return Json(ContaPagar.Exemplos());
        }

        public IActionResult Relatorio()
        {
            return View("Relatorio");
        }
    }
}
