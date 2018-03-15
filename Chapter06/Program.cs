using System;

namespace Chapter06
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Lists:");
            ListExample lists = new ListExample();
            lists.myListMethod();

            Console.WriteLine();

            Console.WriteLine("Dictionaries:");
            DictionaryExample dic = new DictionaryExample();
            dic.myDictionaryMethod();

            Console.WriteLine();
            Console.WriteLine("Generic Class with String:");
            MyGenericClass<string> stringclass = new MyGenericClass<string>();
            stringclass.Item = "Hello";
            Console.WriteLine(stringclass.Item);

            Console.WriteLine();
            Console.WriteLine("Generic Class with int:");
            MyGenericClass<int> intclass = new MyGenericClass<int>();
            intclass.Item = 3;
            Console.WriteLine($"Is {intclass.Item} > 4 : {intclass.Item > 4}");

            Console.WriteLine();
            Console.WriteLine("ReportCreations:");
            var rpt2 = ReportFactory.Create<CustomerReport>();
            Console.WriteLine($"{rpt2} : {rpt2.Date}");
        }
    }
}
