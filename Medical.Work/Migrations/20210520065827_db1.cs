﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Medical.Work.Migrations
{
    public partial class db1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MedicalDGK",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MedicalDGKGuid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    patientInfoGuid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    medicalPgguid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    medicalPdguid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    medicalPkguid = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalDGK", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MedicalPD",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MedicalPDGuid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Inspectiontime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Typeofspecimen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reporttime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MIC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NGSinformation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalPD", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MedicalPG",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MedicalPGGuid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Genes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GenesResults = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Metabolictype = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PathogenicGeneName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PathogenicGeneDetectionResults = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BiochemicalTest = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CLcr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EGFR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Scr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    INR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CPscore = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ALT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ALP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BUN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AST = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TBLL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DirectTBLL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IndirectTBLL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ALB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PLT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WBC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CRP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PCT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IL6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ESR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Combineduseofdrugs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Symptomsofadversereactions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Typesofadversereactions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Analysisadversereactions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Treatmentoutcome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Treatmentsummary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalPG", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MedicalPK",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MedicalPKGuid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Firstdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AMTsingledose = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AMTNum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Maintenancedose = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nameofsolvent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Solventdose = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Channelofdrug = table.Column<DateTime>(type: "datetime2", nullable: false),
                    stopdrugdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    stopdrugtime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    beforedrugdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    beforedrugtimePM = table.Column<DateTime>(type: "datetime2", nullable: false),
                    bloodcollectiondate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Startingtimeofdrug = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Infusiontime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Infusiontimecomplete = table.Column<DateTime>(type: "datetime2", nullable: false),
                    C1bloodcollectiontime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    C2bloodcollectiontime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    C3bloodcollectiontime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    C4bloodcollectiontime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    C5bloodcollectiontime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    C1dvi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C2dvi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C3dvi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C4dvi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C5dvi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Singledialysisdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Dialysistype = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Starttimeofsingledialysis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Stoptimeofsingledialysis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DurationofsingledialysisH = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dialysissamplesamplingdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dialysissamplesamplingtime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Typesofdialysissamples = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dialysissampleconcentrationresults = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Transplantation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Postoperativetime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalPK", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PatientInfo",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientInfoGuid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Adminuser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Medicalrecordnumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<byte>(type: "tinyint", nullable: false),
                    AGE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BW = table.Column<int>(type: "int", nullable: false),
                    HEI = table.Column<int>(type: "int", nullable: false),
                    BMI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BSA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Transplantationtype = table.Column<int>(type: "int", nullable: false),
                    Transplantationtime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ancestralhome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GCS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SOFA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    APACHEⅡ = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Admissiontime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Dischargetime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Medicalhistorysummary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Medication = table.Column<int>(type: "int", nullable: false),
                    Pathogenicbacteria = table.Column<int>(type: "int", nullable: false),
                    Healingeffect = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientInfo", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PatientInfoExDiagnosisTable",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AffectedDiagnosis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Affectedarea = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatientInfoID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientInfoExDiagnosisTable", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PatientInfoExDiagnosisTable_PatientInfo_PatientInfoID",
                        column: x => x.PatientInfoID,
                        principalTable: "PatientInfo",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PatientInfoExDiagnosisTable_PatientInfoID",
                table: "PatientInfoExDiagnosisTable",
                column: "PatientInfoID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MedicalDGK");

            migrationBuilder.DropTable(
                name: "MedicalPD");

            migrationBuilder.DropTable(
                name: "MedicalPG");

            migrationBuilder.DropTable(
                name: "MedicalPK");

            migrationBuilder.DropTable(
                name: "PatientInfoExDiagnosisTable");

            migrationBuilder.DropTable(
                name: "PatientInfo");
        }
    }
}