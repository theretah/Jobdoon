using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jobdoon.Migrations
{
    /// <inheritdoc />
    public partial class PopulateSalariesWithNumericValues : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO MinimumSalaries (Title, Value) VALUES (NULL, 4500000), (NULL, 5000000), (NULL, 5500000), (NULL, 6000000), (NULL, 6500000), (NULL, 7000000), (NULL, 7500000), (NULL, 8000000), (NULL, 9500000), (NULL, 10000000), (NULL, 15000000), (NULL, 20000000), (NULL, 30000000), (NULL, 50000000), (NULL, 100000000)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM MinimumSalaries WHERE(Title = NULL)");
        }
    }
}
