using System.Configuration;

using Amdaris.Internship.Data.Context;

using Google.Protobuf.WellKnownTypes;

using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.Azure.Functions.Worker;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Identity.Web;

var host = new HostBuilder()
    .ConfigureFunctionsWebApplication()
    .ConfigureServices((builder, services) =>
    {
        string _connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog = FitnessApplication; Integrated Security = True;";
        services.AddApplicationInsightsTelemetryWorkerService();
        services.ConfigureFunctionsApplicationInsights();
        services.AddDbContext<InternshipDbContext>(optionBuilder =>
        {
            optionBuilder.UseSqlServer(_connectionString);

        });
        services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
        .AddMicrosoftIdentityWebApi(options =>
        {
            builder.Configuration.Bind("AzureAd", options);
            options.TokenValidationParameters.NameClaimType = "name";
        }, options => { builder.Configuration.Bind("AzureAd", options); });

        services.AddAuthorization(config =>
        {
            config.AddPolicy("AuthZPolicy", policyBuilder =>
                policyBuilder.Requirements.Add(new ScopeAuthorizationRequirement() { RequiredScopesConfigurationKey = $"AzureAd:Scopes" }));
        });
    })
.Build();

host.Run();
