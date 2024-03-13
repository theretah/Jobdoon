using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jobdoon.Migrations
{
    /// <inheritdoc />
    public partial class AddIsClosedStateToOpportunityTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsClosed",
                table: "Opportunities",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsClosed",
                table: "Opportunities");
        }
    }
}
