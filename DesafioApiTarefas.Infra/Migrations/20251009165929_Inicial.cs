using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DesafioApiTarefas.Infra.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TAREFAS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TITULO = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DESCRICAO = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DATA_CRIACAO = table.Column<DateTime>(type: "datetime2", nullable: false),
                    STATUS = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TAREFAS", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TAREFAS");
        }
    }
}
