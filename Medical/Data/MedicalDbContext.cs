using Medical.Data.Models;
using Medical.Data.Models.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata;
using System.Linq.Expressions;
using System.Reflection;

//using ExpressionTreeToString;
//using static System.Linq.Expressions.Expression;
//using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Medical.Data
{
    public class MedicalDbContext : DbContext
    {
        // public DbSet<MedicalDGK> medicalDGKs { set; get; }

        #region

        /// <summary>
        /// 药敏试验
        /// </summary>
        public DbSet<MedicalPD_DrugAllergy> MPD_Drugs { set; get; } = null!;

        /// <summary>
        /// 临床微生物
        /// </summary>
        public DbSet<MedicalPD_Microbiological> MPD_Microbiologicals { set; get; } = null!;

        /// <summary>
        /// 药物基因组学
        /// </summary>
        public DbSet<MedicalPG_Pharmacogenomics> MPG_Pharmacogenomics { set; get; } = null!;

        /// <summary>
        /// 病原菌基因
        /// </summary>
        public DbSet<MedicalPG_PathogenGene> MPG_PathogenGenes { set; get; } = null!;

        /// <summary>
        /// 给药方案
        /// </summary>
        public DbSet<MedicalPK> MPKs { set; get; } = null!;

        /// <summary>
        /// 采集信息
        /// </summary>
        public DbSet<MedicalPKSampling> MPK_Samplings { set; get; } = null!;

        public DbSet<MedicalPKSamplingsample> MPK_Sampling_Samples { set; get; } = null!;

        /// <summary>
        /// 个人基础信息
        /// </summary>
        public DbSet<PatientInfo> patientInfos { set; get; } = null!;

        public DbSet<PatientInfoExDiagnosisTable> patientInfoExDiagnosisTables { set; get; } = null!;

        /// <summary>
        /// 联系人
        /// </summary>
        public DbSet<Contacts> Contacts { set; get; } = null!;

        public DbSet<Summaryreport> Summaryreports { set; get; } = null!;

        public DbSet<SummaryOfCases> SummaryOfCases { set; get; } = null!;

        /// <summary>
        /// 纤维支气管镜检查
        /// </summary>
        public DbSet<X_raybronchoscopy> X_raybronchoscopys { set; get; } = null!;

        /// <summary>
        /// 影像学
        /// </summary>
        public DbSet<X_rayImaging> X_rayImagings { set; get; } = null!;

        /// <summary>
        /// 病理检查
        /// </summary>
        public DbSet<X_raypathological> X_raypathologicals { set; get; } = null!;

        /// <summary>
        /// 影像学图像文件
        /// </summary>
        public DbSet<X_rayImagePaths> x_RayImagePaths { set; get; } = null!;

        /// <summary>
        /// 纤维支气管镜检查图像文件
        /// </summary>
        public DbSet<X_raybronchoscopyPaths> x_RaybronchoscopyPaths { set; get; } = null!;

        /// <summary>
        /// 病理检查图像文件
        /// </summary>
        public DbSet<X_raypathologicalPaths> x_RaypathologicalPaths { set; get; } = null!;

        /// <summary>
        /// 生物实验室检查
        /// </summary>
        public DbSet<LaboratoryExamination> laboratoryExaminations { set; get; } = null!;

        //   private readonly ITenantService tenantService;
        #endregion

        private readonly string tenant;

        private ILogger<MedicalDbContext> Logger { set; get; }

        public MedicalDbContext(DbContextOptions<MedicalDbContext> options, ITenantService service, ILogger<MedicalDbContext> logger)
           : base(options)
        {
            tenant = service.GetTenantName();
            Logger = logger;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*            IEnumerable<IMutableEntityType> entityTypes = modelBuilder.Model.GetEntityTypes();
                        foreach (IMutableEntityType entityType in entityTypes)
                        {
                            IEnumerable<IMutableProperty> props = entityType.GetProperties();
                            if (props.Any(x => x.Name == "Adminname"))
                            {
                                InitGobalFilter(modelBuilder, entityType, tenant);
                            }
                        }
                        Logger.LogInformation($"OnModelCreating 中获取的用户ID：{tenant}");*/

            modelBuilder.Entity<MedicalPD_DrugAllergy>().ToTable("PD_DrugAllergy");
            modelBuilder.Entity<MedicalPD_Microbiological>().ToTable("PD_Microbiological");
            modelBuilder.Entity<MedicalPG_Pharmacogenomics>().ToTable("PG_Pharmacogenomics");
            modelBuilder.Entity<MedicalPG_PathogenGene>().ToTable("PG_PathogenGene");
            modelBuilder.Entity<MedicalPK>().ToTable("PKs");
            modelBuilder.Entity<MedicalPKSampling>().ToTable("PK_Samplings");
            modelBuilder.Entity<MedicalPKSamplingsample>().ToTable("PK_Sampling_Samples");
            modelBuilder.Entity<PatientInfo>().ToTable("PatientInfo");//.IsMemoryOptimized();
            modelBuilder.Entity<Contacts>().ToTable("Contacts");
            modelBuilder.Entity<MedicalPKSamplingsample>().HasOne(s => s.medicalPKSampling).WithMany(w => w.medicalPKSamplings).HasForeignKey(h => h.sampleForeignKey);
            modelBuilder.Entity<PatientInfoExDiagnosisTable>().HasOne(s => s.Summaryofcases).WithMany(w => w.PatientInfoExDiagnosisTable).HasForeignKey(h => h.ID);
            modelBuilder.Entity<X_rayImagePaths>().HasOne(s => s.x_RayImaging).WithMany(w => w.ImgUrl).HasForeignKey(h => h.ID).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<X_raybronchoscopyPaths>().HasOne(s => s.x_Raybronchoscopy).WithMany(w => w.ImgUrl).HasForeignKey(h => h.ID).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<X_raypathologicalPaths>().HasOne(s => s.x_Raypathological).WithMany(w => w.ImgUrl).HasForeignKey(h => h.ID).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<LaboratoryExamination>().ToTable("LaboratoryExamination");
            base.OnModelCreating(modelBuilder);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            ChangeTracker.DetectChanges();

            var entities = ChangeTracker.Entries().Where(e => e.State == EntityState.Added && e.Entity.GetType().BaseType == typeof(BaseDataInterface));
            foreach (var item in entities)
            {
                (item.Entity as BaseDataInterface).Adminname = tenant;
                (item.Entity as BaseDataInterface).CreateTime = DateTime.Now;
                (item.Entity as BaseDataInterface).Guid = Guid.NewGuid().ToString();
            }

            //ChangeTracker.Entries().Where(e => e.State == EntityState.Modified && e.Entity is BaseDataInterface).ToList()
            //    .ForEach(e => ((BaseDataInterface)e.Entity).UpdateTime = DateTime.Now);
            return base.SaveChangesAsync(cancellationToken);
        }

        public override int SaveChanges()
        {
            ChangeTracker.DetectChanges();

            var entities = ChangeTracker.Entries().Where(e => e.State == EntityState.Added && e.Entity.GetType().BaseType == typeof(BaseDataInterface));
            foreach (var item in entities)
            {
                (item.Entity as BaseDataInterface).Adminname = tenant;
                (item.Entity as BaseDataInterface).CreateTime = DateTime.Now;
                (item.Entity as BaseDataInterface).Guid = Guid.NewGuid().ToString();
            }
            return base.SaveChanges();
        }

        //public Guid GetTenantId(string host)
        //{
        //    var tenant = Tenants.FirstOrDefault(t => t.Host == host);
        //    return tenant == null ? Guid.Empty : tenant.Id;
        //}

        /// <summary>
        /// 初始化全局的过滤,Doc
        /// </summary>
        /// <param name = "entityType" > 过滤 </ param >
        /// < param name="modelBuilder">builder</param>
        public static void InitGobalFilter(ModelBuilder modelBuilder, IMutableEntityType entityType, string tenant)
        {
            if (modelBuilder == null)
            {
                return;
            }
            IEnumerable<IMutableProperty> props = entityType.GetProperties();
            if (props.Any(x => x.Name == "Adminname"))
            {
                //两个值相等（查询条件）表达式树
                ParameterExpression parameter = Expression.Parameter(entityType.ClrType, "e");
                BinaryExpression body = Expression.Equal(
                    Expression.Call(typeof(EF), nameof(EF.Property), new[] { typeof(string) }, parameter, Expression.Constant("Adminname")),
                    Expression.Constant(tenant));

                modelBuilder.Entity(entityType.ClrType).HasQueryFilter(Expression.Lambda(body, parameter));
                Console.WriteLine($"全局过滤器：{Expression.Lambda(body, parameter)}");
            }
        }

        private static MethodInfo ConfigureGlobalFiltersMethodInfo = typeof(MedicalDbContext).GetMethod(nameof(ConfigureGlobalFilters), BindingFlags.Instance | BindingFlags.NonPublic);

        protected void ConfigureGlobalFilters<T>(ModelBuilder builder) where T : BaseDataInterface
        {
            builder.Entity<T>().HasQueryFilter(e => e.Adminname == tenant);
        }
    }
}