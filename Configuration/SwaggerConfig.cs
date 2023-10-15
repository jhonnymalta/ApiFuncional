using Microsoft.OpenApi.Models;

namespace ApiFuncional.Configuration
{
    public static class SwaggerConfig
    {
        public static WebApplicationBuilder AddSwaggerConfig(this WebApplicationBuilder builder)
        {
            builder.Services.AddEndpointsApiExplorer();

            builder.Services.AddSwaggerGen(c =>
            {
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Description = "Insert a token JWT like this: Bearer {your token}",
                    Name = "Authorization",
                    Scheme = "Bearer",
                    BearerFormat = "JWT",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey
                });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                    new OpenApiSecurityScheme
                    {
                        Reference = new OpenApiReference
                        {
                            Type = ReferenceType.SecurityScheme,
                            Id = "Bearer"
                        }
                     },
                        new string[] {}
                    }
                });
            });

            return builder;
        }
    }
}
