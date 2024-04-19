using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ParqueDeDiversaoAPI.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Migration01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Logins",
                columns: table => new
                {
                    codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    usuario = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    senha = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    isAdmin = table.Column<bool>(type: "bit", nullable: true),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logins", x => x.codigo);
                });

            migrationBuilder.CreateTable(
                name: "Setores",
                columns: table => new
                {
                    codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descricaoSetor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    valorLiquidoArrecadado = table.Column<double>(type: "float(5)", precision: 5, scale: 2, nullable: true),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Setores", x => x.codigo);
                });

            migrationBuilder.CreateTable(
                name: "Atracoes",
                columns: table => new
                {
                    codigo = table.Column<int>(type: "int", nullable: false),
                    descricaoAtracao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    valorLiquidoArrecadado = table.Column<double>(type: "float(8)", precision: 8, scale: 2, nullable: true),
                    valorBrutoArrecadado = table.Column<double>(type: "float(8)", precision: 8, scale: 2, nullable: true),
                    valorCustoDeManutencao = table.Column<double>(type: "float(12)", precision: 12, scale: 2, nullable: true),
                    aberto = table.Column<bool>(type: "bit", nullable: true),
                    entradasVendidas = table.Column<int>(type: "int", nullable: true),
                    custoDeEntrada = table.Column<double>(type: "float(12)", precision: 12, scale: 2, nullable: true),
                    setorCodigo = table.Column<int>(type: "int", nullable: false),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Atracoes", x => x.codigo);
                    table.ForeignKey(
                        name: "FK_Atracoes_Setores_codigo",
                        column: x => x.codigo,
                        principalTable: "Setores",
                        principalColumn: "codigo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Barraquinhas",
                columns: table => new
                {
                    codigo = table.Column<int>(type: "int", nullable: false),
                    descricaoBarraquinha = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    valorLiquidoArrecadado = table.Column<double>(type: "float(8)", precision: 8, scale: 2, nullable: true),
                    valorBrutoArrecadado = table.Column<double>(type: "float(8)", precision: 8, scale: 2, nullable: true),
                    valorCustoDeOperacao = table.Column<double>(type: "float(8)", precision: 8, scale: 2, nullable: true),
                    aberto = table.Column<bool>(type: "bit", nullable: true),
                    setorCodigo = table.Column<int>(type: "int", nullable: false),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Barraquinhas", x => x.codigo);
                    table.ForeignKey(
                        name: "FK_Barraquinhas_Setores_codigo",
                        column: x => x.codigo,
                        principalTable: "Setores",
                        principalColumn: "codigo",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Atracoes");

            migrationBuilder.DropTable(
                name: "Barraquinhas");

            migrationBuilder.DropTable(
                name: "Logins");

            migrationBuilder.DropTable(
                name: "Setores");
        }
    }
}
