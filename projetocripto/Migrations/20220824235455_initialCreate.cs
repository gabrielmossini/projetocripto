using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projetocripto.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "clientes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    estado = table.Column<int>(type: "int", nullable: false),
                    idade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clientes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "moedas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    quantidade = table.Column<float>(type: "real", nullable: false),
                    venda = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_moedas", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "contas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    clienteid = table.Column<int>(type: "int", nullable: true),
                    moedaid = table.Column<int>(type: "int", nullable: true),
                    quantidade = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contas", x => x.id);
                    table.ForeignKey(
                        name: "FK_contas_clientes_clienteid",
                        column: x => x.clienteid,
                        principalTable: "clientes",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_contas_moedas_moedaid",
                        column: x => x.moedaid,
                        principalTable: "moedas",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "transasoes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    contaid = table.Column<int>(type: "int", nullable: true),
                    data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    quantidade = table.Column<float>(type: "real", nullable: false),
                    valor = table.Column<float>(type: "real", nullable: false),
                    operacao = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_transasoes", x => x.id);
                    table.ForeignKey(
                        name: "FK_transasoes_contas_contaid",
                        column: x => x.contaid,
                        principalTable: "contas",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_contas_clienteid",
                table: "contas",
                column: "clienteid");

            migrationBuilder.CreateIndex(
                name: "IX_contas_moedaid",
                table: "contas",
                column: "moedaid");

            migrationBuilder.CreateIndex(
                name: "IX_transasoes_contaid",
                table: "transasoes",
                column: "contaid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "transasoes");

            migrationBuilder.DropTable(
                name: "contas");

            migrationBuilder.DropTable(
                name: "clientes");

            migrationBuilder.DropTable(
                name: "moedas");
        }
    }
}
