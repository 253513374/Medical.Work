using Microsoft.EntityFrameworkCore.Migrations;

namespace Medical.Work.Migrations
{
    public partial class db9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PatientInfoExDiagnosisTable_PatientInfo_PatientInfoID",
                table: "PatientInfoExDiagnosisTable");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PatientInfoExDiagnosisTable",
                table: "PatientInfoExDiagnosisTable");

            migrationBuilder.RenameTable(
                name: "PatientInfoExDiagnosisTable",
                newName: "patientInfoExDiagnosisTables");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "PatientInfo",
                newName: "PatientInfoID");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "patientInfoExDiagnosisTables",
                newName: "PatientInfoExDiagnosisTableID");

            migrationBuilder.RenameIndex(
                name: "IX_PatientInfoExDiagnosisTable_PatientInfoID",
                table: "patientInfoExDiagnosisTables",
                newName: "IX_patientInfoExDiagnosisTables_PatientInfoID");

            migrationBuilder.AlterColumn<int>(
                name: "PatientInfoID",
                table: "patientInfoExDiagnosisTables",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_patientInfoExDiagnosisTables",
                table: "patientInfoExDiagnosisTables",
                column: "PatientInfoExDiagnosisTableID");

            migrationBuilder.AddForeignKey(
                name: "FK_patientInfoExDiagnosisTables_PatientInfo_PatientInfoID",
                table: "patientInfoExDiagnosisTables",
                column: "PatientInfoID",
                principalTable: "PatientInfo",
                principalColumn: "PatientInfoID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_patientInfoExDiagnosisTables_PatientInfo_PatientInfoID",
                table: "patientInfoExDiagnosisTables");

            migrationBuilder.DropPrimaryKey(
                name: "PK_patientInfoExDiagnosisTables",
                table: "patientInfoExDiagnosisTables");

            migrationBuilder.RenameTable(
                name: "patientInfoExDiagnosisTables",
                newName: "PatientInfoExDiagnosisTable");

            migrationBuilder.RenameColumn(
                name: "PatientInfoID",
                table: "PatientInfo",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "PatientInfoExDiagnosisTableID",
                table: "PatientInfoExDiagnosisTable",
                newName: "ID");

            migrationBuilder.RenameIndex(
                name: "IX_patientInfoExDiagnosisTables_PatientInfoID",
                table: "PatientInfoExDiagnosisTable",
                newName: "IX_PatientInfoExDiagnosisTable_PatientInfoID");

            migrationBuilder.AlterColumn<int>(
                name: "PatientInfoID",
                table: "PatientInfoExDiagnosisTable",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PatientInfoExDiagnosisTable",
                table: "PatientInfoExDiagnosisTable",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_PatientInfoExDiagnosisTable_PatientInfo_PatientInfoID",
                table: "PatientInfoExDiagnosisTable",
                column: "PatientInfoID",
                principalTable: "PatientInfo",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
