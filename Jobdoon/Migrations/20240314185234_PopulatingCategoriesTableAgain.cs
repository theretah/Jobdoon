using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jobdoon.Migrations
{
    /// <inheritdoc />
    public partial class PopulatingCategoriesTableAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categories VALUES (N'شیمی، داروسازی'), (N'مهندسی شیمی و نفت'), (N'مدیریت بیمه'), (N'ترجمه'), (N'هتل داری'), (N'تحقیق بازار و تحلیل اقتصادی'), (N'مدیر محصول'), (N'کارگر حوزه سینما و تصویر'), (N'مهندسی مکانیک و هوافضا'), (N'مهندسی برق و الکترونیک')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categories");
        }
    }
}
