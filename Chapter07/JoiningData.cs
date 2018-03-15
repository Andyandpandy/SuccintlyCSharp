using System;
using System.Linq;

namespace Chapter07
{
    public class JoiningData
    {
        public JoiningData()
        {
        }

        public void JoinMyData(){

            //So takes from the customers 
            //It tries to join them to orders if the id's match
            //If they match a new object is created with 
            //Customer ID, Customer name and Order description
            //This is a normal join
            var customerOrders =
            from cust in Company.Customers
            join ord in Company.Orders
                on cust.ID equals ord.CustomerID
            select new
            {
                ID = cust.ID,
                Customer = cust.Name,
                Item = ord.Description
            };
            foreach (var custOrd in customerOrders)
                Console.WriteLine($"Customer: {custOrd.Customer}, Item: {custOrd.Item}");


            //Left join
            var customerOrders2 =
            from cust in Company.Customers
            join ord in Company.Orders.DefaultIfEmpty()
                on cust.ID equals ord.CustomerID
            select new
            {
                ID = cust.ID,
                Customer = cust.Name,
                Item = ord.Description
            };
            foreach (var custOrd2 in customerOrders)
            {
                Console.WriteLine($"Customer: {custOrd2.Customer}, Item: {custOrd2.Item}");
            }
        }
    }
}
