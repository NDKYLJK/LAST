using Microsoft.EntityFrameworkCore.Migrations;

namespace TZstore.Migrations
{
    public partial class kkk58 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ordertime",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ShowCarYN",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Orders",
                maxLength: 50,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShowCarYN",
                table: "Products");

            migrationBuilder.AddColumn<string>(
               name: "UserName",
               table: "Orders",
               maxLength: 50,
               nullable: true);

            migrationBuilder.DropColumn(
               name: "Ordertime",
               table: "Orders");
        }
    }
}
