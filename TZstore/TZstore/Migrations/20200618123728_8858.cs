using Microsoft.EntityFrameworkCore.Migrations;

namespace TZstore.Migrations
{
    public partial class _8858 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Orders",
                newName: "Username");

            migrationBuilder.AddColumn<string>(
                name: "Ordertime",
                table: "Orders",
                maxLength: 50,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ordertime",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "Orders",
                newName: "UserName");
        }
    }
}
