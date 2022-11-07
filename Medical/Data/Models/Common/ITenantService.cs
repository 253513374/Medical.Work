using Microsoft.AspNetCore.Components.Authorization;
using Serilog;
using Serilog.Core;

namespace Medical.Data.Models.Common
{
    /// <summary>
    /// 多租户实现的服务类， 实时获取登录的账户信息。
    /// </summary>
    public class ITenantService
    {
        private readonly AuthenticationStateProvider _authenticationStateProvider;

        private ILogger<ITenantService> Logger;

        private IServiceProvider serviceProvider;

        public ITenantService(AuthenticationStateProvider authenticationStateProvider,
            IServiceProvider service, ILogger<ITenantService> logger)
        {
            _authenticationStateProvider = authenticationStateProvider;
            this.Logger = logger;
            serviceProvider = service;
        }

        public string GetTenantName()
        {
            try
            {
                /*       using (var serviceScope = serviceProvider.CreateScope())
                       {
                           var service = serviceScope.ServiceProvider.GetRequiredService<AuthenticationStateProvider>();
                           var authenticationState = service.GetAuthenticationStateAsync().Result;

                            var authenticationState = _authenticationStateProvider.GetAuthenticationStateAsync().Result;
                           var userclaPrincipal = authenticationState.User;
                           if (userclaPrincipal.Identity.IsAuthenticated)
                           {
                               Logger.LogInformation($"获取到登录用户信息：{userclaPrincipal.Identity.Name}");
                               return userclaPrincipal.Identity.Name;
                           }
                           return null;
                       }*/
                var authenticationState = _authenticationStateProvider.GetAuthenticationStateAsync().Result;
                var userclaPrincipal = authenticationState.User;
                if (userclaPrincipal.Identity.IsAuthenticated)
                {
                    Logger.LogInformation($"获取到登录用户信息：{userclaPrincipal.Identity.Name}");
                    return userclaPrincipal.Identity.Name;
                }
                return "";
            }
            catch (Exception ex)
            {
                string type = ex.GetType().Name;
                if (type.Equals("StopTheHostException", StringComparison.Ordinal))
                {
                    //  throw;
                    Logger.LogInformation("出现StopTheHostException异常");
                }
                // Log.Fatal(ex, $"Host主机意外终止:{ex.Message}");
                return "";
            }
        }

        // event TenantChangedEventHandler OnTenantChanged;
    }
}