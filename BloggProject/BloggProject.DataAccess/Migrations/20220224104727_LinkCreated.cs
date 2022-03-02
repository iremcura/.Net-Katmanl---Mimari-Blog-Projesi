using Microsoft.EntityFrameworkCore.Migrations;

namespace BloggProject.DataAccess.Migrations
{
    public partial class LinkCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rol_Id",
                table: "Users");

            migrationBuilder.AlterColumn<string>(
                name: "User_Password",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "User_Email",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AddColumn<int>(
                name: "User_Id",
                table: "Rols",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Rols_User_Id",
                table: "Rols",
                column: "User_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Rols_Users_User_Id",
                table: "Rols",
                column: "User_Id",
                principalTable: "Users",
                principalColumn: "User_Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rols_Users_User_Id",
                table: "Rols");

            migrationBuilder.DropIndex(
                name: "IX_Rols_User_Id",
                table: "Rols");

            migrationBuilder.DropColumn(
                name: "User_Id",
                table: "Rols");

            migrationBuilder.AlterColumn<string>(
                name: "User_Password",
                table: "Users",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "User_Email",
                table: "Users",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "Rol_Id",
                table: "Users",
                type: "int",
                maxLength: 10,
                nullable: false,
                defaultValue: 0);
        }
    }
}
