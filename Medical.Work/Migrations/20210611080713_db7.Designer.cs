﻿// <auto-generated />
using System;
using Medical.Work.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Medical.Work.Migrations
{
    [DbContext(typeof(MedicalDbContext))]
    [Migration("20210611080713_db7")]
    partial class db7
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Medical.Work.Data.Models.Contacts", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contactnumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Emai")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Emainame")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Medicalrecordnumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Uername")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("dateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("Medical.Work.Data.Models.MedicalDGK", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("MedicalDGKGuid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("medicalPdguid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("medicalPgguid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("medicalPkguid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("patientInfoGuid")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("MedicalDGK");
                });

            modelBuilder.Entity("Medical.Work.Data.Models.MedicalPD", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Inspectiontime")
                        .HasColumnType("datetime2");

                    b.Property<string>("MIC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MedicalPDGuid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NGSinformation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Reporttime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Typeofspecimen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("MedicalPD");
                });

            modelBuilder.Entity("Medical.Work.Data.Models.MedicalPG", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ALB")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ALP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ALT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AST")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Analysisadversereactions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BUN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BiochemicalTest")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CLcr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CPscore")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CRP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Combineduseofdrugs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("DirectTBLL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EGFR")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ESR")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GenesResults")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IL6")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("INR")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IndirectTBLL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Manufacturer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MedicalPGGuid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Metabolictype")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PCT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PLT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PathogenicGeneDetectionResults")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PathogenicGeneName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Remarks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Scr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Symptomsofadversereactions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TBLL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Treatmentoutcome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Treatmentsummary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Typesofadversereactions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WBC")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("MedicalPG");
                });

            modelBuilder.Entity("Medical.Work.Data.Models.MedicalPK", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AMTNum")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AMTsingledose")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("C1bloodcollectiontime")
                        .HasColumnType("datetime2");

                    b.Property<string>("C1dvi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("C2bloodcollectiontime")
                        .HasColumnType("datetime2");

                    b.Property<string>("C2dvi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("C3bloodcollectiontime")
                        .HasColumnType("datetime2");

                    b.Property<string>("C3dvi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("C4bloodcollectiontime")
                        .HasColumnType("datetime2");

                    b.Property<string>("C4dvi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("C5bloodcollectiontime")
                        .HasColumnType("datetime2");

                    b.Property<string>("C5dvi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Channelofdrug")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Dialysissampleconcentrationresults")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dialysistype")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DurationofsingledialysisH")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Firstdate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Infusiontime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Infusiontimecomplete")
                        .HasColumnType("datetime2");

                    b.Property<string>("Maintenancedose")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MedicalPKGuid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nameofsolvent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Postoperativetime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Singledialysisdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Solventdose")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Startingtimeofdrug")
                        .HasColumnType("datetime2");

                    b.Property<string>("Starttimeofsingledialysis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Stoptimeofsingledialysis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Transplantation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Typesofdialysissamples")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("beforedrugdate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("beforedrugtimePM")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("bloodcollectiondate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("dialysissamplesamplingdate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("dialysissamplesamplingtime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("stopdrugdate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("stopdrugtime")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("MedicalPK");
                });

            modelBuilder.Entity("Medical.Work.Data.Models.PatientInfo", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("AGE")
                        .HasColumnType("datetime2");

                    b.Property<string>("APACHEⅡ")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Adminuser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Admissiontime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Ancestralhome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BMI")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BSA")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BW")
                        .HasColumnType("int");

                    b.Property<int>("BWWeight")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Department")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Dischargetime")
                        .HasColumnType("datetime2");

                    b.Property<string>("GCS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("Gender")
                        .HasColumnType("tinyint");

                    b.Property<int>("HEI")
                        .HasColumnType("int");

                    b.Property<int?>("Healingeffect")
                        .HasColumnType("int");

                    b.Property<string>("IsBWType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Medicalhistorysummary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Medicalrecordnumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Medication")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nationality")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Pathogenicbacteria")
                        .HasColumnType("int");

                    b.Property<string>("PatientInfoGuid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SOFA")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Transplantationtime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Transplantationtype")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("PatientInfo");
                });

            modelBuilder.Entity("Medical.Work.Data.Models.PatientInfoExDiagnosisTable", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AffectedDiagnosis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Affectedarea")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PatientInfoID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("PatientInfoID");

                    b.ToTable("PatientInfoExDiagnosisTable");
                });

            modelBuilder.Entity("Medical.Work.Data.Models.Summaryreport", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Amdinname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Clinicalsymptoms")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Cretetime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Medicalrecordnumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Notesdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Summaryreportclass")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Treatmentplan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Summaryreports");
                });

            modelBuilder.Entity("Medical.Work.Data.Models.X_rayImaging", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Amdinname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Cretetime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Describe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Imge1")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("Imge2")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("Imge3")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("Imge4")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("Imge5")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Medicalrecordnumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Photodate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Reportdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("XrayImaginglocationenum")
                        .HasColumnType("int");

                    b.Property<int>("Xrayimagingenum")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("X_rayImagings");
                });

            modelBuilder.Entity("Medical.Work.Data.Models.X_raybronchoscopy", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Amdinname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Cretetime")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("Imge1")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("Imge2")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("Imge3")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("Imge4")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("Imge5")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Medicalrecordnumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Photodate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Reportdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Xrayinspection")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Xraylocation")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("X_raybronchoscopys");
                });

            modelBuilder.Entity("Medical.Work.Data.Models.X_raypathological", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Amdinname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Cretetime")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("Imge1")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("Imge2")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("Imge3")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("Imge4")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("Imge5")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Medicalrecordnumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Photodate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Reportdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Xrayinspection")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Xraylocation")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("X_raypathologicals");
                });

            modelBuilder.Entity("Medical.Work.Data.Models.PatientInfoExDiagnosisTable", b =>
                {
                    b.HasOne("Medical.Work.Data.Models.PatientInfo", null)
                        .WithMany("PatientInfoExDiagnosisTable")
                        .HasForeignKey("PatientInfoID");
                });

            modelBuilder.Entity("Medical.Work.Data.Models.PatientInfo", b =>
                {
                    b.Navigation("PatientInfoExDiagnosisTable");
                });
#pragma warning restore 612, 618
        }
    }
}
