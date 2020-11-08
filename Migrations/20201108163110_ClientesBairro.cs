using Microsoft.EntityFrameworkCore.Migrations;

namespace EmporioVirtual.Migrations
{
    public partial class ClientesBairro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Bairro_2",
                table: "Clientes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Bairro_3",
                table: "Clientes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bairro_2",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "Bairro_3",
                table: "Clientes");
        }
    }
}
