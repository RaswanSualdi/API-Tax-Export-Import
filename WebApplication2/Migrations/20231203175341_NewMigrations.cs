using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication2.Migrations
{
    /// <inheritdoc />
    public partial class NewMigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Harbors_Countries_Countryid",
                table: "Harbors");

            migrationBuilder.RenameColumn(
                name: "Countryid",
                table: "Harbors",
                newName: "countryId");

            migrationBuilder.RenameIndex(
                name: "IX_Harbors_Countryid",
                table: "Harbors",
                newName: "IX_Harbors_countryId");

            migrationBuilder.AlterColumn<int>(
                name: "countryId",
                table: "Harbors",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Harbors_Countries_countryId",
                table: "Harbors",
                column: "countryId",
                principalTable: "Countries",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Harbors_Countries_countryId",
                table: "Harbors");

            migrationBuilder.RenameColumn(
                name: "countryId",
                table: "Harbors",
                newName: "Countryid");

            migrationBuilder.RenameIndex(
                name: "IX_Harbors_countryId",
                table: "Harbors",
                newName: "IX_Harbors_Countryid");

            migrationBuilder.AlterColumn<int>(
                name: "Countryid",
                table: "Harbors",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_Harbors_Countries_Countryid",
                table: "Harbors",
                column: "Countryid",
                principalTable: "Countries",
                principalColumn: "id");
        }
    }
}
