using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CitasXWeb.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CitasXWeb.Controllers
{
    public class InicioSesionController : Controller
    {

        CitasXContext _context = new CitasXContext();

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult IniciarSesion(string identificador, string contrasenia)
        {

            var usuario = _context.TbUsuario.FirstOrDefault(u => u.UsuIdentificador.Equals(identificador) && u.UsuContrasenia.Equals(contrasenia));

            return View(usuario);
        }
    }
}
