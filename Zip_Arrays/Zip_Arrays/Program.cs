using System;
using System.Collections.Generic;
using System.Linq;

namespace Zip_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var list1 = new List<int> { 1, 5, 2 };
            var list2 = new List<int> { 3, 6, 4 };

            var list3 = new List<int>();
            //todo: look every number in list1, add this item to list3, and same indext to list2
            int i = 0;

            for (i = 0; i < list1.Count(); i++)
            {
                list3.Add(list1[i]);
                list3.Add(list2[i]);
            }


            Console.WriteLine("The list zipped is: ");
            foreach (int number in list3)
            {
                Console.Write( number + ",");
            }
            Console.ReadKey();

        }

    }
}
