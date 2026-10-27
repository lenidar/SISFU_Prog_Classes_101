using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISFU_Prog_Classes_101
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Class1 c1 = new Class1();
            //Class1 c2 = new Class1();

            //c1.Method1();
            //c2.Method1();

            //c1.Method2(12);

            //c1.Method1();
            //c2.Method1();

            //c1.Method3();
            //c2.Method3();

            //c2.Method4();

            //c1.Method3();
            //c2.Method3();

            //Person p1 = new Person();
            //p1.name = "Test name";
            //p1.gender = "Test gender";
            //p1.age = 18;

            //p1.Introduce();

            //Person p2 = new Person();
            //p2.name = "John Doe";
            //p2.gender = "Male";
            //p2.age = 12;

            //p2.Introduce();

            Person[] ps = new Person[30];

            for(int x = 0; x <  ps.Length; x++)
            {
                ps[x] = new Person($"Name {x + 1}", $"Gender {x}", x);
                //ps[x].name = $"Person {x+1}";
                //ps[x].Introduce();
            }
        }
    }
}
