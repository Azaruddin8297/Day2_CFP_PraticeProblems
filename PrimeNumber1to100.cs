using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2PraticeProblems
{
    public class PrimeNumber1to100
    {
        public static void call()
        {
           
            for(int i = 2 ; i <= 100; i++)
            {
                int count = 0;
                for (int j = 2 ; j <= i; j++)
                {
                    if(i%j == 0)
                    {
                        count++;
                    }
                   
                }
                if (count == 1)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
