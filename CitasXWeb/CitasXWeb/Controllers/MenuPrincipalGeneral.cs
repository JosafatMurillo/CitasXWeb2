using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CitasXWeb.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CitasXWeb.Controllers
{
    public class MenuPrincipalGeneral : Controller
    {

        CitasXContext _context = new CitasXContext();

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Inicio()
        {
            return View(/*MenuPrincipalGeneralView*/);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AgendarCita()
        {



            return View(/*AgendarCita*/);
        }

    }
}
