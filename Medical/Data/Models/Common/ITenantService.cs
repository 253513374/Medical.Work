using Microsoft.AspNetCore.Components.Authorization;

namespace Medical.Data.Models.Common
{


    //public interface ITenantProvider
    //{
    //    Guid GetTenantId();
    //}
    //public class TenantProvider : ITenantProvider
    //{
    //    private Guid _tenantId;
    //    public TenantProvider(IHttpContextAccessor accessor, MedicalDbContext context)
    //    {
    //        var host = accessor.HttpContext.Request.Host.Value;
    //        _tenantId = context.GetTenantId(host);
    //    }
    //    public Guid GetTenantId()
    //    {
    //        return _tenantId;
    //    }
    //}
    public class ITenantService 
    {

        private readonly AuthenticationStateProvider _authenticationStateProvider;

        public ITenantService(AuthenticationStateProvider authenticationStateProvider)
        {
            _authenticationStateProvider = authenticationStateProvider;
        }

        public string GetTenantName()
        {
            var authenticationState = _authenticationStateProvider.GetAuthenticationStateAsync().Result;
            var user = authenticationState.User;
            if (user.Identity.IsAuthenticated)
            {
                return user.Identity.Name;
            }
            return null;
        }
        // event TenantChangedEventHandler OnTenantChanged;
    }

}
