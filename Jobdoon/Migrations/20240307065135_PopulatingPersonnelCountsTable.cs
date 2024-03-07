using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jobdoon.Migrations
{
    /// <inheritdoc />
    public partial class PopulatingPersonnelCountsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO PersonnelCounts VALUES (N'یک نفر (من)'), (N'2 تا 10 نفر'), (N'11 تا 50 نفر'), (N'51 تا 200 نفر'), (N'201 تا 500 نفر'), (N'501 تا 1000 نفر'), (N'بیش از 1000 نفر')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM PersonnelCounts");
        }
    }
}
