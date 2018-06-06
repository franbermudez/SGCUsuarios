using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SGCUsuarios.Migrations
{
    public partial class SGC : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Niveles",
                columns: table => new
                {
                    IdNivel = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nivel = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Niveles", x => x.IdNivel);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    CodigoUsuario = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ApellidosUsuario = table.Column<string>(nullable: true),
                    ClaveUsuario = table.Column<string>(nullable: true),
                    CuentaUsuario = table.Column<string>(nullable: true),
                    EstadoUsuario = table.Column<bool>(nullable: false),
                    IdNivel = table.Column<int>(nullable: false),
                    NombreUsuario = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.CodigoUsuario);
                    table.ForeignKey(
                        name: "FK_Usuarios_Niveles_IdNivel",
                        column: x => x.IdNivel,
                        principalTable: "Niveles",
                        principalColumn: "IdNivel",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_IdNivel",
                table: "Usuarios",
                column: "IdNivel");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Niveles");
        }
    }
}
