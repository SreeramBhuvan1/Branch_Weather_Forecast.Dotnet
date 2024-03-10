using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Task1.Migrations
{
    /// <inheritdoc />
    public partial class CreatedAnotherTableAndForeignKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "state",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CITY = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    STATE_NAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    COUNTRY_NAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CURRENCY = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_state", x => x.ID);
                });

            migrationBuilder.UpdateData(
                table: "SampleData",
                keyColumn: "Id",
                keyValue: 1,
                column: "CITYID",
                value: 100);
            migrationBuilder.UpdateData(
               table: "SampleData",
               keyColumn: "Id",
               keyValue: 2,
               column: "CITYID",
               value: 101);
            migrationBuilder.UpdateData(
               table: "SampleData",
               keyColumn: "Id",
               keyValue: 3,
               column: "CITYID",
               value: 102);
            migrationBuilder.UpdateData(
               table: "SampleData",
               keyColumn: "Id",
               keyValue: 4,
               column: "CITYID",
               value: 103);
            migrationBuilder.UpdateData(
               table: "SampleData",
               keyColumn: "Id",
               keyValue: 5,
               column: "CITYID",
               value: 103);
            migrationBuilder.UpdateData(
               table: "SampleData",
               keyColumn: "Id",
               keyValue: 6,
               column: "CITYID",
               value: 104);
            migrationBuilder.UpdateData(
               table: "SampleData",
               keyColumn: "Id",
               keyValue: 7,
               column: "CITYID",
               value: 100);
            migrationBuilder.UpdateData(
               table: "SampleData",
               keyColumn: "Id",
               keyValue: 8,
               column: "CITYID",
               value: 100);
            migrationBuilder.UpdateData(
               table: "SampleData",
               keyColumn: "Id",
               keyValue: 9,
               column: "CITYID",
               value: 100);
            migrationBuilder.UpdateData(
               table: "SampleData",
               keyColumn: "Id",
               keyValue: 10,
               column: "CITYID",
               value: 105);
            migrationBuilder.UpdateData(
               table: "SampleData",
               keyColumn: "Id",
               keyValue: 11,
               column: "CITYID",
               value: 106);
            migrationBuilder.UpdateData(
               table: "SampleData",
               keyColumn: "Id",
               keyValue: 12,
               column: "CITYID",
               value: 107);
            migrationBuilder.UpdateData(
               table: "SampleData",
               keyColumn: "Id",
               keyValue: 13,
               column: "CITYID",
               value: 108);
            migrationBuilder.UpdateData(
               table: "SampleData",
               keyColumn: "Id",
               keyValue: 14,
               column: "CITYID",
               value: 109);
            migrationBuilder.UpdateData(
               table: "SampleData",
               keyColumn: "Id",
               keyValue: 15,
               column: "CITYID",
               value: 110);
            migrationBuilder.UpdateData(
               table: "SampleData",
               keyColumn: "Id",
               keyValue: 16,
               column: "CITYID",
               value: 111);

            migrationBuilder.InsertData(
                table: "state",
                columns: new[] { "ID", "CITY", "COUNTRY_NAME", "CURRENCY", "STATE_NAME" },
                values: new object[,]
                {
                    { 100, "EDMONTON", "Canada", "CAD", "Alberta" },
                    { 101, "ACHESON", "Canada", "CAD", "Alberta" },
                    { 102, "AIRDRIE", "Canada", "CAD", "Alberta" },
                    { 103, "CALGARY", "Canada", "CAD", "Alberta" },
                    { 104, "GRANDE PRAIRIE", "Canada", "CAD", "Alberta" },
                    { 105, "NISKU", "Canada", "CAD", "Alberta" },
                    { 106, "LLOYDMINSTER", "Canada", "CAD", "Alberta" },
                    { 107, "MEDICINE HAT", "Canada", "CAD", "Alberta" },
                    { 108, "RED DEER", "Canada", "CAD", "Alberta" },
                    { 109, "WHITECOURT", "Canada", "CAD", "Alberta" },
                    { 110, "ANCHORAGE", "United States", "USD", "Alaska" },
                    { 111, "FAIRBANKS", "United States", "USD", "Alaska" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SampleData_CITYID",
                table: "SampleData",
                column: "CITYID");

            migrationBuilder.AddForeignKey(
                name: "FK_SampleData_state_CITYID",
                table: "SampleData",
                column: "CITYID",
                principalTable: "state",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SampleData_state_CITYID",
                table: "SampleData");

            migrationBuilder.DropTable(
                name: "state");

            migrationBuilder.DropIndex(
                name: "IX_SampleData_CITYID",
                table: "SampleData");

            migrationBuilder.DropColumn(
                name: "CITYID",
                table: "SampleData");

            migrationBuilder.AddColumn<string>(
                name: "CITY",
                table: "SampleData",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "COUNTRY_NAME",
                table: "SampleData",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CURRENCY",
                table: "SampleData",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "STATE_NAME",
                table: "SampleData",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "SampleData",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CITY", "COUNTRY_NAME", "CURRENCY", "STATE_NAME" },
                values: new object[] { "EDMONTON", "Canada", "CAD", "Alberta" });
        }
    }
}
