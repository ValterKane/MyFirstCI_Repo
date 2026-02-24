using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();
builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.WriteIndented = true;
    options.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
    options.JsonSerializerOptions.IgnoreNullValues = true;
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseRouting();

app.MapControllers();

app.Run();