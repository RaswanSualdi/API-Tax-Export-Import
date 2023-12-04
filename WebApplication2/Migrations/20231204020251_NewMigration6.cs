using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication2.Migrations
{
    /// <inheritdoc />
    public partial class NewMigration6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Transactions_Transactionid",
                table: "Products");

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

            migrationBuilder.RenameColumn(
                name: "Transactionid",
                table: "Products",
                newName: "TransactionId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_Transactionid",
                table: "Products",
                newName: "IX_Products_TransactionId");

            migrationBuilder.AlterColumn<int>(
                name: "TransactionId",
                table: "Products",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Transactions_TransactionId",
                table: "Products",
                column: "TransactionId",
                principalTable: "Transactions",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Transactions_TransactionId",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "TransactionId",
                table: "Products",
                newName: "Transactionid");

            migrationBuilder.RenameIndex(
                name: "IX_Products_TransactionId",
                table: "Products",
                newName: "IX_Products_Transactionid");

            migrationBuilder.AlterColumn<int>(
                name: "Transactionid",
                table: "Products",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

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
                table: "Products",
                columns: new[] { "id", "Countryid", "Transactionid", "name" },
                values: new object[,]
                {
                    { 1, null, null, "Product1" },
                    { 2, null, null, "Product2" },
                    { 3, null, null, "Product3" },
                    { 4, null, null, "Product4" },
                    { 5, null, null, "Product5" }
                });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "id", "code", "price", "tariff", "tariffPrice" },
                values: new object[,]
                {
                    { 1, "T001", null, 0.1m, null },
                    { 2, "T002", null, 0.2m, null },
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

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Transactions_Transactionid",
                table: "Products",
                column: "Transactionid",
                principalTable: "Transactions",
                principalColumn: "id");
        }
    }
}
