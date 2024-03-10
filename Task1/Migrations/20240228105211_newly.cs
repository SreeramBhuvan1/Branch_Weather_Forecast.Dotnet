using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Task1.Migrations
{
    /// <inheritdoc />
    public partial class newly : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "1612199f-946e-47fa-be9a-112beb62c197");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "c3598c97-8822-4600-85d9-bb242a71fddb");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "16e623c7-e101-4258-973f-1b91ecfdca18", null, "User", "USER" },
                    { "935e7e5b-8f73-4b9b-8598-218831028151", null, "Administrator", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "16e623c7-e101-4258-973f-1b91ecfdca18");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "935e7e5b-8f73-4b9b-8598-218831028151");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1612199f-946e-47fa-be9a-112beb62c197", null, "Administrator", "ADMIN" },
                    { "c3598c97-8822-4600-85d9-bb242a71fddb", null, "User", "USER" }
                });
        }
    }
}
