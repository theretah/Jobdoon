using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jobdoon.Migrations
{
    /// <inheritdoc />
    public partial class AddCompanyOpportunitiesRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "MinimumSalaryId",
                table: "Opportunities",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "Opportunities",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Opportunities_CompanyId",
                table: "Opportunities",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Opportunities_Companies_CompanyId",
                table: "Opportunities",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Opportunities_Companies_CompanyId",
                table: "Opportunities");

            migrationBuilder.DropIndex(
                name: "IX_Opportunities_CompanyId",
                table: "Opportunities");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "Opportunities");

            migrationBuilder.AlterColumn<int>(
                name: "MinimumSalaryId",
                table: "Opportunities",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
