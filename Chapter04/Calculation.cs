using System;
namespace Chapter04
{
    public interface Calculation
    // Common convention is to prefix it meaning: ICalculation instead of Calculation
    {
        double Add(double num1, double num2);

        void Start();

        double Subtract(double num1, double num2);
    }
}
