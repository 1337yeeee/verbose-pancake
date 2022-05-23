using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Vision.Migrations
{
    public partial class MigrationForImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "path",
                table: "Images",
                newName: "ImageTitle");

            migrationBuilder.AddColumn<byte[]>(
                name: "ImageData",
                table: "Images",
                type: "BLOB",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageData",
                table: "Images");

            migrationBuilder.RenameColumn(
                name: "ImageTitle",
                table: "Images",
                newName: "path");
        }
    }
}
