using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaEnxoval.Migrations
{
    /// <inheritdoc />
    public partial class AjusteUserItems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "UserItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserItem",
                table: "UserItems",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "UserItems");

            migrationBuilder.DropColumn(
                name: "UserItem",
                table: "UserItems");
        }
    }
}
