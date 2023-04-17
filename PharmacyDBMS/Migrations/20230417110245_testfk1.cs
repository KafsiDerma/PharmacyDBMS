using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharmacyDBMS.Migrations
{
    /// <inheritdoc />
    public partial class testfk1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProductID",
                table: "Prescriptions",
                newName: "productID");

            migrationBuilder.RenameColumn(
                name: "PatientID",
                table: "Prescriptions",
                newName: "HealthCardNum");

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 3440,
                column: "HashedPassword",
                value: "$2a$10$ULF8clO0RMnwmU603Z3icusrB5Iic8ETz4K4EyKu74gZqOTOtFVDW");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "productID",
                table: "Prescriptions",
                newName: "ProductID");

            migrationBuilder.RenameColumn(
                name: "HealthCardNum",
                table: "Prescriptions",
                newName: "PatientID");

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 3440,
                column: "HashedPassword",
                value: "$2a$10$smlxhs8vnufanq0P4KZVbOOMmJoKBQez8qDwbzaTvUsk1QDe4Aixq");
        }
    }
}
