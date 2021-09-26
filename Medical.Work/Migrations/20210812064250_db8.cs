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
                newName: "Createtime");

            migrationBuilder.RenameColumn(
                name: "Cretetime",
                table: "X_rayImagings",
                newName: "Createtime");

            migrationBuilder.RenameColumn(
                name: "Cretetime",
                table: "X_raybronchoscopys",
                newName: "Createtime");

            migrationBuilder.RenameColumn(
                name: "Createtime",
                table: "LaboratoryExamination",
                newName: "Createtime");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Createtime",
                table: "X_raypathologicals",
                newName: "Cretetime");

            migrationBuilder.RenameColumn(
                name: "Createtime",
                table: "X_rayImagings",
                newName: "Cretetime");

            migrationBuilder.RenameColumn(
                name: "Createtime",
                table: "X_raybronchoscopys",
                newName: "Cretetime");

            migrationBuilder.RenameColumn(
                name: "Createtime",
                table: "LaboratoryExamination",
                newName: "Createtime");
        }
    }
}
