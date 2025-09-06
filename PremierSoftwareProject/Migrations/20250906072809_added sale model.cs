using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventoryWebApp.Migrations
{
    /// <inheritdoc />
    public partial class addedsalemodel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "Items",
                newName: "Stock");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 6, 7, 28, 7, 884, DateTimeKind.Utc).AddTicks(4775));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 6, 7, 28, 7, 884, DateTimeKind.Utc).AddTicks(5668));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Stock",
                table: "Items",
                newName: "Quantity");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 4, 21, 1, 40, 266, DateTimeKind.Utc).AddTicks(882));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 4, 21, 1, 40, 266, DateTimeKind.Utc).AddTicks(1761));
        }
    }
}
