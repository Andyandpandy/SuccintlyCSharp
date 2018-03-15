using System;
namespace Chapter05
{
    public class ActionExamples
    {
        Action hello;
        public ActionExamples()
        {
            hello = () => Console.Write("Lambda's are cool");
        }

        public void printYourName(string name){
            hello();
            Console.WriteLine($" and my name is {name}");
        }

        public void printSomething(string something){
            hello();
            Console.WriteLine($" {something}");
        }
    }
}
