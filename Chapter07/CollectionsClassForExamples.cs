using System;
using System.Collections.Generic;

namespace Chapter07
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
    public class Order
    {
        public int CustomerID { get; set; }
        public string Description { get; set; }
    }
    public static class Company
    {
        static Company()
        {
            Customers = new List<Customer>
        {
new Customer { ID = 0, Name = "May" },
new Customer { ID = 1, Name = "Gary" }, new Customer { ID = 2, Name = "Jennifer" }
        };
            Orders = new List<Order>
        {
new Order { CustomerID = 0, Description = "Shoes" },
new Order { CustomerID = 0, Description = "Purse" },
new Order { CustomerID = 2, Description = "Headphones" }
};
        }
        public static List<Customer> Customers { get; set; }
        public static List<Order> Orders { get; set; }
    }
}
