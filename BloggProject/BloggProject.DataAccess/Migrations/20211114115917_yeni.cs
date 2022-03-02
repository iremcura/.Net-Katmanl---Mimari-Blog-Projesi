using Microsoft.EntityFrameworkCore.Migrations;

namespace BloggProject.DataAccess.Migrations
{
    public partial class yeni : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rol_Name",
                table: "Rols");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Rols",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Rols");

            migrationBuilder.AddColumn<int>(
                name: "Rol_Name",
                table: "Rols",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
