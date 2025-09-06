using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InventoryWebApp.Migrations
{
    /// <inheritdoc />
    public partial class addedseedersforsalesanditems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Description", "Name", "Price", "Stock" },
                values: new object[] { new DateTime(2025, 9, 6, 7, 41, 1, 190, DateTimeKind.Utc).AddTicks(9562), "High performance laptop for developers", "Laptop", 1200.00m, 10 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Description", "Name", "Price", "Stock" },
                values: new object[] { new DateTime(2025, 9, 6, 7, 41, 1, 191, DateTimeKind.Utc).AddTicks(439), "Latest generation flagship smartphone", "Smartphone", 800.00m, 25 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "Price", "Stock", "UpdatedAt" },
                values: new object[,]
                {
                    { 3, new DateTime(2025, 9, 6, 7, 41, 1, 191, DateTimeKind.Utc).AddTicks(441), "Noise-cancelling over-ear headphones", "Headphones", 199.99m, 50, null },
                    { 4, new DateTime(2025, 9, 6, 7, 41, 1, 191, DateTimeKind.Utc).AddTicks(442), "RGB backlit mechanical keyboard with blue switches", "Mechanical Keyboard", 150.00m, 15, null },
                    { 5, new DateTime(2025, 9, 6, 7, 41, 1, 191, DateTimeKind.Utc).AddTicks(444), "High DPI wireless gaming mouse", "Gaming Mouse", 89.99m, 30, null }
                });

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "Id", "ItemId", "PurchaseDate", "UnitsSold" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 8, 27, 7, 41, 1, 191, DateTimeKind.Utc).AddTicks(4934), 2 },
                    { 2, 2, new DateTime(2025, 8, 29, 7, 41, 1, 191, DateTimeKind.Utc).AddTicks(5539), 1 },
                    { 3, 3, new DateTime(2025, 9, 1, 7, 41, 1, 191, DateTimeKind.Utc).AddTicks(5545), 3 },
                    { 4, 4, new DateTime(2025, 9, 3, 7, 41, 1, 191, DateTimeKind.Utc).AddTicks(5546), 1 },
                    { 5, 5, new DateTime(2025, 9, 5, 7, 41, 1, 191, DateTimeKind.Utc).AddTicks(5547), 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Description", "Name", "Price", "Stock" },
                values: new object[] { new DateTime(2025, 9, 6, 7, 35, 7, 21, DateTimeKind.Utc).AddTicks(9910), "this is motorcycle by cfmoto", "CFMOTO 450SR", 299000m, 69 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Description", "Name", "Price", "Stock" },
                values: new object[] { new DateTime(2025, 9, 6, 7, 35, 7, 22, DateTimeKind.Utc).AddTicks(945), "this is motorcycle by Kawasaki", "Ninja 400", 318000m, 23 });
        }
    }
}
