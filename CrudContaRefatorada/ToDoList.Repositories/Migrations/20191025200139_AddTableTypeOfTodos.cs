using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ToDoList.Repositories.Migrations
{
    public partial class AddTableTypeOfTodos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContasLuz",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    idImovel = table.Column<int>(nullable: false),
                    dataLeitura = table.Column<DateTime>(nullable: false),
                    kwGasto = table.Column<int>(nullable: false),
                    valorAPagar = table.Column<double>(nullable: false),
                    dataPagamento = table.Column<DateTime>(nullable: false),
                    mediaConsumo = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContasLuz", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ImovelDb",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    identificação = table.Column<string>(nullable: true),
                    numero = table.Column<string>(nullable: true),
                    bairro = table.Column<string>(nullable: true),
                    cidade = table.Column<string>(nullable: true),
                    estado = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImovelDb", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContasLuz");

            migrationBuilder.DropTable(
                name: "ImovelDb");
        }
    }
}
