using Microsoft.AspNetCore.Mvc;
using TuApp.Models;

namespace TuApp.Controllers
{
    public class MascotasController : Controller
    {
        // Muestra el formulario
        [HttpGet]
        public IActionResult Crear()
        {
            return View("Formulario");
        }
        [HttpGet]
        public IActionResult VistaTabla()
        {
            return View("Tablas");
        }

        // Procesa el formulario
        [HttpPost]
        public IActionResult Crear(Mascota mascota)
        {
            if (!ModelState.IsValid)
            {
                return View(mascota);
            }

            // Aquí puedes guardar en base de datos
            // Por ahora, solo mostramos los datos o redirigimos

            return RedirectToAction("Crear");
        }

        public IActionResult Gracias()
        {
            return View();
        }
    }
}
