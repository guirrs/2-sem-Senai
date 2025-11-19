using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sistema_de_Personagens.Migrations
{
    /// <inheritdoc />
    public partial class CriarBanco2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Dano",
                table: "TabelaPersonagem");

            migrationBuilder.DropColumn(
                name: "Guerreiro_Dano",
                table: "TabelaPersonagem");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Dano",
                table: "TabelaPersonagem",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Guerreiro_Dano",
                table: "TabelaPersonagem",
                type: "float",
                nullable: true);
        }
    }
}
