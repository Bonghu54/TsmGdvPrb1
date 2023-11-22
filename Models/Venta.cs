namespace TsmGdvPrb1.Models
{
    public class Venta
    {
        public int id_venta { get; set; }
        // aqui va un fk_producto
        public int cantidad { get; set; }
        public DateTime fechahora_venta { get; set; }
        public DateTime fechahora_entrega { get; set; }
        public string estado_seguimiento { get; set; }
        //aui va fk_empleado

    }
}
