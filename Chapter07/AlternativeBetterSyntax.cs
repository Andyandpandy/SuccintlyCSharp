using System;
using System.Collections.Generic;
using System.Linq;

namespace Chapter07
{
    public class AlternativeBetterSyntax
    {
        public AlternativeBetterSyntax()
        {
        }

        public void AlternateMyData()
        {
            //Dot notation for each operation.
            var customers6 =
            Company.Customers
                   .Where(cust => cust.Name.StartsWith("J")).ToList();

            customers6.ForEach(cust => Console.WriteLine(cust.Name));

            var customers7 =
                Company.Customers.Select(cust => cust.Name).ToList();
            customers7.ForEach(cust => Console.WriteLine(cust));



            //Union, Except or Intersection are also possible.
            var additionalCustomers =
            new List<Customer>
            {
                new Customer { ID = 1, Name = "Gary" }
            };
            var customerUnion =
                Company.Customers
                       .Union(additionalCustomers)
                       .ToArray();

            foreach (var cust in customerUnion)
            {
                Console.WriteLine(cust.Name);
            }

            //Shorthands for First, FirstOrDefault, Single, SingleOrDefault, Last, and LastOrDefault.
            //Possibility of InvalidOperationException 
            //Therefore safer to use orDefault methods
            Console.WriteLine(Company.Customers.First().Name);
        }
    }
}
