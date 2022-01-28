using Microsoft.EntityFrameworkCore.Migrations;

namespace modeloDB.Migrations
{
    public partial class Inicio2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Precio",
                table: "Presupuestos",
                newName: "PrecioP");

            migrationBuilder.RenameColumn(
                name: "Distribuidor",
                table: "Presupuestos",
                newName: "DistribuidorP");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PrecioP",
                table: "Presupuestos",
                newName: "Precio");

            migrationBuilder.RenameColumn(
                name: "DistribuidorP",
                table: "Presupuestos",
                newName: "Distribuidor");
        }
    }
}
