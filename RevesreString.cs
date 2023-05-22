using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2PraticeProblems
{
    public class RevesreString
    {
        public static void Call()
        {
            Console.WriteLine("Please Enter the Sentence");
            string Sentence = Console.ReadLine();

            string[] Words = Sentence.Split(' ');

            for(int i = Words.Length-1 ; i >=0 ; i--) 
            {
                Console.Write(Words[i]+" ");
            }
        }
    }
}
