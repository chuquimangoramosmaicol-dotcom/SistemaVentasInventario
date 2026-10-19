
using System.ComponentModel.DataAnnotations;

namespace SistemaVentasInventario.Models
{
    public class Venta
    {
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public string NumeroVenta { get; set; } = string.Empty;

        public DateTime Fecha { get; set; } = DateTime.Now;

        public int ClienteId { get; set; }

        public Cliente Cliente { get; set; } = null!;

        public int UsuarioId { get; set; }

        public Usuario Usuario { get; set; } = null!;

        public int? PedidoId { get; set; }

        public Pedido? Pedido { get; set; }

        [Range(typeof(decimal), "0", "9999999999999999.99")]
        public decimal Subtotal { get; set; }

        [Range(typeof(decimal), "0", "9999999999999999.99")]
        public decimal Descuento { get; set; }

        [Range(typeof(decimal), "0", "9999999999999999.99")]
        public decimal Total { get; set; }

        [StringLength(500)]
        public string? Observaciones { get; set; }

        public ICollection<DetalleVenta> Detalles { get; set; } = new List<DetalleVenta>();

        public Comprobante? Comprobante { get; set; }
    }
}
