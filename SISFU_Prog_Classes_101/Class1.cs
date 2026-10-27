using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISFU_Prog_Classes_101
{
    internal class Class1
    {
        private int x = 5;

        public void Method1()
        {
            Console.WriteLine($"I am holding the value {x}");
        }

        public void Method2(int y)
        {
            x = y;
        }

        public void Method3()
        {
            Console.WriteLine($"The value of x is {Class2.x}");
        }

        public void Method4()
        {
            Class2.x = 7;
        }
    }
}
