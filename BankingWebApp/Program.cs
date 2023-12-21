/* 
 * Author: Kopil Kaiser
 * Student Id: K2360182
 * 
 */

using NLog;
using NLog.Web;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.AddBankAppServices();
GlobalDiagnosticsContext.Set("configDir", "C:\\Users\\kopil\\OneDrive\\Documents\\KU_University_Documents\\SAPM_Final_Project\\BankingWebApp\\BankingWebApp");
GlobalDiagnosticsContext.Set("connectionString", builder.Configuration.GetConnectionString("DefaultConnectionString"));

var app = builder.Build();

//using (var scope = app.Services.CreateScope())
//{
//    var serviceScope = scope.ServiceProvider;
//    SeedDataInitalizerExtension.InitalizeDatabase(serviceScope);
//}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

app.UseHttpLogging();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=LoginPage}/{id?}");


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



