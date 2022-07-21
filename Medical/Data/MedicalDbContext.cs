using Medical.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Medical.Data
{
    public class MedicalDbContext : DbContext
    {
        // public DbSet<MedicalDGK> medicalDGKs { set; get; }

        /// <summary>
        /// 药敏试验
        /// </summary>
        public DbSet<MedicalPD_DrugAllergy> MPD_Drugs { set; get; }

        /// <summary>
        /// 临床微生物
        /// </summary>
        public DbSet<MedicalPD_Microbiological> MPD_Microbiologicals { set; get; }


        /// <summary>
        /// 药物基因组学
        /// </summary>
        public DbSet<MedicalPG_Pharmacogenomics> MPG_Pharmacogenomics { set; get; }

        /// <summary>
        /// 病原菌基因
        /// </summary>
        public DbSet<MedicalPG_PathogenGene> MPG_PathogenGenes { set; get; }


        /// <summary>
        /// 给药方案
        /// </summary>
        public DbSet<MedicalPK> MPKs { set; get; }

        /// <summary>
        /// 采集信息
        /// </summary>
        public DbSet<MedicalPKSampling> MPK_Samplings { set; get; }
        public DbSet<MedicalPKSamplingsample> MPK_Sampling_Samples { set; get; }

        /// <summary>
        /// 个人基础信息
        /// </summary>
        public DbSet<PatientInfo> patientInfos { set; get; }

        public DbSet<PatientInfoExDiagnosisTable> patientInfoExDiagnosisTables { set; get; }

        /// <summary>
        /// 联系人
        /// </summary>
        public DbSet<Contacts> Contacts { set; get; }

        public DbSet<Summaryreport> Summaryreports { set; get; }

        public DbSet<SummaryOfCases> SummaryOfCases { set; get; }

        /// <summary>
        /// 纤维支气管镜检查
        /// </summary>
        public DbSet<X_raybronchoscopy> X_raybronchoscopys { set; get; }

        /// <summary>
        /// 影像学
        /// </summary>
        public DbSet<X_rayImaging> X_rayImagings { set; get; }

        /// <summary>
        /// 病理检查
        /// </summary>
        public DbSet<X_raypathological> X_raypathologicals { set; get; }

        /// <summary>
        /// 影像学图像文件
        /// </summary>
        public DbSet<X_rayImagePaths> x_RayImagePaths { set; get; }

        /// <summary>
        /// 纤维支气管镜检查图像文件
        /// </summary>
        public DbSet<X_raybronchoscopyPaths> x_RaybronchoscopyPaths { set; get; }

        /// <summary>
        /// 病理检查图像文件
        /// </summary>
        public DbSet<X_raypathologicalPaths> x_RaypathologicalPaths { set; get; }


        /// <summary>
        /// 生物实验室检查
        /// </summary>
        public DbSet<LaboratoryExamination> laboratoryExaminations { set; get; }

        public MedicalDbContext(DbContextOptions<MedicalDbContext> options)
           : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MedicalPD_DrugAllergy>().ToTable("PD_DrugAllergy");
            modelBuilder.Entity<MedicalPD_Microbiological>().ToTable("PD_Microbiological");

            modelBuilder.Entity<MedicalPG_Pharmacogenomics>().ToTable("PG_Pharmacogenomics");
            modelBuilder.Entity<MedicalPG_PathogenGene>().ToTable("PG_PathogenGene");

            modelBuilder.Entity<MedicalPK>().ToTable("PKs");
            modelBuilder.Entity<MedicalPKSampling>().ToTable("PK_Samplings");
            modelBuilder.Entity<MedicalPKSamplingsample>().ToTable("PK_Sampling_Samples");
            /*

                 public DbSet<MedicalPK> MPKs { set; get; }
        public DbSet<MedicalPKSampling> MPK_Samplings { set; get; }
        public DbSet<MedicalPKSampling_sample> MPK_Sampling_Samples { set; get; }
             */

            modelBuilder.Entity<PatientInfo>().ToTable("PatientInfo");//.IsMemoryOptimized();
            //modelBuilder.Entity<MedicalDGK>().ToTable("MedicalDGK");
            modelBuilder.Entity<Contacts>().ToTable("Contacts");

            // modelBuilder.Entity<City>().HasOne(city => city.Province).WithMany(x => x.Cities).HasForeignKey(city => .ProviceId);
            modelBuilder.Entity<MedicalPKSamplingsample>().HasOne(s => s.medicalPKSampling).WithMany(w => w.medicalPKSamplings).HasForeignKey(h => h.sampleForeignKey);



          //  modelBuilder.Entity<MedicalPKSampling>().HasOne(s => s.)


            modelBuilder.Entity<PatientInfoExDiagnosisTable>().HasOne(s => s.Summaryofcases).WithMany(w => w.PatientInfoExDiagnosisTable).HasForeignKey(h => h.ID);

            modelBuilder.Entity<X_rayImagePaths>().HasOne(s => s.x_RayImaging).WithMany(w => w.ImgUrl).HasForeignKey(h => h.ID).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<X_raybronchoscopyPaths>().HasOne(s => s.x_Raybronchoscopy).WithMany(w => w.ImgUrl).HasForeignKey(h => h.ID).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<X_raypathologicalPaths>().HasOne(s => s.x_Raypathological).WithMany(w => w.ImgUrl).HasForeignKey(h => h.ID).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<LaboratoryExamination>().ToTable("LaboratoryExamination");

            base.OnModelCreating(modelBuilder);
        }
    }
}