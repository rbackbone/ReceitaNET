using Microsoft.EntityFrameworkCore.Migrations;

namespace mvc001.Migrations
{
    public partial class camposReceita : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Receita_Cadastro_CadastroId",
                table: "Receita");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cadastro",
                table: "Cadastro");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Receita");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Insumo");

            migrationBuilder.DropColumn(
                name: "CadastroId",
                table: "Cadastro");

            migrationBuilder.AddColumn<int>(
                name: "CategoriaId",
                table: "Receita",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Codigo",
                table: "Receita",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Titulo",
                table: "Receita",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Cadastro",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cadastro",
                table: "Cadastro",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(nullable: false),
                    Nome = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Receita_CategoriaId",
                table: "Receita",
                column: "CategoriaId");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Receita_Cadastro_CadastroId",
                table: "Receita");

            migrationBuilder.DropForeignKey(
                name: "FK_Receita_Categoria_CategoriaId",
                table: "Receita");

            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropIndex(
                name: "IX_Receita_CategoriaId",
                table: "Receita");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cadastro",
                table: "Cadastro");

            migrationBuilder.DropColumn(
                name: "CategoriaId",
                table: "Receita");

            migrationBuilder.DropColumn(
                name: "Codigo",
                table: "Receita");

            migrationBuilder.DropColumn(
                name: "Titulo",
                table: "Receita");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Receita",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Insumo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Cadastro",
                type: "int",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "CadastroId",
                table: "Cadastro",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cadastro",
                table: "Cadastro",
                column: "CadastroId");

            migrationBuilder.AddForeignKey(
                name: "FK_Receita_Cadastro_CadastroId",
                table: "Receita",
                column: "CadastroId",
                principalTable: "Cadastro",
                principalColumn: "CadastroId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
