using System;
using System.Collections.Generic;
using System.Linq;

namespace Chapter07
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*
             * For more info on Linq:
             * https://msdn.microsoft.com/en-us/library/bb397896(v=vs.120).aspx 
            */

            //See the method QueryMyData for explaination and code
            Console.WriteLine("Queries:");
            QueryData queries = new QueryData();
            queries.QueryMyData();

            Console.WriteLine();

            //See the method FilterMyData for explaination and code
            Console.WriteLine("Filters:");
            FilteringData filters = new FilteringData();
            filters.FilterMyData();

            Console.WriteLine();

            //See the method OrderMyData for explaination and code
            Console.WriteLine("Ordering:");
            OrderingData order = new OrderingData();
            order.OrderMyData();

            Console.WriteLine();

            //See the method JoinMyData for explaination and code
            Console.WriteLine("Joining:");
            JoiningData joinTheDarkSide = new JoiningData();
            joinTheDarkSide.JoinMyData();
        }
    }
}
