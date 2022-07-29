using Medical.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using MudBlazor.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Medical.Areas.Identity.Data;
using Serilog;
using Medical;
using MudBlazor;

const string OUTPUT_TEMPLATE = "{Timestamp:yyyy-MM-dd HH:mm:ss.fff} <{ThreadId}> [{Level:u3}] {Message:lj}{NewLine}{Exception}";
//Log.Logger = new LoggerConfiguration()
//    .MinimumLevel.Debug()
//    .WriteTo.Console(outputTemplate: OUTPUT_TEMPLATE)

Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()
    .CreateBootstrapLogger();
   

try
{
    var builder = WebApplication.CreateBuilder(args);


    builder.Host.UseSerilog((ctx, lc) => lc
      .WriteTo.Console(outputTemplate:OUTPUT_TEMPLATE)
      .ReadFrom.Configuration(ctx.Configuration));


    // builder.Host.UseSerilog(Log.Logger, dispose: true);
    Log.Information("web host 正常初始化。。。");

    var aconnectionString = builder.Configuration.GetConnectionString("AccountContextConnection") ?? throw new InvalidOperationException("Connection string 'AccountContextConnection' not found.");
    var mconnectionString = builder.Configuration.GetConnectionString("MedicalContextConnection") ?? throw new InvalidOperationException("Connection string 'AccountContextConnection' not found.");

    builder.Services.AddDbContextFactory<AccountContext>(options =>
        options.UseSqlServer(aconnectionString));

    builder.Services.AddDbContextFactory<MedicalDbContext>(options =>
       options.UseSqlServer(mconnectionString));

    builder.Services.AddDefaultIdentity<AccountUser>(options => {
        ///配置密码规则
        options.Password.RequireDigit = true;
        options.Password.RequireLowercase = false;
        options.Password.RequiredLength = 6;
        options.Password.RequiredUniqueChars = 0;
        options.Password.RequireUppercase = false;
        options.Password.RequireNonAlphanumeric = false;

        //设置登录规则
        options.SignIn.RequireConfirmedEmail = true;
        options.SignIn.RequireConfirmedPhoneNumber = false;
        options.SignIn.RequireConfirmedAccount = true;

        ///设置用户验证规则
        options.User.RequireUniqueEmail = true;
        options.User.AllowedUserNameCharacters = null;

    }).AddEntityFrameworkStores<AccountContext>(); ;

    // Add services to the container.
    builder.Services.AddRazorPages();
    builder.Services.AddServerSideBlazor();
    builder.Services.AddSingleton<WeatherForecastService>();
    builder.Services.AddSingleton<EmailSender>();
    builder.Services.AddSingleton<AutocompleteService>();//全局单列，所有访问用户都使用同一个对象

    builder.Services.AddScoped<EnumServer>();//同一个请求 都是一个实列对象

    builder.Services.AddMasaBlazor();
    
    builder.Services.AddMudServices(config =>
    {
        config.SnackbarConfiguration.PositionClass = Defaults.Classes.Position.TopCenter;

        config.SnackbarConfiguration.PreventDuplicates = false;
        config.SnackbarConfiguration.NewestOnTop = false;
        config.SnackbarConfiguration.ShowCloseIcon = true;
        config.SnackbarConfiguration.VisibleStateDuration = 10000;
        config.SnackbarConfiguration.HideTransitionDuration = 500;
        config.SnackbarConfiguration.ShowTransitionDuration = 500;
        config.SnackbarConfiguration.SnackbarVariant = Variant.Filled;
    });

    var app = builder.Build();

    // Configure the HTTP request pipeline.
    if (!app.Environment.IsDevelopment())
    {
        app.UseExceptionHandler("/Error");
        // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
        app.UseHsts();
    }

    app.UseHttpsRedirection();

    app.UseStaticFiles();

    app.UseRouting();

    app.UseAuthentication();
    app.UseAuthorization();
    //app.MapBlazorHub();
    //app.MapControllers();
    app.UseEndpoints(endpoints => {
        endpoints.MapControllers();
        endpoints.MapBlazorHub();
        endpoints.MapFallbackToPage("/_Host");
    });


 //   app.MapFallbackToPage("/_Host");




    app.Run();
}
catch (Exception ex)
{
    Log.Fatal(ex, "Host主机意外终止");
   // throw;
}
finally
{
    Log.Information("Serilog 关闭");
    Log.CloseAndFlush();
}

