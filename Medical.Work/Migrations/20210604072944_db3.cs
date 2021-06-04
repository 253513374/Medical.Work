using Microsoft.EntityFrameworkCore.Migrations;

namespace Medical.Work.Migrations
{
    public partial class db3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BWWeight",
                table: "PatientInfo",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BWWeight",
                table: "PatientInfo");
        }
    }
}
