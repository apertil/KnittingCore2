using System;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace KnittingCore2.Models
{
    public partial class ModelosPuntoContext : DbContext
    {
        public ModelosPuntoContext()
        {
        }

        public ModelosPuntoContext(DbContextOptions<ModelosPuntoContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Patrones> NombrePatron { get; set; }
        public virtual DbSet<AutorPatron> AutorPatron { get; set; }
        public virtual DbSet<GeneroEdad> GeneroEdad { get; set; }
        public virtual DbSet<Lanas> Lanas { get; set; }
        public virtual DbSet<Patrones> Patrones { get; set; }
        public virtual DbSet<Prendas> Prendas { get; set; }
        public virtual DbSet<Revistas> Revistas { get; set; }
        public virtual DbSet<TiposCaracteristicas> TiposCaracteristicas { get; set; }
        public virtual DbSet<TiposDeTejer> TiposDeTejer { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=ES-L000290\\SQLEXPRESS;Database=ModelosPunto;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.1-servicing-10028");

            modelBuilder.Entity<AutorPatron>(entity =>
            {
                entity.HasKey(e => e.IdAutorPatron);

                entity.Property(e => e.NombreAutor).HasMaxLength(50);
            });

            modelBuilder.Entity<GeneroEdad>(entity =>
            {
                entity.HasKey(e => e.IdGenEd);

                entity.Property(e => e.GenEdad).HasMaxLength(50);
            });

            modelBuilder.Entity<Lanas>(entity =>
            {
                entity.HasKey(e => e.IdLana);

                entity.Property(e => e.NombreLana).HasMaxLength(50);
            });

            modelBuilder.Entity<Patrones>(entity =>
            {
                entity.HasKey(e => e.IdNombrePatron);

                entity.Property(e => e.NombrePatron)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Patron).IsRequired();

                entity.HasOne(d => d.AutorPatron)
                    .WithMany(p => p.Patrones)
                    .HasForeignKey(d => d.IdAutorPatron)
                    .HasConstraintName("FK_Patrones_AutorPatron");

                entity.HasOne(d => d.GeneroEdad)
                    .WithMany(p => p.Patrones)
                    .HasForeignKey(d => d.IdGenEdad)
                    .HasConstraintName("FK_Patrones_GeneroEdad");

                entity.HasOne(d => d.Lanas)
                    .WithMany(p => p.Patrones)
                    .HasForeignKey(d => d.IdLana)
                    .HasConstraintName("FK_Patrones_Lanas");

                entity.HasOne(d => d.Prendas)
                    .WithMany(p => p.Patrones)
                    .HasForeignKey(d => d.IdPrendas)
                    .HasConstraintName("FK_Patrones_Prendas");

                entity.HasOne(d => d.Revistas)
                    .WithMany(p => p.Patrones)
                    .HasForeignKey(d => d.IdRevistas)
                    .HasConstraintName("FK_Patrones_Revistas");

                entity.HasOne(d => d.TiposCaracteristicas)
                    .WithMany(p => p.Patrones)
                    .HasForeignKey(d => d.IdTiposCaract)
                    .HasConstraintName("FK_Patrones_TiposCaracteristicas");

                entity.HasOne(d => d.TiposDeTejer)
                    .WithMany(p => p.Patrones)
                    .HasForeignKey(d => d.IdTiposdeTejer)
                    .HasConstraintName("FK_Patrones_TiposDeTejer");
            });

            modelBuilder.Entity<Prendas>(entity =>
            {
                entity.HasKey(e => e.IdPrendas);

                entity.Property(e => e.NombrePrendas).HasMaxLength(50);
            });

            modelBuilder.Entity<Revistas>(entity =>
            {
                entity.HasKey(e => e.IdRevistas);

                entity.Property(e => e.Autor).HasMaxLength(50);

                entity.Property(e => e.NombreRevista).HasMaxLength(50);
            });

            modelBuilder.Entity<TiposCaracteristicas>(entity =>
            {
                entity.HasKey(e => e.IdTiposCaract);

                entity.Property(e => e.NombreCaracteristicas).HasMaxLength(50);
            });

            modelBuilder.Entity<TiposDeTejer>(entity =>
            {
                entity.HasKey(e => e.IdTiposTejer);

                entity.Property(e => e.NombreDeTejer)
                    .IsRequired()
                    .HasMaxLength(50);
            });
        }

        public virtual ObjectResult<Prueba_tablas_Result> Prueba_tablas()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Prueba_tablas_Result>("Prueba_tablas");
        }
    }
}
