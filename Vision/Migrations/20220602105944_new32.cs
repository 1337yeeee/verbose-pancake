using Microsoft.EntityFrameworkCore.Migrations;

namespace Vision.Migrations
{
    public partial class new32 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DataImgUrl",
                table: "Images",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataImgUrl",
                table: "Images");
        }
    }
}
