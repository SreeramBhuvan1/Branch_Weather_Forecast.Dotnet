using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Task1.Migrations
{
    /// <inheritdoc />
    public partial class Statetablesadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SampleData_StateTable_CITYID",
                table: "SampleData");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StateTable",
                table: "StateTable");

            migrationBuilder.RenameTable(
                name: "StateTable",
                newName: "stateTables");

            migrationBuilder.AddPrimaryKey(
                name: "PK_stateTables",
                table: "stateTables",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_SampleData_stateTables_CITYID",
                table: "SampleData",
                column: "CITYID",
                principalTable: "stateTables",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SampleData_stateTables_CITYID",
                table: "SampleData");

            migrationBuilder.DropPrimaryKey(
                name: "PK_stateTables",
                table: "stateTables");

            migrationBuilder.RenameTable(
                name: "stateTables",
                newName: "StateTable");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StateTable",
                table: "StateTable",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_SampleData_StateTable_CITYID",
                table: "SampleData",
                column: "CITYID",
                principalTable: "StateTable",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
