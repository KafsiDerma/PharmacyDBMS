using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharmacyDBMS.Migrations
{
    /// <inheritdoc />
    public partial class POfk4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "prescription_onlyproductID",
                table: "Products",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 3440,
                column: "HashedPassword",
                value: "$2a$10$InOh2KTTJ7uXxvXr3HCX3erlB2kJk5/cj3nIuNHQEFWhhT960jRwq");

            migrationBuilder.CreateIndex(
                name: "IX_Products_prescription_onlyproductID",
                table: "Products",
                column: "prescription_onlyproductID");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Prescriptions_only_prescription_onlyproductID",
                table: "Products",
                column: "prescription_onlyproductID",
                principalTable: "Prescriptions_only",
                principalColumn: "productID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Prescriptions_only_prescription_onlyproductID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_prescription_onlyproductID",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "prescription_onlyproductID",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 3440,
                column: "HashedPassword",
                value: "$2a$10$fCuumwqdvLS0igXISp2PueGg6Vtc2u7vK4kAORNV9GA2MkZIBqMT.");
        }
    }
}
