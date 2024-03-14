using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jobdoon.Migrations
{
    /// <inheritdoc />
    public partial class AddJobCategoriesAndCompanyCategoriesTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Companies_Categories_CategoryId",
                table: "Companies");

            migrationBuilder.DropForeignKey(
                name: "FK_Opportunities_Categories_ExperienceId",
                table: "Opportunities");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Opportunities",
                newName: "JobCategoryId");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Companies",
                newName: "CompanyCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Companies_CategoryId",
                table: "Companies",
                newName: "IX_Companies_CompanyCategoryId");

            migrationBuilder.CreateTable(
                name: "CompanyCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobCategories", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Opportunities_JobCategoryId",
                table: "Opportunities",
                column: "JobCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_CompanyCategories_CompanyCategoryId",
                table: "Companies",
                column: "CompanyCategoryId",
                principalTable: "CompanyCategories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Opportunities_JobCategories_JobCategoryId",
                table: "Opportunities",
                column: "JobCategoryId",
                principalTable: "JobCategories",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Companies_CompanyCategories_CompanyCategoryId",
                table: "Companies");

            migrationBuilder.DropForeignKey(
                name: "FK_Opportunities_JobCategories_JobCategoryId",
                table: "Opportunities");

            migrationBuilder.DropTable(
                name: "CompanyCategories");

            migrationBuilder.DropTable(
                name: "JobCategories");

            migrationBuilder.DropIndex(
                name: "IX_Opportunities_JobCategoryId",
                table: "Opportunities");

            migrationBuilder.RenameColumn(
                name: "JobCategoryId",
                table: "Opportunities",
                newName: "CategoryId");

            migrationBuilder.RenameColumn(
                name: "CompanyCategoryId",
                table: "Companies",
                newName: "CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Companies_CompanyCategoryId",
                table: "Companies",
                newName: "IX_Companies_CategoryId");

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_Categories_CategoryId",
                table: "Companies",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Opportunities_Categories_ExperienceId",
                table: "Opportunities",
                column: "ExperienceId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
