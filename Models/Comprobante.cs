
using System.ComponentModel.DataAnnotations;

namespace SistemaVentasInventario.Models
{
    public class Comprobante
    {
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public string Tipo { get; set; } = string.Empty;

        [Required]
        [StringLength(40)]
        public string Numero { get; set; } = string.Empty;

        public DateTime FechaEmision { get; set; } = DateTime.Now;

        public int VentaId { get; set; }

        public Venta Venta { get; set; } = null!;

        [Range(typeof(decimal), "0", "9999999999999999.99")]
        public decimal Subtotal { get; set; }

        [Range(typeof(decimal), "0", "9999999999999999.99")]
        public decimal Descuento { get; set; }

        [Range(typeof(decimal), "0", "9999999999999999.99")]
        public decimal Total { get; set; }

        [StringLength(500)]
        public string? Observaciones { get; set; }
    }
}
