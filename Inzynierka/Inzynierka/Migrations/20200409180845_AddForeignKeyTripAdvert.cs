using Microsoft.EntityFrameworkCore.Migrations;

namespace Inzynierka.Migrations
{
    public partial class AddForeignKeyTripAdvert : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TripAdverts_AspNetUsers_ApplicationUserId",
                table: "TripAdverts");

            migrationBuilder.DropIndex(
                name: "IX_TripAdverts_ApplicationUserId",
                table: "TripAdverts");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "TripAdverts");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "TripAdverts",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TripAdverts_UserId",
                table: "TripAdverts",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_TripAdverts_AspNetUsers_UserId",
                table: "TripAdverts",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TripAdverts_AspNetUsers_UserId",
                table: "TripAdverts");

            migrationBuilder.DropIndex(
                name: "IX_TripAdverts_UserId",
                table: "TripAdverts");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "TripAdverts",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "TripAdverts",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TripAdverts_ApplicationUserId",
                table: "TripAdverts",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_TripAdverts_AspNetUsers_ApplicationUserId",
                table: "TripAdverts",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
