using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharmacyDBMS.Migrations
{
    /// <inheritdoc />
    public partial class MEtest3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 3440,
                column: "HashedPassword",
                value: "$2a$10$2eK4MT9qQwVdl6/xMofVru2q9i0bz26MdCN6DUVzFoU4KjBXIbx6u");

            migrationBuilder.CreateIndex(
                name: "IX_Prescriptions_ProductID",
                table: "Prescriptions",
                column: "ProductID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Prescriptions_Products_ProductID",
                table: "Prescriptions",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "productID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prescriptions_Products_ProductID",
                table: "Prescriptions");

            migrationBuilder.DropIndex(
                name: "IX_Prescriptions_ProductID",
                table: "Prescriptions");

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 3440,
                column: "HashedPassword",
                value: "$2a$10$stXaMTx0oLm0x0iNa3R6Eu1vVreHgZ/KyY6UKED2CzB72yFiKWR.K");
        }
    }
}
