using Microsoft.EntityFrameworkCore.Migrations;

namespace Intervencije.Data.Migrations
{
    public partial class DovrsenaIntervencija : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GodineZrtve",
                table: "DbIntervencija",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Hitna",
                table: "DbIntervencija",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "ImeZrtve",
                table: "DbIntervencija",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OpisAkcije",
                table: "DbIntervencija",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ozljeda",
                table: "DbIntervencija",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Policija",
                table: "DbIntervencija",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "PrezimeZrtve",
                table: "DbIntervencija",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Vatrogasci",
                table: "DbIntervencija",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GodineZrtve",
                table: "DbIntervencija");

            migrationBuilder.DropColumn(
                name: "Hitna",
                table: "DbIntervencija");

            migrationBuilder.DropColumn(
                name: "ImeZrtve",
                table: "DbIntervencija");

            migrationBuilder.DropColumn(
                name: "OpisAkcije",
                table: "DbIntervencija");

            migrationBuilder.DropColumn(
                name: "Ozljeda",
                table: "DbIntervencija");

            migrationBuilder.DropColumn(
                name: "Policija",
                table: "DbIntervencija");

            migrationBuilder.DropColumn(
                name: "PrezimeZrtve",
                table: "DbIntervencija");

            migrationBuilder.DropColumn(
                name: "Vatrogasci",
                table: "DbIntervencija");
        }
    }
}
