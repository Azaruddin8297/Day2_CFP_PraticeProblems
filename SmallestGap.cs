using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2PraticeProblems
{
    public class SmallestGap
    {
        public static void call()
        {
            int[] numbers1 = { 18, 23, 7, 5, 8, 9, 11};
            int[] numbers2 = { 200, 300, 250, 151, 162 };

            int small = smallestGap(numbers1);
            Console.WriteLine("smallest Gap Between Numbers are :"+small);

            int small1 = smallestGap(numbers2);
            Console.WriteLine("smallest Gap Between Numbers are :" + small1);


        }

        public static int smallestGap(int[] numbers)
        {
            Array.Sort(numbers);
            int smallestGap = int.MaxValue;
            for(int i  = 1; i < numbers.Length; i++)
            {
                int currentGap = numbers[i] - numbers[i-1];
                if(currentGap > 0)
                {
                    if (currentGap < smallestGap)
                    {
                        smallestGap = currentGap;
                    }
                }
             
            }
            return smallestGap;
        }
    }
}
