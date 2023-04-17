using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharmacyDBMS.Migrations
{
    /// <inheritdoc />
    public partial class MEtest2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "Prescriptions_only",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 3440,
                column: "HashedPassword",
                value: "$2a$10$stXaMTx0oLm0x0iNa3R6Eu1vVreHgZ/KyY6UKED2CzB72yFiKWR.K");

            migrationBuilder.AddForeignKey(
                name: "FK_Prescriptions_only_Products_id",
                table: "Prescriptions_only",
                column: "id",
                principalTable: "Products",
                principalColumn: "productID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prescriptions_only_Products_id",
                table: "Prescriptions_only");

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "Prescriptions_only",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 3440,
                column: "HashedPassword",
                value: "$2a$10$3JwKTCxTncHnRJOWLxEpyuh2plQz1tC.yN6EwePSH/gse/nlesxSm");
        }
    }
}
