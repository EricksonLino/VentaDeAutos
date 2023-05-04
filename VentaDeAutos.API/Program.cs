using Microsoft.EntityFrameworkCore;
using VentaDeAutos.Application.Implementaciones;
using VentaDeAutos.Application.Interfaces;
using VentaDeAutos.Repository;
using VentaDeAutos.Repository.Implementaciones;
using VentaDeAutos.Repository.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ApplicationDbContext>(conf => 
                                conf.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<IAutoCedanRepository, AutoCedanRepository>();
builder.Services.AddScoped<IAutoCedanApplication, AutoCedanApplication>();

builder.Services.AddControllers();
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

app.UseAuthorization();

app.MapControllers();

app.Run();
