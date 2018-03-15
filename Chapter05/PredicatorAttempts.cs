using System;
namespace Chapter05
{
    public class PredicatorAttempts
    {
        Predicate<string> myExpression;

        public PredicatorAttempts()
        {
            myExpression = sentence =>
            {
                int length_of_sentence = sentence.Length;
                return length_of_sentence > 3;                                 
            };
        }

        /**
         * If word is above more than 3 letters the expression is true 
        */
        public void printSomething(string word){
            bool isValid = myExpression(word);
            Console.WriteLine($"The value is: {isValid}");
        }
    }
}
