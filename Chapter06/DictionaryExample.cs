using System;
using System.Collections.Generic;

namespace Chapter06
{   
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
    public class DictionaryExample
    {
        public DictionaryExample()
        {
        }

        public void myDictionaryMethod(){
            
            Dictionary<int, Customer> customers = new Dictionary<int, Customer>(); 

            //Create customers
            Customer jane = new Customer { ID = 0, Name = "Jane" };
            Customer joe = new Customer { ID = 1, Name = "Joe" }; 

            //Add to dictionary 
            customers.Add(jane.ID, jane);
            customers[joe.ID] = joe;

            //iterate through customers.keys also known as ID's
            foreach (int key in customers.Keys){
                //The Customer is saved so the value is a customer 
                //therefore use the name property's getter
                Console.WriteLine(customers[key].Name);
            }

            //Instant initilisation
            Dictionary<int, Customer> customers2 = new Dictionary<int, Customer>
            {
                [0] = new Customer { ID = 0, Name = "Chris" },
                [1] = new Customer { ID = 1, Name = "Alex" }
            };

        }

    }
}
