using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Medical.Work.Migrations
{
    public partial class db6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ALB",
                table: "MedicalPG");

            migrationBuilder.DropColumn(
                name: "ALP",
                table: "MedicalPG");

            migrationBuilder.DropColumn(
                name: "ALT",
                table: "MedicalPG");

            migrationBuilder.DropColumn(
                name: "AST",
                table: "MedicalPG");

            migrationBuilder.DropColumn(
                name: "Analysisadversereactions",
                table: "MedicalPG");

            migrationBuilder.DropColumn(
                name: "BUN",
                table: "MedicalPG");

            migrationBuilder.DropColumn(
                name: "BiochemicalTest",
                table: "MedicalPG");

            migrationBuilder.DropColumn(
                name: "CLcr",
                table: "MedicalPG");

            migrationBuilder.DropColumn(
                name: "CPscore",
                table: "MedicalPG");

            migrationBuilder.DropColumn(
                name: "CRP",
                table: "MedicalPG");

            migrationBuilder.DropColumn(
                name: "Combineduseofdrugs",
                table: "MedicalPG");

            migrationBuilder.DropColumn(
                name: "DirectTBLL",
                table: "MedicalPG");

            migrationBuilder.DropColumn(
                name: "EGFR",
                table: "MedicalPG");

            migrationBuilder.DropColumn(
                name: "ESR",
                table: "MedicalPG");

            migrationBuilder.DropColumn(
                name: "IL6",
                table: "MedicalPG");

            migrationBuilder.DropColumn(
                name: "INR",
                table: "MedicalPG");

            migrationBuilder.DropColumn(
                name: "IndirectTBLL",
                table: "MedicalPG");

            migrationBuilder.DropColumn(
                name: "Manufacturer",
                table: "MedicalPG");

            migrationBuilder.DropColumn(
                name: "PCT",
                table: "MedicalPG");

            migrationBuilder.DropColumn(
                name: "PLT",
                table: "MedicalPG");

            migrationBuilder.DropColumn(
                name: "PathogenicGeneDetectionResults",
                table: "MedicalPG");

            migrationBuilder.DropColumn(
                name: "PathogenicGeneName",
                table: "MedicalPG");

            migrationBuilder.DropColumn(
                name: "Remarks",
                table: "MedicalPG");

            migrationBuilder.DropColumn(
                name: "Scr",
                table: "MedicalPG");

            migrationBuilder.DropColumn(
                name: "Symptomsofadversereactions",
                table: "MedicalPG");

            migrationBuilder.DropColumn(
                name: "TBLL",
                table: "MedicalPG");

            migrationBuilder.DropColumn(
                name: "Treatmentoutcome",
                table: "MedicalPG");

            migrationBuilder.DropColumn(
                name: "Emainame",
                table: "Contacts");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "X_raypathologicals",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "Adminname",
                table: "X_raypathologicals",
                newName: "Adminname");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "X_rayImagings",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "Adminname",
                table: "X_rayImagings",
                newName: "Adminname");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "X_raybronchoscopys",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "Adminname",
                table: "X_raybronchoscopys",
                newName: "Adminname");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "Summaryreports",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "PatientInfo",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "Adminuser",
                table: "PatientInfo",
                newName: "Adminname");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "MedicalPG",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "WBC",
                table: "MedicalPG",
                newName: "Medicalrecordnumber");

            migrationBuilder.RenameColumn(
                name: "Typesofadversereactions",
                table: "MedicalPG",
                newName: "Exegesis");

            migrationBuilder.RenameColumn(
                name: "Treatmentsummary",
                table: "MedicalPG",
                newName: "Adminname");

            migrationBuilder.RenameColumn(
                name: "Adminname",
                table: "MedicalPD_Microbiological",
                newName: "Adminname");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "LaboratoryExamination",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "Adminuser",
                table: "LaboratoryExamination",
                newName: "Adminname");

            migrationBuilder.RenameColumn(
                name: "Uername",
                table: "Contacts",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Contacts",
                newName: "Adminname");

            migrationBuilder.AddColumn<string>(
                name: "Medicalrecordnumber",
                table: "MedicalPK",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "MedicalPK",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TestorisNot",
                table: "MedicalPD_Microbiological",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "TestorNot",
                table: "MedicalPD_Microbiological",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "SpecimenType",
                table: "MedicalPD_Microbiological",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Medicalrecordnumber",
                table: "MedicalPD_Microbiological",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "MedicalPD_Microbiological",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Susceptibility",
                table: "MedicalPD_DrugAllergy",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DrugsensitivityTest",
                table: "MedicalPD_DrugAllergy",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "DrugsensitivityTestOther",
                table: "MedicalPD_DrugAllergy",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Medicalrecordnumber",
                table: "MedicalPD_DrugAllergy",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ReportTime",
                table: "MedicalPD_DrugAllergy",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "MedicalPD_DrugAllergy",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Medicalrecordnumber",
                table: "MedicalPK");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "MedicalPK");

            migrationBuilder.DropColumn(
                name: "Medicalrecordnumber",
                table: "MedicalPD_Microbiological");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "MedicalPD_Microbiological");

            migrationBuilder.DropColumn(
                name: "DrugsensitivityTestOther",
                table: "MedicalPD_DrugAllergy");

            migrationBuilder.DropColumn(
                name: "Medicalrecordnumber",
                table: "MedicalPD_DrugAllergy");

            migrationBuilder.DropColumn(
                name: "ReportTime",
                table: "MedicalPD_DrugAllergy");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "MedicalPD_DrugAllergy");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "X_raypathologicals",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "Adminname",
                table: "X_raypathologicals",
                newName: "Adminname");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "X_rayImagings",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "Adminname",
                table: "X_rayImagings",
                newName: "Adminname");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "X_raybronchoscopys",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "Adminname",
                table: "X_raybronchoscopys",
                newName: "Adminname");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "Summaryreports",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "PatientInfo",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Adminname",
                table: "PatientInfo",
                newName: "Adminuser");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "MedicalPG",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "Medicalrecordnumber",
                table: "MedicalPG",
                newName: "WBC");

            migrationBuilder.RenameColumn(
                name: "Exegesis",
                table: "MedicalPG",
                newName: "Typesofadversereactions");

            migrationBuilder.RenameColumn(
                name: "Adminname",
                table: "MedicalPG",
                newName: "Treatmentsummary");

            migrationBuilder.RenameColumn(
                name: "Adminname",
                table: "MedicalPD_Microbiological",
                newName: "Adminname");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "LaboratoryExamination",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Adminname",
                table: "LaboratoryExamination",
                newName: "Adminuser");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "Contacts",
                newName: "Uername");

            migrationBuilder.RenameColumn(
                name: "Adminname",
                table: "Contacts",
                newName: "Name");

            migrationBuilder.AddColumn<string>(
                name: "ALB",
                table: "MedicalPG",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ALP",
                table: "MedicalPG",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ALT",
                table: "MedicalPG",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AST",
                table: "MedicalPG",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Analysisadversereactions",
                table: "MedicalPG",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BUN",
                table: "MedicalPG",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BiochemicalTest",
                table: "MedicalPG",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CLcr",
                table: "MedicalPG",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CPscore",
                table: "MedicalPG",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CRP",
                table: "MedicalPG",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Combineduseofdrugs",
                table: "MedicalPG",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DirectTBLL",
                table: "MedicalPG",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EGFR",
                table: "MedicalPG",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ESR",
                table: "MedicalPG",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IL6",
                table: "MedicalPG",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "INR",
                table: "MedicalPG",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IndirectTBLL",
                table: "MedicalPG",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Manufacturer",
                table: "MedicalPG",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PCT",
                table: "MedicalPG",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PLT",
                table: "MedicalPG",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PathogenicGeneDetectionResults",
                table: "MedicalPG",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PathogenicGeneName",
                table: "MedicalPG",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Remarks",
                table: "MedicalPG",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Scr",
                table: "MedicalPG",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Symptomsofadversereactions",
                table: "MedicalPG",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TBLL",
                table: "MedicalPG",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Treatmentoutcome",
                table: "MedicalPG",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TestorisNot",
                table: "MedicalPD_Microbiological",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TestorNot",
                table: "MedicalPD_Microbiological",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SpecimenType",
                table: "MedicalPD_Microbiological",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Susceptibility",
                table: "MedicalPD_DrugAllergy",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DrugsensitivityTest",
                table: "MedicalPD_DrugAllergy",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Emainame",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
