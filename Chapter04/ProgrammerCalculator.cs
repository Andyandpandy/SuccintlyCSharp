using System;
namespace Chapter04
{
    public class ProgrammerCalculator : Calculator
    {
        public ProgrammerCalculator()
        {
            
        }

        public int Or(int num1, int num2){
            return num1 | num2;
        }

        public override void Start()
        {
            throw new NotImplementedException();
        }
    }
}
