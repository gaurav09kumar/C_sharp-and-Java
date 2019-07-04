using System;
using System.Collections;
using System.Collections.Generic;
namespace ConsoleApp17
{
   class demo
    {
        static void Main()
        {
            //here dictionary is accepting int and any values here
            Dictionary<int, object> dt = new Dictionary<int, object>();
            dt.Add(1,"ABC");
            dt.Add(2, 300);
            foreach(var i in dt){
                Console.WriteLine(i);
            }
            Console.WriteLine(dt.GetHashCode());
        }
    }
}
