using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using InventoryQuickCRUD.Models;

namespace InventoryQuickCRUD.Data
{
    public class AplicationDbContext : IdentityDbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<UsuarioRegistrado> UsuarioRegistrado { get; set; }

    }
}
