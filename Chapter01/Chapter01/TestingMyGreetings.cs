using System;
using Chapter01;

namespace MyGreeting
{
    public class TestingMyGreetings
    {
        public TestingMyGreetings()
        {
        }

        static void Main(){
            Greetings greeting = new Greetings();
            greeting.printName("Andreas");
        }
    }
}
