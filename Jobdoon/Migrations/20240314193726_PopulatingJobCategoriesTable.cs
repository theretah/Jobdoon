using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jobdoon.Migrations
{
    /// <inheritdoc />
    public partial class PopulatingJobCategoriesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO JobCategories VALUES (N'وب، برنامه نویسی و نرم افزار'), (N'فروش و بازاریابی'), (N'مالی و حسابداری'), (N'طراحی'), (N'خرید و بازرگانی'), (N'تولید و مدیریت محتوا'), (N'آموزش'), (N'کارگر ماهر، کارگر صنعتی'), (N'روابط عمومی'), (N'کارشناس حقوق، وکالت'), (N'شیمی، داروسازی'), (N'مهندسی شیمی و نفت'), (N'مدیریت بیمه'), (N'ترجمه'), (N'هتل داری'), (N'تحقیق بازار و تحلیل اقتصادی'), (N'مدیر محصول'), (N'کارگر حوزه سینما و تصویر'), (N'مهندسی مکانیک و هوافضا'), (N'مهندسی برق و الکترونیک')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM JobCategories");
        }
    }
}
