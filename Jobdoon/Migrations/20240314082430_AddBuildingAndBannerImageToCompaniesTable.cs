using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jobdoon.Migrations
{
    /// <inheritdoc />
    public partial class AddBuildingAndBannerImageToCompaniesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "BannerImage",
                table: "Companies",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "BuildingImage",
                table: "Companies",
                type: "varbinary(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BannerImage",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "BuildingImage",
                table: "Companies");
        }
    }
}
