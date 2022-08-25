using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp1_SkillsBank.Migrations
{
    public partial class backup4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LangName",
                table: "Languages",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "LangAName",
                table: "Languages",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "levelAName",
                table: "CrsLevels",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "categoryName",
                table: "Categories",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LangAName",
                table: "Languages");

            migrationBuilder.DropColumn(
                name: "levelAName",
                table: "CrsLevels");

            migrationBuilder.AlterColumn<int>(
                name: "LangName",
                table: "Languages",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "categoryName",
                table: "Categories",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
