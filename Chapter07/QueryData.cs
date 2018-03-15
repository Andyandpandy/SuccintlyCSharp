using System;
using System.Collections.Generic;
using System.Linq;

namespace Chapter07
{
    public class QueryData
    {
        public QueryData()
        {
        }

        public void QueryMyData(){
            //Get data to our Object IEnumerable
            IEnumerable<Customer> customers =
            from cust in Company.Customers
            select cust;

            //Iterate over all customers and print their name
            foreach (Customer cust in customers)
                Console.WriteLine(cust.Name);


            //Customer after the from is a variable name for each element
            //in the Company.customers.
            IEnumerable<int> customerIDs =
                from customer in Company.Customers
                select customer.ID;
            foreach (int id in customerIDs)
            {
                Console.Write(id + " ");
            }


            //In this case we now might need a different class to handle the 
            //given data from the query so we create a new CustomerViewModel
            //The brackets are called object initialisation syntax and all 
            //objects can use it
            IEnumerable<CustomerViewModel> customerVMs =
            from custVM in Company.Customers
            select new CustomerViewModel
            {
                Name = custVM.Name
            };


            //var keyword is used for anonymous classes
            //The type is redundant seeing as we know its a customer
            //Although sometimes it isn't readable and analyseable 
            //What the object is so make sure to use it wisely
            var customers3 =
            from cust3 in Company.Customers
            select new
            {
                Name = cust3.Name
            };
            foreach (var cust3 in customers3)
            {
                Console.WriteLine(cust3.Name);
            }


            //LINQ queries use deferred execution. 
            //This means that the query doesn’t execute 
            //until you execute a foreach loop or 
            //call one of the standard query operators, 
            //like ToList, that requests the data.
            Console.WriteLine("Lambdas:");
            var customerLambda =
                (from customerlambda in Company.Customers select customerlambda);
            //Ergo this above doesn't execute untill i say .toList or .ForEach
            customerLambda.ToList().ForEach(cust => Console.WriteLine(cust.Name));

        }

    }
}
