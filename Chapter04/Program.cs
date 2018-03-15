using System;

namespace Chapter04
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            
            ScientificCalculator sciCalc = new ScientificCalculator();

            double powerResult = sciCalc.Power(2, 5);
            Console.WriteLine($"Scientific Calculator 2**5: {powerResult}");

            double sciSum = sciCalc.Add(3, 3);
            Console.WriteLine($"Scientific Calculator 3 + 3: {sciSum}");



            ProgrammerCalculator prgCalc = new ProgrammerCalculator();

            double orResult = prgCalc.Or(5, 10);
            Console.WriteLine($"Programmer Calculator 5 | 10: {orResult}");

            double prgSum = prgCalc.Add(3, 3);
            Console.WriteLine($"Programmer Calculator 3 + 3: {prgSum}");



            Complex complex1 = new Complex();
            complex1.Real = 3;
            complex1.Imaginary = 1;

            Complex complex2 = new Complex(7, 5);

            Complex complexSum = complex1 + complex2;
            Console.WriteLine(
                $"Complex sum - Real: {complexSum.Real}, " +
                $"Imaginary: {complexSum.Imaginary}");
            
            Complex complex3 = 9;

            double realPart = (double)complex3;


            Customer cust1 = new Customer(1, "May"); 
            Customer cust2 = new Customer(2, "Joe");
            Console.WriteLine($"cust1 == cust2: {cust1 == cust2}"); 
            Customer cust3 = new Customer(1, "May");
            Console.WriteLine($"\ncust1 == cust3: {cust1 == cust3}");
            Console.WriteLine($"cust1.Equals(cust3): {cust1.Equals(cust3)}");
            Console.WriteLine($"object.ReferenceEquals(cust1, cust3):{ object.ReferenceEquals(cust1, cust3)}");
            Console.WriteLine($"\ncust1: {cust1}");
            Console.WriteLine($"cust2: {cust2}");
            Console.WriteLine($"cust3: {cust3}");
        }

    }
}
