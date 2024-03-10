using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Task1.Migrations
{
    /// <inheritdoc />
    public partial class ChangedName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SampleData_state_CITYID",
                table: "SampleData");

            migrationBuilder.DropTable(
                name: "state");

            migrationBuilder.CreateTable(
                name: "StateTable",
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
                    table.PrimaryKey("PK_StateTable", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "StateTable",
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

            migrationBuilder.AddForeignKey(
                name: "FK_SampleData_StateTable_CITYID",
                table: "SampleData",
                column: "CITYID",
                principalTable: "StateTable",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SampleData_StateTable_CITYID",
                table: "SampleData");

            migrationBuilder.DropTable(
                name: "StateTable");

            migrationBuilder.CreateTable(
                name: "state",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CITY = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    COUNTRY_NAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CURRENCY = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    STATE_NAME = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_state", x => x.ID);
                });

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

            migrationBuilder.AddForeignKey(
                name: "FK_SampleData_state_CITYID",
                table: "SampleData",
                column: "CITYID",
                principalTable: "state",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
