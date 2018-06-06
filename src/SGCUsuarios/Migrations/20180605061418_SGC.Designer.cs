using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using SGC.Models;

namespace SGCUsuarios.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20180605061418_SGC")]
    partial class SGC
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SGC.Models.Niveles", b =>
                {
                    b.Property<int>("IdNivel")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nivel");

                    b.HasKey("IdNivel");

                    b.ToTable("Niveles");
                });

            modelBuilder.Entity("SGC.Models.Usuarios", b =>
                {
                    b.Property<int>("CodigoUsuario")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ApellidosUsuario");

                    b.Property<string>("ClaveUsuario");

                    b.Property<string>("CuentaUsuario");

                    b.Property<bool>("EstadoUsuario");

                    b.Property<int>("IdNivel");

                    b.Property<string>("NombreUsuario");

                    b.HasKey("CodigoUsuario");

                    b.HasIndex("IdNivel");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("SGC.Models.Usuarios", b =>
                {
                    b.HasOne("SGC.Models.Niveles", "NivelUsuario")
                        .WithMany("Usuarios")
                        .HasForeignKey("IdNivel")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
