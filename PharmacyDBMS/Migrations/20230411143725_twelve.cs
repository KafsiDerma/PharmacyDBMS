using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharmacyDBMS.Migrations
{
    /// <inheritdoc />
    public partial class twelve : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Employee",
                type: "TEXT",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 3440,
                columns: new[] { "HashedPassword", "PhoneNumber" },
                values: new object[] { "$2a$10$/66E8MhHXuo2v3fO68yJQeq2n7VaAyiRfdhlQU3xbgrZ3tU.Hyg16", "" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Employee",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 10);

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 3440,
                columns: new[] { "HashedPassword", "PhoneNumber" },
                values: new object[] { "$2a$10$bQygpoOq2pYW2M2WnBXoNuQvxKIKypBnDvfRBnN/Xc35iIUnIG.G6", null });
        }
    }
}
