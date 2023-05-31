using Microsoft.OpenApi.Models;

namespace UniversoGeek.API.Configuration
{
    public static class SwaggerConfig
    {
        public static void AddSwaggerConfiguration(this IServiceCollection services)
        {
            services.AddSwaggerGen(s =>
            {
                s.SwaggerDoc("v1", new OpenApiInfo()
                {
                    Title = "UniversoGeek API",
                    Description = "Esta API é feita como API do site UniversoGeek",
                    Contact = new OpenApiContact()
                    {
                        Name = "UniversoGeek",
                        Email = "UniversoGeek@go.com.br"
                    }
                });
            });
        }

        public static void UseSwaggerConfiguration(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(s =>
            {
                s.SwaggerEndpoint("swagger/v1/swagger.json", "v1");
            });
        }
    }
}
