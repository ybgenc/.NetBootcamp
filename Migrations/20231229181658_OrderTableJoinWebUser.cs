using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace netBootcamp.Migrations
{
    public partial class OrderTableJoinWebUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "WebUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_WebUsers_OrderId",
                table: "WebUsers",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_WebUsers_Orders_OrderId",
                table: "WebUsers",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WebUsers_Orders_OrderId",
                table: "WebUsers");

            migrationBuilder.DropIndex(
                name: "IX_WebUsers_OrderId",
                table: "WebUsers");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "WebUsers");
        }
    }
}
