using Microsoft.EntityFrameworkCore.Migrations;

namespace TomoyoseStore.Migrations
{
    public partial class AddModels2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAdmin",
                table: "Employees");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsAdmin",
                table: "Employees",
                nullable: false,
                defaultValue: false);
        }
    }
}
