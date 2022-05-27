using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Петров";
            string surname = "Петр";
            string temp;
            Console.WriteLine(name + " "+ surname);
            temp = name;
            name = surname;
            surname = temp;
            temp = null;
            Console.WriteLine(name + " " + surname);
        }
    }
}
