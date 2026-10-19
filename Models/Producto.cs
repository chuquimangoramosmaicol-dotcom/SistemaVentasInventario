
using System.ComponentModel.DataAnnotations;

namespace SistemaVentasInventario.Models
{
    public class Producto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Codigo { get; set; } = string.Empty;

        [Required]
        [StringLength(150)]
        public string Nombre { get; set; } = string.Empty;

        [StringLength(500)]
        public string? Descripcion { get; set; }

        [StringLength(100)]
        public string? Categoria { get; set; }

        [StringLength(50)]
        public string? UnidadMedida { get; set; }

        [Range(typeof(decimal), "0", "9999999999999999.99")]
        public decimal PrecioCompra { get; set; }

        [Range(typeof(decimal), "0", "9999999999999999.99")]
        public decimal PrecioVenta { get; set; }

        [Range(0, int.MaxValue)]
        public int StockActual { get; set; }

        [Range(0, int.MaxValue)]
        public int StockMinimo { get; set; }

        public bool Activo { get; set; } = true;

        public ICollection<DetalleVenta> DetallesVenta { get; set; } = new List<DetalleVenta>();

        public ICollection<DetallePedido> DetallesPedido { get; set; } = new List<DetallePedido>();

        public ICollection<MovimientoInventario> MovimientosInventario { get; set; } = new List<MovimientoInventario>();
    }
}
