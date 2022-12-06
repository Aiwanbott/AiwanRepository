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
            _context.Calculations.Add(calculation);
            _context.SaveChanges();

            return result;
        }

        public double Div(double value1, double value2)
        {
            var result = value1 / value2;

            var calculation = new Calculation
            {
                Param1 = (decimal)value1,
                Param2 = (decimal)value2,
                ActionType = "Div",
                Result = (decimal)result
            };
            _context.Calculations.Add(calculation);
            _context.SaveChanges();

            return result;
        }


        public double Mul(double value1, double value2)
        {
            var result = value1 * value2;
            var calculation = new Calculation
            {
                Param1 = (decimal)value1,
                Param2 = (decimal)value2,
                ActionType = "Mul",
                Result = (decimal)result
            };
            _context.Calculations.Add(calculation);
            _context.SaveChanges();

            return result;
        }



        public double Pow(double value, double precision)
        {
            var result = Math.Pow(value, precision);
            var calculation = new Calculation
            {
                Param1 = (decimal)value,
                Param2 = (decimal)precision,
                ActionType = "Pow",
                Result = (decimal)result
            };
            _context.Calculations.Add(calculation);
            _context.SaveChanges();

            return result;
        }


        public double Sqrt(double value, double precision)
        {
            var result = Math.Pow(value, 1 / precision);
            var calculation = new Calculation
            {
                Param1 = (decimal)value,
                Param2 = (decimal)precision,
                ActionType = "Sqrt",
                Result = (decimal)result
            };
            _context.Calculations.Add(calculation);
            _context.SaveChanges();

            return result;
        }



        public double Sub(double value1, double value2)
        {
            var result = value1 - value2;
            var calculation = new Calculation
            {
                Param1 = (decimal)value1,
                Param2 = (decimal)value2,
                ActionType = "Div",
                Result = (decimal)result
            };
            _context.Calculations.Add(calculation);
            _context.SaveChanges();

            return result;
        }



    }

}