using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2PraticeProblems
{
    public class FindSecondLargest
    {
        public static void Call()
        {
            Console.WriteLine("Enter the Size of the Array");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] Array = new int[size];
            Console.WriteLine("Enter the {0} Elements of the Array in order", size);
            for (int i = 0; i < size; i++)
            {
                Console.Write("element - {0} : ", i);
                Array[i] = Convert.ToInt32(Console.ReadLine());
            }
            //foreach (int i in Array)
            //{
            //    Console.WriteLine("Entered Elements are :" + i);
            //}

            int second = SecondLargestNumber(Array);
            Console.WriteLine("Second Largest Number is " + second);

        }

        public static int SecondLargestNumber(int[] number)
        {
            if (number.Length < 2)
            {
                throw new ArgumentException("Array must have at least two elements.");
            }
            int largest = int.MinValue;
            int secondLargest = int.MinValue;
            for(int i = 0; i < number.Length;i++)
            {
                if (number[i] > largest)
                {
                    secondLargest = largest;
                    largest = number[i];
                }
                else if (number[i]>secondLargest && number[i]<largest) 
                {
                    secondLargest= number[i];
                }
            }
            return secondLargest;
        }
        }
    }
