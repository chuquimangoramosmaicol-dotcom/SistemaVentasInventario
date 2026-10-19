
using System.ComponentModel.DataAnnotations;

namespace SistemaVentasInventario.Models
{
    public class DetalleVenta
    {
        public int Id { get; set; }

        public int VentaId { get; set; }

        public Venta Venta { get; set; } = null!;

        public int ProductoId { get; set; }

        public Producto Producto { get; set; } = null!;

        [Range(1, int.MaxValue)]
        public int Cantidad { get; set; }

        [Range(typeof(decimal), "0", "9999999999999999.99")]
        public decimal PrecioUnitario { get; set; }

        [Range(typeof(decimal), "0", "9999999999999999.99")]
        public decimal Descuento { get; set; }

        [Range(typeof(decimal), "0", "9999999999999999.99")]
        public decimal Subtotal { get; set; }
    }
}
