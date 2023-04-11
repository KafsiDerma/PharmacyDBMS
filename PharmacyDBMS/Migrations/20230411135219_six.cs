using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharmacyDBMS.Migrations
{
    /// <inheritdoc />
    public partial class six : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 1,
                column: "HashedPassword",
                value: "$2a$10$sT0lSgPqWc/KAb4/PHkji.PM7fildLOZieG30UpOcdjM7QszXuNzq");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 1,
                column: "HashedPassword",
                value: "$2a$10$qc38p8O4dmblkd3aTsQBXeYoJS2g24iCfg4NKZEO03UgRmLmTw7e.");
        }
    }
}
