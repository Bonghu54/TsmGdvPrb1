using System.ComponentModel.DataAnnotations;

namespace TsmGdvPrb1.Models
{
    public class Usuario
    {
        [Key]
        public int id_usuario { get; set; }
        public string nombre_usuario { get; set;}
        public string contrasena { get; set; }
        [DataType(DataType.Date)]
        public DateTime fechahora_registro { get; set; }

        public Empleado Empleado { get; set; }
        public Rol Rol { get; set; }

    }
}
