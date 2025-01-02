var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();
app.UsePathBase("/api/v1/");

await app.RunAsync();
