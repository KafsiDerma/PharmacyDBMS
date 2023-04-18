using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharmacyDBMS.Migrations
{
    /// <inheritdoc />
    public partial class fuckyou : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prescriptions_Products_Product",
                table: "Prescriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_Prescriptions_only_Products_ProductId",
                table: "Prescriptions_only");

            migrationBuilder.DropForeignKey(
                name: "FK_Suppliers_Products_productID",
                table: "Suppliers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Product");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product",
                table: "Product",
                column: "productID");

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 3440,
                column: "HashedPassword",
                value: "$2a$10$to2dc7ctWTepTm2FWQFQG.vInn3nKKKIYO9HNBi8lZJQrtZKfocce");

            migrationBuilder.AddForeignKey(
                name: "FK_Prescriptions_Product_Product",
                table: "Prescriptions",
                column: "Product",
                principalTable: "Product",
                principalColumn: "productID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Prescriptions_only_Product_ProductId",
                table: "Prescriptions_only",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "productID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Suppliers_Product_productID",
                table: "Suppliers",
                column: "productID",
                principalTable: "Product",
                principalColumn: "productID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prescriptions_Product_Product",
                table: "Prescriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_Prescriptions_only_Product_ProductId",
                table: "Prescriptions_only");

            migrationBuilder.DropForeignKey(
                name: "FK_Suppliers_Product_productID",
                table: "Suppliers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product",
                table: "Product");

            migrationBuilder.RenameTable(
                name: "Product",
                newName: "Products");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "productID");

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 3440,
                column: "HashedPassword",
                value: "$2a$10$K8Cvp3V4KOPz6EtiRlgSd.y0duOFP6eiRMzmP0wfuAXiZBwo5KWEC");

            migrationBuilder.AddForeignKey(
                name: "FK_Prescriptions_Products_Product",
                table: "Prescriptions",
                column: "Product",
                principalTable: "Products",
                principalColumn: "productID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Prescriptions_only_Products_ProductId",
                table: "Prescriptions_only",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "productID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Suppliers_Products_productID",
                table: "Suppliers",
                column: "productID",
                principalTable: "Products",
                principalColumn: "productID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
