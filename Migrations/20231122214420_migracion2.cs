using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalPPAIPatrones.Migrations
{
    public partial class migracion2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dni = table.Column<int>(nullable: false),
                    nombreCompleto = table.Column<string>(nullable: true),
                    numeroCelular = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Encuesta",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcion = table.Column<string>(nullable: true),
                    fechaFinVigencia = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Encuesta", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Estado",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estado", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Llamada",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcionOperador = table.Column<int>(nullable: false),
                    detalleAccionRequerida = table.Column<int>(nullable: false),
                    duracion = table.Column<int>(nullable: false),
                    encuestaEnviadaid = table.Column<int>(nullable: true),
                    observacionAuditor = table.Column<int>(nullable: false),
                    clienteid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Llamada", x => x.id);
                    table.ForeignKey(
                        name: "FK_Llamada_Cliente_clienteid",
                        column: x => x.clienteid,
                        principalTable: "Cliente",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Llamada_Encuesta_encuestaEnviadaid",
                        column: x => x.encuestaEnviadaid,
                        principalTable: "Encuesta",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pregunta",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pregunta = table.Column<string>(nullable: true),
                    Encuestaid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pregunta", x => x.id);
                    table.ForeignKey(
                        name: "FK_Pregunta_Encuesta_Encuestaid",
                        column: x => x.Encuestaid,
                        principalTable: "Encuesta",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CambioDeEstado",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fechaHoraInicio = table.Column<DateTime>(nullable: false),
                    fechaHoraFin = table.Column<DateTime>(nullable: true),
                    estadoid = table.Column<int>(nullable: true),
                    Llamadaid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CambioDeEstado", x => x.id);
                    table.ForeignKey(
                        name: "FK_CambioDeEstado_Llamada_Llamadaid",
                        column: x => x.Llamadaid,
                        principalTable: "Llamada",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CambioDeEstado_Estado_estadoid",
                        column: x => x.estadoid,
                        principalTable: "Estado",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RespuestaPosible",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcion = table.Column<string>(nullable: true),
                    Preguntaid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RespuestaPosible", x => x.id);
                    table.ForeignKey(
                        name: "FK_RespuestaPosible_Pregunta_Preguntaid",
                        column: x => x.Preguntaid,
                        principalTable: "Pregunta",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RespuestaDeCliente",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fechaEncuesta = table.Column<DateTime>(nullable: false),
                    respuestaPosibleid = table.Column<int>(nullable: true),
                    Llamadaid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RespuestaDeCliente", x => x.id);
                    table.ForeignKey(
                        name: "FK_RespuestaDeCliente_Llamada_Llamadaid",
                        column: x => x.Llamadaid,
                        principalTable: "Llamada",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RespuestaDeCliente_RespuestaPosible_respuestaPosibleid",
                        column: x => x.respuestaPosibleid,
                        principalTable: "RespuestaPosible",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CambioDeEstado_Llamadaid",
                table: "CambioDeEstado",
                column: "Llamadaid");

            migrationBuilder.CreateIndex(
                name: "IX_CambioDeEstado_estadoid",
                table: "CambioDeEstado",
                column: "estadoid");

            migrationBuilder.CreateIndex(
                name: "IX_Llamada_clienteid",
                table: "Llamada",
                column: "clienteid");

            migrationBuilder.CreateIndex(
                name: "IX_Llamada_encuestaEnviadaid",
                table: "Llamada",
                column: "encuestaEnviadaid");

            migrationBuilder.CreateIndex(
                name: "IX_Pregunta_Encuestaid",
                table: "Pregunta",
                column: "Encuestaid");

            migrationBuilder.CreateIndex(
                name: "IX_RespuestaDeCliente_Llamadaid",
                table: "RespuestaDeCliente",
                column: "Llamadaid");

            migrationBuilder.CreateIndex(
                name: "IX_RespuestaDeCliente_respuestaPosibleid",
                table: "RespuestaDeCliente",
                column: "respuestaPosibleid");

            migrationBuilder.CreateIndex(
                name: "IX_RespuestaPosible_Preguntaid",
                table: "RespuestaPosible",
                column: "Preguntaid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CambioDeEstado");

            migrationBuilder.DropTable(
                name: "RespuestaDeCliente");

            migrationBuilder.DropTable(
                name: "Estado");

            migrationBuilder.DropTable(
                name: "Llamada");

            migrationBuilder.DropTable(
                name: "RespuestaPosible");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Pregunta");

            migrationBuilder.DropTable(
                name: "Encuesta");
        }
    }
}
