using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projetocripto.Migrations
{
    public partial class initialCreate_V2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Impressoraid",
                table: "Contas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Impressora",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    setor = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    data = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Impressora", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contas_Impressoraid",
                table: "Contas",
                column: "Impressoraid");

            migrationBuilder.AddForeignKey(
                name: "FK_Contas_Impressora_Impressoraid",
                table: "Contas",
                column: "Impressoraid",
                principalTable: "Impressora",
                principalColumn: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contas_Impressora_Impressoraid",
                table: "Contas");

            migrationBuilder.DropTable(
                name: "Impressora");

            migrationBuilder.DropIndex(
                name: "IX_Contas_Impressoraid",
                table: "Contas");

            migrationBuilder.DropColumn(
                name: "Impressoraid",
                table: "Contas");
        }
    }
}
