
using System.ComponentModel.DataAnnotations;

namespace SistemaVentasInventario.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombres { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string Apellidos { get; set; } = string.Empty;

        [Required]
        [StringLength(50)]
        public string NombreUsuario { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        [StringLength(150)]
        public string Correo { get; set; } = string.Empty;

        [Required]
        [StringLength(255)]
        public string PasswordHash { get; set; } = string.Empty;

        public bool Activo { get; set; } = true;

        public int RolId { get; set; }

        public Rol Rol { get; set; } = null!;

        public ICollection<Venta> Ventas { get; set; } = new List<Venta>();

        public ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();

        public ICollection<MovimientoInventario> MovimientosInventario { get; set; } = new List<MovimientoInventario>();
    }
}
