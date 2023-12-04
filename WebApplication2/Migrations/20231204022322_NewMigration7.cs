using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication2.Migrations
{
    /// <inheritdoc />
    public partial class NewMigration7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "id", "code", "name" },
                values: new object[,]
                {
                    { 1, "ID", "Indonesia" },
                    { 2, "SG", "Singapore" },
                    { 3, "MY", "Malaysia" },
                    { 4, "TH", "Thailand" },
                    { 5, "VN", "Vietnam" }
                });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "id", "code", "price", "tariff", "tariffPrice" },
                values: new object[,]
                {
                    { 1, "T001", null, 10.0m, null },
                    { 2, "T002", null, 20.2m, null },
                    { 3, "T003", null, 0.15m, null }
                });

            migrationBuilder.InsertData(
                table: "Harbors",
                columns: new[] { "id", "code", "countryId", "name" },
                values: new object[,]
                {
                    { 1, "MAK", 1, "Makassar" },
                    { 2, "BIT", 1, "Bitung" },
                    { 3, "JUR", 2, "Jurong" },
                    { 4, "KLA", 3, "Klang" },
                    { 5, "BAN", 4, "Bangkok" },
                    { 6, "HAI", 5, "Hai Phong" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "id", "Countryid", "TransactionId", "name" },
                values: new object[,]
                {
                    { 1, null, 1, "Product1" },
                    { 2, null, 1, "Product2" },
                    { 3, null, 2, "Product3" },
                    { 4, null, 2, "Product4" },
                    { 5, null, 3, "Product5" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Harbors",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Harbors",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Harbors",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Harbors",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Harbors",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Harbors",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "id",
                keyValue: 3);
        }
    }
}
