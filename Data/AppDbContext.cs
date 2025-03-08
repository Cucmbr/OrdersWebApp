using Microsoft.EntityFrameworkCore;
using OrdersWebApp.Models;

namespace OrdersWebApp.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
    {

    }

    public DbSet<Order> Orders { get; set; }
}
