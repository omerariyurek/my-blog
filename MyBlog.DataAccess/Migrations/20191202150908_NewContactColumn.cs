using Microsoft.EntityFrameworkCore.Migrations;

namespace MyBlog.DataAccess.Migrations
{
    public partial class NewContactColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "Contacts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Content",
                table: "Contacts");
        }
    }
}
