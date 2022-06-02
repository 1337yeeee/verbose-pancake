using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Vision.Migrations
{
    public partial class new31 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "bannerid",
                table: "Articles",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "posterid",
                table: "Articles",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Articles_bannerid",
                table: "Articles",
                column: "bannerid");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_posterid",
                table: "Articles",
                column: "posterid");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Images_bannerid",
                table: "Articles",
                column: "bannerid",
                principalTable: "Images",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Images_posterid",
                table: "Articles",
                column: "posterid",
                principalTable: "Images",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Images_bannerid",
                table: "Articles");

            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Images_posterid",
                table: "Articles");

            migrationBuilder.DropIndex(
                name: "IX_Articles_bannerid",
                table: "Articles");

            migrationBuilder.DropIndex(
                name: "IX_Articles_posterid",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "bannerid",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "posterid",
                table: "Articles");
        }
    }
}
