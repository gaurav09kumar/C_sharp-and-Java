using System;
using System.Collections;
using System.Collections.Generic;
namespace ConsoleApp17
{
    class Program
    {
        //GenericDemo

            public bool Compare1(object a, object b)
        {
            if (a.Equals(b))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
            public Boolean Compare(int a , int b)
        {
            if (a == b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main()
        {
         Program p = new Program();
         foreach(int number in l1)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine(p.Compare(10,10));
            Console.WriteLine(p.Compare1(1, 10));
        }
    }
}
