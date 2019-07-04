using System;
using System.Collections;
using System.Collections.Generic;
namespace ConsoleApp17
{
    class Program
    {
        static void Main()
        {
            Hashtable ht = new Hashtable();

            ht.Add("Eid","101") ;
            ht.Add("Ename", "John");
            ht.Add("Esalary", 50000);

            elements();
            void elements() {
                foreach (var key in ht.Keys)
                {
                    Console.WriteLine(key + ":" + ht[key]);
                }
            }
            
            Console.WriteLine(ht["Eid"].GetHashCode());
            Console.WriteLine(ht.Count);
            ht.Remove("Esalary");
            Console.WriteLine(ht.Count);
            elements();
            Console.WriteLine(ht["Eid"]);
            int a = Convert.ToInt32(ht["Eid"]);
            Console.WriteLine(a);
            // HashTable is a key/value pair
            //It can be accessed only by the key
            //It uses hashing algorithm to sort the list
            Console.WriteLine(ht[0]); //doesnt work
            
        }
    }
}
