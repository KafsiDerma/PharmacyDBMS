using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharmacyDBMS.Migrations
{
    /// <inheritdoc />
    public partial class POfk42 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Prescriptions_only_prescription_onlyproductID",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "prescription_onlyproductID",
                table: "Products",
                newName: "prescription_OnlyproductID");

            migrationBuilder.RenameIndex(
                name: "IX_Products_prescription_onlyproductID",
                table: "Products",
                newName: "IX_Products_prescription_OnlyproductID");

            migrationBuilder.AlterColumn<int>(
                name: "prescription_OnlyproductID",
                table: "Products",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 3440,
                column: "HashedPassword",
                value: "$2a$10$9P1cBCobSvHquNrkIFgyketmPSWLJCMbD1u3udo.EBMUGNRXHBG6K");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Prescriptions_only_prescription_OnlyproductID",
                table: "Products",
                column: "prescription_OnlyproductID",
                principalTable: "Prescriptions_only",
                principalColumn: "productID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Prescriptions_only_prescription_OnlyproductID",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "prescription_OnlyproductID",
                table: "Products",
                newName: "prescription_onlyproductID");

            migrationBuilder.RenameIndex(
                name: "IX_Products_prescription_OnlyproductID",
                table: "Products",
                newName: "IX_Products_prescription_onlyproductID");

            migrationBuilder.AlterColumn<int>(
                name: "prescription_onlyproductID",
                table: "Products",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 3440,
                column: "HashedPassword",
                value: "$2a$10$InOh2KTTJ7uXxvXr3HCX3erlB2kJk5/cj3nIuNHQEFWhhT960jRwq");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Prescriptions_only_prescription_onlyproductID",
                table: "Products",
                column: "prescription_onlyproductID",
                principalTable: "Prescriptions_only",
                principalColumn: "productID");
        }
    }
}
