using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BloggProject.DataAccess.Migrations
{
    public partial class CommentCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Comment_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Comment_Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comment_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Content_Id = table.Column<int>(type: "int", nullable: false),
                    User_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Comment_Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");
        }
    }
}
