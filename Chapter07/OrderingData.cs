using System;
using System.Linq;
namespace Chapter07
{
    public class OrderingData
    {
        public OrderingData()
        {
        }

        public void OrderMyData(){
            var customers5 =
            from cust5 in Company.Customers
                                 orderby cust5.Name descending
                                 select cust5;
            
            foreach (var cust5 in customers5)
            {
                Console.WriteLine(cust5.Name);
            }

            var customers6 =
            from cust6 in Company.Customers
                                 orderby cust6.Name ascending
                                 select cust6;

            foreach (var cust6 in customers6)
            {
                Console.WriteLine(cust6.Name);
            }


        }
    }
}
