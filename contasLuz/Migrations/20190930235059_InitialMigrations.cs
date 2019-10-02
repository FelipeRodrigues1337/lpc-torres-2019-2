using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace contasLuz.Migrations
{
    public partial class InitialMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "contaLuz",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    numeroLeitura = table.Column<int>(nullable: false),
                    dataLeitura = table.Column<DateTime>(nullable: false),
                    kwGasto = table.Column<int>(nullable: false),
                    valorPagar = table.Column<double>(nullable: false),
                    dataPagamento = table.Column<DateTime>(nullable: false),
                    mediaConsumo = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contaLuz", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "contaLuz");
        }
    }
}
