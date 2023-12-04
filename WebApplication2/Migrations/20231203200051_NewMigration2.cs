using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace WebApplication2.Migrations
{
    /// <inheritdoc />
    public partial class NewMigration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomsDuties");

            migrationBuilder.DropColumn(
                name: "code",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "Transactionid",
                table: "Products",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code = table.Column<string>(type: "text", nullable: false),
                    tariff = table.Column<decimal>(type: "numeric", nullable: false),
                    price = table.Column<long>(type: "bigint", nullable: false),
                    finalPrice = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_Transactionid",
                table: "Products",
                column: "Transactionid");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Transactions_Transactionid",
                table: "Products",
                column: "Transactionid",
                principalTable: "Transactions",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Transactions_Transactionid",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_Products_Transactionid",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Transactionid",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "code",
                table: "Products",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "CustomsDuties",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Harborid = table.Column<int>(type: "integer", nullable: false),
                    Productid = table.Column<int>(type: "integer", nullable: false),
                    price = table.Column<long>(type: "bigint", nullable: false),
                    tariff = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomsDuties", x => x.id);
                    table.ForeignKey(
                        name: "FK_CustomsDuties_Harbors_Harborid",
                        column: x => x.Harborid,
                        principalTable: "Harbors",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomsDuties_Products_Productid",
                        column: x => x.Productid,
                        principalTable: "Products",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomsDuties_Harborid",
                table: "CustomsDuties",
                column: "Harborid");

            migrationBuilder.CreateIndex(
                name: "IX_CustomsDuties_Productid",
                table: "CustomsDuties",
                column: "Productid");
        }
    }
}
