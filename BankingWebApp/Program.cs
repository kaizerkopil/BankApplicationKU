/* 
 * Author: Kopil Kaiser
 * Student Id: K2360182
 * 
 */

using BankingWebApp.Database;
using BankingWebApp.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.AddBankAppServices();


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

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
