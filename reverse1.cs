using System;
using System.Collections;
using System.Collections.Generic;
namespace ConsoleApp17
{
    class ArrayListDemo
    {
        static void Main(string [] args) { 
            ArrayList a1 = new ArrayList();
            a1.Add("red");
            a1.Add("blue");
            a1.Add("white");
            a1.Add("green");
            a1.Add("yellow");
            foreach (var values in a1)
            {
                Console.WriteLine(values);
            }
            Console.WriteLine();
            /*string s = a1[1].ToString();
            a1[1] = a1[2];
            a1[2] = s;*/
            a1.Reverse(1,2);

            a1[3] = "orange";
            Console.WriteLine();
            foreach (var values in a1)
            {
                Console.WriteLine(values);
            }
        }
    }
}
