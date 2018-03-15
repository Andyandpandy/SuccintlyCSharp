using System;
using System.Collections.Generic;

namespace Chapter06
{   
    //Random class for the example
    public class Company
    {
        public string Name { get; set; }
    }
    public class ListExample
    {
        public ListExample()
        {
        }

        public void myListMethod(){
            //List of strings through generic variable
            List<string> names = new List<string>();
            //Add Joe
            names.Add("Joe");
            //Insert car move joe to index 1
            names.Insert(0, "Car");
            //Add Jill to index 2
            names.Add("Jill");
            //Change car to Building
            names[0] = "Building";
            //Remove building
            names.RemoveAt(0);
            //Print out Joe on index 0
            Console.WriteLine($"First name: {names[0]}");
            //Create a List of Companies instantly
            IList<Company> companies = new List<Company>
        {
            new Company { Name = "Syncfusion" },
            new Company { Name = "Microsoft" },
            new Company { Name = "Acme" }
};
            //Use the ForEach from the List class instead of the IList interface
            //As changes the companies connected to iList and says its now List
            List<Company> companyList = companies as List<Company>;
            //The foreach goes through each iteration and saves the current 
            //iteration variable from the list in cmp
            companyList.ForEach(cmp => Console.WriteLine(cmp.Name));
        }
    }
}
