using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Medical.Work.Migrations
{
    public partial class db5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MedicalPD");

            migrationBuilder.CreateTable(
                name: "MedicalPD_DrugAllergy",
                columns: table => new
                {
                    MedicalPD_DrugAllergyID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    P_Guid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adminname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Createtime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TestorisNot = table.Column<int>(type: "int", nullable: false),
                    TestTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DrugsensitivityTest = table.Column<int>(type: "int", nullable: false),
                    DrugsName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MIC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Susceptibility = table.Column<int>(type: "int", nullable: false),
                    TMic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AUCMic = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalPD_DrugAllergy", x => x.MedicalPD_DrugAllergyID);
                });

            migrationBuilder.CreateTable(
                name: "MedicalPD_Microbiological",
                columns: table => new
                {
                    MedicalPD_MicrobiologicalID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    P_Guid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adminname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Createtime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TestorisNot = table.Column<int>(type: "int", nullable: false),
                    TestTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SpecimenType = table.Column<int>(type: "int", nullable: false),
                    TestorNot = table.Column<int>(type: "int", nullable: false),
                    ReportTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Inspectiontime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Bacterial = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalPD_Microbiological", x => x.MedicalPD_MicrobiologicalID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MedicalPD_DrugAllergy");

            migrationBuilder.DropTable(
                name: "MedicalPD_Microbiological");

            migrationBuilder.CreateTable(
                name: "MedicalPD",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adminname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Createtime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DrugsensitivityTest = table.Column<int>(type: "int", nullable: false),
                    Drugsname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inspectiontime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MIC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reporttime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SpecimenType = table.Column<int>(type: "int", nullable: false),
                    Susceptibility = table.Column<int>(type: "int", nullable: false),
                    TestTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TestorNot = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalPD", x => x.ID);
                });
        }
    }
}
