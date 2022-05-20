using Microsoft.EntityFrameworkCore;
using MuskelMat_backend.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>(options =>
options.UseSqlite(@"Data Source=C:\Users\Isac\Documents\Skola\Moderna Webbsystem\Submits\MuskelMat\MuskelMat_backend\DB\app.db"));

builder.Services.AddScoped<IRecipesRepository, RecipesRepository>();
builder.Services.AddScoped<IIngredientsRepository, IngredientsRepository>();

builder.Services.AddCors(options => options.AddPolicy("AllowEverything", builder => builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
