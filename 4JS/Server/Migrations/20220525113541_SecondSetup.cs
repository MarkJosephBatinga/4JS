using Microsoft.EntityFrameworkCore.Migrations;

namespace _4JS.Server.Migrations
{
    public partial class SecondSetup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "user_info",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "user_info",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "user_info");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "user_info");
        }
    }
}
