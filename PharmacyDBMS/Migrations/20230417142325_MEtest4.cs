using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharmacyDBMS.Migrations
{
    /// <inheritdoc />
    public partial class MEtest4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DoctorMedical_License",
                table: "Prescriptions",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 3440,
                column: "HashedPassword",
                value: "$2a$10$4j8n54hR7yb3J0FVT.E6Qe.C0d4brVAFYNE0vWjOnI8JfObvudljC");

            migrationBuilder.CreateIndex(
                name: "IX_Prescriptions_DoctorMedical_License",
                table: "Prescriptions",
                column: "DoctorMedical_License");

            migrationBuilder.CreateIndex(
                name: "IX_Prescriptions_PatientID",
                table: "Prescriptions",
                column: "PatientID");

            migrationBuilder.AddForeignKey(
                name: "FK_Prescriptions_Doctors_DoctorMedical_License",
                table: "Prescriptions",
                column: "DoctorMedical_License",
                principalTable: "Doctors",
                principalColumn: "Medical_License");

            migrationBuilder.AddForeignKey(
                name: "FK_Prescriptions_Patients_PatientID",
                table: "Prescriptions",
                column: "PatientID",
                principalTable: "Patients",
                principalColumn: "HealthCardNum",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prescriptions_Doctors_DoctorMedical_License",
                table: "Prescriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_Prescriptions_Patients_PatientID",
                table: "Prescriptions");

            migrationBuilder.DropIndex(
                name: "IX_Prescriptions_DoctorMedical_License",
                table: "Prescriptions");

            migrationBuilder.DropIndex(
                name: "IX_Prescriptions_PatientID",
                table: "Prescriptions");

            migrationBuilder.DropColumn(
                name: "DoctorMedical_License",
                table: "Prescriptions");

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 3440,
                column: "HashedPassword",
                value: "$2a$10$2eK4MT9qQwVdl6/xMofVru2q9i0bz26MdCN6DUVzFoU4KjBXIbx6u");
        }
    }
}
