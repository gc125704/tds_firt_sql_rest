using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Teste.API.Migrations
{
    /// <inheritdoc />
    public partial class AtualizacaoCamposProdutos1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Categoria",
                table: "Products",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Preco",
                table: "Products",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "Quantidade",
                table: "Products",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Categoria",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Preco",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Quantidade",
                table: "Products");
        }
    }
}
