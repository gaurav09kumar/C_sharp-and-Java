using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Math_Operation
    {
        Math_Operation(int i, int j)
        {
            Console.WriteLine("sum is" + (i + j));
            Console.WriteLine("sub is" + (i - j));
            Console.WriteLine("mul is" + (i * j));
            Console.WriteLine("div is" + (i / j));
        }
        static Math_Operation()
        {
            Console.WriteLine("static");
        }



        static void Main(string[] args)
        {
            Math_Operation m = new Math_Operation(10, 5);
            

            Console.ReadKey();

        }
    }
}

