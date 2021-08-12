using Microsoft.EntityFrameworkCore.Migrations;

namespace Medical.Work.Migrations
{
    public partial class db8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Cretetime",
                table: "X_raypathologicals",
                newName: "CreateTime");

            migrationBuilder.RenameColumn(
                name: "Cretetime",
                table: "X_rayImagings",
                newName: "CreateTime");

            migrationBuilder.RenameColumn(
                name: "Cretetime",
                table: "X_raybronchoscopys",
                newName: "CreateTime");

            migrationBuilder.RenameColumn(
                name: "Createtime",
                table: "LaboratoryExamination",
                newName: "CreateTime");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreateTime",
                table: "X_raypathologicals",
                newName: "Cretetime");

            migrationBuilder.RenameColumn(
                name: "CreateTime",
                table: "X_rayImagings",
                newName: "Cretetime");

            migrationBuilder.RenameColumn(
                name: "CreateTime",
                table: "X_raybronchoscopys",
                newName: "Cretetime");

            migrationBuilder.RenameColumn(
                name: "CreateTime",
                table: "LaboratoryExamination",
                newName: "Createtime");
        }
    }
}
