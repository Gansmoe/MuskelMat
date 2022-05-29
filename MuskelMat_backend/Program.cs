using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.NewtonsoftJson;
using MuskelMat_backend.Models;
using AutoMapper;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddNewtonsoftJson();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Change this to your filepath for database.
builder.Services.AddDbContext<AppDbContext>(options =>
options.UseSqlite(@"Data Source=C:\Users\Isac\Documents\Skola\Moderna Webbsystem\Submits\MuskelMat\MuskelMat_backend\DB\app.db"));

builder.Services.AddScoped<IRecipesRepository, RecipesRepository>();
builder.Services.AddScoped<IIngredientsRepository, IngredientsRepository>();

builder.Services.AddCors(options => options.AddPolicy("AllowEverything", builder => builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()));

builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("AllowEverything");

app.UseAuthorization();

app.MapControllers();

app.Run();
