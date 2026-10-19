
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SistemaVentasInventario.Models;

namespace SistemaVentasInventario.Data
{
    public static class InicializadorDatos
    {
        public static async Task InicializarAsync(
            AppDbContext context,
            IPasswordHasher<Usuario> passwordHasher)
        {
            // Crear los roles si todavía no existen.
            if (!await context.Roles.AnyAsync())
            {
                context.Roles.AddRange(
                    new Rol
                    {
                        Nombre = "Administrador",
                        Descripcion = "Control total del sistema"
                    },
                    new Rol
                    {
                        Nombre = "Vendedor",
                        Descripcion = "Gestión de ventas y pedidos"
                    });

                await context.SaveChangesAsync();
            }

            // Crear el administrador solo si no existe.
            bool existeAdministrador = await context.Usuarios
                .AnyAsync(u => u.NombreUsuario == "admin");

            if (!existeAdministrador)
            {
                var rolAdministrador = await context.Roles
                    .FirstAsync(r => r.Nombre == "Administrador");

                var usuario = new Usuario
                {
                    Nombres = "Administrador",
                    Apellidos = "Sistema",
                    NombreUsuario = "admin",
                    Correo = "admin@jlrevestimientos.com",
                    RolId = rolAdministrador.Id,
                    Activo = true
                };

                // La contraseña se configurará de forma segura
                // antes de guardar el usuario.
                usuario.PasswordHash = passwordHasher.HashPassword(
                    usuario,
                    Environment.GetEnvironmentVariable(
                        "JL_ADMIN_PASSWORD")
                    ?? throw new InvalidOperationException(
                        "Configura la variable JL_ADMIN_PASSWORD antes de inicializar."));

                context.Usuarios.Add(usuario);
                await context.SaveChangesAsync();
            }
        }
    }
}
