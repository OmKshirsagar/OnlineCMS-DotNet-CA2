using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineCMS.Data.Migrations
{
    public partial class AddedBlogs2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Content",
                table: "Blogs");

            migrationBuilder.AddColumn<string>(
                name: "BlogContent",
                table: "Blogs",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BlogContent",
                table: "Blogs");

            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "Blogs",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
