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
    [Migration("20210812064250_db8")]
    partial class db8
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Medical.Work.Data.Models.Contacts", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Adminname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contactnumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Createtime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Emai")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Medicalrecordnumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("Medical.Work.Data.Models.LaboratoryExamination", b =>
                {
                    b.Property<int>("LaboratoryExaminationID")
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

                    b.Property<string>("Adminname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Assaysituation")
                        .HasColumnType("int");

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

                    b.Property<string>("PatientInfoGuid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Remark")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Scr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Screnum")
                        .HasColumnType("int");

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

                    b.HasKey("LaboratoryExaminationID");

                    b.ToTable("LaboratoryExamination");
                });

            modelBuilder.Entity("Medical.Work.Data.Models.MedicalDGK", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Createtime")
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

            modelBuilder.Entity("Medical.Work.Data.Models.MedicalPD_DrugAllergy", b =>
                {
                    b.Property<int>("MedicalPD_DrugAllergyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AUCMic")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Adminname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Createtime")
                        .HasColumnType("datetime2");

                    b.Property<string>("DrugsName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DrugsensitivityTest")
                        .HasColumnType("int");

                    b.Property<string>("DrugsensitivityTestOther")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MIC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Medicalrecordnumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("P_Guid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ReportTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Susceptibility")
                        .HasColumnType("int");

                    b.Property<string>("TMic")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TestTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("TestorisNot")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MedicalPD_DrugAllergyID");

                    b.ToTable("PD_DrugAllergy");
                });

            modelBuilder.Entity("Medical.Work.Data.Models.MedicalPD_Microbiological", b =>
                {
                    b.Property<int>("MedicalPD_MicrobiologicalID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adminname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Bacterial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Createtime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Inspectiontime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Medicalrecordnumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("P_Guid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ReportTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("SpecimenType")
                        .HasColumnType("int");

                    b.Property<DateTime>("TestTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("TestorNot")
                        .HasColumnType("int");

                    b.Property<int?>("TestorisNot")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MedicalPD_MicrobiologicalID");

                    b.ToTable("PD_Microbiological");
                });

            modelBuilder.Entity("Medical.Work.Data.Models.MedicalPG_PathogenGene", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adminname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Createtime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Exegesis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MedicalPGGuid")
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

                    b.ToTable("PG_PathogenGene");
                });

            modelBuilder.Entity("Medical.Work.Data.Models.MedicalPG_Pharmacogenomics", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

                    b.Property<string>("MedicalPGGuid")
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

                    b.ToTable("PG_Pharmacogenomics");
                });

            modelBuilder.Entity("Medical.Work.Data.Models.MedicalPK", b =>
                {
                    b.Property<int>("MedicalPKID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AMTsingledose")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Adminname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Createtime")
                        .HasColumnType("datetime2");

                    b.Property<int>("DrugNCount")
                        .HasColumnType("int");

                    b.Property<int>("DrugNCountDuration")
                        .HasColumnType("int");

                    b.Property<string>("DrugSolvent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DrugSpecifications")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Drugdosage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DrugdosageRoute")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DrugdosageUnit")
                        .HasColumnType("int");

                    b.Property<string>("DrugsNmae")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DrugsNmae2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("FirstTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LasttTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Manufacturertype")
                        .HasColumnType("int");

                    b.Property<string>("MedicalPKGuid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MedicalPKName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Medicalrecordnumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SolventToDosage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MedicalPKID");

                    b.ToTable("PKs");
                });

            modelBuilder.Entity("Medical.Work.Data.Models.MedicalPKSampling", b =>
                {
                    b.Property<int>("MedicalPKSamplingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adminname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CollectDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Collectingvessel")
                        .HasColumnType("int");

                    b.Property<DateTime>("Createtime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EndDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LastDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("MedicalPKID")
                        .HasColumnType("int");

                    b.Property<int?>("SpecimenType")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("MedicalPKSamplingID");

                    b.HasIndex("MedicalPKID");

                    b.ToTable("PK_Samplings");
                });

            modelBuilder.Entity("Medical.Work.Data.Models.MedicalPKSampling_sample", b =>
                {
                    b.Property<int>("MedicalPKSampling_sampleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("C1Concentration")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("C1ConcentrationMethod")
                        .HasColumnType("int");

                    b.Property<string>("C1ConcentrationStandard")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("C1ConcentrationUnit")
                        .HasColumnType("int");

                    b.Property<string>("C1Remarks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("C1bloodcollectiontime")
                        .HasColumnType("datetime2");

                    b.Property<int>("MedicalPKSamplingID")
                        .HasColumnType("int");

                    b.Property<string>("Other")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SamplingNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MedicalPKSampling_sampleID");

                    b.HasIndex("MedicalPKSamplingID");

                    b.ToTable("PK_Sampling_Samples");
                });

            modelBuilder.Entity("Medical.Work.Data.Models.PatientInfo", b =>
                {
                    b.Property<int>("PatientInfoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("AGE")
                        .HasColumnType("datetime2");

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

                    b.Property<int>("BW")
                        .HasColumnType("int");

                    b.Property<int>("BWWeight")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Createtime")
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

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PatientInfoID");

                    b.ToTable("PatientInfo");
                });

            modelBuilder.Entity("Medical.Work.Data.Models.PatientInfoExDiagnosisTable", b =>
                {
                    b.Property<int>("PatientInfoExDiagnosisTableID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AffectedDiagnosis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Affectedarea")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PatientInfoID")
                        .HasColumnType("int");

                    b.HasKey("PatientInfoExDiagnosisTableID");

                    b.HasIndex("PatientInfoID");

                    b.ToTable("patientInfoExDiagnosisTables");
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

            modelBuilder.Entity("Medical.Work.Data.Models.X_rayImagePaths", b =>
                {
                    b.Property<int>("X_rayImagePathsID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adminuser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Createtime")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImgUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("X_rayImagingID")
                        .HasColumnType("int");

                    b.HasKey("X_rayImagePathsID");

                    b.HasIndex("X_rayImagingID");

                    b.ToTable("x_RayImagePaths");
                });

            modelBuilder.Entity("Medical.Work.Data.Models.X_rayImaging", b =>
                {
                    b.Property<int>("X_rayImagingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adminname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Createtime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Describe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Medicalrecordnumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PatientInfoGuid")
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

                    b.HasKey("X_rayImagingID");

                    b.ToTable("X_rayImagings");
                });

            modelBuilder.Entity("Medical.Work.Data.Models.X_raybronchoscopy", b =>
                {
                    b.Property<int>("X_raybronchoscopyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adminname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Createtime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Medicalrecordnumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PatientInfoGuid")
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

                    b.HasKey("X_raybronchoscopyID");

                    b.ToTable("X_raybronchoscopys");
                });

            modelBuilder.Entity("Medical.Work.Data.Models.X_raybronchoscopyPaths", b =>
                {
                    b.Property<int>("X_raybronchoscopyPathsID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adminuser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Createtime")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImgUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("X_raybronchoscopyID")
                        .HasColumnType("int");

                    b.HasKey("X_raybronchoscopyPathsID");

                    b.HasIndex("X_raybronchoscopyID");

                    b.ToTable("x_RaybronchoscopyPaths");
                });

            modelBuilder.Entity("Medical.Work.Data.Models.X_raypathological", b =>
                {
                    b.Property<int>("X_raypathologicalID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adminname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Createtime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Medicalrecordnumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PatientInfoGuid")
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

                    b.HasKey("X_raypathologicalID");

                    b.ToTable("X_raypathologicals");
                });

            modelBuilder.Entity("Medical.Work.Data.Models.X_raypathologicalPaths", b =>
                {
                    b.Property<int>("X_raypathologicalPathsID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adminuser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Createtime")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImgUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("X_raypathologicalID")
                        .HasColumnType("int");

                    b.HasKey("X_raypathologicalPathsID");

                    b.HasIndex("X_raypathologicalID");

                    b.ToTable("x_RaypathologicalPaths");
                });

            modelBuilder.Entity("Medical.Work.Data.Models.MedicalPKSampling", b =>
                {
                    b.HasOne("Medical.Work.Data.Models.MedicalPK", "medicalPK")
                        .WithMany("MedicalPKSamplings")
                        .HasForeignKey("MedicalPKID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("medicalPK");
                });

            modelBuilder.Entity("Medical.Work.Data.Models.MedicalPKSampling_sample", b =>
                {
                    b.HasOne("Medical.Work.Data.Models.MedicalPKSampling", "medicalPKSampling")
                        .WithMany("medicalPKSamplings")
                        .HasForeignKey("MedicalPKSamplingID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("medicalPKSampling");
                });

            modelBuilder.Entity("Medical.Work.Data.Models.PatientInfoExDiagnosisTable", b =>
                {
                    b.HasOne("Medical.Work.Data.Models.PatientInfo", "Patient")
                        .WithMany("PatientInfoExDiagnosisTable")
                        .HasForeignKey("PatientInfoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("Medical.Work.Data.Models.X_rayImagePaths", b =>
                {
                    b.HasOne("Medical.Work.Data.Models.X_rayImaging", "x_RayImaging")
                        .WithMany("ImgUrl")
                        .HasForeignKey("X_rayImagingID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("x_RayImaging");
                });

            modelBuilder.Entity("Medical.Work.Data.Models.X_raybronchoscopyPaths", b =>
                {
                    b.HasOne("Medical.Work.Data.Models.X_raybronchoscopy", "x_Raybronchoscopy")
                        .WithMany("ImgUrl")
                        .HasForeignKey("X_raybronchoscopyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("x_Raybronchoscopy");
                });

            modelBuilder.Entity("Medical.Work.Data.Models.X_raypathologicalPaths", b =>
                {
                    b.HasOne("Medical.Work.Data.Models.X_raypathological", "x_Raypathological")
                        .WithMany("ImgUrl")
                        .HasForeignKey("X_raypathologicalID")
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

            modelBuilder.Entity("Medical.Work.Data.Models.PatientInfo", b =>
                {
                    b.Navigation("PatientInfoExDiagnosisTable");
                });

            modelBuilder.Entity("Medical.Work.Data.Models.X_rayImaging", b =>
                {
                    b.Navigation("ImgUrl");
                });

            modelBuilder.Entity("Medical.Work.Data.Models.X_raybronchoscopy", b =>
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
