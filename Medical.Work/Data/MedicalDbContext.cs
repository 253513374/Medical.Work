using Medical.Work.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medical.Work.Data
{
    public class MedicalDbContext : DbContext
    {


        public DbSet<MedicalDGK> medicalDGKs { set; get; }
        public DbSet<MedicalPD_DrugAllergy>  medicalPD_Drugs { set; get; }
        public DbSet<MedicalPD_Microbiological>  medicalPD_Microbiologicals { set; get; }

        public DbSet<MedicalPG> medicalPGs { set; get; }
        public DbSet<MedicalPK> medicalPKs { set; get; }
        public DbSet<PatientInfo> patientInfos { set; get; }

        public DbSet<PatientInfoExDiagnosisTable> patientInfoExDiagnosisTables { set; get; }
        public DbSet<Contacts> Contacts { set; get; }

        public DbSet<X_raybronchoscopy> X_raybronchoscopys { set; get; }
        public DbSet<X_rayImaging> X_rayImagings { set; get; }
        public DbSet<X_raypathological> X_raypathologicals { set; get; }
        public DbSet<Summaryreport> Summaryreports { set; get; }


        public DbSet<MedicalPKSampling> medicalPKSamplings   { set; get; }

        public DbSet<MedicalPKSampling_sample>  pKSampling_Samples { set; get; }


        public DbSet<X_rayImagePaths> x_RayImagePaths { set; get; }
        public DbSet<X_raybronchoscopyPaths>  x_RaybronchoscopyPaths { set; get; }
        public DbSet<X_raypathologicalPaths> x_RaypathologicalPaths { set; get; }

        public DbSet<LaboratoryExamination>  laboratoryExaminations { set; get; }


        public MedicalDbContext(DbContextOptions<MedicalDbContext> options)
           : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.Entity<MedicalPD_DrugAllergy>().ToTable("MedicalPD_DrugAllergy");
            modelBuilder.Entity<MedicalPD_Microbiological>().ToTable("MedicalPD_Microbiological");
            
            modelBuilder.Entity<MedicalPG>().ToTable("MedicalPG");
            modelBuilder.Entity<MedicalPK>().ToTable("MedicalPK");
            modelBuilder.Entity<PatientInfo>().ToTable("PatientInfo");
            modelBuilder.Entity<MedicalDGK>().ToTable("MedicalDGK");
            modelBuilder.Entity<Contacts>().ToTable("Contacts");
            // modelBuilder.Entity<City>().HasOne(city => city.Province).WithMany(x => x.Cities).HasForeignKey(city => .ProviceId);
            modelBuilder.Entity<MedicalPKSampling_sample>().HasOne(s => s.medicalPKSampling).WithMany(w => w.medicalPKSamplings).HasForeignKey(h=>h.MedicalPKSamplingID);
            modelBuilder.Entity<PatientInfoExDiagnosisTable>().HasOne(s => s.Patient).WithMany(w => w.PatientInfoExDiagnosisTable).HasForeignKey(h => h.PatientInfoID);


            modelBuilder.Entity<X_rayImagePaths>().HasOne(s => s.x_RayImaging).WithMany(w => w.ImgUrl).HasForeignKey(h => h.X_rayImagingID).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<X_raybronchoscopyPaths>().HasOne(s => s.x_Raybronchoscopy).WithMany(w => w.ImgUrl).HasForeignKey(h => h.X_raybronchoscopyID).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<X_raypathologicalPaths>().HasOne(s => s.x_Raypathological).WithMany(w => w.ImgUrl).HasForeignKey(h => h.X_raypathologicalID).OnDelete(DeleteBehavior.Cascade);



            modelBuilder.Entity<LaboratoryExamination>().ToTable("LaboratoryExamination");

            base.OnModelCreating(modelBuilder);
        }



    }
}
