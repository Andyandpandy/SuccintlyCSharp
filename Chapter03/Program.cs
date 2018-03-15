using System;
using Calculation;

namespace Chapter03
{
    class MainClass
    {
        static void Main()
        {
            Calculator calc = new Calculator();
            calc.GetNumber("First");
            calc.GetNumber("Second");
            //calc.GetNumber("Third"); //If testing for throwing ArgException
            calc.PrintResult();
        }
    }
}
