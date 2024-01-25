/* 
 * Author: Kopil Kaiser
 * Student Id: K2360182
 * Module Code: 
 * Module Title: Software Architecture and Programming Models
 */

using NLog;
using NLog.Web;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

builder.Services.AddControllersWithViews();

// Add services to the container.
builder.AddBankAppServices();

GlobalDiagnosticsContext.Set("appDirectory", AppContext.BaseDirectory);
GlobalDiagnosticsContext.Set("connectionString", builder.Configuration.GetConnectionString("DefaultConnectionString"));

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

if (app.Configuration.GetValue<bool>("EnableHttpLogging"))
{
    app.UseHttpLogging();
}

app.UseStaticFiles();

app.UseSession();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Customer}/{action=LoginPage}/{id?}");


var logger = LogManager.Setup().LoadConfigurationFromAppSettings().GetCurrentClassLogger();

try
{
    logger.Debug("init main");
    app.Run();

} catch (Exception exception)
{
    //NLog: catch setup errors
    logger.Error(exception, "Stopped program because of exception");
    throw;
} finally
{
    // Ensure to flush and stop internal timers/threads before application-exit (Avoid segmentation fault on Linux)
    NLog.LogManager.Shutdown();

}
