using Medical.Data.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Caching.Memory;

namespace Medical.Data
{
    public class AutocompleteService
    {

        private const string PatientInfoCacheKey = "PatientInfosKey";



        private IDbContextFactory<MedicalDbContext> ContextFactory { set; get; }
        public IMemoryCache MemoryCache { set; get; }

        public AutocompleteService(IDbContextFactory<MedicalDbContext>  factory)
        {
            MemoryCache = new MemoryCache(new MemoryCacheOptions());
            ContextFactory = factory;
        }


        /// <summary>
        /// 加载数据到内存缓存,返回List<PatientInfo>
        /// </summary>
        /// <returns></returns>
        public async Task<List<PatientInfo>> GetCachePatientInfoToListAsync()
        {
            if (!MemoryCache.TryGetValue(PatientInfoCacheKey, out List<PatientInfo> PatientInfos))
            {
                var cacheEntryOptions = new MemoryCacheEntryOptions()
                    .SetPriority(priority: CacheItemPriority.NeverRemove);

                using var context = ContextFactory.CreateDbContext();
                PatientInfos = await context.patientInfos.AsNoTracking().OrderByDescending(o=>o.Createtime).ToListAsync();
                MemoryCache.Set(PatientInfoCacheKey, PatientInfos, cacheEntryOptions);
            }
            return PatientInfos.OrderByDescending(o=>o.Createtime).ToList();
        }


        /// <summary>
        /// 获取PatientInfo 列表
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public async Task<PatientInfo> GetCachePatientInfokeyAsync(string key)
        {
            if (!MemoryCache.TryGetValue(PatientInfoCacheKey, out List<PatientInfo> PatientInfos))
            {
                var cacheEntryOptions = new MemoryCacheEntryOptions()
                    .SetPriority(priority: CacheItemPriority.NeverRemove);
                using var context = ContextFactory.CreateDbContext();

                PatientInfos = await context.patientInfos.AsNoTracking().Where(w=>w.Guid.Contains(key)).ToListAsync();
                MemoryCache.Set(PatientInfoCacheKey, PatientInfos, cacheEntryOptions);
            }
           return PatientInfos.FirstOrDefault(w => w.Guid.Contains(key));
        }



        /// <summary>
        /// 更新缓存数据
        /// </summary>
        /// <param name="PatientInfos"></param>
        /// <returns></returns>
        public async Task<bool> SetCachePatientInfokeyAsync(List<PatientInfo> PatientInfos)
        {
            if(PatientInfos is not null && PatientInfos.Count>0)
            {
                var cacheEntryOptions = new MemoryCacheEntryOptions()
                   .SetPriority(priority: CacheItemPriority.NeverRemove);
                MemoryCache.Set(PatientInfoCacheKey, PatientInfos, cacheEntryOptions);

                return true;
            }
            return false;
        }
    }
}