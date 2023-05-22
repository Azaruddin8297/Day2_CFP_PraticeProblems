using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2PraticeProblems
{
    public class FileExists
    {
        public static void Call()
        {
            string path = "D:\\CFP\\Day2PraticeProblems\\Day2PraticeProblems\\azar1.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("File Exists");
            }
            else 
            {
                try
                {
                    using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
                    {
                        Console.WriteLine("New File Created");
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
          
        }
    }
}
