using Microsoft.EntityFrameworkCore.Migrations;

namespace Medical.Work.Migrations
{
    public partial class db3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AdminName",
                table: "medicalPKSamplings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MedicalPKGuid",
                table: "MedicalPK",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdminName",
                table: "medicalPKSamplings");

            migrationBuilder.DropColumn(
                name: "MedicalPKGuid",
                table: "MedicalPK");
        }
    }
}
