using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jobdoon.Migrations
{
    /// <inheritdoc />
    public partial class AddResumesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ResumeAppendix",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "ResumeAppendixId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Resumes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    EmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resumes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ResumeAppendixId",
                table: "AspNetUsers",
                column: "ResumeAppendixId",
                unique: true,
                filter: "[ResumeAppendixId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Resumes_ResumeAppendixId",
                table: "AspNetUsers",
                column: "ResumeAppendixId",
                principalTable: "Resumes",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Resumes_ResumeAppendixId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Resumes");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_ResumeAppendixId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ResumeAppendixId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<byte[]>(
                name: "ResumeAppendix",
                table: "AspNetUsers",
                type: "varbinary(max)",
                nullable: true);
        }
    }
}
