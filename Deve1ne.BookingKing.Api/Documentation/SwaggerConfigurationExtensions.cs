using System.Reflection;
using Microsoft.OpenApi.Models;

namespace Deve1ne.BookingKing.Api.Documentation;

public static class SwaggerConfigurationExtensions
{
    public static IServiceCollection AddCustomSwagger(this IServiceCollection services)
    {
        services.AddSwaggerGen(options =>
        {
            options.SwaggerDoc("v1", new OpenApiInfo
            {
                Version = "v1",
                Title = "Booking management API",
                Description = "API for booking management",
                Contact = new OpenApiContact
                {
                    Name = "Dimitri Even",
                    Email = "dimitri.even@groolot.net",
                    Url = new Uri("https://example.com")
                }
            });

            var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
            options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
        });

        return services;
    }
}