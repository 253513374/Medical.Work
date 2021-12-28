using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(Medical.Work.Areas.Identity.IdentityHostingStartup))]

namespace Medical.Work.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
            });
        }
    }
}