using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HomePetCare.App.Persistencia.Migrations
{
    public partial class Inicial6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "seres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telephone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneOwner = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_seres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Veterinarys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameVet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastNameVet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneVet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProfCard = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veterinarys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Visits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Temperature = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Weight = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Breath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RPM = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mood = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VisitDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Commentary = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameVDog = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Breed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    veterinarioId = table.Column<int>(type: "int", nullable: true),
                    visitaId = table.Column<int>(type: "int", nullable: true),
                    dueñoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dogs_seres_dueñoId",
                        column: x => x.dueñoId,
                        principalTable: "seres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Dogs_Veterinarys_veterinarioId",
                        column: x => x.veterinarioId,
                        principalTable: "Veterinarys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Dogs_Visits_visitaId",
                        column: x => x.visitaId,
                        principalTable: "Visits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EstadoVitales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaHora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Valor = table.Column<float>(type: "real", nullable: false),
                    Signo = table.Column<int>(type: "int", nullable: false),
                    DogId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoVitales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EstadoVitales_Dogs_DogId",
                        column: x => x.DogId,
                        principalTable: "Dogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dogs_dueñoId",
                table: "Dogs",
                column: "dueñoId");

            migrationBuilder.CreateIndex(
                name: "IX_Dogs_veterinarioId",
                table: "Dogs",
                column: "veterinarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Dogs_visitaId",
                table: "Dogs",
                column: "visitaId");

            migrationBuilder.CreateIndex(
                name: "IX_EstadoVitales_DogId",
                table: "EstadoVitales",
                column: "DogId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EstadoVitales");

            migrationBuilder.DropTable(
                name: "Dogs");

            migrationBuilder.DropTable(
                name: "seres");

            migrationBuilder.DropTable(
                name: "Veterinarys");

            migrationBuilder.DropTable(
                name: "Visits");
        }
    }
}
