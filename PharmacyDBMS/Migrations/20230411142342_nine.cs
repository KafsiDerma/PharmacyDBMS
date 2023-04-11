using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharmacyDBMS.Migrations
{
    /// <inheritdoc />
    public partial class nine : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id", "Email", "HashedPassword", "Name", "PhoneNumber", "Position", "Salary", "supervisor" },
                values: new object[] { 3440, null, "$2a$10$No7OFMGNb.35J4UuDvo0Au/YL3lnDluy8fwEkzd5iQ/a9xkCwL5kK", "admin", null, 5, 0f, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 3440);

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id", "Email", "HashedPassword", "Name", "PhoneNumber", "Position", "Salary", "supervisor" },
                values: new object[] { 1, null, "$2a$10$cWNrQx/5p08.NOhDkaRiaOmMXfThOBwTBONfNaed/j7hb5xdXNzBS", "admin", null, 5, 0f, null });
        }
    }
}
