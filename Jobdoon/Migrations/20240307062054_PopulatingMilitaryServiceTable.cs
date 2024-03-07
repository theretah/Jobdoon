using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jobdoon.Migrations
{
    /// <inheritdoc />
    public partial class PopulatingMilitaryServiceTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder
                .Sql("INSERT INTO MilitaryServices VALUES (N'مهم نیست'), (N'مشمول'), (N'در حال انجام'), (N'معافیت تحصیلی'), (N'معافیت دائم'), (N'پایان خدمت')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM MilitaryServices");
        }
    }
}
