using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp1_SkillsBank.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    categoryName = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CrsLevels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    levelName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CrsLevels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CrsTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    typeValue = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CrsTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Currencies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    currencyName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currencies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LangName = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: false),
                    img = table.Column<string>(nullable: true),
                    CrsPromoLink = table.Column<string>(nullable: true),
                    duration = table.Column<DateTime>(nullable: false),
                    description = table.Column<string>(nullable: true),
                    CrsReferenceText = table.Column<string>(nullable: true),
                    CrsStatus = table.Column<string>(nullable: false),
                    startDate = table.Column<DateTime>(nullable: false),
                    endDate = table.Column<DateTime>(nullable: false),
                    ApplicationDueDate = table.Column<DateTime>(nullable: false),
                    CrsReleasedDate = table.Column<DateTime>(nullable: false),
                    Sessions = table.Column<int>(nullable: false),
                    TotalHours = table.Column<DateTime>(nullable: false),
                    minStudents = table.Column<int>(nullable: false),
                    maxStudents = table.Column<int>(nullable: false),
                    CertAvailable = table.Column<bool>(nullable: false),
                    Price = table.Column<int>(nullable: false),
                    SearchTags = table.Column<string>(nullable: true),
                    DiscountPercent = table.Column<int>(nullable: false),
                    CrsRequirement = table.Column<int>(nullable: false),
                    categoryFK = table.Column<int>(nullable: false),
                    crsLevelFK = table.Column<int>(nullable: false),
                    currencyFK = table.Column<int>(nullable: false),
                    crsTypeFK = table.Column<int>(nullable: false),
                    languageFK = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Courses_Categories_categoryFK",
                        column: x => x.categoryFK,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Courses_CrsLevels_crsLevelFK",
                        column: x => x.crsLevelFK,
                        principalTable: "CrsLevels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Courses_CrsTypes_crsTypeFK",
                        column: x => x.crsTypeFK,
                        principalTable: "CrsTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Courses_Currencies_currencyFK",
                        column: x => x.currencyFK,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Courses_Languages_languageFK",
                        column: x => x.languageFK,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CrsSkills",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    skillName = table.Column<string>(nullable: true),
                    CrsFK = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CrsSkills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CrsSkills_Courses_CrsFK",
                        column: x => x.CrsFK,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CrsReferenceText",
                table: "Courses",
                column: "CrsReferenceText",
                unique: true,
                filter: "[CrsReferenceText] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_categoryFK",
                table: "Courses",
                column: "categoryFK");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_crsLevelFK",
                table: "Courses",
                column: "crsLevelFK");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_crsTypeFK",
                table: "Courses",
                column: "crsTypeFK");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_currencyFK",
                table: "Courses",
                column: "currencyFK");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_languageFK",
                table: "Courses",
                column: "languageFK");

            migrationBuilder.CreateIndex(
                name: "IX_CrsSkills_CrsFK",
                table: "CrsSkills",
                column: "CrsFK");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CrsSkills");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "CrsLevels");

            migrationBuilder.DropTable(
                name: "CrsTypes");

            migrationBuilder.DropTable(
                name: "Currencies");

            migrationBuilder.DropTable(
                name: "Languages");
        }
    }
}
