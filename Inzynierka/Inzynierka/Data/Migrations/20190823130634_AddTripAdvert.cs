using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Inzynierka.Data.Migrations
{
    public partial class AddTripAdvert : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TripAdverts",
                columns: table => new
                {
                    TripAdvertID = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    AdvertDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TripAdverts", x => x.TripAdvertID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TripAdverts");
        }
    }
}
