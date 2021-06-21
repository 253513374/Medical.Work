using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Medical.Work.Migrations
{
    public partial class db8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AMTNum",
                table: "MedicalPK");

            migrationBuilder.DropColumn(
                name: "C1bloodcollectiontime",
                table: "MedicalPK");

            migrationBuilder.DropColumn(
                name: "C1dvi",
                table: "MedicalPK");

            migrationBuilder.DropColumn(
                name: "C2bloodcollectiontime",
                table: "MedicalPK");

            migrationBuilder.DropColumn(
                name: "C2dvi",
                table: "MedicalPK");

            migrationBuilder.DropColumn(
                name: "C3bloodcollectiontime",
                table: "MedicalPK");

            migrationBuilder.DropColumn(
                name: "C3dvi",
                table: "MedicalPK");

            migrationBuilder.DropColumn(
                name: "C4bloodcollectiontime",
                table: "MedicalPK");

            migrationBuilder.DropColumn(
                name: "C4dvi",
                table: "MedicalPK");

            migrationBuilder.DropColumn(
                name: "C5bloodcollectiontime",
                table: "MedicalPK");

            migrationBuilder.DropColumn(
                name: "C5dvi",
                table: "MedicalPK");

            migrationBuilder.DropColumn(
                name: "Channelofdrug",
                table: "MedicalPK");

            migrationBuilder.DropColumn(
                name: "DateTime",
                table: "MedicalPK");

            migrationBuilder.DropColumn(
                name: "Dialysissampleconcentrationresults",
                table: "MedicalPK");

            migrationBuilder.DropColumn(
                name: "Dialysistype",
                table: "MedicalPK");

            migrationBuilder.DropColumn(
                name: "DurationofsingledialysisH",
                table: "MedicalPK");

            migrationBuilder.DropColumn(
                name: "Firstdate",
                table: "MedicalPK");

            migrationBuilder.DropColumn(
                name: "Infusiontime",
                table: "MedicalPK");

            migrationBuilder.DropColumn(
                name: "Infusiontimecomplete",
                table: "MedicalPK");

            migrationBuilder.DropColumn(
                name: "Maintenancedose",
                table: "MedicalPK");

            migrationBuilder.DropColumn(
                name: "MedicalPKGuid",
                table: "MedicalPK");

            migrationBuilder.DropColumn(
                name: "Nameofsolvent",
                table: "MedicalPK");

            migrationBuilder.DropColumn(
                name: "Singledialysisdate",
                table: "MedicalPK");

            migrationBuilder.DropColumn(
                name: "Startingtimeofdrug",
                table: "MedicalPK");

            migrationBuilder.DropColumn(
                name: "beforedrugdate",
                table: "MedicalPK");

            migrationBuilder.DropColumn(
                name: "beforedrugtimePM",
                table: "MedicalPK");

            migrationBuilder.DropColumn(
                name: "bloodcollectiondate",
                table: "MedicalPK");

            migrationBuilder.DropColumn(
                name: "dialysissamplesamplingdate",
                table: "MedicalPK");

            migrationBuilder.DropColumn(
                name: "MedicalPDGuid",
                table: "MedicalPD");

            migrationBuilder.DropColumn(
                name: "NGSinformation",
                table: "MedicalPD");

            migrationBuilder.RenameColumn(
                name: "Amdinname",
                table: "X_raypathologicals",
                newName: "Adminname");

            migrationBuilder.RenameColumn(
                name: "Amdinname",
                table: "X_rayImagings",
                newName: "Adminname");

            migrationBuilder.RenameColumn(
                name: "Amdinname",
                table: "X_raybronchoscopys",
                newName: "Adminname");

            migrationBuilder.RenameColumn(
                name: "DateTime",
                table: "PatientInfo",
                newName: "CreateTime");

            migrationBuilder.RenameColumn(
                name: "stopdrugtime",
                table: "MedicalPK",
                newName: "LasttTime");

            migrationBuilder.RenameColumn(
                name: "stopdrugdate",
                table: "MedicalPK",
                newName: "FirstTime");

            migrationBuilder.RenameColumn(
                name: "dialysissamplesamplingtime",
                table: "MedicalPK",
                newName: "CreateTime");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "MedicalPK",
                newName: "DrugsNmae2");

            migrationBuilder.RenameColumn(
                name: "Typesofdialysissamples",
                table: "MedicalPK",
                newName: "DrugsNmae");

            migrationBuilder.RenameColumn(
                name: "Transplantation",
                table: "MedicalPK",
                newName: "DrugdosageRoute");

            migrationBuilder.RenameColumn(
                name: "Stoptimeofsingledialysis",
                table: "MedicalPK",
                newName: "Drugdosage");

            migrationBuilder.RenameColumn(
                name: "Starttimeofsingledialysis",
                table: "MedicalPK",
                newName: "DrugSpecifications");

            migrationBuilder.RenameColumn(
                name: "Solventdose",
                table: "MedicalPK",
                newName: "DrugNCount");

            migrationBuilder.RenameColumn(
                name: "Postoperativetime",
                table: "MedicalPK",
                newName: "AdminName");

            migrationBuilder.RenameColumn(
                name: "DateTime",
                table: "MedicalPG",
                newName: "CreateTime");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "MedicalPD",
                newName: "Drugsname");

            migrationBuilder.RenameColumn(
                name: "Typeofspecimen",
                table: "MedicalPD",
                newName: "Adminname");

            migrationBuilder.RenameColumn(
                name: "DateTime",
                table: "MedicalPD",
                newName: "TestTime");

            migrationBuilder.RenameColumn(
                name: "DateTime",
                table: "MedicalDGK",
                newName: "CreateTime");

            migrationBuilder.RenameColumn(
                name: "dateTime",
                table: "Contacts",
                newName: "CreateTime");

            migrationBuilder.AddColumn<int>(
                name: "DrugdosageUnit",
                table: "MedicalPK",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Manufacturertype",
                table: "MedicalPK",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateTime",
                table: "MedicalPD",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "DrugsensitivityTest",
                table: "MedicalPD",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SpecimenType",
                table: "MedicalPD",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Susceptibility",
                table: "MedicalPD",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TestorNot",
                table: "MedicalPD",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "medicalPKSamplings",
                columns: table => new
                {
                    MedicalPKSamplingID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                name: "IX_pKSampling_Samples_MedicalPKSamplingID",
                table: "pKSampling_Samples",
                column: "MedicalPKSamplingID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "pKSampling_Samples");

            migrationBuilder.DropTable(
                name: "medicalPKSamplings");

            migrationBuilder.DropColumn(
                name: "DrugdosageUnit",
                table: "MedicalPK");

            migrationBuilder.DropColumn(
                name: "Manufacturertype",
                table: "MedicalPK");

            migrationBuilder.DropColumn(
                name: "CreateTime",
                table: "MedicalPD");

            migrationBuilder.DropColumn(
                name: "DrugsensitivityTest",
                table: "MedicalPD");

            migrationBuilder.DropColumn(
                name: "SpecimenType",
                table: "MedicalPD");

            migrationBuilder.DropColumn(
                name: "Susceptibility",
                table: "MedicalPD");

            migrationBuilder.DropColumn(
                name: "TestorNot",
                table: "MedicalPD");

            migrationBuilder.RenameColumn(
                name: "Adminname",
                table: "X_raypathologicals",
                newName: "Amdinname");

            migrationBuilder.RenameColumn(
                name: "Adminname",
                table: "X_rayImagings",
                newName: "Amdinname");

            migrationBuilder.RenameColumn(
                name: "Adminname",
                table: "X_raybronchoscopys",
                newName: "Amdinname");

            migrationBuilder.RenameColumn(
                name: "CreateTime",
                table: "PatientInfo",
                newName: "DateTime");

            migrationBuilder.RenameColumn(
                name: "LasttTime",
                table: "MedicalPK",
                newName: "stopdrugtime");

            migrationBuilder.RenameColumn(
                name: "FirstTime",
                table: "MedicalPK",
                newName: "stopdrugdate");

            migrationBuilder.RenameColumn(
                name: "DrugsNmae2",
                table: "MedicalPK",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "DrugsNmae",
                table: "MedicalPK",
                newName: "Typesofdialysissamples");

            migrationBuilder.RenameColumn(
                name: "DrugdosageRoute",
                table: "MedicalPK",
                newName: "Transplantation");

            migrationBuilder.RenameColumn(
                name: "Drugdosage",
                table: "MedicalPK",
                newName: "Stoptimeofsingledialysis");

            migrationBuilder.RenameColumn(
                name: "DrugSpecifications",
                table: "MedicalPK",
                newName: "Starttimeofsingledialysis");

            migrationBuilder.RenameColumn(
                name: "DrugNCount",
                table: "MedicalPK",
                newName: "Solventdose");

            migrationBuilder.RenameColumn(
                name: "CreateTime",
                table: "MedicalPK",
                newName: "dialysissamplesamplingtime");

            migrationBuilder.RenameColumn(
                name: "AdminName",
                table: "MedicalPK",
                newName: "Postoperativetime");

            migrationBuilder.RenameColumn(
                name: "CreateTime",
                table: "MedicalPG",
                newName: "DateTime");

            migrationBuilder.RenameColumn(
                name: "TestTime",
                table: "MedicalPD",
                newName: "DateTime");

            migrationBuilder.RenameColumn(
                name: "Drugsname",
                table: "MedicalPD",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "Adminname",
                table: "MedicalPD",
                newName: "Typeofspecimen");

            migrationBuilder.RenameColumn(
                name: "CreateTime",
                table: "MedicalDGK",
                newName: "DateTime");

            migrationBuilder.RenameColumn(
                name: "CreateTime",
                table: "Contacts",
                newName: "dateTime");

            migrationBuilder.AddColumn<string>(
                name: "AMTNum",
                table: "MedicalPK",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "C1bloodcollectiontime",
                table: "MedicalPK",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "C1dvi",
                table: "MedicalPK",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "C2bloodcollectiontime",
                table: "MedicalPK",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "C2dvi",
                table: "MedicalPK",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "C3bloodcollectiontime",
                table: "MedicalPK",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "C3dvi",
                table: "MedicalPK",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "C4bloodcollectiontime",
                table: "MedicalPK",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "C4dvi",
                table: "MedicalPK",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "C5bloodcollectiontime",
                table: "MedicalPK",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "C5dvi",
                table: "MedicalPK",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Channelofdrug",
                table: "MedicalPK",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateTime",
                table: "MedicalPK",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Dialysissampleconcentrationresults",
                table: "MedicalPK",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Dialysistype",
                table: "MedicalPK",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DurationofsingledialysisH",
                table: "MedicalPK",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Firstdate",
                table: "MedicalPK",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Infusiontime",
                table: "MedicalPK",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Infusiontimecomplete",
                table: "MedicalPK",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Maintenancedose",
                table: "MedicalPK",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MedicalPKGuid",
                table: "MedicalPK",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nameofsolvent",
                table: "MedicalPK",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Singledialysisdate",
                table: "MedicalPK",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Startingtimeofdrug",
                table: "MedicalPK",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "beforedrugdate",
                table: "MedicalPK",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "beforedrugtimePM",
                table: "MedicalPK",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "bloodcollectiondate",
                table: "MedicalPK",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "dialysissamplesamplingdate",
                table: "MedicalPK",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "MedicalPDGuid",
                table: "MedicalPD",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NGSinformation",
                table: "MedicalPD",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
