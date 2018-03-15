using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter02
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*
             * Hey
             * Multi 
            */ 
            string myAge;
            char keyPress = 'Q';
            Console.Write("Enter your name: ");
            string myName = Console.ReadLine();
            Console.Write("How old are you: ");
            myAge = Console.ReadLine();
            int myIntAge = int.Parse(myAge);
            // d after the 3.14 is a suffix ...
            double myDouble = 3.14d;
            int myDoubleAsInt = (int)myDouble;
            char randomUnicode = '\u1984';
            int thisInteger = --myIntAge;

            string action = myDoubleAsInt > thisInteger ? "Less" : "More";
            if (thisInteger == 6){
                Console.WriteLine("6 is true");
            } else if (thisInteger > 6 && thisInteger > 7 || thisInteger == 12){
                Console.Write("meh");
            }
            else {
                Console.Write("not");
            }

            //Switch same as java

            DateTime currentTime = DateTime.Now;

            //Arrays
            string[] simpleArray = new string[3];
            simpleArray[0] = "Not";
            simpleArray[1] = "Difficult";

            //Lists, Stacks, Queues and more
            List<decimal> prices = new List<decimal>();
            prices.Add(53);
            prices.Add(55);
            prices.Add(56);
            prices.Add(58);

            string greetingWithName = string.Format("Hello, {0}!", myName);

            StringBuilder sb = new StringBuilder();
            sb.Append("You are ");
            sb.Append(myAge.ToString());
            sb.Append(" years old");

            Console.WriteLine(thisInteger.ToString() + " " +  myDoubleAsInt.ToString() + keyPress);
            Console.WriteLine(greetingWithName);
            Console.WriteLine(sb.ToString());
            Console.WriteLine(randomUnicode);
            Console.WriteLine(action);
            Console.WriteLine(currentTime.ToString());

            for (int i = 0; i < simpleArray.Length; i++)
            {
                Console.Write(simpleArray[i] + ", ");
            }

            Console.WriteLine("ForEach");

            foreach(int price in prices){
                Console.Write(price + " ");
            }
            int counter = 0;
            Console.WriteLine("While:");
            while (counter < simpleArray.Length){
                Console.Write(counter + " ");
                counter++;
            }

            Console.WriteLine();
            do
            {
                Console.Write(counter + " ");
                counter--;
            }
            while (counter > 0);
        }


    }
}
