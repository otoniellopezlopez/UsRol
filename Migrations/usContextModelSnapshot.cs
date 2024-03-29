﻿// <auto-generated />
using CRUD_MVC;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace CRUD_MVC.Migrations
{
    [DbContext(typeof(usContext))]
    partial class usContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("CRUD_MVC.Rol", b =>
                {
                    b.Property<decimal>("IdRol")
                        .HasColumnName("id_rol")
                        .HasColumnType("numeric");

                    b.Property<decimal>("FkRol")
                        .HasColumnName("FK_rol")
                        .HasColumnType("numeric");

                    b.Property<string>("NombreRol")
                        .IsRequired()
                        .HasColumnName("nombre_rol");

                    b.HasKey("IdRol")
                        .HasName("rol_pkey");

                    b.HasIndex("FkRol")
                        .HasName("fki_Fk_rolus");

                    b.ToTable("rol");
                });

            modelBuilder.Entity("CRUD_MVC.Usuario", b =>
                {
                    b.Property<decimal>("IdUsuario")
                        .HasColumnName("id_usuario")
                        .HasColumnType("numeric");

                    b.Property<string>("ClaveUsuario")
                        .IsRequired()
                        .HasColumnName("clave_usuario");

                    b.Property<string>("NombreUsuario")
                        .IsRequired()
                        .HasColumnName("nombre_usuario");

                    b.Property<string>("PasUsuario")
                        .IsRequired()
                        .HasColumnName("Pas_usuario");

                    b.HasKey("IdUsuario")
                        .HasName("usuario_pkey");

                    b.ToTable("usuario");
                });

            modelBuilder.Entity("CRUD_MVC.Rol", b =>
                {
                    b.HasOne("CRUD_MVC.Usuario", "FkRolNavigation")
                        .WithMany("Rol")
                        .HasForeignKey("FkRol")
                        .HasConstraintName("Fk_rolus");
                });
#pragma warning restore 612, 618
        }
    }
}
