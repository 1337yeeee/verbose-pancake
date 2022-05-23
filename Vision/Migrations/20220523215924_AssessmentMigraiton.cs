using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Vision.Migrations
{
    public partial class AssessmentMigraiton : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Assessments",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Rating = table.Column<int>(type: "INTEGER", nullable: false),
                    Articleid = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assessments", x => x.id);
                    table.ForeignKey(
                        name: "FK_Assessments_Articles_Articleid",
                        column: x => x.Articleid,
                        principalTable: "Articles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Assessments_Articleid",
                table: "Assessments",
                column: "Articleid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Assessments");
        }
    }
}
