using Microsoft.EntityFrameworkCore.Migrations;

namespace Medical.Work.Migrations
{
    public partial class medical3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ancestralhome",
                table: "MedicalPG");

            migrationBuilder.DropColumn(
                name: "Nationality",
                table: "MedicalPG");

            migrationBuilder.AddColumn<string>(
                name: "Ancestralhome",
                table: "PatientInfo",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nationality",
                table: "PatientInfo",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ancestralhome",
                table: "PatientInfo");

            migrationBuilder.DropColumn(
                name: "Nationality",
                table: "PatientInfo");

            migrationBuilder.AddColumn<string>(
                name: "Ancestralhome",
                table: "MedicalPG",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nationality",
                table: "MedicalPG",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
