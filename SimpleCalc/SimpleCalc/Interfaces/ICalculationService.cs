using SimpleCalc.Models;

namespace SimpleCalc.Interfaces
{
    public interface ICalculationService
    {
        double Add(double value1, double value2);

        double Sub(double value1, double value2);

        double Mul(double value1, double value2);

        double Div(double value1, double value2);

        double Sqrt(double value, double precision);

        double Pow(double value, double precision);
    }
}
