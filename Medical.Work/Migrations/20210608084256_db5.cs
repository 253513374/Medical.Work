using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Medical.Work.Migrations
{
    public partial class db5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Summaryreports",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cretetime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Amdinname = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cretetime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Amdinname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Medicalrecordnumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Photodate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Reportdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Xraylocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Xrayinspection = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Imge1 = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Imge2 = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Imge3 = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Imge4 = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Imge5 = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
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
                    Cretetime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Amdinname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Medicalrecordnumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Photodate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Reportdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Xrayimagingenum = table.Column<int>(type: "int", nullable: false),
                    XrayImaginglocationenum = table.Column<int>(type: "int", nullable: false),
                    Describe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Imge1 = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Imge2 = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Imge3 = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Imge4 = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Imge5 = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
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
                    Cretetime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Amdinname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Medicalrecordnumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Photodate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Reportdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Xraylocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Xrayinspection = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Imge1 = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Imge2 = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Imge3 = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Imge4 = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Imge5 = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_X_raypathologicals", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Summaryreports");

            migrationBuilder.DropTable(
                name: "X_raybronchoscopys");

            migrationBuilder.DropTable(
                name: "X_rayImagings");

            migrationBuilder.DropTable(
                name: "X_raypathologicals");
        }
    }
}
