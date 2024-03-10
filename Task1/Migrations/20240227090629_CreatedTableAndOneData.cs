using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Task1.Migrations
{
    /// <inheritdoc />
    public partial class CreatedTableAndOneData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SampleData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BU_CODES = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    STATUS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OPENED_DT = table.Column<DateOnly>(type: "date", nullable: false),
                    ADDRESS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CITY = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    STATE_NAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    COUNTRY_NAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CURRENCY = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PHONE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BUSINESS_HOURS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LATITUDE = table.Column<int>(type: "int", nullable: false),
                    LONGITUDE = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SampleData", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "SampleData",
                columns: new[] { "Id", "ADDRESS", "BUSINESS_HOURS", "BU_CODES", "CITY", "COUNTRY_NAME", "CURRENCY", "LATITUDE", "LONGITUDE", "OPENED_DT", "PHONE", "STATE_NAME", "STATUS" },
                values: new object[] { 1, "19020   111th Ave", "Monday - Friday 7:30am - 5:00pm", "AB100", "EDMONTON", "Canada", "CAD", 54, -114, new DateOnly(2008, 9, 15), "780-801-5006", "Alberta", "Open" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SampleData");
        }
    }
}
