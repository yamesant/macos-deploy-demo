using System;
using System.IO;
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
        
        string path = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "HelloWorld",
            "data.db");

        Directory.CreateDirectory(Path.GetDirectoryName(path)!);
        optionsBuilder.UseSqlite($"Data Source={path}");
    }
}