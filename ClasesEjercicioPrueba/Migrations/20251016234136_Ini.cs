using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClasesModelo.Migrations
{
    /// <inheritdoc />
    public partial class Ini : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pedidos");

            migrationBuilder.RenameColumn(
                name: "Subtotal",
                table: "DetallePedidos",
                newName: "Total");

            migrationBuilder.RenameColumn(
                name: "IdPedido",
                table: "DetallePedidos",
                newName: "IdCliente");

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaPedido",
                table: "DetallePedidos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FechaPedido",
                table: "DetallePedidos");

            migrationBuilder.RenameColumn(
                name: "Total",
                table: "DetallePedidos",
                newName: "Subtotal");

            migrationBuilder.RenameColumn(
                name: "IdCliente",
                table: "DetallePedidos",
                newName: "IdPedido");

            migrationBuilder.CreateTable(
                name: "Pedidos",
                columns: table => new
                {
                    IdPedido = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaPedido = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdCliente = table.Column<int>(type: "int", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedidos", x => x.IdPedido);
                });
        }
    }
}
