using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jobdoon.Migrations
{
    /// <inheritdoc />
    public partial class PopulatingProvincesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Provinces VALUES (N'آذربایجان شرقی'), (N'آذربایجان غربی'), (N'اردبیل'), (N'اصفهان'), (N'البرز'),(N'ایلام'), (N'بوشهر'), (N'تهران'), (N'چهارمحال و بختیاری'), (N'خراسان جنوبی'),(N'خراسان رضوی'), (N'خراسان شمالی'), (N'خوزستان'), (N'زنجان'), (N'سمنان'),(N'سیستان و بلوچستان'), (N'فارس'), (N'قزوین'), (N'قم'), (N'کردستان'),(N'کرمان'), (N'کرمانشاه'), (N'کهگیلویه و بویراحمد'), (N'گلستان'), (N'گیلان'),(N'لرستان'), (N'مازندران'), (N'مرکزی'), (N'هرمزگان'), (N'همدان'),(N'یزد')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Provinces");
        }
    }
}
