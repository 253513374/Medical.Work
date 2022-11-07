using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using Medical;
using Medical.Areas.Identity.Data;
using Medical.Data;
using Medical.Data.Models.Common;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MudBlazor;
using MudBlazor.Services;
using Serilog;

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
        .WriteTo.Console(outputTemplate: OUTPUT_TEMPLATE)
        .ReadFrom.Configuration(ctx.Configuration));

    // builder.Host.UseSerilog(Log.Logger, dispose: true);
    Log.Information("web host Serilog������ʼ��������");

    var aconnectionString = builder.Configuration.GetConnectionString("AccountContextConnection") ??
                            throw new InvalidOperationException(
                                "Connection string 'AccountContextConnection' not found.");
    var mconnectionString = builder.Configuration.GetConnectionString("MedicalContextConnection") ??
                            throw new InvalidOperationException(
                                "Connection string 'AccountContextConnection' not found.");

    //�ڵ���ģʽ����ʾ��������
#if DEBUG
    builder.Services.AddDbContextFactory<MedicalDbContext>(options =>
        options.UseSqlServer(mconnectionString).EnableSensitiveDataLogging(), ServiceLifetime.Scoped);

#endif
    builder.Services.AddDbContextFactory<MedicalDbContext>(options =>
        options.UseSqlServer(mconnectionString), ServiceLifetime.Scoped);

    builder.Services.AddDbContextFactory<AccountContext>(options =>
        options.UseSqlServer(aconnectionString), ServiceLifetime.Scoped);

    builder.Services.AddDefaultIdentity<AccountUser>(options =>
    {
        ///�����������
        options.Password.RequireDigit = true;
        options.Password.RequireLowercase = false;
        options.Password.RequiredLength = 6;
        options.Password.RequiredUniqueChars = 0;
        options.Password.RequireUppercase = false;
        options.Password.RequireNonAlphanumeric = false;

        //���õ�¼����
        options.SignIn.RequireConfirmedEmail = true;
        options.SignIn.RequireConfirmedPhoneNumber = false;
        options.SignIn.RequireConfirmedAccount = true;

        ///�����û���֤����
        options.User.RequireUniqueEmail = true;
        options.User.AllowedUserNameCharacters = null;
    }).AddEntityFrameworkStores<AccountContext>();
    ;

    // Add services to the container.
    builder.Services.AddRazorPages();
    builder.Services.AddServerSideBlazor();
    // builder.Services.AddSingleton<WeatherForecastService>();
    builder.Services.AddSingleton<EmailSender>();
    builder.Services.AddSingleton<AutocompleteService>(); //ȫ�ֵ��У����з����û���ʹ��ͬһ������

    builder.Services.AddScoped<EnumServer>(); //ͬһ������ ����һ��ʵ�ж���
    builder.Services.AddScoped<ITenantService>(); //ÿһ�ε��ö��� ����һ����ʵ�ж���
    builder.Services.AddScoped<DbServerProvider>(); //ÿһ�ε��ö��� ����һ����ʵ�ж���

    builder.Services.AddScoped<AuthenticationStateProvider, ServerAuthenticationStateProvider>();
    //services.AddScoped<AuthenticationStateProvider, ServerAuthenticationStateProvider>();
    // builder.Services.AddMasaBlazor();

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
    app.UseEndpoints(endpoints =>
    {
        endpoints.MapControllers();
        endpoints.MapBlazorHub();
        endpoints.MapFallbackToPage("/_Host");
    });
    app.Run();
}
catch (Exception ex)
{
    string type = ex.GetType().Name;
    if (type.Equals("StopTheHostException", StringComparison.Ordinal))
    {
        throw;
    }
    Log.Fatal(ex, $"Host����������ֹ:{ex.Message}");
}
finally
{
    // _logger.Fatal(ex, "Unhandled exception");
    // return 1;

    Log.CloseAndFlush();
    // throw;
}