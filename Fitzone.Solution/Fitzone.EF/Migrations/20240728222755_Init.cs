using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fitzone.EF.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Actividad",
                columns: table => new
                {
                    idActividad = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actividad", x => x.idActividad);
                });

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
                name: "Configuraciones",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    valor = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Configuraciones", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "EstadoEquipamiento",
                columns: table => new
                {
                    idEstadoEquipamiento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoEquipamiento", x => x.idEstadoEquipamiento);
                });

            migrationBuilder.CreateTable(
                name: "EstadoMembresia",
                columns: table => new
                {
                    idEstadoMembresia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    descripcion = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoMembresia", x => x.idEstadoMembresia);
                });

            migrationBuilder.CreateTable(
                name: "Marca",
                columns: table => new
                {
                    idMarca = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marca", x => x.idMarca);
                });

            migrationBuilder.CreateTable(
                name: "Instructor",
                columns: table => new
                {
                    idInstructor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    apellido = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    telefono1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    telefono2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    mail = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    tipoDocumento = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    numeroDocumento = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    calle = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    calleNumero = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    fechaAlta = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    anulado = table.Column<bool>(type: "bit", nullable: false),
                    idBarrio = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructor", x => x.idInstructor);
                    table.ForeignKey(
                        name: "FK_Instructor_Barrio_idBarrio",
                        column: x => x.idBarrio,
                        principalTable: "Barrio",
                        principalColumn: "idBarrio",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Socio",
                columns: table => new
                {
                    idSocio = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    apellido = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    numeroDocumento = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true),
                    telefono1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    telefono2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    mail = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    tipoDocumento = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    calle = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    calleNumero = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    anulado = table.Column<bool>(type: "bit", nullable: false),
                    imagen = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    fechaAlta = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    idBarrio = table.Column<int>(type: "int", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "Equipamiento",
                columns: table => new
                {
                    idEquipamiento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    dimensiones = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    modelo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    idEstadoEquipamiento = table.Column<int>(type: "int", nullable: false),
                    idMarca = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipamiento", x => x.idEquipamiento);
                    table.ForeignKey(
                        name: "FK_Equipamiento_EstadoEquipamiento_idEstadoEquipamiento",
                        column: x => x.idEstadoEquipamiento,
                        principalTable: "EstadoEquipamiento",
                        principalColumn: "idEstadoEquipamiento",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Equipamiento_Marca_idMarca",
                        column: x => x.idMarca,
                        principalTable: "Marca",
                        principalColumn: "idMarca",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TipoMembresia",
                columns: table => new
                {
                    idTipoMembresia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    descripcion = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    precioTotal = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    cantidadCuotas = table.Column<int>(type: "int", nullable: false),
                    cantidadDiasSemanales = table.Column<int>(type: "int", nullable: false),
                    diasHabilitados = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    horadesde = table.Column<DateTime>(type: "datetime2", nullable: false),
                    horaHasta = table.Column<DateTime>(type: "datetime2", nullable: false),
                    cupoClase = table.Column<int>(type: "int", nullable: true),
                    idInstructor = table.Column<int>(type: "int", nullable: true),
                    idActividad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoMembresia", x => x.idTipoMembresia);
                    table.ForeignKey(
                        name: "FK_TipoMembresia_Actividad_idActividad",
                        column: x => x.idActividad,
                        principalTable: "Actividad",
                        principalColumn: "idActividad",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TipoMembresia_Instructor_idInstructor",
                        column: x => x.idInstructor,
                        principalTable: "Instructor",
                        principalColumn: "idInstructor");
                });

            migrationBuilder.CreateTable(
                name: "Membresia",
                columns: table => new
                {
                    idMembresia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    precio = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    fechaAlta = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    fechaDesde = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fechaHasta = table.Column<DateTime>(type: "datetime2", nullable: false),
                    detalle = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    cantidadDiasSemanales = table.Column<int>(type: "int", nullable: false),
                    diasHabilitados = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    horadesde = table.Column<DateTime>(type: "datetime2", nullable: false),
                    horaHasta = table.Column<DateTime>(type: "datetime2", nullable: false),
                    idTipoMembresia = table.Column<int>(type: "int", nullable: false),
                    idEstadoMembresia = table.Column<int>(type: "int", nullable: false),
                    idSocio = table.Column<int>(type: "int", nullable: false),
                    idInstructor = table.Column<int>(type: "int", nullable: true),
                    idActividad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Membresia", x => x.idMembresia);
                    table.ForeignKey(
                        name: "FK_Membresia_Actividad_idActividad",
                        column: x => x.idActividad,
                        principalTable: "Actividad",
                        principalColumn: "idActividad",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Membresia_EstadoMembresia_idEstadoMembresia",
                        column: x => x.idEstadoMembresia,
                        principalTable: "EstadoMembresia",
                        principalColumn: "idEstadoMembresia",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Membresia_Instructor_idInstructor",
                        column: x => x.idInstructor,
                        principalTable: "Instructor",
                        principalColumn: "idInstructor");
                    table.ForeignKey(
                        name: "FK_Membresia_Socio_idSocio",
                        column: x => x.idSocio,
                        principalTable: "Socio",
                        principalColumn: "idSocio",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EquipamientoTipoMembresia",
                columns: table => new
                {
                    idexc = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idEquipamiento = table.Column<int>(type: "int", nullable: false),
                    idTipoMembresia = table.Column<int>(type: "int", nullable: false),
                    cantidadEquipamiento = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipamientoTipoMembresia", x => x.idexc);
                    table.ForeignKey(
                        name: "FK_EquipamientoTipoMembresia_Equipamiento_idEquipamiento",
                        column: x => x.idEquipamiento,
                        principalTable: "Equipamiento",
                        principalColumn: "idEquipamiento",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EquipamientoTipoMembresia_TipoMembresia_idTipoMembresia",
                        column: x => x.idTipoMembresia,
                        principalTable: "TipoMembresia",
                        principalColumn: "idTipoMembresia",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cuota",
                columns: table => new
                {
                    idCuota = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    precio = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    numero = table.Column<int>(type: "int", nullable: false),
                    fechaDesde = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fechaHasta = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fechaVencimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    idMembresia = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cuota", x => x.idCuota);
                    table.ForeignKey(
                        name: "FK_Cuota_Membresia_idMembresia",
                        column: x => x.idMembresia,
                        principalTable: "Membresia",
                        principalColumn: "idMembresia",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cuota_idMembresia",
                table: "Cuota",
                column: "idMembresia");

            migrationBuilder.CreateIndex(
                name: "IX_Equipamiento_idEstadoEquipamiento",
                table: "Equipamiento",
                column: "idEstadoEquipamiento");

            migrationBuilder.CreateIndex(
                name: "IX_Equipamiento_idMarca",
                table: "Equipamiento",
                column: "idMarca");

            migrationBuilder.CreateIndex(
                name: "IX_EquipamientoTipoMembresia_idEquipamiento",
                table: "EquipamientoTipoMembresia",
                column: "idEquipamiento");

            migrationBuilder.CreateIndex(
                name: "IX_EquipamientoTipoMembresia_idTipoMembresia",
                table: "EquipamientoTipoMembresia",
                column: "idTipoMembresia");

            migrationBuilder.CreateIndex(
                name: "IX_Instructor_idBarrio",
                table: "Instructor",
                column: "idBarrio");

            migrationBuilder.CreateIndex(
                name: "IX_Membresia_idActividad",
                table: "Membresia",
                column: "idActividad");

            migrationBuilder.CreateIndex(
                name: "IX_Membresia_idEstadoMembresia",
                table: "Membresia",
                column: "idEstadoMembresia");

            migrationBuilder.CreateIndex(
                name: "IX_Membresia_idInstructor",
                table: "Membresia",
                column: "idInstructor");

            migrationBuilder.CreateIndex(
                name: "IX_Membresia_idSocio",
                table: "Membresia",
                column: "idSocio");

            migrationBuilder.CreateIndex(
                name: "IX_Socio_idBarrio",
                table: "Socio",
                column: "idBarrio");

            migrationBuilder.CreateIndex(
                name: "IX_TipoMembresia_idActividad",
                table: "TipoMembresia",
                column: "idActividad");

            migrationBuilder.CreateIndex(
                name: "IX_TipoMembresia_idInstructor",
                table: "TipoMembresia",
                column: "idInstructor");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Configuraciones");

            migrationBuilder.DropTable(
                name: "Cuota");

            migrationBuilder.DropTable(
                name: "EquipamientoTipoMembresia");

            migrationBuilder.DropTable(
                name: "Membresia");

            migrationBuilder.DropTable(
                name: "Equipamiento");

            migrationBuilder.DropTable(
                name: "TipoMembresia");

            migrationBuilder.DropTable(
                name: "EstadoMembresia");

            migrationBuilder.DropTable(
                name: "Socio");

            migrationBuilder.DropTable(
                name: "EstadoEquipamiento");

            migrationBuilder.DropTable(
                name: "Marca");

            migrationBuilder.DropTable(
                name: "Actividad");

            migrationBuilder.DropTable(
                name: "Instructor");

            migrationBuilder.DropTable(
                name: "Barrio");
        }
    }
}
