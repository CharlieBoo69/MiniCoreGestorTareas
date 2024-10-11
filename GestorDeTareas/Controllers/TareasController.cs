using GestorDeTareas.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace GestorDeTareas.Controllers
{
    public class TareasController : Controller
    {
        private readonly AppDbContext _context;

        public TareasController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Tareas
        public async Task<IActionResult> Index(DateTime? fechaInicio, DateTime? fechaFin)
        {
            var tareas = from t in _context.Tareas select t;

            if (fechaInicio.HasValue && fechaFin.HasValue)
            {
                tareas = tareas.Where(t => t.FechaInicio >= fechaInicio && t.FechaInicio <= fechaFin);
            }

            var tareasList = await tareas.ToListAsync();

            return View(tareasList);
        }
    }
}
