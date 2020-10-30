using Microsoft.EntityFrameworkCore.Migrations;

namespace mvc001.Migrations
{
    public partial class camposv02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Receita_Cadastro_CadastroId",
                table: "Receita");

            migrationBuilder.DropForeignKey(
                name: "FK_Receita_Categoria_CategoriaId",
                table: "Receita");

            migrationBuilder.AlterColumn<string>(
                name: "Titulo",
                table: "Receita",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CategoriaId",
                table: "Receita",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CadastroId",
                table: "Receita",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Receita_Cadastro_CadastroId",
                table: "Receita",
                column: "CadastroId",
                principalTable: "Cadastro",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Receita_Categoria_CategoriaId",
                table: "Receita",
                column: "CategoriaId",
                principalTable: "Categoria",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Receita_Cadastro_CadastroId",
                table: "Receita");

            migrationBuilder.DropForeignKey(
                name: "FK_Receita_Categoria_CategoriaId",
                table: "Receita");

            migrationBuilder.AlterColumn<string>(
                name: "Titulo",
                table: "Receita",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "CategoriaId",
                table: "Receita",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CadastroId",
                table: "Receita",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Receita_Cadastro_CadastroId",
                table: "Receita",
                column: "CadastroId",
                principalTable: "Cadastro",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Receita_Categoria_CategoriaId",
                table: "Receita",
                column: "CategoriaId",
                principalTable: "Categoria",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
