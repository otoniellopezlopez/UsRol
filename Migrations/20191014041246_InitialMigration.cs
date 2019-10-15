using Microsoft.EntityFrameworkCore.Migrations;

namespace CRUD_MVC.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "usuario",
                columns: table => new
                {
                    id_usuario = table.Column<decimal>(type: "numeric", nullable: false),
                    clave_usuario = table.Column<string>(nullable: false),
                    nombre_usuario = table.Column<string>(nullable: false),
                    Pas_usuario = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("usuario_pkey", x => x.id_usuario);
                });

            migrationBuilder.CreateTable(
                name: "rol",
                columns: table => new
                {
                    id_rol = table.Column<decimal>(type: "numeric", nullable: false),
                    nombre_rol = table.Column<string>(nullable: false),
                    FK_rol = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("rol_pkey", x => x.id_rol);
                    table.ForeignKey(
                        name: "Fk_rolus",
                        column: x => x.FK_rol,
                        principalTable: "usuario",
                        principalColumn: "id_usuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "fki_Fk_rolus",
                table: "rol",
                column: "FK_rol");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "rol");

            migrationBuilder.DropTable(
                name: "usuario");
        }
    }
}
