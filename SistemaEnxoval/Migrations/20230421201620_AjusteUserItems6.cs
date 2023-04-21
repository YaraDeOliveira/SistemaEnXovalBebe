using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaEnxoval.Migrations
{
    /// <inheritdoc />
    public partial class AjusteUserItems6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserItems_Items_ItemsId",
                table: "UserItems");

            migrationBuilder.DropIndex(
                name: "IX_UserItems_ItemsId",
                table: "UserItems");

            migrationBuilder.DropColumn(
                name: "ItemsId",
                table: "UserItems");

            migrationBuilder.CreateIndex(
                name: "IX_UserItems_ItemId",
                table: "UserItems",
                column: "ItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserItems_Items_ItemId",
                table: "UserItems",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserItems_Items_ItemId",
                table: "UserItems");

            migrationBuilder.DropIndex(
                name: "IX_UserItems_ItemId",
                table: "UserItems");

            migrationBuilder.AddColumn<int>(
                name: "ItemsId",
                table: "UserItems",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserItems_ItemsId",
                table: "UserItems",
                column: "ItemsId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserItems_Items_ItemsId",
                table: "UserItems",
                column: "ItemsId",
                principalTable: "Items",
                principalColumn: "Id");
        }
    }
}
