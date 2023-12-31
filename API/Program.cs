using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using API.Extensions;
using System.Reflection;

// Add services to the container.
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddAutoMapper(Assembly.GetEntryAssembly());
builder.Services.ConfigureCors();
builder.Services.AddControllers();
//builder.Services.ConfigureApiVersioning();
//builder.Services.ConfigureRatelimiting();
//builder.Services.AddAplicacionServices();

builder.Services.AddDbContext<APItiendaContext>(optionBuilder =>
{
    string ? connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
    optionBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("CorsPolicy");
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
