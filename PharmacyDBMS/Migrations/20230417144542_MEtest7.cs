using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharmacyDBMS.Migrations
{
    /// <inheritdoc />
    public partial class MEtest7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prescriptions_Products_ProductID",
                table: "Prescriptions");

            migrationBuilder.RenameColumn(
                name: "ProductID",
                table: "Prescriptions",
                newName: "Product");

            migrationBuilder.RenameIndex(
                name: "IX_Prescriptions_ProductID",
                table: "Prescriptions",
                newName: "IX_Prescriptions_Product");

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 3440,
                column: "HashedPassword",
                value: "$2a$10$wlZxyqXctTc5gYLNfiblSOMphVximB14WX/Nwr9VKV75mutV0Zbtm");

            migrationBuilder.AddForeignKey(
                name: "FK_Prescriptions_Products_Product",
                table: "Prescriptions",
                column: "Product",
                principalTable: "Products",
                principalColumn: "productID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prescriptions_Products_Product",
                table: "Prescriptions");

            migrationBuilder.RenameColumn(
                name: "Product",
                table: "Prescriptions",
                newName: "ProductID");

            migrationBuilder.RenameIndex(
                name: "IX_Prescriptions_Product",
                table: "Prescriptions",
                newName: "IX_Prescriptions_ProductID");

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 3440,
                column: "HashedPassword",
                value: "$2a$10$5AQFQk6meAoRlV2MLo4X2OCKEXkiIxzeUCebc3.tTFNWWLEr.lfTa");

            migrationBuilder.AddForeignKey(
                name: "FK_Prescriptions_Products_ProductID",
                table: "Prescriptions",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "productID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
