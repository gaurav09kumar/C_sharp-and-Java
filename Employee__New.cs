using System;

namespace ConsoleApp15
{
    public class Employee
    {
        private static int custId = 101;
        private string custStatus = "Active";
        private string name = "John";
        private int balance = 5000;
        private string city = "Mumbai";
        private int count = 0;
        public int Count
        {
            get
            {
                return count;
            }
            set
            {
                count = value;
            }
        }
        public int CustID
        {
            get
            {
                return custId;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string CustStatus
        {
            get
            {
                return custStatus;
            }
            set
            {
                custStatus = value;
            }
        }
        public int Balance
        {
            get
            {
                return balance;
            }
            set
            {
                balance = value;
            }
        }
        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }
    }
    class Program
    {
        enum cities
        {
            Mumbai,
            Hyderabad,
            Delhi,
            Chennai,
            Bangalore
        }
        static void Main(string[] args)
        {
            
            Employee e = new Employee();
            Operations();
            void Operations()
            {

                Console.WriteLine("------------------");
                Console.WriteLine("Choose one option");
                Console.WriteLine("1. Check Status and details\n2.Check Balance\n3.Modify Name\n4.Balance Withdrawal\n5.Modify City\n6.Exit the application");
                int intTemp = Convert.ToInt32(Console.ReadLine());
                switch (intTemp)
                {
                    case 1:
                        Console.WriteLine($"Your status is : {e.CustStatus} \nName is : {e.Name} \nId is : {e.CustID}");
                        Operations();
                        break;
                    case 2:
                        Console.WriteLine($"Your balance is : {e.Balance}");
                        Operations();
                        break;
                    case 3:
                        if (e.CustStatus.Equals("Active"))
                        {
                            Console.WriteLine("Enter new Name");
                            string s = Console.ReadLine();
                            e.Name = s;
                            Console.WriteLine($"your new name is : {e.Name}");
                            Operations();
                        }
                        else
                        {
                            Console.WriteLine("You cannot change the name as ur status is InActive");
                            Operations();
                        }
                        break;
                    case 4:
                        if (e.Balance == 0)
                        {
                            Console.WriteLine("Your account has 0 balance");
                            Operations();
                        }
                        else if (e.Balance > 0)
                        {
                            Console.WriteLine("enter the withdraw amount");
                            int a = Convert.ToInt32(Console.ReadLine());
                            if (a <= (e.Balance))
                            {
                                e.Balance = e.Balance - a;
                                Console.WriteLine($"The withdraw amount is: {a} and new balance is {e.Balance}");
                                Operations();
                            }
                            else
                            {
                                Console.WriteLine("The entered amount is greater than available balance");
                                Operations();
                            }
                        }
                        break;
                    case 5:
                        if (e.Count < 5)
                        {
                            Read();
                            void Read()
                            {
                                int i = 0;
                                Console.WriteLine($"You current city is {e.City}");
                                var namesCount = Enum.GetNames(typeof(cities)).Length;
                                foreach (string str in Enum.GetNames(typeof(cities)))
                                {
                                    i = i + 1;
                                    Console.WriteLine($"{i}: {str}");
                                }
                                int s = Convert.ToInt32(Console.ReadLine());
                                if (s>0 && s<=namesCount) { 
                                e.City = Enum.GetName(typeof(cities),(s-1));
                                e.Count = e.Count + 1;
                                Console.WriteLine($"New city is : {e.City}\nYou have changed the city : {e.Count} times");
                                Operations();
                                }
                                else
                                {
                                    Console.WriteLine("Please enter a proper city number");
                                    Read();
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("You have already changed the city 5 times");
                            Operations();
                        }
                        break;
                    case 6:
                        Console.WriteLine("Successfully exited the application");
                        break;
                    default:
                        Console.WriteLine("Enter the option between 1 and 6");
                        Operations();
                        break;
                }

            }
        }
    }
}
