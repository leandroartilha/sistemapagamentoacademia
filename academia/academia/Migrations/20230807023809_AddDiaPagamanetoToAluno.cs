using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace academia.Migrations
{
    public partial class AddDiaPagamanetoToAluno : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataCadastro",
                table: "Aluno",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DiaPagamento",
                table: "Aluno",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataCadastro",
                table: "Aluno");

            migrationBuilder.DropColumn(
                name: "DiaPagamento",
                table: "Aluno");
        }
    }
}
