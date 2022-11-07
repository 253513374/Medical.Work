using Microsoft.EntityFrameworkCore;
using MudBlazor;
using System.Linq.Expressions;
using Microsoft.AspNetCore.Components;

namespace Medical.Data.Models.Common
{
    //泛型类，包装数据查询
    public class DbServerProvider
    {
        //  private readonly AuthenticationStateProvider _authenticationStateProvider;

        private readonly IDbContextFactory<MedicalDbContext> _Db;
        private readonly string _adminName;
        private readonly ILogger<DbServerProvider> Logger;

        public DbServerProvider(ITenantService service, IDbContextFactory<MedicalDbContext> medicalDb, ILogger<DbServerProvider> logger)
        {
            _adminName = service.GetTenantName();
            _Db = medicalDb;
            Logger = logger;
        }

        /// <summary>
        /// 查询泛型，返回实体类数据列表
        /// </summary>
        /// <param name="entitytype"></param>
        /// <returns></returns>
        public async Task<List<T>> GetListAsync<T>() where T : class
        {
            ParameterExpression parameter = Expression.Parameter(typeof(T), "e");

            BinaryExpression body = await GetBaseExpressionAsync<T>(parameter);
            Expression<Func<T, bool>> expression = Expression.Lambda<Func<T, bool>>(body, parameter);

            Expression<Func<T, DateTime?>> orderby = await GetOrderByExpression<T>();
            Logger.LogInformation(expression.ToString());

            using var context = _Db.CreateDbContext();
            // var s= await context.Set<T>().AsNoTracking().Where(expression).ToListAsync();

            return await context.Set<T>().AsNoTracking().Where(expression).OrderByDescending(orderby).Take(100).ToListAsync();
        }

        /// <summary>
        /// 查询泛型 ，按时间范围 返回实体类数据列表
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="tabname"></param>
        /// <param name="range">时间范围</param>
        /// <returns></returns>
        public async Task<List<T>> GetListAsync<T>(DateRange range) where T : class
        {
            ParameterExpression parameter = Expression.Parameter(typeof(T), "e");

            BinaryExpression baseexpression = await GetBaseExpressionAsync<T>(parameter);
            BinaryExpression rangeexpression = await GetDateRangeExPression<T>(parameter, range);

            BinaryExpression binaryexpression = Expression.And(baseexpression, rangeexpression);

            Expression<Func<T, bool>> expression = Expression.Lambda<Func<T, bool>>(binaryexpression, parameter);

            Logger.LogInformation($"按时间范围查询数据：{expression}");
            using var context = _Db.CreateDbContext();
            return await context.Set<T>().AsNoTracking().Where(expression).ToListAsync();
        }

        /// <summary>
        /// 根据主键查询数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="id">主键</param>
        /// <returns></returns>
        public async Task<T> FindSingleAsync<T>(string id) where T : class
        {
            using var context = _Db.CreateDbContext();
            return await context.Set<T>().FindAsync(id);
        }

        public async Task<T> FindSingleAsync<T>(Expression<Func<T, bool>> expression) where T : class
        {
            using var context = _Db.CreateDbContext();
            return await context.Set<T>().Where(expression).FirstOrDefaultAsync();
        }

        /// <summary>
        ///  查找单个对象
        /// </summary>
        /// <typeparam name="T">对象</typeparam>
        /// <param name="ftype"></param>
        /// <returns></returns>
        public async Task<T> FindSingleAsync<T>(T ftype) where T : class
        {
            using var context = _Db.CreateDbContext();
            return await context.Set<T>().FindAsync(ftype);
        }

        public DbSet<T> FindDbSet<T>() where T : class
        {
            using var context = _Db.CreateDbContext();
            return context.Set<T>();
        }

        /// <summary>
        /// 插入保存数据
        /// </summary>
        /// <typeparam name="T">插入类型</typeparam>
        /// <param name="expression">插入对象</param>
        /// <returns></returns>
        public async Task<int> AddAsync<T>(T expression) where T : class
        {
            using var context = _Db.CreateDbContext();
            context.Set<T>().Add(expression);
            return await context.SaveChangesAsync();
        }

        /// <summary>
        /// 更新数据
        /// </summary>
        public async Task<int> UpdateAsync<T>(T expression) where T : class
        {
            using var context = _Db.CreateDbContext();
            context.Set<T>().Update(expression);
            return await context.SaveChangesAsync();
        }

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <typeparam name="T">删除类型</typeparam>
        /// <param name="expression">删除对象</param>
        /// <returns></returns>
        public async Task<int> DeleteAsync<T>(T expression) where T : class
        {
            var item = FindSingleAsync<T>(expression);
            if (item is not null)
            {
                using var context = _Db.CreateDbContext();
                context.Set<T>().Remove(expression);
                return await context.SaveChangesAsync();
            }
            return 0;
        }

        /// <summary>
        /// 时间范围查询条件
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="parameter"></param>
        /// <param name="range"></param>
        /// <returns></returns>
        private async Task<BinaryExpression> GetDateRangeExPression<T>(ParameterExpression parameter, DateRange range) where T : class
        {
            // ParameterExpression parameter = Expression.Parameter(typeof(T), "e");

            BinaryExpression body = Expression.GreaterThanOrEqual(
                Expression.Call(typeof(EF), nameof(EF.Property), new[] { typeof(DateTime) }, parameter, Expression.Constant("CreateTime")),
                Expression.Constant(range.Start));

            BinaryExpression body2 = Expression.LessThanOrEqual(
               Expression.Call(typeof(EF), nameof(EF.Property), new[] { typeof(DateTime) }, parameter, Expression.Constant("CreateTime")),
               Expression.Constant(range.End.Value.Date.AddDays(1)));

            BinaryExpression expression = Expression.AndAlso(body, body2);

            return await Task.FromResult(expression);
        }

        /// <summary>
        /// 基础查询条件
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="parameter"></param>
        /// <returns></returns>
        private async Task<BinaryExpression> GetBaseExpressionAsync<T>(ParameterExpression parameter) where T : class
        {
            BinaryExpression body = Expression.Equal(
                  Expression.Call(typeof(EF), nameof(EF.Property), new[] { typeof(string) }, parameter, Expression.Constant("Adminname")),
                  Expression.Constant(_adminName)
                  );
            return await Task.FromResult(body);
        }

        /// <summary>
        /// 排序条件
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="parameter"></param>
        /// <returns></returns>
        private async Task<Expression<Func<T, DateTime?>>> GetOrderByExpression<T>()
        {
            ParameterExpression orderbydescparameter = Expression.Parameter(typeof(T), "o");
            MemberExpression member = Expression.Property(orderbydescparameter, "CreateTime");

            Expression<Func<T, DateTime?>> expression = Expression.Lambda<Func<T, DateTime?>>(member, orderbydescparameter);
            Logger.LogInformation(expression.ToString());
            return expression;
        }
    }
}