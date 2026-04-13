using Microsoft.EntityFrameworkCore;
using GardenApp.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<GardenContext>(options =>
    options.UseInMemoryDatabase("GardenDB"));

var app = builder.Build();

app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Section}/{action=Index}/{id?}");

app.Run();
