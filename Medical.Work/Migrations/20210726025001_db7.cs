using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Medical.Work.Migrations
{
    public partial class db7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_medicalPKSamplings_MedicalPK_MedicalPKID",
                table: "medicalPKSamplings");

            migrationBuilder.DropForeignKey(
                name: "FK_pKSampling_Samples_medicalPKSamplings_MedicalPKSamplingID",
                table: "pKSampling_Samples");

            migrationBuilder.DropPrimaryKey(
                name: "PK_pKSampling_Samples",
                table: "pKSampling_Samples");

            migrationBuilder.DropPrimaryKey(
                name: "PK_medicalPKSamplings",
                table: "medicalPKSamplings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MedicalPK",
                table: "MedicalPK");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MedicalPG",
                table: "MedicalPG");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MedicalPD_Microbiological",
                table: "MedicalPD_Microbiological");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MedicalPD_DrugAllergy",
                table: "MedicalPD_DrugAllergy");

            migrationBuilder.RenameTable(
                name: "pKSampling_Samples",
                newName: "PK_Sampling_Samples");

            migrationBuilder.RenameTable(
                name: "medicalPKSamplings",
                newName: "PK_Samplings");

            migrationBuilder.RenameTable(
                name: "MedicalPK",
                newName: "PKs");

            migrationBuilder.RenameTable(
                name: "MedicalPG",
                newName: "PG_Pharmacogenomics");

            migrationBuilder.RenameTable(
                name: "MedicalPD_Microbiological",
                newName: "PD_Microbiological");

            migrationBuilder.RenameTable(
                name: "MedicalPD_DrugAllergy",
                newName: "PD_DrugAllergy");

            migrationBuilder.RenameIndex(
                name: "IX_pKSampling_Samples_MedicalPKSamplingID",
                table: "PK_Sampling_Samples",
                newName: "IX_PK_Sampling_Samples_MedicalPKSamplingID");

            migrationBuilder.RenameIndex(
                name: "IX_medicalPKSamplings_MedicalPKID",
                table: "PK_Samplings",
                newName: "IX_PK_Samplings_MedicalPKID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PK_Sampling_Samples",
                table: "PK_Sampling_Samples",
                column: "MedicalPKSampling_sampleID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PK_Samplings",
                table: "PK_Samplings",
                column: "MedicalPKSamplingID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PKs",
                table: "PKs",
                column: "MedicalPKID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PG_Pharmacogenomics",
                table: "PG_Pharmacogenomics",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PD_Microbiological",
                table: "PD_Microbiological",
                column: "MedicalPD_MicrobiologicalID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PD_DrugAllergy",
                table: "PD_DrugAllergy",
                column: "MedicalPD_DrugAllergyID");

            migrationBuilder.CreateTable(
                name: "PG_PathogenGene",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MedicalPGGuid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adminname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Createtime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Medicalrecordnumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PathogenName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PathogenicGeneName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PathogenicGeneDetectionResults = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Exegesis = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PG_PathogenGene", x => x.ID);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_PK_Sampling_Samples_PK_Samplings_MedicalPKSamplingID",
                table: "PK_Sampling_Samples",
                column: "MedicalPKSamplingID",
                principalTable: "PK_Samplings",
                principalColumn: "MedicalPKSamplingID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PK_Samplings_PKs_MedicalPKID",
                table: "PK_Samplings",
                column: "MedicalPKID",
                principalTable: "PKs",
                principalColumn: "MedicalPKID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PK_Sampling_Samples_PK_Samplings_MedicalPKSamplingID",
                table: "PK_Sampling_Samples");

            migrationBuilder.DropForeignKey(
                name: "FK_PK_Samplings_PKs_MedicalPKID",
                table: "PK_Samplings");

            migrationBuilder.DropTable(
                name: "PG_PathogenGene");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PKs",
                table: "PKs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PK_Samplings",
                table: "PK_Samplings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PK_Sampling_Samples",
                table: "PK_Sampling_Samples");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PG_Pharmacogenomics",
                table: "PG_Pharmacogenomics");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PD_Microbiological",
                table: "PD_Microbiological");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PD_DrugAllergy",
                table: "PD_DrugAllergy");

            migrationBuilder.RenameTable(
                name: "PKs",
                newName: "MedicalPK");

            migrationBuilder.RenameTable(
                name: "PK_Samplings",
                newName: "medicalPKSamplings");

            migrationBuilder.RenameTable(
                name: "PK_Sampling_Samples",
                newName: "pKSampling_Samples");

            migrationBuilder.RenameTable(
                name: "PG_Pharmacogenomics",
                newName: "MedicalPG");

            migrationBuilder.RenameTable(
                name: "PD_Microbiological",
                newName: "MedicalPD_Microbiological");

            migrationBuilder.RenameTable(
                name: "PD_DrugAllergy",
                newName: "MedicalPD_DrugAllergy");

            migrationBuilder.RenameIndex(
                name: "IX_PK_Samplings_MedicalPKID",
                table: "medicalPKSamplings",
                newName: "IX_medicalPKSamplings_MedicalPKID");

            migrationBuilder.RenameIndex(
                name: "IX_PK_Sampling_Samples_MedicalPKSamplingID",
                table: "pKSampling_Samples",
                newName: "IX_pKSampling_Samples_MedicalPKSamplingID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MedicalPK",
                table: "MedicalPK",
                column: "MedicalPKID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_medicalPKSamplings",
                table: "medicalPKSamplings",
                column: "MedicalPKSamplingID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_pKSampling_Samples",
                table: "pKSampling_Samples",
                column: "MedicalPKSampling_sampleID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MedicalPG",
                table: "MedicalPG",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MedicalPD_Microbiological",
                table: "MedicalPD_Microbiological",
                column: "MedicalPD_MicrobiologicalID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MedicalPD_DrugAllergy",
                table: "MedicalPD_DrugAllergy",
                column: "MedicalPD_DrugAllergyID");

            migrationBuilder.AddForeignKey(
                name: "FK_medicalPKSamplings_MedicalPK_MedicalPKID",
                table: "medicalPKSamplings",
                column: "MedicalPKID",
                principalTable: "MedicalPK",
                principalColumn: "MedicalPKID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_pKSampling_Samples_medicalPKSamplings_MedicalPKSamplingID",
                table: "pKSampling_Samples",
                column: "MedicalPKSamplingID",
                principalTable: "medicalPKSamplings",
                principalColumn: "MedicalPKSamplingID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
