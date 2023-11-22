namespace TsmGdvPrb1.Models
{
    public class Empleado
    {
        public int id_empleado { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string ci { get; set; }
        public DateTime fecha_nacimiento { get; set; }
        public string departamento { get; set; }
        public DateTime fech_contratacion { get; set; }

    }
}
