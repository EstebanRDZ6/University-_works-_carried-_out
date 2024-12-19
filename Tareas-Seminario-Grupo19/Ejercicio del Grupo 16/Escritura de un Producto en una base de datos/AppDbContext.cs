using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Escritura_de_un_Producto_en_una_base_de_datos
{
    public class AppDbContext : DbContext
    {
        public DbSet<Producto> Productos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=PecuTostadora3k\\SQLEXPRESS;Database=Empresa;User Id=sa;Password=123456;TrustServerCertificate=True;"
);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Producto>()
                .Property(p => p.Precio)
                .HasColumnType("decimal(18, 2)"); // Esto asegura que el tipo sea 'decimal' en SQL Server.
        }

    }
}
