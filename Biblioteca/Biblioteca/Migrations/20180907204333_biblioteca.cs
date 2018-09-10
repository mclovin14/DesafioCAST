using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Biblioteca.Migrations
{
    public partial class biblioteca : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "biblioteca");

            migrationBuilder.CreateTable(
                name: "cliente",
                schema: "biblioteca",
                columns: table => new
                {
                    id_cliente = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    nm_cliente = table.Column<string>(maxLength: 100, nullable: false),
                    ra_cliente = table.Column<string>(maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cliente", x => x.id_cliente);
                });

            migrationBuilder.CreateTable(
                name: "livro",
                schema: "biblioteca",
                columns: table => new
                {
                    id_livro = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    nm_livro = table.Column<string>(maxLength: 100, nullable: false),
                    ds_livro = table.Column<string>(maxLength: 500, nullable: false),
                    st_livro = table.Column<int>(maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_livro", x => x.id_livro);
                });

            migrationBuilder.CreateTable(
                name: "emprestimo",
                schema: "biblioteca",
                columns: table => new
                {
                    id_emprestimo = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    id_cliente_emprestimo = table.Column<int>(nullable: false),
                    id_livro_emprestimo = table.Column<int>(nullable: false),
                    dt_aluguel_emprestimo = table.Column<DateTime>(nullable: false),
                    dt_entrega_emprestimo = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_emprestimo", x => x.id_emprestimo);
                    table.ForeignKey(
                        name: "FK_emprestimo_cliente_id_cliente_emprestimo",
                        column: x => x.id_cliente_emprestimo,
                        principalSchema: "biblioteca",
                        principalTable: "cliente",
                        principalColumn: "id_cliente",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_emprestimo_livro_id_livro_emprestimo",
                        column: x => x.id_livro_emprestimo,
                        principalSchema: "biblioteca",
                        principalTable: "livro",
                        principalColumn: "id_livro",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_emprestimo_id_cliente_emprestimo",
                schema: "biblioteca",
                table: "emprestimo",
                column: "id_cliente_emprestimo");

            migrationBuilder.CreateIndex(
                name: "IX_emprestimo_id_livro_emprestimo",
                schema: "biblioteca",
                table: "emprestimo",
                column: "id_livro_emprestimo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "emprestimo",
                schema: "biblioteca");

            migrationBuilder.DropTable(
                name: "cliente",
                schema: "biblioteca");

            migrationBuilder.DropTable(
                name: "livro",
                schema: "biblioteca");
        }
    }
}
