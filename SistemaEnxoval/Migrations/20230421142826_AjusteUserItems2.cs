using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaEnxoval.Migrations
{
    /// <inheritdoc />
    public partial class AjusteUserItems2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_UserItems_UserItemRepositoryId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_UserItems_UserItemRepositoryId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_UserItemRepositoryId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Items_UserItemRepositoryId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "UserItemRepositoryId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserItemRepositoryId",
                table: "Items");

            migrationBuilder.AddColumn<int>(
                name: "ItemsId",
                table: "UserItems",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UsersId",
                table: "UserItems",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ItemRepositoryUserRepository",
                columns: table => new
                {
                    ItemsId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemRepositoryUserRepository", x => new { x.ItemsId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_ItemRepositoryUserRepository_Items_ItemsId",
                        column: x => x.ItemsId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemRepositoryUserRepository_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserItems_ItemsId",
                table: "UserItems",
                column: "ItemsId");

            migrationBuilder.CreateIndex(
                name: "IX_UserItems_UsersId",
                table: "UserItems",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemRepositoryUserRepository_UsersId",
                table: "ItemRepositoryUserRepository",
                column: "UsersId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserItems_Items_ItemsId",
                table: "UserItems",
                column: "ItemsId",
                principalTable: "Items",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserItems_Users_UsersId",
                table: "UserItems",
                column: "UsersId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserItems_Items_ItemsId",
                table: "UserItems");

            migrationBuilder.DropForeignKey(
                name: "FK_UserItems_Users_UsersId",
                table: "UserItems");

            migrationBuilder.DropTable(
                name: "ItemRepositoryUserRepository");

            migrationBuilder.DropIndex(
                name: "IX_UserItems_ItemsId",
                table: "UserItems");

            migrationBuilder.DropIndex(
                name: "IX_UserItems_UsersId",
                table: "UserItems");

            migrationBuilder.DropColumn(
                name: "ItemsId",
                table: "UserItems");

            migrationBuilder.DropColumn(
                name: "UsersId",
                table: "UserItems");

            migrationBuilder.AddColumn<int>(
                name: "UserItemRepositoryId",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserItemRepositoryId",
                table: "Items",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserItemRepositoryId",
                table: "Users",
                column: "UserItemRepositoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_UserItemRepositoryId",
                table: "Items",
                column: "UserItemRepositoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_UserItems_UserItemRepositoryId",
                table: "Items",
                column: "UserItemRepositoryId",
                principalTable: "UserItems",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_UserItems_UserItemRepositoryId",
                table: "Users",
                column: "UserItemRepositoryId",
                principalTable: "UserItems",
                principalColumn: "Id");
        }
    }
}
