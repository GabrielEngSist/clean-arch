using GymManagement.Application;
using GymManagement.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services
    .AddApplication()
    .AddInfrastructure();

var app = builder.Build();

app.MapControllers();
app.UsePathBase("/api/v1/");

await app.RunAsync();
