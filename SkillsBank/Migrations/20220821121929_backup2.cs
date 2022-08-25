using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp1_SkillsBank.Migrations
{
    public partial class backup2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CrsSkills",
                table: "CrsSkills");

            migrationBuilder.DropIndex(
                name: "IX_CrsSkills_CrsFK",
                table: "CrsSkills");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "CrsSkills");

            migrationBuilder.DropColumn(
                name: "skillName",
                table: "CrsSkills");

            migrationBuilder.DropColumn(
                name: "CrsStatus",
                table: "Courses");

            migrationBuilder.AddColumn<string>(
                name: "currencyAName",
                table: "Currencies",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "typeValue",
                table: "CrsTypes",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "typeAValue",
                table: "CrsTypes",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "skillFK",
                table: "CrsSkills",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Courses",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Adescription",
                table: "Courses",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Aname",
                table: "Courses",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "crsStatusFK",
                table: "Courses",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "categoryAName",
                table: "Categories",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CrsSkills",
                table: "CrsSkills",
                columns: new[] { "CrsFK", "skillFK" });

            migrationBuilder.CreateTable(
                name: "CrsStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    statusName = table.Column<string>(nullable: true),
                    statusAName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CrsStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    skillName = table.Column<string>(nullable: true),
                    skillAName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CrsSkills_skillFK",
                table: "CrsSkills",
                column: "skillFK");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_crsStatusFK",
                table: "Courses",
                column: "crsStatusFK");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_CrsStatus_crsStatusFK",
                table: "Courses",
                column: "crsStatusFK",
                principalTable: "CrsStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CrsSkills_Skills_skillFK",
                table: "CrsSkills",
                column: "skillFK",
                principalTable: "Skills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_CrsStatus_crsStatusFK",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_CrsSkills_Skills_skillFK",
                table: "CrsSkills");

            migrationBuilder.DropTable(
                name: "CrsStatus");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CrsSkills",
                table: "CrsSkills");

            migrationBuilder.DropIndex(
                name: "IX_CrsSkills_skillFK",
                table: "CrsSkills");

            migrationBuilder.DropIndex(
                name: "IX_Courses_crsStatusFK",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "currencyAName",
                table: "Currencies");

            migrationBuilder.DropColumn(
                name: "typeAValue",
                table: "CrsTypes");

            migrationBuilder.DropColumn(
                name: "skillFK",
                table: "CrsSkills");

            migrationBuilder.DropColumn(
                name: "Adescription",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "Aname",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "crsStatusFK",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "categoryAName",
                table: "Categories");

            migrationBuilder.AlterColumn<int>(
                name: "typeValue",
                table: "CrsTypes",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "CrsSkills",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "skillName",
                table: "CrsSkills",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Price",
                table: "Courses",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AddColumn<string>(
                name: "CrsStatus",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CrsSkills",
                table: "CrsSkills",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_CrsSkills_CrsFK",
                table: "CrsSkills",
                column: "CrsFK");
        }
    }
}
