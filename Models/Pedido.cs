
using System.ComponentModel.DataAnnotations;

namespace SistemaVentasInventario.Models
{
    public class Pedido
    {
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public string NumeroPedido { get; set; } = string.Empty;

        public DateTime Fecha { get; set; } = DateTime.Now;

        public DateTime? FechaEntrega { get; set; }

        public int ClienteId { get; set; }

        public Cliente Cliente { get; set; } = null!;

        public int UsuarioId { get; set; }

        public Usuario Usuario { get; set; } = null!;

        [Range(typeof(decimal), "0", "9999999999999999.99")]
        public decimal Total { get; set; }

        [Range(typeof(decimal), "0", "9999999999999999.99")]
        public decimal Adelanto { get; set; }

        [Required]
        [StringLength(30)]
        public string Estado { get; set; } = "Pendiente";

        [StringLength(500)]
        public string? Observaciones { get; set; }

        public ICollection<DetallePedido> Detalles { get; set; } = new List<DetallePedido>();

        public Venta? Venta { get; set; }
    }
}
