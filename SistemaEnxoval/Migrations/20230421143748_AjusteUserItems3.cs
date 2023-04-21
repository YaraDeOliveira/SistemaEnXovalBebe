using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaEnxoval.Migrations
{
    /// <inheritdoc />
    public partial class AjusteUserItems3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserItems_Users_UsersId",
                table: "UserItems");

            migrationBuilder.DropIndex(
                name: "IX_UserItems_UsersId",
                table: "UserItems");

            migrationBuilder.DropColumn(
                name: "UserItem",
                table: "UserItems");

            migrationBuilder.DropColumn(
                name: "UsersId",
                table: "UserItems");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "UserItems",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_UserItems_UserId",
                table: "UserItems",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserItems_Users_UserId",
                table: "UserItems",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserItems_Users_UserId",
                table: "UserItems");

            migrationBuilder.DropIndex(
                name: "IX_UserItems_UserId",
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
                name: "UserItem",
                table: "UserItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UsersId",
                table: "UserItems",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserItems_UsersId",
                table: "UserItems",
                column: "UsersId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserItems_Users_UsersId",
                table: "UserItems",
                column: "UsersId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
