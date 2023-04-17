using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharmacyDBMS.Migrations
{
    /// <inheritdoc />
    public partial class firstFKinpresc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DoctorMLNum",
                table: "Prescriptions",
                newName: "Medical_License");

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 3440,
                column: "HashedPassword",
                value: "$2a$10$yHBDRP7wPorZnkxK0TfWkuh.Ny.jvYIRa3/U0W2c.YUW6/w6UjYp.");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Medical_License",
                table: "Prescriptions",
                newName: "DoctorMLNum");

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 3440,
                column: "HashedPassword",
                value: "$2a$10$rMTDHdWYU3GcMfuoZBPktOdNGxx/KrzYe9ClF4XaLxRMj8XXBbBjO");
        }
    }
}
