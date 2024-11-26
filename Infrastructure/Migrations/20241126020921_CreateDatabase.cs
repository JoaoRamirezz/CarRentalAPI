using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class CreateDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    CategoriaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Categori__F353C1E5ACF1952A", x => x.CategoriaId);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    ClienteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Cpf = table.Column<string>(type: "varchar(11)", unicode: false, maxLength: 11, nullable: true),
                    Endereco = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    Telefone = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    Email = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Cliente__71ABD087D410F494", x => x.ClienteId);
                });

            migrationBuilder.CreateTable(
                name: "Funcionario",
                columns: table => new
                {
                    FuncionarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Cpf = table.Column<string>(type: "varchar(11)", unicode: false, maxLength: 11, nullable: true),
                    Cargo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Telefone = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Funciona__297ECCAAF8D468AE", x => x.FuncionarioId);
                });

            migrationBuilder.CreateTable(
                name: "Carro",
                columns: table => new
                {
                    Carro_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoriaId = table.Column<int>(type: "int", nullable: false),
                    Placa = table.Column<string>(type: "varchar(7)", unicode: false, maxLength: 7, nullable: true),
                    Modelo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Fabricante = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Ano = table.Column<int>(type: "int", unicode: false, maxLength: 7, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Carro__6467B009831ED7AB", x => x.Carro_id);
                    table.ForeignKey(
                        name: "FK__Carro__Categoria__4F7CD00D",
                        column: x => x.CategoriaId,
                        principalTable: "Categoria",
                        principalColumn: "CategoriaId");
                });

            migrationBuilder.CreateTable(
                name: "Reserva",
                columns: table => new
                {
                    ReservaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClienteId = table.Column<int>(type: "int", nullable: false),
                    Carro_Id = table.Column<int>(type: "int", nullable: false),
                    Data_inicio = table.Column<DateTime>(type: "datetime", nullable: false),
                    Data_fim = table.Column<DateTime>(type: "datetime", nullable: false),
                    Status = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Reserva__C399376365B93271", x => x.ReservaId);
                    table.ForeignKey(
                        name: "FK__Reserva__Carro_i__534D60F1",
                        column: x => x.Carro_Id,
                        principalTable: "Carro",
                        principalColumn: "Carro_id");
                    table.ForeignKey(
                        name: "FK__Reserva__Cliente__52593CB8",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "ClienteId");
                });

            migrationBuilder.CreateTable(
                name: "Locacao",
                columns: table => new
                {
                    LocacaoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReservaId = table.Column<int>(type: "int", nullable: false),
                    ClienteId = table.Column<int>(type: "int", nullable: false),
                    Carro_id = table.Column<int>(type: "int", nullable: false),
                    FuncionarioId = table.Column<int>(type: "int", nullable: false),
                    DataRetirada = table.Column<DateTime>(type: "datetime", nullable: false),
                    DataDevolucao = table.Column<DateTime>(type: "datetime", nullable: false),
                    ValorTotal = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Status = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Locacao__31DA8772AB53BD5A", x => x.LocacaoId);
                    table.ForeignKey(
                        name: "FK__Locacao__Carro_i__5812160E",
                        column: x => x.Carro_id,
                        principalTable: "Carro",
                        principalColumn: "Carro_id");
                    table.ForeignKey(
                        name: "FK__Locacao__Cliente__571DF1D5",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "ClienteId");
                    table.ForeignKey(
                        name: "FK__Locacao__Funcion__59063A47",
                        column: x => x.FuncionarioId,
                        principalTable: "Funcionario",
                        principalColumn: "FuncionarioId");
                    table.ForeignKey(
                        name: "FK__Locacao__Reserva__5629CD9C",
                        column: x => x.ReservaId,
                        principalTable: "Reserva",
                        principalColumn: "ReservaId");
                });

            migrationBuilder.CreateTable(
                name: "Pagamento",
                columns: table => new
                {
                    PagamentoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocacaoId = table.Column<int>(type: "int", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime", nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    Metodo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Status = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Pagament__977DE7F3FD4262ED", x => x.PagamentoId);
                    table.ForeignKey(
                        name: "FK__Pagamento__Locac__5BE2A6F2",
                        column: x => x.LocacaoId,
                        principalTable: "Locacao",
                        principalColumn: "LocacaoId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Carro_CategoriaId",
                table: "Carro",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Locacao_Carro_id",
                table: "Locacao",
                column: "Carro_id");

            migrationBuilder.CreateIndex(
                name: "IX_Locacao_ClienteId",
                table: "Locacao",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Locacao_FuncionarioId",
                table: "Locacao",
                column: "FuncionarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Locacao_ReservaId",
                table: "Locacao",
                column: "ReservaId");

            migrationBuilder.CreateIndex(
                name: "IX_Pagamento_LocacaoId",
                table: "Pagamento",
                column: "LocacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Reserva_Carro_Id",
                table: "Reserva",
                column: "Carro_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Reserva_ClienteId",
                table: "Reserva",
                column: "ClienteId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pagamento");

            migrationBuilder.DropTable(
                name: "Locacao");

            migrationBuilder.DropTable(
                name: "Funcionario");

            migrationBuilder.DropTable(
                name: "Reserva");

            migrationBuilder.DropTable(
                name: "Carro");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Categoria");
        }
    }
}
