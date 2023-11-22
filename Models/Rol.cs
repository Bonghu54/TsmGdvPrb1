using System.ComponentModel.DataAnnotations;

namespace TsmGdvPrb1.Models
{
    public class Rol
    {
        [Key]
        public int id_rol { get; set; }
        public string nombre_rol { get; set; }
        public string descripcion { get; set; }
        public List<Usuario> Usuarios { get; set; }
    }
}
