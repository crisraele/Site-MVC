using AgenciadeViagens.Models;
using Microsoft.EntityFrameworkCore;

namespace AgenciadeViagens.Data
{
    public class Contexto : DbContext
       
    {
        public DbSet<Cliente>? Cliente { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder  optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-C37G4TA;Initial Catalog=AgenciadeViagens; Integrated Security=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>(table =>
            {
                table.ToTable("Clientes");
                table.HasKey(prop => prop.Id);
                table.Property(prop => prop.Nome).HasMaxLength(40).IsRequired();
                table.Property(prop => prop.CPF).HasColumnType("char(11)").IsRequired();
                table.Property(prop => prop.Nascimento).HasColumnType("date");
                table.Property(prop => prop.Destino).HasMaxLength(40).IsRequired();
            });
        }

    }
}
