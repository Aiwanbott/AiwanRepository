using SimpleCalc.Interfaces;
using SimpleCalc.Models;

namespace SimpleCalc.Services
{
    public class CalculationService : ICalculationService
    {
        public double Add(double value1, double value2) => value1 + value2;
       
        public double Div(double value1, double value2) => value1 / value2;

        public double Mul(double value1, double value2) => value1 * value2;

        public double Pow(double value, double precision) => Math.Pow(value, precision);

        public double Sqrt(double value, double precision) => Math.Pow(value, 1 / precision);

        public double Sub(double value1, double value2) => value1 - value2;
        
    }
}