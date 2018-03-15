using System;
namespace Chapter05
{
    public class FuncSucces
    {
        Func<string, string> bestFunc;
        public FuncSucces()
        {
            bestFunc = (arg) => {
                if (arg.Length < 16){
                    return "This is a short sentence";
                } 
                return "Now this is a big sentence";
            };
        }

        public void FuncCity(string input){
            Console.WriteLine(input);
            Console.WriteLine(bestFunc(input));
        }
    }
}
