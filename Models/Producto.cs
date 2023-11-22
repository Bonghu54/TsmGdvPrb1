namespace TsmGdvPrb1.Models
{
    public class Producto
    {
        public int id_producto { get; set; }
        public string nombre_producto { get; set; }
        public string unidad_de_venta { get; set; }
        public string tipo_producto { get; set; }
        public decimal precio_unitario { get; set; }
        public int cantidad_en_almacen { get; set; }
        public string descripcion_adicional { get; set; }
    }
}
