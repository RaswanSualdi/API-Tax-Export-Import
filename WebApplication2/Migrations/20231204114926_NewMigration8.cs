using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication2.Migrations
{
    /// <inheritdoc />
    public partial class NewMigration8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "id",
                keyValue: 1,
                column: "code",
                value: "10079000");

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "id",
                keyValue: 2,
                column: "code",
                value: "10079001");

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "code", "tariff" },
                values: new object[] { "10079002", 30.0m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "id",
                keyValue: 1,
                column: "code",
                value: "T001");

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "id",
                keyValue: 2,
                column: "code",
                value: "T002");

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "code", "tariff" },
                values: new object[] { "T003", 0.15m });
        }
    }
}
