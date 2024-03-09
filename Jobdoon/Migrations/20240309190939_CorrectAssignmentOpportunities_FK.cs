using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jobdoon.Migrations
{
    /// <inheritdoc />
    public partial class CorrectAssignmentOpportunities_FK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Opportunities_Assignments_ExperienceId",
                table: "Opportunities");

            migrationBuilder.CreateIndex(
                name: "IX_Opportunities_AssignmentId",
                table: "Opportunities",
                column: "AssignmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Opportunities_Assignments_AssignmentId",
                table: "Opportunities",
                column: "AssignmentId",
                principalTable: "Assignments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Opportunities_Assignments_AssignmentId",
                table: "Opportunities");

            migrationBuilder.DropIndex(
                name: "IX_Opportunities_AssignmentId",
                table: "Opportunities");

            migrationBuilder.AddForeignKey(
                name: "FK_Opportunities_Assignments_ExperienceId",
                table: "Opportunities",
                column: "ExperienceId",
                principalTable: "Assignments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
