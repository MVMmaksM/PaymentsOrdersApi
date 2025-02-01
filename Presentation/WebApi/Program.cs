using WebApi.Extensions;
using WebApi.Middlewares;

namespace WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers().AddJsonOptions(option => 
            {
                option.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles;
            });
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddApiVersioning();

            builder.AddSwagger();
            builder.AddData();
            builder.AddServices();
            builder.AddRepositories();
            builder.AddRedisCache();

            var app = builder.Build();

            app.UseMiddleware<LoggerMiddleware>();
            app.UseSwagger();
            app.UseSwaggerUI();
            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();

            app.Run();
        }
    }
}
