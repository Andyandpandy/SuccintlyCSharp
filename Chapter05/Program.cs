using System;

namespace Chapter05
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ActionExamples actionEx = new ActionExamples();
            actionEx.printYourName("Andreas");
            actionEx.printSomething("Action lambdas take no parameters and just perform whatever you like!");

            PredicatorAttempts attempt = new PredicatorAttempts();
            attempt.printSomething("Predicators must return a boolean apparently");
            attempt.printSomething("Ok");

            FuncSucces theFunk = new FuncSucces();
            theFunk.FuncCity("I have no words except for congratulations");
            theFunk.FuncCity("I'm Speechless");

            ExpressionBodiedIGuess ex = new ExpressionBodiedIGuess();
            ex.Log(ex.Today);

        }
    }
}
