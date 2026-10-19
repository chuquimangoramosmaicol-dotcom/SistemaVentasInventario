
using System.ComponentModel.DataAnnotations;

namespace SistemaVentasInventario.Models
{
    public class MovimientoInventario
    {
        public int Id { get; set; }

        public int ProductoId { get; set; }

        public Producto Producto { get; set; } = null!;

        public int UsuarioId { get; set; }

        public Usuario Usuario { get; set; } = null!;

        [Required]
        [StringLength(20)]
        public string TipoMovimiento { get; set; } = string.Empty;

        [Range(1, int.MaxValue)]
        public int Cantidad { get; set; }

        [Range(0, int.MaxValue)]
        public int StockAnterior { get; set; }

        [Range(0, int.MaxValue)]
        public int StockNuevo { get; set; }

        public DateTime Fecha { get; set; } = DateTime.Now;

        [StringLength(250)]
        public string? Motivo { get; set; }

        [StringLength(100)]
        public string? Referencia { get; set; }
    }
}
