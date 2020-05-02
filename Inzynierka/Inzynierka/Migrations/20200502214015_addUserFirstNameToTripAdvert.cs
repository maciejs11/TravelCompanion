using Microsoft.EntityFrameworkCore.Migrations;

namespace Inzynierka.Migrations
{
    public partial class addUserFirstNameToTripAdvert : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserFirstName",
                table: "TripAdverts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserFirstName",
                table: "TripAdverts");
        }
    }
}
