using SimpleCalc.Data;
using SimpleCalc.Interfaces;
using SimpleCalc.Models;

namespace SimpleCalc.Services
{
    public class CalculationService : ICalculationService
    {
        private readonly CalculatorDbContext _context;
        public CalculationService(CalculatorDbContext context)
        {
            _context = context;
        }

        public double Add(double value1, double value2)
        {
            var result = value1 + value2;

            var calculation = new Calculation
            {
                Param1 = (decimal)value1,
                Param2 = (decimal)value2,
                ActionType = "Add",
                Result = (decimal)result
            };

            using var _context = new CalculatorDbContext();

            _context.Calculations.Add(calculation);
            _context.SaveChanges();

            return result;
        }

        public double Div(double value1, double value2) => value1 / value2;

        public double Mul(double value1, double value2) => value1 * value2;

        public double Pow(double value, double precision) => Math.Pow(value, precision);

        public double Sqrt(double value, double precision) => Math.Pow(value, 1 / precision);

        public double Sub(double value1, double value2) => value1 - value2;

    }
   
}