using Microsoft.EntityFrameworkCore.Migrations;

namespace modeloDB.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Presupuestos",
                columns: table => new
                {
                    PresupuestoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LibrosP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Precio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CantidadP = table.Column<double>(type: "float", nullable: false),
                    Distribuidor = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Presupuestos", x => x.PresupuestoId);
                });

            migrationBuilder.CreateTable(
                name: "DemandaLibrerias",
                columns: table => new
                {
                    DemandalibreriaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Usuario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Libro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fechas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConfirmacionDL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PresupuestoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DemandaLibrerias", x => x.DemandalibreriaId);
                    table.ForeignKey(
                        name: "FK_DemandaLibrerias_Presupuestos_PresupuestoId",
                        column: x => x.PresupuestoId,
                        principalTable: "Presupuestos",
                        principalColumn: "PresupuestoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Distribuidores",
                columns: table => new
                {
                    DistribuidoresId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LibrosD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrecioD = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Edicion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Oferta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Editoriales = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConfirmacionD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PresupuestoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Distribuidores", x => x.DistribuidoresId);
                    table.ForeignKey(
                        name: "FK_Distribuidores_Presupuestos_PresupuestoId",
                        column: x => x.PresupuestoId,
                        principalTable: "Presupuestos",
                        principalColumn: "PresupuestoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InventarioLibros",
                columns: table => new
                {
                    InventarioLibroId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InventarioL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstadoL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrecioL = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PresupuestoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventarioLibros", x => x.InventarioLibroId);
                    table.ForeignKey(
                        name: "FK_InventarioLibros_Presupuestos_PresupuestoId",
                        column: x => x.PresupuestoId,
                        principalTable: "Presupuestos",
                        principalColumn: "PresupuestoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Inventarios",
                columns: table => new
                {
                    InventarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Libro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cantidad = table.Column<double>(type: "float", nullable: false),
                    Motivo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PresupuestoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventarios", x => x.InventarioId);
                    table.ForeignKey(
                        name: "FK_Inventarios_Presupuestos_PresupuestoId",
                        column: x => x.PresupuestoId,
                        principalTable: "Presupuestos",
                        principalColumn: "PresupuestoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DemandaLibrerias_PresupuestoId",
                table: "DemandaLibrerias",
                column: "PresupuestoId");

            migrationBuilder.CreateIndex(
                name: "IX_Distribuidores_PresupuestoId",
                table: "Distribuidores",
                column: "PresupuestoId");

            migrationBuilder.CreateIndex(
                name: "IX_InventarioLibros_PresupuestoId",
                table: "InventarioLibros",
                column: "PresupuestoId");

            migrationBuilder.CreateIndex(
                name: "IX_Inventarios_PresupuestoId",
                table: "Inventarios",
                column: "PresupuestoId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DemandaLibrerias");

            migrationBuilder.DropTable(
                name: "Distribuidores");

            migrationBuilder.DropTable(
                name: "InventarioLibros");

            migrationBuilder.DropTable(
                name: "Inventarios");

            migrationBuilder.DropTable(
                name: "Presupuestos");
        }
    }
}
