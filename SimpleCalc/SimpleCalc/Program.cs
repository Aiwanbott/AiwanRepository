using SimpleCalc.Interfaces;
using SimpleCalc.Services;
using SimpleCalc.Data;
using Microsoft.EntityFrameworkCore;



        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        builder.Services.AddTransient<ICalculationService, CalculationService>();
//    builder.Services.AddDbContext<CalculatorDbContext>(options =>
//options.UseSqlServer(builder.Configuration.GetConnectionString("Server=(localdb)\\mssqllocaldb;Database=SimpleCalc.Data;Trusted_Connection=True;MultipleActiveResultSets=true")));
var connectionsString = builder.Configuration.GetConnectionString("CalculatorDbContext");
builder.Services.AddDbContext<CalculatorDbContext>(options =>
{
    options.UseSqlServer(connectionsString);
}, ServiceLifetime.Transient);


//builder.Services.AddDbContext<CalculatorDbContext>(options => options.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=CalcaulatorDb;Trusted_Connection=True;MultipleActiveResultSets=true"));

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

