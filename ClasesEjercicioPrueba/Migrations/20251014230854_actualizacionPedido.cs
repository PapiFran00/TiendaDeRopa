using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClasesModelo.Migrations
{
    /// <inheritdoc />
    public partial class actualizacionPedido : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Pedidos_PedidoIdPedido",
                table: "Productos");

            migrationBuilder.DropIndex(
                name: "IX_Productos_PedidoIdPedido",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "PedidoIdPedido",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "Cantidad",
                table: "Pedidos");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PedidoIdPedido",
                table: "Productos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Cantidad",
                table: "Pedidos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Productos_PedidoIdPedido",
                table: "Productos",
                column: "PedidoIdPedido");

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Pedidos_PedidoIdPedido",
                table: "Productos",
                column: "PedidoIdPedido",
                principalTable: "Pedidos",
                principalColumn: "IdPedido");
        }
    }
}
