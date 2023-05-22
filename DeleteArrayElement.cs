using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2PraticeProblems
{
    public class DeleteArrayElement
    {
        public static void Call()
        {
            Console.WriteLine("Enter the Size of the Array");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] Array = new int[size];
            Console.WriteLine("Enter the {0} Elements of the Array in order",size);
            for(int i = 0; i < size; i++)
            {
                Console.Write("element - {0} : ", i);
                Array[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach(int i in Array)
            {
                Console.WriteLine("Entered Elements are :"+ i);
            }
          
            Console.WriteLine("Enter the position to delete");
            int position = Convert.ToInt32(Console.ReadLine());

            if(position < 1 || position > size) 
            {
                Console.WriteLine("Invalid Position");
            }
            else
            {
               int[] newArray = DeleteElement(Array,position);
                foreach (int i in newArray)
                {
                    Console.WriteLine("aftter deletion.. Elements are :" + i);
                }
            }
        }
        public static int[] DeleteElement(int[] array , int position)
        {
            int newsize = array.Length-1;
            int[] newArray = new int[newsize];

            for(int i = 0; i < position-1 ; i++)
            {
                newArray[i] = array[i];
            }
            for(int i = position;i<array.Length;i++)
            {
                newArray[i - 1] = array[i];
            }
            return newArray;
        }
    }
}
