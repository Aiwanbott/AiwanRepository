using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SimpleCalc.Services;
using SimpleCalc.Models;

namespace SimpleCalc.Data;

public class CalculatorDbContext : DbContext
{

    public DbSet<Calculation> Calculations { get; set; }

   public CalculatorDbContext(DbContextOptions options) :base(options) {}

    public CalculatorDbContext()
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Calculation>().HasKey(c => c.Id);
        // использование Fluent API
        base.OnModelCreating(modelBuilder);
    }
}
