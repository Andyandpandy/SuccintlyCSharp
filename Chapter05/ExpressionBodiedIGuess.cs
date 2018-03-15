using System;
namespace Chapter05
{
    public class ExpressionBodiedIGuess
    {
        public ExpressionBodiedIGuess()
        {
        }

        public string Today => DateTime.Now.ToShortDateString();
        public void Log(string message) => Console.WriteLine(message);

    }

}
