using System;
using System.Linq;

namespace Chapter07
{
    public class FilteringData
    {
        public FilteringData()
        {
        }

        public void FilterMyData(){
            // Again another anonymous variable
            // Where clause must evaluate a boolean
            var customers4 =
            from cust4 in Company.Customers
            where cust4.Name.Length > 3 && !cust4.Name.StartsWith("G")
                                 select cust4;
            foreach (var cust4 in customers4)
                Console.WriteLine(cust4.Name);

            //Same principle
            var customers5 =
            from cust5 in Company.Customers
            where cust5.Name.Length <= 3
            select cust5;
            foreach (var cust5 in customers5)
                Console.WriteLine(cust5.Name);


        }
    }
}
