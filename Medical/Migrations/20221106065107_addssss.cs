using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Medical.Migrations
{
    public partial class addssss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Contactnumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adminname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Medicalrecordnumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Guid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LaboratoryExamination",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Assaysituation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Assaytime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BodyTemperature = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Scr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Screnum = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adminname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Medicalrecordnumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Guid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LaboratoryExamination", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PatientInfo",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Guid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adminname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Medicalrecordnumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AGE = table.Column<int>(type: "int", nullable: true),
                    MonthAGE = table.Column<int>(type: "int", nullable: true),
                    DayAGE = table.Column<int>(type: "int", nullable: true),
                    BW = table.Column<double>(type: "float", nullable: true),
                    BWWeight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsBWType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HEI = table.Column<int>(type: "int", nullable: true),
                    BMI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BSA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    INDiagnosis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OUTDiagnosis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Transplantationtype = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Transplantationtime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Ancestralhome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GCS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SOFA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    APACHEⅡ = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Admissiontime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Dischargetime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CollationAttribute = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientInfo", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PD_DrugAllergy",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestorisNot = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TestTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ReportTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DrugsensitivityTest = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DrugsensitivityTestOther = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DrugsName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MIC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Susceptibility = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TMic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AUCMic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adminname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Medicalrecordnumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Guid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PD_DrugAllergy", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PD_Microbiological",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestorisNot = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TestTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SpecimenType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TestorNot = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReportTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Inspectiontime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Bacterial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adminname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Medicalrecordnumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Guid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PD_Microbiological", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PG_PathogenGene",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PathogenName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PathogenicGeneName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PathogenicGeneDetectionResults = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Exegesis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adminname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Medicalrecordnumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Guid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PG_PathogenGene", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PG_Pharmacogenomics",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Genes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rs = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GenesResults = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Metabolictype = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Exegesis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adminname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Medicalrecordnumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Guid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PG_Pharmacogenomics", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PKs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MedicalPKName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LasttTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DrugsNmae = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DrugsNmae2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DrugSpecifications = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Manufacturertype = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Drugdosage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DrugdosageUnit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DrugdosageRoute = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DrugNCount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DrugNCountDuration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DrugSolvent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SolventToDosage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AMTsingledose = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adminname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Medicalrecordnumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Guid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PKs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SummaryOfCases",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Medicalhistorysummary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Medication = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pathogenicbacteria = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Healingeffect = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TextUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SummaryOfCasesGuid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PublishedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(160)", maxLength: 160, nullable: false),
                    BodyContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    IsFeatured = table.Column<bool>(type: "bit", nullable: false),
                    Ispublic = table.Column<bool>(type: "bit", nullable: false),
                    keywordTag = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adminname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Medicalrecordnumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Guid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SummaryOfCases", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Summaryreports",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Summaryreportclass = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Notesdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Clinicalsymptoms = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Treatmentplan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adminname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Medicalrecordnumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Guid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Summaryreports", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "X_raybronchoscopys",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Photodate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Reportdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Xraylocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Xrayinspection = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adminname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Medicalrecordnumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Guid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_X_raybronchoscopys", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "X_rayImagings",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Photodate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Reportdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Xrayimagingenum = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    XrayImaginglocationenum = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Describe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adminname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Medicalrecordnumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Guid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_X_rayImagings", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "X_raypathologicals",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Photodate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Reportdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Xraylocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Xrayinspection = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adminname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Medicalrecordnumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Guid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_X_raypathologicals", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PK_Samplings",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpecimenType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CollectDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StartDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Collectingvessel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MedicalPKID = table.Column<int>(type: "int", nullable: true),
                    Adminname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Medicalrecordnumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Guid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PK_Samplings", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PK_Samplings_PKs_MedicalPKID",
                        column: x => x.MedicalPKID,
                        principalTable: "PKs",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "patientInfoExDiagnosisTables",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    PatientInfoExDiagnosisTableID = table.Column<int>(type: "int", nullable: false),
                    AffectedDiagnosis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Affectedarea = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_patientInfoExDiagnosisTables", x => x.ID);
                    table.ForeignKey(
                        name: "FK_patientInfoExDiagnosisTables_SummaryOfCases_ID",
                        column: x => x.ID,
                        principalTable: "SummaryOfCases",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "x_RaybronchoscopyPaths",
                columns: table => new
                {
                    X_raybronchoscopyPathsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adminuser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_x_RaybronchoscopyPaths", x => x.X_raybronchoscopyPathsID);
                    table.ForeignKey(
                        name: "FK_x_RaybronchoscopyPaths_X_raybronchoscopys_ID",
                        column: x => x.ID,
                        principalTable: "X_raybronchoscopys",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "x_RayImagePaths",
                columns: table => new
                {
                    X_rayImagePathsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adminuser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_x_RayImagePaths", x => x.X_rayImagePathsID);
                    table.ForeignKey(
                        name: "FK_x_RayImagePaths_X_rayImagings_ID",
                        column: x => x.ID,
                        principalTable: "X_rayImagings",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "x_RaypathologicalPaths",
                columns: table => new
                {
                    X_raypathologicalPathsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adminuser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_x_RaypathologicalPaths", x => x.X_raypathologicalPathsID);
                    table.ForeignKey(
                        name: "FK_x_RaypathologicalPaths_X_raypathologicals_ID",
                        column: x => x.ID,
                        principalTable: "X_raypathologicals",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PK_Sampling_Samples",
                columns: table => new
                {
                    sampleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SamplingGuid = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sampleForeignKey = table.Column<int>(type: "int", nullable: false),
                    SamplingNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Samplingname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    C1bloodcollectiontime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    C1Concentration = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    C1ConcentrationUnit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    C1ConcentrationStandard = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    C1ConcentrationStandardUnit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    C1ConcentrationMethod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Other = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    C1Remarks = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Collectingvessel = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PK_Sampling_Samples", x => x.sampleId);
                    table.ForeignKey(
                        name: "FK_PK_Sampling_Samples_PK_Samplings_sampleForeignKey",
                        column: x => x.sampleForeignKey,
                        principalTable: "PK_Samplings",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PK_Sampling_Samples_sampleForeignKey",
                table: "PK_Sampling_Samples",
                column: "sampleForeignKey");

            migrationBuilder.CreateIndex(
                name: "IX_PK_Samplings_MedicalPKID",
                table: "PK_Samplings",
                column: "MedicalPKID");

            migrationBuilder.CreateIndex(
                name: "IX_x_RaybronchoscopyPaths_ID",
                table: "x_RaybronchoscopyPaths",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_x_RayImagePaths_ID",
                table: "x_RayImagePaths",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_x_RaypathologicalPaths_ID",
                table: "x_RaypathologicalPaths",
                column: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "LaboratoryExamination");

            migrationBuilder.DropTable(
                name: "PatientInfo");

            migrationBuilder.DropTable(
                name: "patientInfoExDiagnosisTables");

            migrationBuilder.DropTable(
                name: "PD_DrugAllergy");

            migrationBuilder.DropTable(
                name: "PD_Microbiological");

            migrationBuilder.DropTable(
                name: "PG_PathogenGene");

            migrationBuilder.DropTable(
                name: "PG_Pharmacogenomics");

            migrationBuilder.DropTable(
                name: "PK_Sampling_Samples");

            migrationBuilder.DropTable(
                name: "Summaryreports");

            migrationBuilder.DropTable(
                name: "x_RaybronchoscopyPaths");

            migrationBuilder.DropTable(
                name: "x_RayImagePaths");

            migrationBuilder.DropTable(
                name: "x_RaypathologicalPaths");

            migrationBuilder.DropTable(
                name: "SummaryOfCases");

            migrationBuilder.DropTable(
                name: "PK_Samplings");

            migrationBuilder.DropTable(
                name: "X_raybronchoscopys");

            migrationBuilder.DropTable(
                name: "X_rayImagings");

            migrationBuilder.DropTable(
                name: "X_raypathologicals");

            migrationBuilder.DropTable(
                name: "PKs");
        }
    }
}
