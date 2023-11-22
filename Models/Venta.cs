using System.ComponentModel.DataAnnotations;

namespace TsmGdvPrb1.Models
{
    public class Venta
    {
        [Key]
        public int id_venta { get; set; }
        // aqui va un fk_producto
        public int cantidad { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime fechahora_venta { get; set; }
        [DataType(DataType.Date)]
        public DateTime fechahora_entrega { get; set; }
        public string estado_seguimiento { get; set; }
        //aqui va fk_empleado
        public List<Empleado> Empleados { get; set; }

        public Producto producto { get; set; }
    }
}
