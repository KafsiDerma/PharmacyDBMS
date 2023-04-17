using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharmacyDBMS.Migrations
{
    /// <inheritdoc />
    public partial class MEtest5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "healthcardnum",
                table: "Carts",
                newName: "HealthCardNum");

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 3440,
                column: "HashedPassword",
                value: "$2a$10$Okv.lUtTujIpHx661zGy6.wXi6e8MYAVSUU0FZAuAyqkbcpxzZC16");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_HealthCardNum",
                table: "Carts",
                column: "HealthCardNum");

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_Patients_HealthCardNum",
                table: "Carts",
                column: "HealthCardNum",
                principalTable: "Patients",
                principalColumn: "HealthCardNum",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carts_Patients_HealthCardNum",
                table: "Carts");

            migrationBuilder.DropIndex(
                name: "IX_Carts_HealthCardNum",
                table: "Carts");

            migrationBuilder.RenameColumn(
                name: "HealthCardNum",
                table: "Carts",
                newName: "healthcardnum");

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 3440,
                column: "HashedPassword",
                value: "$2a$10$4j8n54hR7yb3J0FVT.E6Qe.C0d4brVAFYNE0vWjOnI8JfObvudljC");
        }
    }
}
