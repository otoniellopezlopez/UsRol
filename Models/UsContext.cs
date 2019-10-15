using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CRUD_MVC
{
    public partial class usContext : DbContext
    {
        public usContext()
        {
        }

        public usContext(DbContextOptions<usContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Rol> Rol { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

       /* protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql("host=127.0.0.1;Database=us;Uid=postgres;Password=Elite0416");
            }
        }*/ 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Rol>(entity =>
            {
                entity.HasKey(e => e.IdRol)
                    .HasName("rol_pkey");

                entity.ToTable("rol");

                entity.HasIndex(e => e.FkRol)
                    .HasName("fki_Fk_rolus");

                entity.Property(e => e.IdRol)
                    .HasColumnName("id_rol")
                    .HasColumnType("numeric");

                entity.Property(e => e.FkRol)
                    .HasColumnName("FK_rol")
                    .HasColumnType("numeric");

                entity.Property(e => e.NombreRol)
                    .IsRequired()
                    .HasColumnName("nombre_rol");

                entity.HasOne(d => d.FkRolNavigation)
                    .WithMany(p => p.Rol)
                    .HasForeignKey(d => d.FkRol)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_rolus");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("usuario_pkey");

                entity.ToTable("usuario");

                entity.Property(e => e.IdUsuario)
                    .HasColumnName("id_usuario")
                    .HasColumnType("numeric");

                entity.Property(e => e.ClaveUsuario)
                    .IsRequired()
                    .HasColumnName("clave_usuario");

                entity.Property(e => e.NombreUsuario)
                    .IsRequired()
                    .HasColumnName("nombre_usuario");

                entity.Property(e => e.PasUsuario)
                    .IsRequired()
                    .HasColumnName("Pas_usuario");
            });
        }
    }
}
