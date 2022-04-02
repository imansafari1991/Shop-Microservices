using GraphQL.Server;
using Microsoft.EntityFrameworkCore;
using Products.Api;
using Products.Api.GQL;
using Products.Api.GQL.Mutations;
using Products.Api.GQL.Queries;
using Products.Infrastructure;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.AddServiceRegistery();

builder.AddInfrastructureServices();
builder.AddApplicationServices();

builder.Services.AddScoped<AppMutations>();

builder.Services.AddScoped<AppQueries>();



builder.Services.AddScoped<AppSchema>();
builder.Services.AddGraphQL().AddSystemTextJson();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseGraphQL<AppSchema>();


app.UseGraphQLGraphiQL("/ui/graphql");
app.UseAuthorization();

app.MapControllers();

app.Run();