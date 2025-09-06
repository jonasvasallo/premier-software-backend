using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventoryWebApp.Migrations
{
    /// <inheritdoc />
    public partial class addedsellingpricefieldtosales : Migration
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

            migrationBuilder.AddColumn<decimal>(
                name: "SellingPrice",
                table: "Sales",
                type: "decimal(65,30)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 6, 13, 34, 28, 167, DateTimeKind.Utc).AddTicks(5958));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 6, 13, 34, 28, 167, DateTimeKind.Utc).AddTicks(6841));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 6, 13, 34, 28, 167, DateTimeKind.Utc).AddTicks(6843));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 6, 13, 34, 28, 167, DateTimeKind.Utc).AddTicks(6844));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 6, 13, 34, 28, 167, DateTimeKind.Utc).AddTicks(6845));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PurchaseDate", "SellingPrice" },
                values: new object[] { new DateTime(2025, 8, 27, 13, 34, 28, 168, DateTimeKind.Utc).AddTicks(1494), 0m });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PurchaseDate", "SellingPrice" },
                values: new object[] { new DateTime(2025, 8, 29, 13, 34, 28, 168, DateTimeKind.Utc).AddTicks(2378), 0m });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PurchaseDate", "SellingPrice" },
                values: new object[] { new DateTime(2025, 9, 1, 13, 34, 28, 168, DateTimeKind.Utc).AddTicks(2384), 0m });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PurchaseDate", "SellingPrice" },
                values: new object[] { new DateTime(2025, 9, 3, 13, 34, 28, 168, DateTimeKind.Utc).AddTicks(2385), 0m });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PurchaseDate", "SellingPrice" },
                values: new object[] { new DateTime(2025, 9, 5, 13, 34, 28, 168, DateTimeKind.Utc).AddTicks(2386), 0m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SellingPrice",
                table: "Sales");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 6, 7, 41, 1, 190, DateTimeKind.Utc).AddTicks(9562));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 6, 7, 41, 1, 191, DateTimeKind.Utc).AddTicks(439));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 6, 7, 41, 1, 191, DateTimeKind.Utc).AddTicks(441));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 6, 7, 41, 1, 191, DateTimeKind.Utc).AddTicks(442));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 6, 7, 41, 1, 191, DateTimeKind.Utc).AddTicks(444));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 1,
                column: "PurchaseDate",
                value: new DateTime(2025, 8, 27, 7, 41, 1, 191, DateTimeKind.Utc).AddTicks(4934));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 2,
                column: "PurchaseDate",
                value: new DateTime(2025, 8, 29, 7, 41, 1, 191, DateTimeKind.Utc).AddTicks(5539));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 3,
                column: "PurchaseDate",
                value: new DateTime(2025, 9, 1, 7, 41, 1, 191, DateTimeKind.Utc).AddTicks(5545));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 4,
                column: "PurchaseDate",
                value: new DateTime(2025, 9, 3, 7, 41, 1, 191, DateTimeKind.Utc).AddTicks(5546));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 5,
                column: "PurchaseDate",
                value: new DateTime(2025, 9, 5, 7, 41, 1, 191, DateTimeKind.Utc).AddTicks(5547));

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
