using Microsoft.EntityFrameworkCore.Migrations;

namespace RestaurantWebApplication.Migrations
{
    public partial class staff : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SecurityLevel",
                table: "Staff");

            migrationBuilder.AddColumn<string>(
                name: "Position",
                table: "Staff",
                maxLength: 50,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Position",
                table: "Staff");

            migrationBuilder.AddColumn<string>(
                name: "SecurityLevel",
                table: "Staff",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);
        }
    }
}
