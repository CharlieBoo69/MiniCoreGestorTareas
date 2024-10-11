namespace GestorDeTareas.Models
{
    public class Tarea
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty; // Evitar valores nulos
        public DateTime FechaInicio { get; set; }
        public double TiempoEstimado { get; set; }
        public string Estado { get; set; } = string.Empty; // Evitar valores nulos
        public string Proyecto { get; set; } = string.Empty; // Evitar valores nulos
        public string EmpleadoAsignado { get; set; } = string.Empty; // Evitar valores nulos

        // Propiedad calculada para determinar si la tarea está retrasada
        public bool EstaRetrasada
        {
            get
            {
                var fechaFinEstimado = FechaInicio.AddDays(TiempoEstimado);
                return DateTime.Now > fechaFinEstimado && Estado != "Completada";
            }
        }

        // Propiedad calculada para los días de retraso
        public int DiasRetraso
        {
            get
            {
                var fechaFinEstimado = FechaInicio.AddDays(TiempoEstimado);
                if (DateTime.Now > fechaFinEstimado && Estado != "Completada")
                {
                    return (DateTime.Now - fechaFinEstimado).Days;
                }
                return 0;
            }
        }

        // Propiedad para obtener el estado dinámico
        public string EstadoActual
        {
            get
            {
                if (EstaRetrasada)
                {
                    return $"Retrasado por {DiasRetraso} días";
                }
                return Estado;
            }
        }
    }

}
