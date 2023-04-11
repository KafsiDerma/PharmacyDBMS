using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharmacyDBMS.Migrations
{
    /// <inheritdoc />
    public partial class fifth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 1,
                column: "HashedPassword",
                value: "$2a$10$qc38p8O4dmblkd3aTsQBXeYoJS2g24iCfg4NKZEO03UgRmLmTw7e.");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 1,
                column: "HashedPassword",
                value: "8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918");
        }
    }
}
