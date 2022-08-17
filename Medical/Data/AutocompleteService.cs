using Medical.Data.Models;
using Medical.Data.Models.Common;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Caching.Memory;

namespace Medical.Data
{
    public class AutocompleteService
    {

        private const string CacheKey = "PatientInfosKey";
       // private IDbContextFactory<MedicalDbContext> ContextFactory { set; get; }
        private  IMemoryCache MemoryCache { set; get; }

       // private readonly string CacheKey;

      //  private readonly Db


     
        public AutocompleteService()
        {
            MemoryCache = new MemoryCache(new MemoryCacheOptions());
           // CacheKey = service.GetTenantName();
        }


        /// <summary>
        /// 加载数据到内存缓存,返回List<PatientInfo>
        /// </summary>
        /// <returns></returns>
        public async Task<List<PatientInfo>> GetCachePatientInfoToListAsync()
        {
            if (!MemoryCache.TryGetValue(CacheKey, out List<PatientInfo> PatientInfos))
            {
                var cacheEntryOptions = new MemoryCacheEntryOptions()
                    .SetPriority(priority: CacheItemPriority.NeverRemove);
            }
            if (PatientInfos is null || PatientInfos.Count == 0) return new List<PatientInfo>();
            return PatientInfos.OrderByDescending(o=>o.CreateTime).ToList();
        }


        /// <summary>
        /// 获取PatientInfo 
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public async Task<PatientInfo> GetCachePatientInfokeyAsync(string objectguidkey)
        {
            if (!MemoryCache.TryGetValue(CacheKey, out List<PatientInfo> PatientInfos))
            {
                var cacheEntryOptions = new MemoryCacheEntryOptions()
                    .SetPriority(priority: CacheItemPriority.NeverRemove);
                //using var context = ContextFactory.CreateDbContext();
                //PatientInfos = await context.patientInfos.AsNoTracking().Where(w=>w.Guid.Contains(key)).ToListAsync();
                MemoryCache.Set(CacheKey, PatientInfos, cacheEntryOptions);
            }
            if (PatientInfos is null || PatientInfos.Count == 0) return null;
            return PatientInfos.FirstOrDefault(w => w.Guid.Contains(objectguidkey));
            //return null;
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
                MemoryCache.Set(CacheKey, PatientInfos, cacheEntryOptions);

                return true;
            }
            return false;
        }
    }
}