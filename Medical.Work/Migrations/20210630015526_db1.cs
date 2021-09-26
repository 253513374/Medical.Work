using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Medical.Work.Migrations
{
    public partial class db1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Medicalrecordnumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contactnumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Emai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Uername = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Emainame = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Createtime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MedicalDGK",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MedicalDGKGuid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Createtime = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                    Adminname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Createtime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TestorNot = table.Column<int>(type: "int", nullable: false),
                    TestTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Inspectiontime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SpecimenType = table.Column<int>(type: "int", nullable: false),
                    Reporttime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DrugsensitivityTest = table.Column<int>(type: "int", nullable: false),
                    Drugsname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MIC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Susceptibility = table.Column<int>(type: "int", nullable: false)
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
                    Createtime = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                    MedicalPKID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adminname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Createtime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MedicalPKName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LasttTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DrugsNmae = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DrugsNmae2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DrugSpecifications = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Manufacturertype = table.Column<int>(type: "int", nullable: false),
                    Drugdosage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DrugdosageUnit = table.Column<int>(type: "int", nullable: false),
                    DrugdosageRoute = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DrugNCount = table.Column<int>(type: "int", nullable: false),
                    DrugNCountDuration = table.Column<int>(type: "int", nullable: false),
                    DrugSolvent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SolventToDosage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AMTsingledose = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalPK", x => x.MedicalPKID);
                });

            migrationBuilder.CreateTable(
                name: "PatientInfo",
                columns: table => new
                {
                    PatientInfoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientInfoGuid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Createtime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Adminuser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Medicalrecordnumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<byte>(type: "tinyint", nullable: false),
                    AGE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BW = table.Column<int>(type: "int", nullable: false),
                    BWWeight = table.Column<int>(type: "int", nullable: false),
                    IsBWType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HEI = table.Column<int>(type: "int", nullable: false),
                    BMI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BSA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Transplantationtype = table.Column<int>(type: "int", nullable: true),
                    Transplantationtime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Ancestralhome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GCS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SOFA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    APACHEⅡ = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Admissiontime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Dischargetime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Medicalhistorysummary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Medication = table.Column<int>(type: "int", nullable: true),
                    Pathogenicbacteria = table.Column<int>(type: "int", nullable: true),
                    Healingeffect = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientInfo", x => x.PatientInfoID);
                });

            migrationBuilder.CreateTable(
                name: "Summaryreports",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cretetime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Amdinname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Summaryreportclass = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Medicalrecordnumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notesdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Clinicalsymptoms = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Treatmentplan = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Summaryreports", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "X_raybronchoscopys",
                columns: table => new
                {
                    X_raybronchoscopyID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cretetime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Adminname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Medicalrecordnumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Photodate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Reportdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Xraylocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Xrayinspection = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_X_raybronchoscopys", x => x.X_raybronchoscopyID);
                });

            migrationBuilder.CreateTable(
                name: "X_rayImagings",
                columns: table => new
                {
                    X_rayImagingID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cretetime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Adminname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Medicalrecordnumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Photodate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Reportdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Xrayimagingenum = table.Column<int>(type: "int", nullable: false),
                    XrayImaginglocationenum = table.Column<int>(type: "int", nullable: false),
                    Describe = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_X_rayImagings", x => x.X_rayImagingID);
                });

            migrationBuilder.CreateTable(
                name: "X_raypathologicals",
                columns: table => new
                {
                    X_raypathologicalID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cretetime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Adminname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Medicalrecordnumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Photodate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Reportdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Xraylocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Xrayinspection = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_X_raypathologicals", x => x.X_raypathologicalID);
                });

            migrationBuilder.CreateTable(
                name: "medicalPKSamplings",
                columns: table => new
                {
                    MedicalPKSamplingID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MedicalPKID = table.Column<int>(type: "int", nullable: false),
                    Createtime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SpecimenType = table.Column<int>(type: "int", nullable: false),
                    CollectDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Collectingvessel = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_medicalPKSamplings", x => x.MedicalPKSamplingID);
                    table.ForeignKey(
                        name: "FK_medicalPKSamplings_MedicalPK_MedicalPKID",
                        column: x => x.MedicalPKID,
                        principalTable: "MedicalPK",
                        principalColumn: "MedicalPKID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "patientInfoExDiagnosisTables",
                columns: table => new
                {
                    PatientInfoExDiagnosisTableID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientInfoID = table.Column<int>(type: "int", nullable: false),
                    AffectedDiagnosis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Affectedarea = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_patientInfoExDiagnosisTables", x => x.PatientInfoExDiagnosisTableID);
                    table.ForeignKey(
                        name: "FK_patientInfoExDiagnosisTables_PatientInfo_PatientInfoID",
                        column: x => x.PatientInfoID,
                        principalTable: "PatientInfo",
                        principalColumn: "PatientInfoID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "x_RaybronchoscopyPaths",
                columns: table => new
                {
                    X_raybronchoscopyPathsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adminuser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Createtime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    X_raybronchoscopyID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_x_RaybronchoscopyPaths", x => x.X_raybronchoscopyPathsID);
                    table.ForeignKey(
                        name: "FK_x_RaybronchoscopyPaths_X_raybronchoscopys_X_raybronchoscopyID",
                        column: x => x.X_raybronchoscopyID,
                        principalTable: "X_raybronchoscopys",
                        principalColumn: "X_raybronchoscopyID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "x_RayImagePaths",
                columns: table => new
                {
                    X_rayImagePathsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adminuser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Createtime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    X_rayImagingID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_x_RayImagePaths", x => x.X_rayImagePathsID);
                    table.ForeignKey(
                        name: "FK_x_RayImagePaths_X_rayImagings_X_rayImagingID",
                        column: x => x.X_rayImagingID,
                        principalTable: "X_rayImagings",
                        principalColumn: "X_rayImagingID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "x_RaypathologicalPaths",
                columns: table => new
                {
                    X_raypathologicalPathsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adminuser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Createtime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    X_raypathologicalID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_x_RaypathologicalPaths", x => x.X_raypathologicalPathsID);
                    table.ForeignKey(
                        name: "FK_x_RaypathologicalPaths_X_raypathologicals_X_raypathologicalID",
                        column: x => x.X_raypathologicalID,
                        principalTable: "X_raypathologicals",
                        principalColumn: "X_raypathologicalID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "pKSampling_Samples",
                columns: table => new
                {
                    MedicalPKSampling_sampleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MedicalPKSamplingID = table.Column<int>(type: "int", nullable: false),
                    SamplingNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C1bloodcollectiontime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    C1Concentration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C1ConcentrationUnit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C1ConcentrationStandard = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    C1ConcentrationMethod = table.Column<int>(type: "int", nullable: false),
                    C1Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pKSampling_Samples", x => x.MedicalPKSampling_sampleID);
                    table.ForeignKey(
                        name: "FK_pKSampling_Samples_medicalPKSamplings_MedicalPKSamplingID",
                        column: x => x.MedicalPKSamplingID,
                        principalTable: "medicalPKSamplings",
                        principalColumn: "MedicalPKSamplingID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_medicalPKSamplings_MedicalPKID",
                table: "medicalPKSamplings",
                column: "MedicalPKID");

            migrationBuilder.CreateIndex(
                name: "IX_patientInfoExDiagnosisTables_PatientInfoID",
                table: "patientInfoExDiagnosisTables",
                column: "PatientInfoID");

            migrationBuilder.CreateIndex(
                name: "IX_pKSampling_Samples_MedicalPKSamplingID",
                table: "pKSampling_Samples",
                column: "MedicalPKSamplingID");

            migrationBuilder.CreateIndex(
                name: "IX_x_RaybronchoscopyPaths_X_raybronchoscopyID",
                table: "x_RaybronchoscopyPaths",
                column: "X_raybronchoscopyID");

            migrationBuilder.CreateIndex(
                name: "IX_x_RayImagePaths_X_rayImagingID",
                table: "x_RayImagePaths",
                column: "X_rayImagingID");

            migrationBuilder.CreateIndex(
                name: "IX_x_RaypathologicalPaths_X_raypathologicalID",
                table: "x_RaypathologicalPaths",
                column: "X_raypathologicalID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "MedicalDGK");

            migrationBuilder.DropTable(
                name: "MedicalPD");

            migrationBuilder.DropTable(
                name: "MedicalPG");

            migrationBuilder.DropTable(
                name: "patientInfoExDiagnosisTables");

            migrationBuilder.DropTable(
                name: "pKSampling_Samples");

            migrationBuilder.DropTable(
                name: "Summaryreports");

            migrationBuilder.DropTable(
                name: "x_RaybronchoscopyPaths");

            migrationBuilder.DropTable(
                name: "x_RayImagePaths");

            migrationBuilder.DropTable(
                name: "x_RaypathologicalPaths");

            migrationBuilder.DropTable(
                name: "PatientInfo");

            migrationBuilder.DropTable(
                name: "medicalPKSamplings");

            migrationBuilder.DropTable(
                name: "X_raybronchoscopys");

            migrationBuilder.DropTable(
                name: "X_rayImagings");

            migrationBuilder.DropTable(
                name: "X_raypathologicals");

            migrationBuilder.DropTable(
                name: "MedicalPK");
        }
    }
}
