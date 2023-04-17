using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharmacyDBMS.Migrations
{
    /// <inheritdoc />
    public partial class secondfk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ID",
                table: "Patients");

            migrationBuilder.AddColumn<string>(
                name: "InsuranceAgency",
                table: "Patients",
                type: "TEXT",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 3440,
                column: "HashedPassword",
                value: "$2a$10$02NaXf9gttLK2Ujr9kfZfeRM7OrIUgmEnkkqhzPxV8Ln4UjNW7MCe");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_InsuranceAgency",
                table: "Patients",
                column: "InsuranceAgency");

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_InsuranceAgencies_InsuranceAgency",
                table: "Patients",
                column: "InsuranceAgency",
                principalTable: "InsuranceAgencies",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patients_InsuranceAgencies_InsuranceAgency",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Patients_InsuranceAgency",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "InsuranceAgency",
                table: "Patients");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "Patients",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 3440,
                column: "HashedPassword",
                value: "$2a$10$37ZiGjWNyX.tQzo51LZYLur5mbs5GELsjABqAICzn5blnKBO0O6wq");
        }
    }
}
