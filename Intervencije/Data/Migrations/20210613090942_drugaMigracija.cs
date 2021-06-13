using Microsoft.EntityFrameworkCore.Migrations;

namespace Intervencije.Data.Migrations
{
    public partial class drugaMigracija : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FkKorisnik",
                table: "DbIntervencija",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FkKorisnik",
                table: "DbIntervencija");
        }
    }
}
