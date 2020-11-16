using Microsoft.EntityFrameworkCore.Migrations;

namespace RestaurantWebApplication.Migrations
{
    public partial class tablenum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Tables",
                table: "Tables");

            migrationBuilder.DropColumn(
                name: "TableNumber",
                table: "Tables");

            migrationBuilder.AddColumn<int>(
                name: "TablesID",
                table: "Tables",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Number",
                table: "Tables",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tables",
                table: "Tables",
                column: "TablesID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Tables",
                table: "Tables");

            migrationBuilder.DropColumn(
                name: "TablesID",
                table: "Tables");

            migrationBuilder.DropColumn(
                name: "Number",
                table: "Tables");

            migrationBuilder.AddColumn<int>(
                name: "TableNumber",
                table: "Tables",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tables",
                table: "Tables",
                column: "TableNumber");
        }
    }
}
