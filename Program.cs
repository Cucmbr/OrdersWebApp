using Microsoft.EntityFrameworkCore;
using OrdersWebApp.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<AppDbContext>(opt => opt.UseNpgsql("Host=localhost;Port=5432;Database=OrderDB;Username=postgres;Password=admin"));

builder.Services.AddScoped<IOrderRepo, OrderRepo>();

var app = builder.Build();

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Orders}/{action=Index}/{id?}");

app.Run();
