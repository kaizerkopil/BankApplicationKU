
namespace BankingWebApp.Services;

public static class ConfigureServicesExtensions
{
    public static IServiceCollection AddBankAppServices(this IHostApplicationBuilder builder)
    {
        var services = builder.Services;

        var builderApp = builder.Services.BuildServiceProvider().GetRequiredService<IConfiguration>().GetConnectionString("DefaultConnectionString");
        services.AddDbContext<BankAppDbContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnectionString")
        ));
        services.AddAutoMapper(System.AppDomain.CurrentDomain.GetAssemblies());

        return services;
    }
}
