using GardenApp.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<GardenContext>(options =>
    options.UseInMemoryDatabase("GardenDB"));

var app = builder.Build();

// Configure pipeline
app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Section}/{action=Index}/{id?}");

app.Run();
