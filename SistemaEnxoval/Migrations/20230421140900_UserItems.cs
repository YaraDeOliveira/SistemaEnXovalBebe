using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaEnxoval.Migrations
{
    /// <inheritdoc />
    public partial class UserItems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "UserItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Stock = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserItems", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_UserItems_UserItemRepositoryId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_UserItems_UserItemRepositoryId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "UserItems");

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
        }
    }
}
