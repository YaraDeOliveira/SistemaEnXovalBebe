using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaEnxoval.Migrations
{
    /// <inheritdoc />
    public partial class AjusteUserItems5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserItems_Users_UserId",
                table: "UserItems");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "UserItems",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemId",
                table: "UserItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_UserItems_Users_UserId",
                table: "UserItems",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserItems_Users_UserId",
                table: "UserItems");

            migrationBuilder.DropColumn(
                name: "ItemId",
                table: "UserItems");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "UserItems",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_UserItems_Users_UserId",
                table: "UserItems",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
