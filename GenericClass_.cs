using System;
using System.Collections;
using System.Collections.Generic;
namespace ConsoleApp17
{
    class Demo<T>
    {
        public void Addition( T a, T b)
        {
            dynamic val = a;
            dynamic val2 = b;
            Console.WriteLine(val + val2);
        }
    }
    class Program
    {
        //GenericDemo
        
       
        static void Main()
        {
            List<int> l1 = new List<int>();


            Demo<int> p = new Demo<int>();


            foreach (int number in l1)
            {
                Console.WriteLine(number);
            }
            p.Addition(10,4);


        }
    }
}
