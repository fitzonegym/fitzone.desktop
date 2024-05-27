using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fitzone.EF.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Barrio",
                columns: table => new
                {
                    idBarrio = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Barrio", x => x.idBarrio);
                });

            migrationBuilder.CreateTable(
                name: "Socio",
                columns: table => new
                {
                    idSocio = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    apellido = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    numeroDocumento = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    telefono1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    telefono2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    mail = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    tipoDocumento = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    calle = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    calleNumero = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    idBarrio = table.Column<int>(type: "int", nullable: false),
                    anulado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Socio", x => x.idSocio);
                    table.ForeignKey(
                        name: "FK_Socio_Barrio_idBarrio",
                        column: x => x.idBarrio,
                        principalTable: "Barrio",
                        principalColumn: "idBarrio",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Socio_idBarrio",
                table: "Socio",
                column: "idBarrio");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Socio");

            migrationBuilder.DropTable(
                name: "Barrio");
        }
    }
}
