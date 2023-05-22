using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2PraticeProblems
{
    public class SumofArray
    {
        public static void Sum()
        {
            Console.WriteLine("Please Enter Size of the Array");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] Array = new int[size];
            for(int i = 0; i < size; i++)
            {
                Console.WriteLine("Please Enter the {0} th Elemnet", i);
                Array[i] = Convert.ToInt32(Console.ReadLine());
            }
            int result = 0;
            for(int i = 0; i < size;i++)
            {
                result = result + Array[i];
            }
            Console.WriteLine("Total of all Elements are {0}", result);

        }
    }
}
