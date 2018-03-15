using System;
namespace Chapter04
{
    public class ScientificCalculator : Calculator
    {
        int x = 0;

        //Overriding konstruktor
        static ScientificCalculator(){
            Console.WriteLine("Static");
        }

        /*
         * Instead of this we do the same by doing this
        public ScientificCalculator()
        {
            Console.WriteLine("Normal");
            x = 10;
        }*/

        public ScientificCalculator() : this(10)
        {
            Console.WriteLine("Normal");
        }

        public ScientificCalculator(int i){
            x = i;
        }

        public ScientificCalculator(int val, string word) : base(){
            x = val;
            Console.Write("Base calls");
        }

        public double Power(double num, double power){
            return Math.Pow(num, power);
        }

        //This method overrides Calculator add
        public override double Add(double num1, double num2)
        {
            
            Console.WriteLine("ScientificCalculator Add called.");
            //Use calculator add (base) method add. 
            return base.Add(num1, num2) + 1;
        }

        public override void Start()
        {
            throw new NotImplementedException();
        }
    }
}
