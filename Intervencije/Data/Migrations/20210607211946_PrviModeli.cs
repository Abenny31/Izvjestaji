using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Intervencije.Data.Migrations
{
    public partial class PrviModeli : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DbAkcija",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Vrsta = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DbAkcija", x => x.Id);
                });

           

            migrationBuilder.CreateTable(
                name: "DbPlaza",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DbPlaza", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DbSpasilac",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prezime = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DbSpasilac", x => x.Id);
                });

            migrationBuilder.CreateTable(
               name: "DbIntervencija",
               columns: table => new
               {
                   Id = table.Column<int>(type: "int", nullable: false)
                       .Annotation("SqlServer:Identity", "1, 1"),
                   Datum = table.Column<DateTime>(type: "datetime2", nullable: false),
                   FkUser = table.Column<int>(type: "int", nullable: false),
                   FkAkcija = table.Column<int>(type: "int", nullable: false),
                   FkPlaza = table.Column<int>(type: "int", nullable: false)
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_DbIntervencija", x => x.Id);
                   table.ForeignKey("Fk_User", x => x.FkUser, "DbSpasilac", "Id");
                   table.ForeignKey("Fk_Akcija", x => x.FkAkcija, "DbAkcija", "Id");
                   table.ForeignKey("Fk_Plaza", x => x.FkPlaza, "DbPlaza", "Id");

               });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DbAkcija");

            migrationBuilder.DropTable(
                name: "DbIntervencija");

            migrationBuilder.DropTable(
                name: "DbPlaza");

            migrationBuilder.DropTable(
                name: "DbSpasilac");
        }
    }
}
