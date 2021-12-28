using Microsoft.EntityFrameworkCore.Migrations;

namespace Medical.Work.Migrations
{
    public partial class db3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PK_Samplings_PKs_MedicalPKID",
                table: "PK_Samplings");

            migrationBuilder.DropColumn(
                name: "MedicalPKID",
                table: "PKs");

            migrationBuilder.AlterColumn<int>(
                name: "MedicalPKID",
                table: "PK_Samplings",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MonthAGE",
                table: "PatientInfo",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DayAGE",
                table: "PatientInfo",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AGE",
                table: "PatientInfo",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PK_Samplings_PKs_MedicalPKID",
                table: "PK_Samplings",
                column: "MedicalPKID",
                principalTable: "PKs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PK_Samplings_PKs_MedicalPKID",
                table: "PK_Samplings");

            migrationBuilder.AddColumn<int>(
                name: "MedicalPKID",
                table: "PKs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "MedicalPKID",
                table: "PK_Samplings",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MonthAGE",
                table: "PatientInfo",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DayAGE",
                table: "PatientInfo",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AGE",
                table: "PatientInfo",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_PK_Samplings_PKs_MedicalPKID",
                table: "PK_Samplings",
                column: "MedicalPKID",
                principalTable: "PKs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}