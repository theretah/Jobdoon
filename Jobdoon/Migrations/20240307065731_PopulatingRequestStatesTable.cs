using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jobdoon.Migrations
{
    /// <inheritdoc />
    public partial class PopulatingRequestStatesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO RequestStates VALUES (N'ارسال شده'), (N'بررسی شده'), (N'تایید برای مصاحبه'), (N'بسته شده'), (N'لغو شده توسط کارجو'), (N'موافقت شده'), (N'لغو شده توسط کارفرما')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM RequestStates");
        }
    }
}
