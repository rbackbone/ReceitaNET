using Microsoft.EntityFrameworkCore.Migrations;

namespace mvc001.Migrations
{
    public partial class preparo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Preparo",
                table: "Receita",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Preparo",
                table: "Receita");
        }
    }
}
