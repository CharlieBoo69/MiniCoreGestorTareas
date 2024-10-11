using GestorDeTareas.Models;

namespace GestorDeTareas.Data
{
    public class DataSeeder
    {
        private readonly AppDbContext _context;

        public DataSeeder(AppDbContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (!_context.Tareas.Any())
            {
                // Agregar tareas
                var tareas = new List<Tarea>
        {
            new Tarea { Nombre = "Tarea 1", FechaInicio = DateTime.Now.AddDays(-10), TiempoEstimado = 5, Estado = "En progreso", Proyecto = "Proyecto A", EmpleadoAsignado = "Juan" },
            new Tarea { Nombre = "Tarea 2", FechaInicio = DateTime.Now.AddDays(-15), TiempoEstimado = 7, Estado = "En progreso", Proyecto = "Proyecto B", EmpleadoAsignado = "Pedro" },
            new Tarea { Nombre = "Tarea 3", FechaInicio = DateTime.Now.AddDays(-20), TiempoEstimado = 10, Estado = "Completada", Proyecto = "Proyecto C", EmpleadoAsignado = "Laura" },
            new Tarea { Nombre = "Tarea 4", FechaInicio = DateTime.Now.AddDays(-30), TiempoEstimado = 20, Estado = "Completada", Proyecto = "Proyecto A", EmpleadoAsignado = "Luis" },
            new Tarea { Nombre = "Tarea 5", FechaInicio = DateTime.Now.AddDays(-5), TiempoEstimado = 4, Estado = "En progreso", Proyecto = "Proyecto D", EmpleadoAsignado = "Ana" },
            new Tarea { Nombre = "Tarea 6", FechaInicio = DateTime.Now.AddDays(-25), TiempoEstimado = 15, Estado = "Retrasada", Proyecto = "Proyecto B", EmpleadoAsignado = "Carlos" },
            new Tarea { Nombre = "Tarea 7", FechaInicio = DateTime.Now.AddDays(-18), TiempoEstimado = 12, Estado = "Completada", Proyecto = "Proyecto C", EmpleadoAsignado = "María" },
            new Tarea { Nombre = "Tarea 8", FechaInicio = DateTime.Now.AddDays(-2), TiempoEstimado = 3, Estado = "En progreso", Proyecto = "Proyecto D", EmpleadoAsignado = "Miguel" },
            new Tarea { Nombre = "Tarea 9", FechaInicio = DateTime.Now.AddDays(-12), TiempoEstimado = 10, Estado = "En progreso", Proyecto = "Proyecto A", EmpleadoAsignado = "Guillermo" },
            new Tarea { Nombre = "Tarea 10", FechaInicio = DateTime.Now.AddDays(-40), TiempoEstimado = 5, Estado = "Retrasada", Proyecto = "Proyecto B", EmpleadoAsignado = "Sandra" },
            new Tarea { Nombre = "Tarea 11", FechaInicio = DateTime.Now.AddDays(-7), TiempoEstimado = 7, Estado = "En progreso", Proyecto = "Proyecto C", EmpleadoAsignado = "Juan" },
            new Tarea { Nombre = "Tarea 12", FechaInicio = DateTime.Now.AddDays(-50), TiempoEstimado = 25, Estado = "Completada", Proyecto = "Proyecto D", EmpleadoAsignado = "Luis" },
            new Tarea { Nombre = "Tarea 13", FechaInicio = DateTime.Now.AddDays(-8), TiempoEstimado = 6, Estado = "En progreso", Proyecto = "Proyecto A", EmpleadoAsignado = "Pedro" },
            new Tarea { Nombre = "Tarea 14", FechaInicio = DateTime.Now.AddDays(-1), TiempoEstimado = 4, Estado = "En progreso", Proyecto = "Proyecto B", EmpleadoAsignado = "Ana" },
            new Tarea { Nombre = "Tarea 15", FechaInicio = DateTime.Now.AddDays(-14), TiempoEstimado = 10, Estado = "Retrasada", Proyecto = "Proyecto C", EmpleadoAsignado = "Laura" },
            new Tarea { Nombre = "Tarea 16", FechaInicio = DateTime.Now.AddDays(-22), TiempoEstimado = 8, Estado = "En progreso", Proyecto = "Proyecto D", EmpleadoAsignado = "Carlos" },
            new Tarea { Nombre = "Tarea 17", FechaInicio = DateTime.Now.AddDays(-3), TiempoEstimado = 12, Estado = "En progreso", Proyecto = "Proyecto A", EmpleadoAsignado = "Miguel" },
            new Tarea { Nombre = "Tarea 18", FechaInicio = DateTime.Now.AddDays(-28), TiempoEstimado = 9, Estado = "Completada", Proyecto = "Proyecto B", EmpleadoAsignado = "Luis" },
            new Tarea { Nombre = "Tarea 19", FechaInicio = DateTime.Now.AddDays(-35), TiempoEstimado = 7, Estado = "Retrasada", Proyecto = "Proyecto C", EmpleadoAsignado = "Sandra" },
            new Tarea { Nombre = "Tarea 20", FechaInicio = DateTime.Now.AddDays(-4), TiempoEstimado = 5, Estado = "En progreso", Proyecto = "Proyecto D", EmpleadoAsignado = "Juan" }
        };

                _context.Tareas.AddRange(tareas);
                _context.SaveChanges();
            }
            else
            {
                // Opcional: Limpiar y volver a agregar tareas
                //_context.Tareas.RemoveRange(_context.Tareas);
                //_context.SaveChanges();

                // Agregar nuevas tareas si es necesario
            }
        }

    }


}
