using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("harshi");
            string stringVar = "demo";
            string stringVar2 = "demo2";
            int intVar = 100;
            float floatVar = 12.44456f;
            char charVar = 'f';
            bool boolVar = true;
            Console.WriteLine(stringVar);
            Console.WriteLine(intVar);
            Console.WriteLine(floatVar);
            Console.WriteLine(charVar);
            Console.WriteLine("output is {1} {0}",stringVar,intVar);
            Console.WriteLine("{0} {1}",stringVar,stringVar2);
            Console.ReadKey();
            
        }
    }
}
