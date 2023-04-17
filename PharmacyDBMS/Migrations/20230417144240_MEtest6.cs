using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharmacyDBMS.Migrations
{
    /// <inheritdoc />
    public partial class MEtest6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 3440,
                column: "HashedPassword",
                value: "$2a$10$5AQFQk6meAoRlV2MLo4X2OCKEXkiIxzeUCebc3.tTFNWWLEr.lfTa");

            migrationBuilder.CreateIndex(
                name: "IX_Suppliers_productID",
                table: "Suppliers",
                column: "productID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Suppliers_Products_productID",
                table: "Suppliers",
                column: "productID",
                principalTable: "Products",
                principalColumn: "productID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Suppliers_Products_productID",
                table: "Suppliers");

            migrationBuilder.DropIndex(
                name: "IX_Suppliers_productID",
                table: "Suppliers");

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 3440,
                column: "HashedPassword",
                value: "$2a$10$6EynzE9N7YucthQwTH7DY.GaFrZJYQTGeE6.QeVpzEFpRVM8DqLbW");
        }
    }
}
