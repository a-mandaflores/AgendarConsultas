using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgendarConsultas.Data.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "clinic",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    uuid = table.Column<Guid>(type: "TEXT", nullable: false),
                    name = table.Column<string>(type: "TEXT", nullable: false),
                    cell = table.Column<string>(type: "TEXT", nullable: true),
                    email = table.Column<string>(type: "TEXT", nullable: false),
                    schedule = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clinic", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "client",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    uuid = table.Column<Guid>(type: "TEXT", nullable: false),
                    name = table.Column<string>(type: "TEXT", nullable: false),
                    cell = table.Column<string>(type: "TEXT", nullable: true),
                    email = table.Column<string>(type: "TEXT", nullable: false),
                    clinic_id = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_client", x => x.id);
                    table.ForeignKey(
                        name: "FK_client_clinic_clinic_id",
                        column: x => x.clinic_id,
                        principalTable: "clinic",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "secretary",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Uuid = table.Column<Guid>(type: "TEXT", nullable: false),
                    name = table.Column<string>(type: "TEXT", nullable: false),
                    cell = table.Column<string>(type: "TEXT", nullable: true),
                    email = table.Column<string>(type: "TEXT", nullable: false),
                    clinic_id = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_secretary", x => x.id);
                    table.ForeignKey(
                        name: "FK_secretary_clinic_clinic_id",
                        column: x => x.clinic_id,
                        principalTable: "clinic",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "veterinary",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    uuid = table.Column<Guid>(type: "TEXT", nullable: false),
                    name = table.Column<string>(type: "TEXT", nullable: false),
                    cell = table.Column<string>(type: "TEXT", nullable: true),
                    email = table.Column<string>(type: "TEXT", nullable: false),
                    schedule = table.Column<string>(type: "TEXT", nullable: true),
                    clinic_id = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_veterinary", x => x.id);
                    table.ForeignKey(
                        name: "FK_veterinary_clinic_clinic_id",
                        column: x => x.clinic_id,
                        principalTable: "clinic",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "pet",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    uuid = table.Column<Guid>(type: "TEXT", nullable: false),
                    name = table.Column<string>(type: "TEXT", nullable: false),
                    race = table.Column<string>(type: "TEXT", nullable: true),
                    year = table.Column<int>(type: "INTEGER", nullable: false),
                    clinic_id = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pet", x => x.id);
                    table.ForeignKey(
                        name: "FK_pet_client_clinic_id",
                        column: x => x.clinic_id,
                        principalTable: "client",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "consultation",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    uuid = table.Column<Guid>(type: "TEXT", nullable: false),
                    schedule = table.Column<DateTime>(type: "TEXT", nullable: false),
                    pet_id = table.Column<int>(type: "INTEGER", nullable: false),
                    veterinary_id = table.Column<int>(type: "INTEGER", nullable: false),
                    clinic_id = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_consultation", x => x.id);
                    table.ForeignKey(
                        name: "FK_consultation_clinic_clinic_id",
                        column: x => x.clinic_id,
                        principalTable: "clinic",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_consultation_pet_pet_id",
                        column: x => x.pet_id,
                        principalTable: "pet",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_consultation_veterinary_veterinary_id",
                        column: x => x.veterinary_id,
                        principalTable: "veterinary",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_client_clinic_id",
                table: "client",
                column: "clinic_id");

            migrationBuilder.CreateIndex(
                name: "IX_consultation_clinic_id",
                table: "consultation",
                column: "clinic_id");

            migrationBuilder.CreateIndex(
                name: "IX_consultation_pet_id",
                table: "consultation",
                column: "pet_id");

            migrationBuilder.CreateIndex(
                name: "IX_consultation_veterinary_id",
                table: "consultation",
                column: "veterinary_id");

            migrationBuilder.CreateIndex(
                name: "IX_pet_clinic_id",
                table: "pet",
                column: "clinic_id");

            migrationBuilder.CreateIndex(
                name: "IX_secretary_clinic_id",
                table: "secretary",
                column: "clinic_id");

            migrationBuilder.CreateIndex(
                name: "IX_veterinary_clinic_id",
                table: "veterinary",
                column: "clinic_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "consultation");

            migrationBuilder.DropTable(
                name: "secretary");

            migrationBuilder.DropTable(
                name: "pet");

            migrationBuilder.DropTable(
                name: "veterinary");

            migrationBuilder.DropTable(
                name: "client");

            migrationBuilder.DropTable(
                name: "clinic");
        }
    }
}
