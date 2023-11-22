using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TsmGdvPrb1.Data;
using TsmGdvPrb1.Models;
using TsmGdvPrb1.ViewModels;

namespace TsmGdvPrb1.Controllers
{
    public class EmpleadosUsuariosController : Controller
    {
        private readonly DataContext _context;

        public EmpleadosUsuariosController(DataContext context)
        {
            _context = context;
        }

        
        [HttpGet]
        public IActionResult Index()
        {
            var empleados = _context.Empleados.Include(e => e.usuario).ToList();
            return View(empleados);
        }


        // POST: Registro
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Empleado empleado, Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                usuario.fechahora_registro = DateTime.Now;

                empleado.usuario = usuario;

                _context.Empleados.Add(empleado);
                _context.Usuarios.Add(usuario);

                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }

            return View();
        }
    }
}
