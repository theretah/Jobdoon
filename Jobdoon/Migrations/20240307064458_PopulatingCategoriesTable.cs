using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jobdoon.Migrations
{
    /// <inheritdoc />
    public partial class PopulatingCategoriesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categories VALUES (N'وب، برنامه نویسی و نرم افزار'), (N'فروش و بازاریابی'), (N'مالی و حسابداری'), (N'طراحی'), (N'خرید و بازرگانی'), (N'تولید و مدیریت محتوا'), (N'آموزش'), (N'کارگر ماهر، کارگر صنعتی'), (N'روابط عمومی'), (N'کارشناس حقوق، وکالت')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categories");
        }
    }
}
