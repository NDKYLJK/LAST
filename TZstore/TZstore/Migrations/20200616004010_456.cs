using Microsoft.EntityFrameworkCore.Migrations;

namespace TZstore.Migrations
{
    public partial class _456 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
