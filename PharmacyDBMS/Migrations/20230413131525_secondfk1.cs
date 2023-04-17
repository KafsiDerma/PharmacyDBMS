using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharmacyDBMS.Migrations
{
    /// <inheritdoc />
    public partial class secondfk1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 3440);

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id", "Email", "HashedPassword", "Name", "PhoneNumber", "Position", "Salary", "supervisor" },
                values: new object[] { 5440, null, "$2a$10$/B/HXrJnR7tJCjELbjG78.BVHhdT0wS806qTdRYxqTY8qt.ruBynm", "admin", "123", 5, 0f, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 5440);

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id", "Email", "HashedPassword", "Name", "PhoneNumber", "Position", "Salary", "supervisor" },
                values: new object[] { 3440, null, "$2a$10$02NaXf9gttLK2Ujr9kfZfeRM7OrIUgmEnkkqhzPxV8Ln4UjNW7MCe", "admin", "", 5, 0f, null });
        }
    }
}
