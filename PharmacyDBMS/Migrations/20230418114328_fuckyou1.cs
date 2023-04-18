using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharmacyDBMS.Migrations
{
    /// <inheritdoc />
    public partial class fuckyou1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prescriptions_only_Product_ProductId",
                table: "Prescriptions_only");

            migrationBuilder.DropIndex(
                name: "IX_Prescriptions_only_ProductId",
                table: "Prescriptions_only");

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 3440,
                column: "HashedPassword",
                value: "$2a$10$jtC.ygtHJYIxuZeHdjTXn.HcibpFZBzoPi92FuLjbFMk4bd/z9e0K");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 3440,
                column: "HashedPassword",
                value: "$2a$10$to2dc7ctWTepTm2FWQFQG.vInn3nKKKIYO9HNBi8lZJQrtZKfocce");

            migrationBuilder.CreateIndex(
                name: "IX_Prescriptions_only_ProductId",
                table: "Prescriptions_only",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Prescriptions_only_Product_ProductId",
                table: "Prescriptions_only",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "productID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
