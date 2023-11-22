using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TsmGdvPrb1.Models
{
    public class Empleado
    {
        [Key]
        public int id_empleado { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string ci { get; set; }
        [DataType(DataType.Date)]
        public DateTime fecha_nacimiento { get; set; }
        public string departamento { get; set; }
        [DataType(DataType.Date)]
        public DateTime fech_contratacion { get; set; }
        [ForeignKey("usuario")]
        public int id_usuario { get; set; }
        public Usuario usuario { get; set;}

        public Venta Venta { get; set; }
    }
}
