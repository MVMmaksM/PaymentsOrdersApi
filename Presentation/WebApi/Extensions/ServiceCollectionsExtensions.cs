using Application.Interfaces;
using Application.Interfaces.Repository;
using Application.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Persistence.Database;
using Persistence.Repository;

namespace WebApi.Extensions
{
    public static class ServiceCollectionsExtensions
    {
        public static WebApplicationBuilder AddSwagger(this WebApplicationBuilder builder) 
        {
            builder.Services.AddSwaggerGen(option =>
            {
                option.SwaggerDoc("v1", new OpenApiInfo()
                {
                    Title = "Web API",
                    Description = "Payments orders API",
                    Version = "v1",
                    Contact = new OpenApiContact()
                    {
                        Email = "vaganov.maksim@mail.ru",
                        Name = "Maksim",
                        Url = new Uri("https://github.com/MVMmaksM/PaymentsOrdersApi")
                    }
                });

                //настройка авторизации
                option.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    In = ParameterLocation.Header,
                    Description = "Please enter a valid token",
                    Name = "Authorization",
                    Type = SecuritySchemeType.Http,
                    BearerFormat = "JWT",
                    Scheme = "Bearer"
                });

                option.AddSecurityRequirement(new OpenApiSecurityRequirement
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
                        Array.Empty<string>()
                    }
                });
            });

            return builder;
        }

        public static WebApplicationBuilder AddData(this WebApplicationBuilder builder) 
        {
            builder.Services.AddDbContext<AppDbContext>(option => option
            .UseNpgsql(builder.Configuration.GetConnectionString("OrdersPayments")));
            return builder;
        }

        public static WebApplicationBuilder AddRepositories(this WebApplicationBuilder builder) 
        {
            builder.Services.AddTransient<ISellerRepository, SellerRepository>();
            builder.Services.AddTransient<IProductRespository, ProductRepository>();
            builder.Services.AddTransient<IManufacturerRepository, ManufacturerRepository>();
            builder.Services.AddTransient<ICategoryRepository, CategoryRepository>();
            builder.Services.AddTransient<IOrdersRepository, OrderRepository>();
            return builder;
        }

        public static WebApplicationBuilder AddServices(this WebApplicationBuilder builder) 
        {
            builder.Services.AddTransient<ICategoryService, CategoryService>();
            builder.Services.AddTransient<IProductService, ProductService>();
            builder.Services.AddTransient<ISellerService, SellerService>();
            builder.Services.AddTransient<IManufacturerService, ManufacturerService>();
            builder.Services.AddTransient<IOrderService, OrderService>();
            return builder;
        }
    }
}
