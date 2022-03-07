using Microsoft.EntityFrameworkCore;
using Products.Infrastructure;

namespace Products.Api
{
    public static class ServiceRegistery
    {
        public static IServiceCollection AddServiceRegistery(this WebApplicationBuilder builder)
        {
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();


            builder.Services.AddDbContext<ProductDbContext>(option =>
                option.UseNpgsql(builder.Configuration.GetConnectionString("ProductDbConn")));

            return builder.Services;
        }
    }
}