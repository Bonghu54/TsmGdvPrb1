using System.ComponentModel.DataAnnotations;

namespace TsmGdvPrb1.ViewModels
{
    public class RegistroEmpleadosUsuariosViewModel
    {
        // Propiedades para el empleado
        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Apellido { get; set; }

        [Required]
        public string CI { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime FechaNacimiento { get; set; }

        [Required]
        public string Departamento { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime FechaContratacion { get; set; }

        // Propiedades para el usuario
        [Required]
        public string NombreUsuario { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Contrasena { get; set; }

        [Required]
        [Compare("Contrasena", ErrorMessage = "Las contraseñas no coinciden.")]
        [DataType(DataType.Password)]
        public string ConfirmarContrasena { get; set; }
    }
}
