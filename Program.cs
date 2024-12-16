using Microsoft.EntityFrameworkCore;
using ProductAPI.Models;
using ProductAPI.Data;

var builder = WebApplication.CreateBuilder(args);

// Налаштування Entity Framework для використання SQLite
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Простий маршрут, який повертає «Hello World»
app.MapGet("/", () => "Hello World!");

// Запуск Аплікухи
app.Run();
