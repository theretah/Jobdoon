using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jobdoon.Migrations
{
    /// <inheritdoc />
    public partial class PopulatingDegreesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Degrees VALUES (N'مهم نیست'), (N'دیپلم'), (N'کاردانی'), (N'کارشناسی'), (N'کارشناسی ارشد'), (N'دکترا و بالاتر')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Degrees");
        }
    }
}
