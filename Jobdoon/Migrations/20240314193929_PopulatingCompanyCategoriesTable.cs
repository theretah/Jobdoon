using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jobdoon.Migrations
{
    /// <inheritdoc />
    public partial class PopulatingCompanyCategoriesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO CompanyCategories VALUES (N'کامپیوتر، فناوری اطلاعات و اینترنت'), (N'تولید و صنایع'), (N'تبلیغات، بازاریابی و برندسازی'), (N'خدمات درمانی، پزشکی و سلامت'), (N'معماری و عمران'), (N'آموزش، مدارس و دانشگاه‌ها'), (N'رسانه و انتشارات'), (N'نفت و گاز'), (N'گردشگری و هتل‌ها'), (N'مالی و اعتباری'), (N'مخابرات و ارتباطات'), (N'املاک و مستغلات'), (N'بیمه'), (N'منابع انسانی'), (N'وکالت و حقوقی'), (N'نیرو'), (N'دولتی'), (N'دیگر شرکت‌ها')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM CompanyCategories");
        }
    }
}
