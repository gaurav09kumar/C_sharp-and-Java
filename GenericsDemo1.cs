using System;
using System.Collections;
using System.Collections.Generic;
namespace ConsoleApp17
{
    class Program
    {
        //GenericDemo

            public int Add(int a, int b)
        {
            return(a+b);
        }
        public int Sub(int a, int b)
        {
            return (a - b);
        }
        public int Mul(int a, int b)
        {
            return (a * b);
        }
        static void Main()
        {
            List<int> l1 = new List<int>();


            Program p = new Program();
            
            l1.Add(p.Add(10, 20));
            l1.Add(p.Sub(10, 20));
            l1.Add(p.Mul(10, 20));
            

            foreach(int number in l1)
            {
                Console.WriteLine(number);
            }
        }
    }
}
