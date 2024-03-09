using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jobdoon.Migrations
{
    /// <inheritdoc />
    public partial class RenameSalariesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Opportunities_UnspecifiedSalaries_ExperienceId",
                table: "Opportunities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UnspecifiedSalaries",
                table: "UnspecifiedSalaries");

            migrationBuilder.RenameTable(
                name: "UnspecifiedSalaries",
                newName: "MinimumSalaries");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MinimumSalaries",
                table: "MinimumSalaries",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Opportunities_MinimumSalaries_ExperienceId",
                table: "Opportunities",
                column: "ExperienceId",
                principalTable: "MinimumSalaries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Opportunities_MinimumSalaries_ExperienceId",
                table: "Opportunities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MinimumSalaries",
                table: "MinimumSalaries");

            migrationBuilder.RenameTable(
                name: "MinimumSalaries",
                newName: "UnspecifiedSalaries");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UnspecifiedSalaries",
                table: "UnspecifiedSalaries",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Opportunities_UnspecifiedSalaries_ExperienceId",
                table: "Opportunities",
                column: "ExperienceId",
                principalTable: "UnspecifiedSalaries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
