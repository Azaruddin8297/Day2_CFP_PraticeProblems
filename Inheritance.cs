using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2PraticeProblems
{
    public class Inheritance
    {
         int variable1;
         int variable2;

        public void values(int var1, int var2)
        {
            variable1 = var1;
            variable2 = var2;
        }

    }
    class DerivedClass : Inheritance
    {
 
        public int SumVariables()
        {
            return variable1 + variable2;
        }
    }
}
