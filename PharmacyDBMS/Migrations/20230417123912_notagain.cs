using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharmacyDBMS.Migrations
{
    /// <inheritdoc />
    public partial class notagain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 3440,
                column: "HashedPassword",
                value: "$2a$10$fCuumwqdvLS0igXISp2PueGg6Vtc2u7vK4kAORNV9GA2MkZIBqMT.");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 3440,
                column: "HashedPassword",
                value: "$2a$10$bSKthODSLP0h1NT4XWYEPe4blMgmHUL0Ge2tinL5j2z0v5PNMfMMG");
        }
    }
}
