using Medical.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.JSInterop;

namespace Medical.Services
{
    public static class DbContextExtension
    {
        public static IQueryable<TEntity> GetEntitiesQuery<TEntity>(this MedicalDbContext dbContext) where TEntity : class
        {
            var s = dbContext.Set<TEntity>().AsQueryable();

           // var ss = s.AsNoTracking().ToList();
            return dbContext.Set<TEntity>().AsQueryable(); ;
        }

        //public static IQueryable<TEntity> GetEntitiesQuery<TEntity>(this MedicalDbContext dbContext,DateTime start, DateTime end) where TEntity : class
        //{
        //    var s = dbContext.Set<TEntity>().AsQueryable();

        //    var ss = s.AsNoTracking().ToList();
        //    return s;
        //}

        public static async Task AddEntity<TEntity>(this MedicalDbContext dbContext, TEntity
        entity) where TEntity : class
        {
            await dbContext.Set<TEntity>().AddAsync(entity);
        }




    }


 
}
