using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Task1.Migrations
{
    /// <inheritdoc />
    public partial class changed_Datetostring : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "OPENED_DT",
                table: "SampleData",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.UpdateData(
                table: "SampleData",
                keyColumn: "Id",
                keyValue: 1,
                column: "OPENED_DT",
                value: "2008-1-15");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateOnly>(
                name: "OPENED_DT",
                table: "SampleData",
                type: "date",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "SampleData",
                keyColumn: "Id",
                keyValue: 1,
                column: "OPENED_DT",
                value: new DateOnly(2008, 9, 15));
        }
    }
}
