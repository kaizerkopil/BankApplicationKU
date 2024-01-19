using BankingWebApp.Settings;
using Microsoft.AspNetCore.HttpLogging;
using Microsoft.Extensions.Options;
using NLog.Web;

namespace BankingWebApp.Extensions;

public static class ConfigureServicesExtension
{
    public static IServiceCollection AddBankAppServices(this IHostApplicationBuilder builder)
    {
        var services = builder.Services;

        //Register DbContext (Database)
        var connectionString = builder.Configuration.GetConnectionString("DefaultConnectionString") ?? Environment.GetEnvironmentVariable("DefaultConnectionString");
        //var password = builder.Configuration.GetValue<string>("COLLEAGUE_CASTLE_EMAIL_PASSWORD") ?? Environment.GetEnvironmentVariable("COLLEAGUE_CASTLE_EMAIL_PASSWORD");
        services.AddDbContext<BankAppDbContext>(options => options.UseSqlServer(connectionString));

        //Register Logging and Services
        services.ConfigureBankAppLogging(builder.Configuration.GetValue<bool>("EnableHttpLogging"));
        services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        //services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        services.AddScoped<ISessionManager, SessionManager>();

        //Register Repositories
        services.AddScoped<CustomerRepository>();
        services.AddScoped<AccountRepository>();
        services.AddScoped<TransactionRepository>();

        //Register Apis


        //Register Configuration Settings
        // Step 1: Bind the GoogleApiSettings section from appsettings.json and
        // Step 2: Access them via Dependency Injection
        //services.Configure<GoogleApiSettings>(builder.Configuration.GetRequiredSection("GoogleApiSettings")); // Step:1
        //services.AddSingleton<GoogleApiSettings>(provider => provider.GetRequiredService<IOptions<GoogleApiSettings>>().Value); // Step:2

        services.Configure<CustomApiSettings>(builder.Configuration.GetRequiredSection("CustomApi")); //step 1
        services.AddSingleton(sp => sp.GetRequiredService<IOptions<CustomApiSettings>>().Value);

        services.Configure<CustomerDetailsSetting>(builder.Configuration.GetRequiredSection("CustomerDetails"));
        services.AddSingleton(sp => sp.GetRequiredService<IOptions<CustomerDetailsSetting>>().Value);

        return services;
    }

    public static IServiceCollection ConfigureBankAppLogging(this IServiceCollection services, bool enableHttpLogging)
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

        if (enableHttpLogging)
        {
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
        }

        return services;
    }
}
