using Microsoft.EntityFrameworkCore.Migrations;

namespace EmporioVirtual.Migrations
{
    public partial class ClienteEndereco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Produto",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Produto",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CEP",
                table: "Clientes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cidade",
                table: "Clientes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Complemento",
                table: "Clientes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Endereco",
                table: "Clientes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Estado",
                table: "Clientes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Numero",
                table: "Clientes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CEP",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "Cidade",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "Complemento",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "Endereco",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "Numero",
                table: "Clientes");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Produto",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Produto",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
