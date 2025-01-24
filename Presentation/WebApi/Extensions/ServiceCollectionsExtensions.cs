namespace WebApi.Extensions
{
    public static class ServiceCollectionsExtensions
    {
        public static WebApplicationBuilder AddSwagger(this WebApplicationBuilder builder) 
        {
            builder.Services.AddSwaggerGen(option =>
            option.SwaggerDoc("v2", new Microsoft.OpenApi.Models.OpenApiInfo 
            {
                Description = "Payments orders API",
                Version = "v1",
            }));

            return builder;
        }
    }
}
