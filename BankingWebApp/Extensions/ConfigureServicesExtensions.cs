using Microsoft.AspNetCore.HttpLogging;
using NLog.Web;

namespace BankingWebApp.Extensions;

public static class ConfigureServicesExtensions
{
    public static IServiceCollection AddBankAppServices(this IHostApplicationBuilder builder)
    {
        var services = builder.Services;

        services.ConfigureBankAppLogging();
        services.AddDbContext<BankAppDbContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnectionString")
        ));
        services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

        //services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));

        services.AddScoped<CustomerRepository>();
        services.AddScoped<AccountRepository>();
        services.AddScoped<TransactionRepository>();

        return services;
    }

    public static IServiceCollection ConfigureBankAppLogging(this IServiceCollection services)
    {
        services.AddLogging(loggingBuilder =>
        {
            // removed "SimpleConsole" logging provider from Microsoft since we are now solely configuring all logging configurations using Nlog
            //loggingBuilder.AddSimpleConsole(consoleOptions =>
            //{
            //    consoleOptions.SingleLine = true;
            //    consoleOptions.IncludeScopes = false;
            //    consoleOptions.TimestampFormat = "dd/MM/yyyy HH:mm:ss ";
            //});
            loggingBuilder.ClearProviders();
            loggingBuilder.AddNLog("nlog.config");
        });

        services.AddHttpLogging(logging =>
        {
            logging.LoggingFields = HttpLoggingFields.All;
            logging.RequestHeaders.Add("sec-ch-ua");
            logging.ResponseHeaders.Add("MyResponseHeader");
            logging.MediaTypeOptions.AddText("application/javascript");
            logging.RequestBodyLogLimit = 4096;
            logging.ResponseBodyLogLimit = 4096;
            logging.CombineLogs = true;
        });

        return services;
    }
}
