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
        public DbSet<MedicalPD> medicalPDs { set; get; }

        public DbSet<MedicalPG> medicalPGs { set; get; }
        public DbSet<MedicalPK> medicalPKs { set; get; }
        public DbSet<PatientInfo> patientInfos { set; get; }
        public DbSet<Contacts> Contacts { set; get; }

        public DbSet<X_raybronchoscopy> X_raybronchoscopys { set; get; }
        public DbSet<X_rayImaging> X_rayImagings { set; get; }
        public DbSet<X_raypathological> X_raypathologicals { set; get; }
        public DbSet<Summaryreport> Summaryreports { set; get; }


        public DbSet<MedicalPKSampling> medicalPKSamplings   { set; get; }

        public DbSet<MedicalPKSampling_sample>  pKSampling_Samples { set; get; }





        public MedicalDbContext(DbContextOptions<MedicalDbContext> options)
           : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.Entity<MedicalPD>().ToTable("MedicalPD");
            modelBuilder.Entity<MedicalPG>().ToTable("MedicalPG");
            modelBuilder.Entity<MedicalPK>().ToTable("MedicalPK");
            modelBuilder.Entity<PatientInfo>().ToTable("PatientInfo");
            modelBuilder.Entity<MedicalDGK>().ToTable("MedicalDGK");
            modelBuilder.Entity<Contacts>().ToTable("Contacts");
            // modelBuilder.Entity<City>().HasOne(city => city.Province).WithMany(x => x.Cities).HasForeignKey(city => .ProviceId);
            modelBuilder.Entity<MedicalPKSampling_sample>().HasOne(s => s.medicalPKSampling).WithMany(w => w.medicalPKSamplings).HasForeignKey(h=>h.MedicalPKSamplingID);

            base.OnModelCreating(modelBuilder);
        }



    }
}
