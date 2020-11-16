using Microsoft.EntityFrameworkCore.Migrations;

namespace RestaurantWebApplication.Migrations
{
    public partial class salesGone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MenuId",
                table: "Ticket",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_MenuId",
                table: "Ticket",
                column: "MenuId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_Menu_MenuId",
                table: "Ticket",
                column: "MenuId",
                principalTable: "Menu",
                principalColumn: "MenuID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_Menu_MenuId",
                table: "Ticket");

            migrationBuilder.DropIndex(
                name: "IX_Ticket_MenuId",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "MenuId",
                table: "Ticket");
        }
    }
}
