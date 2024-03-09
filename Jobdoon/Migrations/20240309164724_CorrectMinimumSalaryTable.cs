using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jobdoon.Migrations
{
    /// <inheritdoc />
    public partial class CorrectMinimumSalaryTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Salary",
                table: "Opportunities");

            migrationBuilder.RenameColumn(
                name: "UnspecifiedSalaryId",
                table: "Opportunities",
                newName: "MinimumSalaryId");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "UnspecifiedSalaries",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<decimal>(
                name: "Value",
                table: "UnspecifiedSalaries",
                type: "decimal(18,2)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Value",
                table: "UnspecifiedSalaries");

            migrationBuilder.RenameColumn(
                name: "MinimumSalaryId",
                table: "Opportunities",
                newName: "UnspecifiedSalaryId");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "UnspecifiedSalaries",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Salary",
                table: "Opportunities",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
