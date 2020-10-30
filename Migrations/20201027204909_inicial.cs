using Microsoft.EntityFrameworkCore.Migrations;

namespace mvc001.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cadastro",
                columns: table => new
                {
                    CadastroId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Telefone = table.Column<string>(nullable: false),
                    Endereco = table.Column<string>(nullable: false),
                    Complemento = table.Column<string>(nullable: false),
                    Bairro = table.Column<string>(nullable: false),
                    Municipio = table.Column<string>(nullable: false),
                    UF = table.Column<string>(nullable: false),
                    CEP = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cadastro", x => x.CadastroId);
                });

            migrationBuilder.CreateTable(
                name: "Insumo",
                columns: table => new
                {
                    InsumoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id = table.Column<int>(nullable: false),
                    Codigo = table.Column<string>(nullable: false),
                    Nome = table.Column<string>(nullable: false),
                    Xicara = table.Column<int>(nullable: false),
                    Gramas = table.Column<int>(nullable: false),
                    ColherSopa = table.Column<int>(nullable: false),
                    ColherCha = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Insumo", x => x.InsumoId);
                });

            migrationBuilder.CreateTable(
                name: "Receita",
                columns: table => new
                {
                    ReceitaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id = table.Column<int>(nullable: false),
                    CadastroId1 = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receita", x => x.ReceitaId);
                    table.ForeignKey(
                        name: "FK_Receita_Cadastro_CadastroId1",
                        column: x => x.CadastroId1,
                        principalTable: "Cadastro",
                        principalColumn: "CadastroId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemReceita",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReceitaId1 = table.Column<int>(nullable: true),
                    InsumoId1 = table.Column<int>(nullable: true),
                    Quantidade = table.Column<int>(nullable: false),
                    um2Meio = table.Column<bool>(nullable: false),
                    um4Quarto = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemReceita", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemReceita_Insumo_InsumoId1",
                        column: x => x.InsumoId1,
                        principalTable: "Insumo",
                        principalColumn: "InsumoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemReceita_Receita_ReceitaId1",
                        column: x => x.ReceitaId1,
                        principalTable: "Receita",
                        principalColumn: "ReceitaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItemReceita_InsumoId1",
                table: "ItemReceita",
                column: "InsumoId1");

            migrationBuilder.CreateIndex(
                name: "IX_ItemReceita_ReceitaId1",
                table: "ItemReceita",
                column: "ReceitaId1");

            migrationBuilder.CreateIndex(
                name: "IX_Receita_CadastroId1",
                table: "Receita",
                column: "CadastroId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemReceita");

            migrationBuilder.DropTable(
                name: "Insumo");

            migrationBuilder.DropTable(
                name: "Receita");

            migrationBuilder.DropTable(
                name: "Cadastro");
        }
    }
}
