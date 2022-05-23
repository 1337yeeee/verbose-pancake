using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Vision.Migrations
{
    public partial class AverageAssessment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assessments_Articles_Articleid",
                table: "Assessments");

            migrationBuilder.DropIndex(
                name: "IX_Assessments_Articleid",
                table: "Assessments");

            migrationBuilder.RenameColumn(
                name: "Articleid",
                table: "Assessments",
                newName: "ArticleId");

            migrationBuilder.AlterColumn<Guid>(
                name: "ArticleId",
                table: "Assessments",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<double>(
                name: "AverageAssessment",
                table: "Articles",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AverageAssessment",
                table: "Articles");

            migrationBuilder.RenameColumn(
                name: "ArticleId",
                table: "Assessments",
                newName: "Articleid");

            migrationBuilder.AlterColumn<Guid>(
                name: "Articleid",
                table: "Assessments",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "TEXT");

            migrationBuilder.CreateIndex(
                name: "IX_Assessments_Articleid",
                table: "Assessments",
                column: "Articleid");

            migrationBuilder.AddForeignKey(
                name: "FK_Assessments_Articles_Articleid",
                table: "Assessments",
                column: "Articleid",
                principalTable: "Articles",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
