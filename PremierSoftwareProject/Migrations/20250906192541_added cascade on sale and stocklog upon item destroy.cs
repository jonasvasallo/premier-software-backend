using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventoryWebApp.Migrations
{
    /// <inheritdoc />
    public partial class addedcascadeonsaleandstockloguponitemdestroy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 6, 19, 25, 40, 6, DateTimeKind.Utc).AddTicks(1441));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 6, 19, 25, 40, 6, DateTimeKind.Utc).AddTicks(2363));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 6, 19, 25, 40, 6, DateTimeKind.Utc).AddTicks(2365));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 6, 19, 25, 40, 6, DateTimeKind.Utc).AddTicks(2366));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 6, 19, 25, 40, 6, DateTimeKind.Utc).AddTicks(2367));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 1,
                column: "PurchaseDate",
                value: new DateTime(2025, 8, 27, 19, 25, 40, 6, DateTimeKind.Utc).AddTicks(6447));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 2,
                column: "PurchaseDate",
                value: new DateTime(2025, 8, 29, 19, 25, 40, 6, DateTimeKind.Utc).AddTicks(6958));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 3,
                column: "PurchaseDate",
                value: new DateTime(2025, 9, 1, 19, 25, 40, 6, DateTimeKind.Utc).AddTicks(6963));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 4,
                column: "PurchaseDate",
                value: new DateTime(2025, 9, 3, 19, 25, 40, 6, DateTimeKind.Utc).AddTicks(6964));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 5,
                column: "PurchaseDate",
                value: new DateTime(2025, 9, 5, 19, 25, 40, 6, DateTimeKind.Utc).AddTicks(6966));

            migrationBuilder.CreateIndex(
                name: "IX_StockLogs_ItemId",
                table: "StockLogs",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_ItemId",
                table: "Sales",
                column: "ItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_Items_ItemId",
                table: "Sales",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StockLogs_Items_ItemId",
                table: "StockLogs",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Items_ItemId",
                table: "Sales");

            migrationBuilder.DropForeignKey(
                name: "FK_StockLogs_Items_ItemId",
                table: "StockLogs");

            migrationBuilder.DropIndex(
                name: "IX_StockLogs_ItemId",
                table: "StockLogs");

            migrationBuilder.DropIndex(
                name: "IX_Sales_ItemId",
                table: "Sales");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 6, 16, 35, 50, 623, DateTimeKind.Utc).AddTicks(7826));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 6, 16, 35, 50, 623, DateTimeKind.Utc).AddTicks(8707));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 6, 16, 35, 50, 623, DateTimeKind.Utc).AddTicks(8708));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 6, 16, 35, 50, 623, DateTimeKind.Utc).AddTicks(8710));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 6, 16, 35, 50, 623, DateTimeKind.Utc).AddTicks(8711));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 1,
                column: "PurchaseDate",
                value: new DateTime(2025, 8, 27, 16, 35, 50, 624, DateTimeKind.Utc).AddTicks(3438));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 2,
                column: "PurchaseDate",
                value: new DateTime(2025, 8, 29, 16, 35, 50, 624, DateTimeKind.Utc).AddTicks(4155));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 3,
                column: "PurchaseDate",
                value: new DateTime(2025, 9, 1, 16, 35, 50, 624, DateTimeKind.Utc).AddTicks(4161));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 4,
                column: "PurchaseDate",
                value: new DateTime(2025, 9, 3, 16, 35, 50, 624, DateTimeKind.Utc).AddTicks(4162));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 5,
                column: "PurchaseDate",
                value: new DateTime(2025, 9, 5, 16, 35, 50, 624, DateTimeKind.Utc).AddTicks(4164));
        }
    }
}
