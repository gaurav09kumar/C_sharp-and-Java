using System;
using System.Collections;
using System.Collections.Generic;
namespace ConsoleApp17
{
    class Customer
    {
        //properties of customer class
        public int CustId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public int Balance { get; set; }

    }
    class CustomerDerived
    {
        static void Main()
        {
            //Create a list of customers of Customer type
            List<Customer> customers = new List<Customer>();
            
            // There are 3 customers
            //We can call customer defined properties here and initialize values to them
            Customer c1 = new Customer { CustId = 10, Name = "John", City = "Hyderabad", Balance = 25000 };

            Customer c2 = new Customer { CustId = 20, Name = "Mathew", City = "Delhi", Balance = 4000 };

            Customer c3 = new Customer { CustId = 30, Name = "Dolphine", City = "Mumbai", Balance = 40080 };
            
            // now we want to add these customers to the customers list
            customers.Add(c1);
            customers.Add(c2);
            customers.Add(c3);

            foreach (var cust in customers)
            {
                Console.WriteLine(cust.CustId+ " " + cust.Name + " " + cust.Balance+" "+ cust.City);
               
            }
        }
    }
}
