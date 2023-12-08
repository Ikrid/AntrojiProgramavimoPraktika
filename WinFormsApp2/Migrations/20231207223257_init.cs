using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace WinFormsApp2.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Grupes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grupes", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Kursai",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kursai", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Naudotojai",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(type: "longtext", nullable: false),
                    LastName = table.Column<string>(type: "longtext", nullable: false),
                    UserName = table.Column<string>(type: "longtext", nullable: false),
                    Password = table.Column<string>(type: "longtext", nullable: false),
                    UserType = table.Column<int>(type: "int", nullable: false),
                    GrupeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Naudotojai", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Naudotojai_Grupes_GrupeId",
                        column: x => x.GrupeId,
                        principalTable: "Grupes",
                        principalColumn: "Id");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "kursasgrupe",
                columns: table => new
                {
                    GrupesId = table.Column<int>(type: "int", nullable: false),
                    KursaiId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kursasgrupe", x => new { x.GrupesId, x.KursaiId });
                    table.ForeignKey(
                        name: "FK_kursasgrupe_Grupes_GrupesId",
                        column: x => x.GrupesId,
                        principalTable: "Grupes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_kursasgrupe_Kursai_KursaiId",
                        column: x => x.KursaiId,
                        principalTable: "Kursai",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "kursasnaudotojai",
                columns: table => new
                {
                    KursaiId = table.Column<int>(type: "int", nullable: false),
                    NaudotojaiId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kursasnaudotojai", x => new { x.KursaiId, x.NaudotojaiId });
                    table.ForeignKey(
                        name: "FK_kursasnaudotojai_Kursai_KursaiId",
                        column: x => x.KursaiId,
                        principalTable: "Kursai",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_kursasnaudotojai_Naudotojai_NaudotojaiId",
                        column: x => x.NaudotojaiId,
                        principalTable: "Naudotojai",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Pazymiai",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Value = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    KursasId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pazymiai", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pazymiai_Kursai_KursasId",
                        column: x => x.KursasId,
                        principalTable: "Kursai",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pazymiai_Naudotojai_UserId",
                        column: x => x.UserId,
                        principalTable: "Naudotojai",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_kursasgrupe_KursaiId",
                table: "kursasgrupe",
                column: "KursaiId");

            migrationBuilder.CreateIndex(
                name: "IX_kursasnaudotojai_NaudotojaiId",
                table: "kursasnaudotojai",
                column: "NaudotojaiId");

            migrationBuilder.CreateIndex(
                name: "IX_Naudotojai_GrupeId",
                table: "Naudotojai",
                column: "GrupeId");

            migrationBuilder.CreateIndex(
                name: "IX_Pazymiai_KursasId",
                table: "Pazymiai",
                column: "KursasId");

            migrationBuilder.CreateIndex(
                name: "IX_Pazymiai_UserId",
                table: "Pazymiai",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "kursasgrupe");

            migrationBuilder.DropTable(
                name: "kursasnaudotojai");

            migrationBuilder.DropTable(
                name: "Pazymiai");

            migrationBuilder.DropTable(
                name: "Kursai");

            migrationBuilder.DropTable(
                name: "Naudotojai");

            migrationBuilder.DropTable(
                name: "Grupes");
        }
    }
}
