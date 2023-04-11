using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElearnTemp.Migrations
{
    public partial class AddAuthorImageColumnWhereAuthor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AuthorImage",
                table: "Authors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AuthorImage",
                table: "Authors");
        }
    }
}
