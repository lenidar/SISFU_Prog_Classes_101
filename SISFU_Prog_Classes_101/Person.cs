using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISFU_Prog_Classes_101
{
    internal class Person
    {
        public string name = "Default Name";
        public string gender = "Default Gender";
        public int age = -99;

        public Person(string Name, string Gender, int Age)
        {
            //Console.WriteLine("Hello! I am the constructor of Person!");
            name = Name;
            gender = Gender;
            age = Age;

            Introduce();
        }

        public void Introduce()
        {
            Console.WriteLine($"My name is {name}. I am a {age} year old {gender}");
        }
    }
}
