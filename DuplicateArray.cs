using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2PraticeProblems
{
    public class DuplicateArray
    {
        public static void call()
        {
            object[] originalArray = { 25, "Anna", false, 25, "4/15/2021 12:10:51 PM", 112.22, "Anna", false };

            Console.WriteLine("Original array elements:");
            Print(originalArray);


            Console.WriteLine("After Removing Duplicate values");
            RemoveDuplicate(originalArray);


        }

        public static void RemoveDuplicate(object[] Array) 
        {
            HashSet<object> list = new HashSet<object>();
            foreach (object obj in Array)
            {
                list.Add(obj);
            }
            foreach (object obj in list)
            {
                Console.WriteLine(obj);
            }
        }

        public static void Print(object[] obj)
        {
            foreach (object o in obj)
            {
                Console.WriteLine(o);
            }
        }
    }
}
