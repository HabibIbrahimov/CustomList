using System;
using System.Collections.Generic;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {

            


            MyList<string> list = new MyList<string>();
            list.Add("Habib1");
            list.Add("Habib2");
            MyList<int> list2 = new MyList<int>();
            list2.Add(1);
            list2.Add(2);
            list2.Add(3);
            Console.WriteLine(list.Contains("Habib1"));
        }
    }
}
