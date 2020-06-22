using Microsoft.EntityFrameworkCore.Migrations;

namespace TZstore.Migrations
{
    public partial class ff565 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ShowCarYN",
                table: "Products",
                maxLength: 300,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShowCarYN",
                table: "Products");
        }
    }
}
