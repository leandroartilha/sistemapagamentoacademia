using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace academia.Migrations
{
    public partial class AddStatusPagamentoToContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StatusPagamentoId",
                table: "Aluno",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "StatusPagamento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeStatusPagamento = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusPagamento", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Aluno_StatusPagamentoId",
                table: "Aluno",
                column: "StatusPagamentoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Aluno_StatusPagamento_StatusPagamentoId",
                table: "Aluno",
                column: "StatusPagamentoId",
                principalTable: "StatusPagamento",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aluno_StatusPagamento_StatusPagamentoId",
                table: "Aluno");

            migrationBuilder.DropTable(
                name: "StatusPagamento");

            migrationBuilder.DropIndex(
                name: "IX_Aluno_StatusPagamentoId",
                table: "Aluno");

            migrationBuilder.DropColumn(
                name: "StatusPagamentoId",
                table: "Aluno");
        }
    }
}
