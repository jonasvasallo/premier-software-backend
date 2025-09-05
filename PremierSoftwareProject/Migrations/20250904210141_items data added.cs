using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InventoryWebApp.Migrations
{
    /// <inheritdoc />
    public partial class itemsdataadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "Price", "Quantity", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 9, 4, 21, 1, 40, 266, DateTimeKind.Utc).AddTicks(882), "this is motorcycle by cfmoto", "CFMOTO 450SR", 299000m, 69, null },
                    { 2, new DateTime(2025, 9, 4, 21, 1, 40, 266, DateTimeKind.Utc).AddTicks(1761), "this is motorcycle by Kawasaki", "Ninja 400", 318000m, 23, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
