﻿using BankingWebApp.Apis;
using GoogleApi.Extensions;
using Microsoft.AspNetCore.HttpLogging;
using Microsoft.Extensions.Options;
using NLog.Web;

namespace BankingWebApp.Extensions;

public static class ConfigureServicesExtensions
{
    public static IServiceCollection AddBankAppServices(this IHostApplicationBuilder builder)
    {
        var services = builder.Services;
        var connectionString = builder.Configuration.GetConnectionString("DefaultConnectionString") ?? Environment.GetEnvironmentVariable("DefaultConnectionString");
        //var password = builder.Configuration.GetValue<string>("COLLEAGUE_CASTLE_EMAIL_PASSWORD") ?? Environment.GetEnvironmentVariable("COLLEAGUE_CASTLE_EMAIL_PASSWORD");
        services.AddDbContext<BankAppDbContext>(options => options.UseSqlServer(connectionString));
        services.ConfigureBankAppLogging();


        services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

        //services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));

        services.AddScoped<CustomerRepository>();
        services.AddScoped<AccountRepository>();
        services.AddScoped<TransactionRepository>();

        services.AddGoogleApiClients();

        // Bind the GoogleApiSettings section from appsettings.json
        services.Configure<GoogleApiSettings>(builder.Configuration.GetSection("GoogleApiSettings"));
        // Access GoogleApiSettings via dependency injection
        services.AddSingleton(provider =>
            provider.GetRequiredService<IOptions<GoogleApiSettings>>().Value);

        services.AddScoped<GoogleApiClient>();

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
