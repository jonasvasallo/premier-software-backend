using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventoryWebApp.Migrations
{
    /// <inheritdoc />
    public partial class removedimageinmodel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Price" },
                values: new object[] { new DateTime(2025, 9, 6, 20, 36, 2, 569, DateTimeKind.Utc).AddTicks(9712), 28000.00m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Price" },
                values: new object[] { new DateTime(2025, 9, 6, 20, 36, 2, 570, DateTimeKind.Utc).AddTicks(691), 22000.00m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Price" },
                values: new object[] { new DateTime(2025, 9, 6, 20, 36, 2, 570, DateTimeKind.Utc).AddTicks(693), 899.99m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Price" },
                values: new object[] { new DateTime(2025, 9, 6, 20, 36, 2, 570, DateTimeKind.Utc).AddTicks(694), 1699.00m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Price" },
                values: new object[] { new DateTime(2025, 9, 6, 20, 36, 2, 570, DateTimeKind.Utc).AddTicks(696), 489.99m });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 1,
                column: "PurchaseDate",
                value: new DateTime(2025, 8, 27, 20, 36, 2, 570, DateTimeKind.Utc).AddTicks(5583));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 2,
                column: "PurchaseDate",
                value: new DateTime(2025, 8, 29, 20, 36, 2, 570, DateTimeKind.Utc).AddTicks(6121));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 3,
                column: "PurchaseDate",
                value: new DateTime(2025, 9, 1, 20, 36, 2, 570, DateTimeKind.Utc).AddTicks(6127));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 4,
                column: "PurchaseDate",
                value: new DateTime(2025, 9, 3, 20, 36, 2, 570, DateTimeKind.Utc).AddTicks(6128));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 5,
                column: "PurchaseDate",
                value: new DateTime(2025, 9, 5, 20, 36, 2, 570, DateTimeKind.Utc).AddTicks(6129));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Price" },
                values: new object[] { new DateTime(2025, 9, 6, 19, 28, 42, 631, DateTimeKind.Utc).AddTicks(5499), 1200.00m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Price" },
                values: new object[] { new DateTime(2025, 9, 6, 19, 28, 42, 631, DateTimeKind.Utc).AddTicks(6492), 800.00m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Price" },
                values: new object[] { new DateTime(2025, 9, 6, 19, 28, 42, 631, DateTimeKind.Utc).AddTicks(6495), 199.99m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Price" },
                values: new object[] { new DateTime(2025, 9, 6, 19, 28, 42, 631, DateTimeKind.Utc).AddTicks(6496), 150.00m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Price" },
                values: new object[] { new DateTime(2025, 9, 6, 19, 28, 42, 631, DateTimeKind.Utc).AddTicks(6497), 89.99m });

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
    }
}
