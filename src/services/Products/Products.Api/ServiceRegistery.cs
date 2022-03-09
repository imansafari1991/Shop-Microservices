using Microsoft.EntityFrameworkCore;
using Products.Domain;
using Products.Infrastructure;
using System.Text.Json.Serialization;
using System.Text.Json;
using MediatR;
using FluentValidation;
using Products.Application.Behaviours;

namespace Products.Api
{
    public static class ServiceRegistery
    {
        public static IServiceCollection AddServiceRegistery(this WebApplicationBuilder builder)
        {
           
            builder.Services.AddControllers().AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.ReferenceHandler= ReferenceHandler.IgnoreCycles;
                options.JsonSerializerOptions.WriteIndented = true;
            });
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();


     

            return builder.Services;
        }

        public static IServiceCollection AddInfrastructureServices(this WebApplicationBuilder builder)
        {
            builder.Services.AddAutoMapper(Assemblies.InfrastructureAssembly);
            builder.Services.AddDbContext<ProductDbContext>(option =>
                option.UseNpgsql(builder.Configuration.GetConnectionString("ProductDbConn")));
            builder.Services.AddScoped<IReadUnitOfWork, ReadUnitOfWork>();
            builder.Services.AddScoped<IWriteUnitOfWork, WriteUnitOfWork>();
            return builder.Services;
        }
        public static IServiceCollection AddApplicationServices(this WebApplicationBuilder builder)
        {
            builder.Services.AddValidatorsFromAssembly(Assemblies.ApplicationAssembly);
            builder.Services.AddMediatR(Assemblies.ApplicationAssembly);
            builder.Services.AddTransient(typeof(IPipelineBehavior<,>), typeof(UnhandledExceptionBehaviour<,>));
            builder.Services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>));

            return builder.Services;
        }
    }
}