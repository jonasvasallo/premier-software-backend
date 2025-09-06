using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventoryWebApp.Migrations
{
    /// <inheritdoc />
    public partial class removedcascadeonsale : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Items_ItemId",
                table: "Sales");

            migrationBuilder.DropIndex(
                name: "IX_Sales_ItemId",
                table: "Sales");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 6, 19, 28, 42, 631, DateTimeKind.Utc).AddTicks(5499));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 6, 19, 28, 42, 631, DateTimeKind.Utc).AddTicks(6492));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 6, 19, 28, 42, 631, DateTimeKind.Utc).AddTicks(6495));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 6, 19, 28, 42, 631, DateTimeKind.Utc).AddTicks(6496));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 6, 19, 28, 42, 631, DateTimeKind.Utc).AddTicks(6497));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 1,
                column: "PurchaseDate",
                value: new DateTime(2025, 8, 27, 19, 28, 42, 632, DateTimeKind.Utc).AddTicks(715));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 2,
                column: "PurchaseDate",
                value: new DateTime(2025, 8, 29, 19, 28, 42, 632, DateTimeKind.Utc).AddTicks(1238));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 3,
                column: "PurchaseDate",
                value: new DateTime(2025, 9, 1, 19, 28, 42, 632, DateTimeKind.Utc).AddTicks(1244));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 4,
                column: "PurchaseDate",
                value: new DateTime(2025, 9, 3, 19, 28, 42, 632, DateTimeKind.Utc).AddTicks(1245));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 5,
                column: "PurchaseDate",
                value: new DateTime(2025, 9, 5, 19, 28, 42, 632, DateTimeKind.Utc).AddTicks(1246));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
