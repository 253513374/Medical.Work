using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Medical.Work.Migrations
{
    public partial class db2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PatientInfoGuid",
                table: "X_raypathologicals",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PatientInfoGuid",
                table: "X_rayImagings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PatientInfoGuid",
                table: "X_raybronchoscopys",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "LaboratoryExamination",
                columns: table => new
                {
                    LaboratoryExaminationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adminuser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Medicalrecordnumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatientInfoGuid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Createtime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Assaysituation = table.Column<int>(type: "int", nullable: false),
                    Assaytime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BodyTemperature = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Scr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Screnum = table.Column<int>(type: "int", nullable: false),
                    Screnumother = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BUN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CLcr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    eGFR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ALT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AST = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ALP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TBLL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TBLL_Z = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TBLL_J = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ALB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    INR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Child_pugh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PLT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WBC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GGT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hemoglobin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CRP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PCT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IL6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ESR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Uricine = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nitrite = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bacterial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Yeast = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CSF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LaboratoryExamination", x => x.LaboratoryExaminationID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LaboratoryExamination");

            migrationBuilder.DropColumn(
                name: "PatientInfoGuid",
                table: "X_raypathologicals");

            migrationBuilder.DropColumn(
                name: "PatientInfoGuid",
                table: "X_rayImagings");

            migrationBuilder.DropColumn(
                name: "PatientInfoGuid",
                table: "X_raybronchoscopys");
        }
    }
}
