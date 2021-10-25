using System;
using System.Collections.Generic;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {

            //MyList<int> grades = new MyList<int>();
            //grades[0] = 100;
            //grades[1] = 25;
            //grades[2] = 34;
            //grades[3] = 42;
            //grades[4] = 12;

            //for (int i = 0; i < grades.Length; i++)
            //    Console.WriteLine(grades[i]);



            MyList<int> intList = new MyList<int>();
            intList.Add(10);
            intList.Add(20);
            

            //int[] n = new int[] { 1, 2, 3 };



            //foreach (var item in n)
            //{
            //    Console.WriteLine(item);
            //}

        }
    }
}
