using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventoryWebApp.Migrations
{
    /// <inheritdoc />
    public partial class addedmissingsellingprice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 6, 20, 44, 47, 786, DateTimeKind.Utc).AddTicks(7141));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 6, 20, 44, 47, 786, DateTimeKind.Utc).AddTicks(8134));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 6, 20, 44, 47, 786, DateTimeKind.Utc).AddTicks(8136));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 6, 20, 44, 47, 786, DateTimeKind.Utc).AddTicks(8138));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 6, 20, 44, 47, 786, DateTimeKind.Utc).AddTicks(8139));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PurchaseDate", "SellingPrice" },
                values: new object[] { new DateTime(2025, 8, 27, 20, 44, 47, 787, DateTimeKind.Utc).AddTicks(2360), 28000.00m });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PurchaseDate", "SellingPrice" },
                values: new object[] { new DateTime(2025, 8, 29, 20, 44, 47, 787, DateTimeKind.Utc).AddTicks(3044), 22000.00m });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PurchaseDate", "SellingPrice" },
                values: new object[] { new DateTime(2025, 9, 1, 20, 44, 47, 787, DateTimeKind.Utc).AddTicks(3050), 899.99m });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PurchaseDate", "SellingPrice" },
                values: new object[] { new DateTime(2025, 9, 3, 20, 44, 47, 787, DateTimeKind.Utc).AddTicks(3052), 1699.00m });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PurchaseDate", "SellingPrice" },
                values: new object[] { new DateTime(2025, 9, 5, 20, 44, 47, 787, DateTimeKind.Utc).AddTicks(3053), 489.99m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 6, 20, 36, 2, 569, DateTimeKind.Utc).AddTicks(9712));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 6, 20, 36, 2, 570, DateTimeKind.Utc).AddTicks(691));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 6, 20, 36, 2, 570, DateTimeKind.Utc).AddTicks(693));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 6, 20, 36, 2, 570, DateTimeKind.Utc).AddTicks(694));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 6, 20, 36, 2, 570, DateTimeKind.Utc).AddTicks(696));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PurchaseDate", "SellingPrice" },
                values: new object[] { new DateTime(2025, 8, 27, 20, 36, 2, 570, DateTimeKind.Utc).AddTicks(5583), 0m });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PurchaseDate", "SellingPrice" },
                values: new object[] { new DateTime(2025, 8, 29, 20, 36, 2, 570, DateTimeKind.Utc).AddTicks(6121), 0m });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PurchaseDate", "SellingPrice" },
                values: new object[] { new DateTime(2025, 9, 1, 20, 36, 2, 570, DateTimeKind.Utc).AddTicks(6127), 0m });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PurchaseDate", "SellingPrice" },
                values: new object[] { new DateTime(2025, 9, 3, 20, 36, 2, 570, DateTimeKind.Utc).AddTicks(6128), 0m });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PurchaseDate", "SellingPrice" },
                values: new object[] { new DateTime(2025, 9, 5, 20, 36, 2, 570, DateTimeKind.Utc).AddTicks(6129), 0m });
        }
    }
}
