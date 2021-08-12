using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace standBY_prototype.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    ClienteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    razao_social = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cnpj = table.Column<int>(type: "int", nullable: false),
                    data_fundacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    capital = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    quarentena = table.Column<bool>(type: "bit", nullable: false),
                    status_cliente = table.Column<bool>(type: "bit", nullable: false),
                    classificacao = table.Column<string>(type: "nvarchar(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.ClienteId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
