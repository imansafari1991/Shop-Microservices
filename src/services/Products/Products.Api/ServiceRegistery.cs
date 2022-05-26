using Microsoft.EntityFrameworkCore;
using Products.Domain;
using Products.Infrastructure;
using System.Text.Json.Serialization;
using System.Text.Json;
using MediatR;
using FluentValidation;
using Products.Application.Behaviours;
using MassTransit;
using EventBus.Messages.Events;

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
        public static IServiceCollection AddMessagingConfiguration(this WebApplicationBuilder builder)
        {
            builder.Services.AddMassTransit(x =>
            {

                x.UsingRabbitMq((ctx, cfg) =>
                {
                    cfg.Host(builder.Configuration["EventBusSettings:HostAddress"]);
                });

                x.AddConsumers(typeof(IntegrationBaseEvent).Assembly);
            });
            // OPTIONAL, but can be used to configure the bus options
            builder.Services.AddOptions<MassTransitHostOptions>()
                .Configure(options =>
                {
                    // if specified, waits until the bus is started before
                    // returning from IHostedService.StartAsync
                    // default is false
                    options.WaitUntilStarted = true;

                    // if specified, limits the wait time when starting the bus
                    options.StartTimeout = TimeSpan.FromSeconds(10);

                    // if specified, limits the wait time when stopping the bus
                    options.StopTimeout = TimeSpan.FromSeconds(30);
                });

            return builder.Services;

        }
    }
}