using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace modeloDB.Migrations
{
    public partial class Inicial5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cantidad",
                table: "Inventarios");

            migrationBuilder.DropColumn(
                name: "Libro",
                table: "Inventarios");

            migrationBuilder.DropColumn(
                name: "ConfirmacionDL",
                table: "DemandaLibrerias");

            migrationBuilder.RenameColumn(
                name: "Motivo",
                table: "Inventarios",
                newName: "Pedido");

            migrationBuilder.AddColumn<DateTime>(
                name: "InicioPedido",
                table: "Inventarios",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LimitePedido",
                table: "Inventarios",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<int>(
                name: "EstadoL",
                table: "InventarioLibros",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ConfirmacionD",
                table: "Distribuidores",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Fechas",
                table: "DemandaLibrerias",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "compras",
                columns: table => new
                {
                    CompraId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CompraEstado = table.Column<int>(type: "int", nullable: false),
                    PresupuestoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_compras", x => x.CompraId);
                    table.ForeignKey(
                        name: "FK_compras_Presupuestos_PresupuestoId",
                        column: x => x.PresupuestoId,
                        principalTable: "Presupuestos",
                        principalColumn: "PresupuestoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "configuracions",
                columns: table => new
                {
                    NombreDistribuidor = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PedidosTotales = table.Column<int>(type: "int", nullable: false),
                    DiasEntreMinimos = table.Column<int>(type: "int", nullable: false),
                    LibrosMinimos = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_configuracions", x => x.NombreDistribuidor);
                });

            migrationBuilder.CreateTable(
                name: "Evaluacions",
                columns: table => new
                {
                    EvaluacionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Calificaion = table.Column<int>(type: "int", nullable: false),
                    PresupuestoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evaluacions", x => x.EvaluacionId);
                    table.ForeignKey(
                        name: "FK_Evaluacions_Presupuestos_PresupuestoId",
                        column: x => x.PresupuestoId,
                        principalTable: "Presupuestos",
                        principalColumn: "PresupuestoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "prerequisitos",
                columns: table => new
                {
                    InventarioId = table.Column<int>(type: "int", nullable: false),
                    PresupuestoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_prerequisitos", x => new { x.InventarioId, x.PresupuestoId });
                    table.ForeignKey(
                        name: "FK_prerequisitos_Inventarios_InventarioId",
                        column: x => x.InventarioId,
                        principalTable: "Inventarios",
                        principalColumn: "InventarioId");
                    table.ForeignKey(
                        name: "FK_prerequisitos_Presupuestos_PresupuestoId",
                        column: x => x.PresupuestoId,
                        principalTable: "Presupuestos",
                        principalColumn: "PresupuestoId");
                });

            migrationBuilder.CreateTable(
                name: "registroLibros",
                columns: table => new
                {
                    RegistroLibroId = table.Column<int>(type: "int", nullable: false),
                    FechaIngreso = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Detalles = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PresupuestoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_registroLibros", x => x.RegistroLibroId);
                    table.ForeignKey(
                        name: "FK_registroLibros_Presupuestos_RegistroLibroId",
                        column: x => x.RegistroLibroId,
                        principalTable: "Presupuestos",
                        principalColumn: "PresupuestoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "reseñaLibros",
                columns: table => new
                {
                    ReseñaLibroId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Reseña = table.Column<int>(type: "int", nullable: false),
                    Detalles = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PresupuestoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reseñaLibros", x => x.ReseñaLibroId);
                    table.ForeignKey(
                        name: "FK_reseñaLibros_Presupuestos_PresupuestoId",
                        column: x => x.PresupuestoId,
                        principalTable: "Presupuestos",
                        principalColumn: "PresupuestoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_compras_PresupuestoId",
                table: "compras",
                column: "PresupuestoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Evaluacions_PresupuestoId",
                table: "Evaluacions",
                column: "PresupuestoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_prerequisitos_PresupuestoId",
                table: "prerequisitos",
                column: "PresupuestoId");

            migrationBuilder.CreateIndex(
                name: "IX_reseñaLibros_PresupuestoId",
                table: "reseñaLibros",
                column: "PresupuestoId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "compras");

            migrationBuilder.DropTable(
                name: "configuracions");

            migrationBuilder.DropTable(
                name: "Evaluacions");

            migrationBuilder.DropTable(
                name: "prerequisitos");

            migrationBuilder.DropTable(
                name: "registroLibros");

            migrationBuilder.DropTable(
                name: "reseñaLibros");

            migrationBuilder.DropColumn(
                name: "InicioPedido",
                table: "Inventarios");

            migrationBuilder.DropColumn(
                name: "LimitePedido",
                table: "Inventarios");

            migrationBuilder.RenameColumn(
                name: "Pedido",
                table: "Inventarios",
                newName: "Motivo");

            migrationBuilder.AddColumn<double>(
                name: "Cantidad",
                table: "Inventarios",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Libro",
                table: "Inventarios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EstadoL",
                table: "InventarioLibros",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ConfirmacionD",
                table: "Distribuidores",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Fechas",
                table: "DemandaLibrerias",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<string>(
                name: "ConfirmacionDL",
                table: "DemandaLibrerias",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
