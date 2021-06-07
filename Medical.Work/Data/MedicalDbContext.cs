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

        public MedicalDbContext(DbContextOptions<MedicalDbContext> options)
           : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //  base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<MedicalPD>().ToTable("MedicalPD");
            modelBuilder.Entity<MedicalPG>().ToTable("MedicalPG");
            modelBuilder.Entity<MedicalPK>().ToTable("MedicalPK");
            modelBuilder.Entity<PatientInfo>().ToTable("PatientInfo");
            modelBuilder.Entity<MedicalDGK>().ToTable("MedicalDGK");
            modelBuilder.Entity<Contacts>().ToTable("Contacts");
        }



    }
}
