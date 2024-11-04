using MacosDeployDemo.UI.Models;
using Microsoft.EntityFrameworkCore;

namespace MacosDeployDemo.UI.Data;

public class MainContext : DbContext
{
    private DbSet<Item> Items { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (optionsBuilder.IsConfigured)
        {
            return;
        }
        
        optionsBuilder.UseSqlite($"Data Source=data.db");
    }
}