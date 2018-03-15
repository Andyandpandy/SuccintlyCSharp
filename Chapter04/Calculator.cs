using System;
namespace Chapter04
{
    public abstract class Calculator : Calculation
    {
        public Calculator()
        {
        }

        //No polymorphic without virtual keyword
        public virtual double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        public abstract void Start();

        // Non virtual therefore not overrideable
        public double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }
    }
}
