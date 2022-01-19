﻿// <auto-generated />
using System;
using Medical.Work.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Medical.Work.Migrations
{
    [DbContext(typeof(MedicalDbContext))]
    partial class MedicalDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Medical.Work.Data.Models.Contacts", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Adminname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contactnumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Createtime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Emai")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Guid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Medicalrecordnumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Contacts", (string)null);
                });

            modelBuilder.Entity("Medical.Work.Data.Models.LaboratoryExamination", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("ALB")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ALP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ALT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AST")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Adminname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Assaysituation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Assaytime")
                        .HasColumnType("datetime2");

                    b.Property<string>("BUN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BodyTemperature")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CLcr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CRP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CSF")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Child_pugh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Createtime")
                        .HasColumnType("datetime2");

                    b.Property<string>("ESR")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GGT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Guid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hemoglobin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IL6")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("INR")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Medicalrecordnumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nitrite")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PCT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PLT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Remark")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Scr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Screnum")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Screnumother")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TBLL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TBLL_J")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TBLL_Z")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Uricine")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WBC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Yeast")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("bacterial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("eGFR")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("LaboratoryExamination", (string)null);
                });

            modelBuilder.Entity("Medical.Work.Data.Models.MedicalPD_DrugAllergy", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("AUCMic")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Adminname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Createtime")
                        .HasColumnType("datetime2");

                    b.Property<string>("DrugsName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DrugsensitivityTest")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DrugsensitivityTestOther")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Guid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MIC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Medicalrecordnumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ReportTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Susceptibility")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TMic")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TestTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("TestorisNot")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("PD_DrugAllergy", (string)null);
                });

            modelBuilder.Entity("Medical.Work.Data.Models.MedicalPD_Microbiological", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Adminname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Bacterial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Createtime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Guid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Inspectiontime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Medicalrecordnumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ReportTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("SpecimenType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TestTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("TestorNot")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TestorisNot")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("PD_Microbiological", (string)null);
                });

            modelBuilder.Entity("Medical.Work.Data.Models.MedicalPG_PathogenGene", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Adminname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Createtime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Exegesis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Guid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Medicalrecordnumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PathogenName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PathogenicGeneDetectionResults")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PathogenicGeneName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("PG_PathogenGene", (string)null);
                });

            modelBuilder.Entity("Medical.Work.Data.Models.MedicalPG_Pharmacogenomics", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Adminname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Createtime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Exegesis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GenesResults")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Guid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Medicalrecordnumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Metabolictype")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("PG_Pharmacogenomics", (string)null);
                });

            modelBuilder.Entity("Medical.Work.Data.Models.MedicalPK", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("AMTsingledose")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Adminname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Createtime")
                        .HasColumnType("datetime2");

                    b.Property<string>("DrugNCount")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DrugNCountDuration")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DrugSolvent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DrugSpecifications")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Drugdosage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DrugdosageRoute")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DrugdosageUnit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DrugsNmae")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DrugsNmae2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("FirstTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Guid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LasttTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Manufacturertype")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MedicalPKName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Medicalrecordnumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SolventToDosage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("PKs", (string)null);
                });

            modelBuilder.Entity("Medical.Work.Data.Models.MedicalPKSampling", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Adminname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CollectDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Collectingvessel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Createtime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EndDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Guid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("MedicalPKID")
                        .HasColumnType("int");

                    b.Property<string>("Medicalrecordnumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpecimenType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("MedicalPKID");

                    b.ToTable("PK_Samplings", (string)null);
                });

            modelBuilder.Entity("Medical.Work.Data.Models.MedicalPKSamplingsample", b =>
                {
                    b.Property<int>("sampleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("sampleId"), 1L, 1);

                    b.Property<string>("C1Concentration")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("C1ConcentrationMethod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("C1ConcentrationStandard")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("C1ConcentrationStandardUnit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("C1ConcentrationUnit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("C1Remarks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("C1bloodcollectiontime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Other")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SamplingNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Samplingname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("sampleForeignKey")
                        .HasColumnType("int");

                    b.HasKey("sampleId");

                    b.HasIndex("sampleForeignKey");

                    b.ToTable("PK_Sampling_Samples", (string)null);
                });

            modelBuilder.Entity("Medical.Work.Data.Models.PatientInfo", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("AGE")
                        .HasColumnType("int");

                    b.Property<string>("APACHEⅡ")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Adminname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Admissiontime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Ancestralhome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BMI")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BSA")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("BW")
                        .HasColumnType("float");

                    b.Property<string>("BWWeight")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Createtime")
                        .HasColumnType("datetime2");

                    b.Property<int>("DayAGE")
                        .HasColumnType("int");

                    b.Property<string>("Department")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Dischargetime")
                        .HasColumnType("datetime2");

                    b.Property<string>("GCS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Guid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HEI")
                        .HasColumnType("int");

                    b.Property<string>("IsBWType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Medicalrecordnumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MonthAGE")
                        .HasColumnType("int");

                    b.Property<string>("Nationality")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SOFA")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Transplantationtime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Transplantationtype")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("PatientInfo", (string)null);
                });

            modelBuilder.Entity("Medical.Work.Data.Models.PatientInfoExDiagnosisTable", b =>
                {
                    b.Property<int>("ID")
                        .HasColumnType("int");

                    b.Property<string>("AffectedDiagnosis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Affectedarea")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PatientInfoExDiagnosisTableID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("patientInfoExDiagnosisTables");
                });

            modelBuilder.Entity("Medical.Work.Data.Models.SummaryOfCases", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Adminname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Createtime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Guid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Healingeffect")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Medicalhistorysummary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Medicalrecordnumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Medication")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pathogenicbacteria")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TextUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("SummaryOfCases");
                });

            modelBuilder.Entity("Medical.Work.Data.Models.Summaryreport", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Adminname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Clinicalsymptoms")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Createtime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Guid")
                        .HasColumnType("nvarchar(max)");

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

            modelBuilder.Entity("Medical.Work.Data.Models.X_raybronchoscopy", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Adminname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Createtime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Guid")
                        .HasColumnType("nvarchar(max)");

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

            modelBuilder.Entity("Medical.Work.Data.Models.X_raybronchoscopyPaths", b =>
                {
                    b.Property<int>("X_raybronchoscopyPathsID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("X_raybronchoscopyPathsID"), 1L, 1);

                    b.Property<string>("Adminuser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Createtime")
                        .HasColumnType("datetime2");

                    b.Property<int>("ID")
                        .HasColumnType("int");

                    b.Property<string>("ImgUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("X_raybronchoscopyPathsID");

                    b.HasIndex("ID");

                    b.ToTable("x_RaybronchoscopyPaths");
                });

            modelBuilder.Entity("Medical.Work.Data.Models.X_rayImagePaths", b =>
                {
                    b.Property<int>("ID")
                        .HasColumnType("int");

                    b.Property<string>("Adminuser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Createtime")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImgUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("X_rayImagePathsID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("x_RayImagePaths");
                });

            modelBuilder.Entity("Medical.Work.Data.Models.X_rayImaging", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Adminname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Createtime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Describe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Guid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Medicalrecordnumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Photodate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Reportdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("XrayImaginglocationenum")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Xrayimagingenum")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("X_rayImagings");
                });

            modelBuilder.Entity("Medical.Work.Data.Models.X_raypathological", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Adminname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Createtime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Guid")
                        .HasColumnType("nvarchar(max)");

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

            modelBuilder.Entity("Medical.Work.Data.Models.X_raypathologicalPaths", b =>
                {
                    b.Property<int>("ID")
                        .HasColumnType("int");

                    b.Property<string>("Adminuser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Createtime")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImgUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("X_raypathologicalPathsID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("x_RaypathologicalPaths");
                });

            modelBuilder.Entity("Medical.Work.Data.Models.MedicalPKSampling", b =>
                {
                    b.HasOne("Medical.Work.Data.Models.MedicalPK", null)
                        .WithMany("MedicalPKSamplings")
                        .HasForeignKey("MedicalPKID");
                });

            modelBuilder.Entity("Medical.Work.Data.Models.MedicalPKSamplingsample", b =>
                {
                    b.HasOne("Medical.Work.Data.Models.MedicalPKSampling", "medicalPKSampling")
                        .WithMany("medicalPKSamplings")
                        .HasForeignKey("sampleForeignKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("medicalPKSampling");
                });

            modelBuilder.Entity("Medical.Work.Data.Models.PatientInfoExDiagnosisTable", b =>
                {
                    b.HasOne("Medical.Work.Data.Models.SummaryOfCases", "Summaryofcases")
                        .WithMany("PatientInfoExDiagnosisTable")
                        .HasForeignKey("ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Summaryofcases");
                });

            modelBuilder.Entity("Medical.Work.Data.Models.X_raybronchoscopyPaths", b =>
                {
                    b.HasOne("Medical.Work.Data.Models.X_raybronchoscopy", "x_Raybronchoscopy")
                        .WithMany("ImgUrl")
                        .HasForeignKey("ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("x_Raybronchoscopy");
                });

            modelBuilder.Entity("Medical.Work.Data.Models.X_rayImagePaths", b =>
                {
                    b.HasOne("Medical.Work.Data.Models.X_rayImaging", "x_RayImaging")
                        .WithMany("ImgUrl")
                        .HasForeignKey("ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("x_RayImaging");
                });

            modelBuilder.Entity("Medical.Work.Data.Models.X_raypathologicalPaths", b =>
                {
                    b.HasOne("Medical.Work.Data.Models.X_raypathological", "x_Raypathological")
                        .WithMany("ImgUrl")
                        .HasForeignKey("ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("x_Raypathological");
                });

            modelBuilder.Entity("Medical.Work.Data.Models.MedicalPK", b =>
                {
                    b.Navigation("MedicalPKSamplings");
                });

            modelBuilder.Entity("Medical.Work.Data.Models.MedicalPKSampling", b =>
                {
                    b.Navigation("medicalPKSamplings");
                });

            modelBuilder.Entity("Medical.Work.Data.Models.SummaryOfCases", b =>
                {
                    b.Navigation("PatientInfoExDiagnosisTable");
                });

            modelBuilder.Entity("Medical.Work.Data.Models.X_raybronchoscopy", b =>
                {
                    b.Navigation("ImgUrl");
                });

            modelBuilder.Entity("Medical.Work.Data.Models.X_rayImaging", b =>
                {
                    b.Navigation("ImgUrl");
                });

            modelBuilder.Entity("Medical.Work.Data.Models.X_raypathological", b =>
                {
                    b.Navigation("ImgUrl");
                });
#pragma warning restore 612, 618
        }
    }
}
