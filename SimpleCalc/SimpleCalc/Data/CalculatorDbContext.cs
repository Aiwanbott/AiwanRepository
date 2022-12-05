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
       
              //var connectionsString = builder.Configuration.GetConnectionString("Server=(localdb)\\MSSQLLocalDB;Database=CalcaulatorDb;Trusted_Connection=True;MultipleActiveResultSets=true");
        //builder.Services.AddDbContext<CalculationContext>(options =>
        //{
        //    options.UseSqlServer(connectionsString);
        //}, ServiceLifetime.Transient);

        //optionsBuilder.UseSqlServer(
        //    @"Server=localhost;Database=CalcaulatorDb;User Id=dbo;Password=123dog123;Trusted_Connection=True;MultiSubnetFailover=True;TrustServerCertificate=true;MultipleActiveResultSets=true");

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Calculation>().HasKey(c => c.Id);
        // использование Fluent API
        base.OnModelCreating(modelBuilder);
    }
}
