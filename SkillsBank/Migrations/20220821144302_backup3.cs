using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp1_SkillsBank.Migrations
{
    public partial class backup3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CrsReferenceLink",
                table: "Courses",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VideoTranscript",
                table: "Courses",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CrsReferenceLink",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "VideoTranscript",
                table: "Courses");
        }
    }
}
