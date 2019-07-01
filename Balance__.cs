using System;

namespace ConsoleApp12
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
                        System.Console.WriteLine($"Your status is : {e.CustStatus} \nName is : {e.Name} \nId is : {e.CustID}");
                        Operations();
                        break;
                    case 2:
                        System.Console.WriteLine($"Your balance is : {e.Balance}");
                        Operations();
                        break;
                    case 3:
                        if (e.CustStatus.Equals("Active"))
                        {
                            System.Console.WriteLine("Enter new Name");
                            string s = Console.ReadLine();
                            e.Name = s;
                            System.Console.WriteLine($"your new name is : {e.Name}");
                            Operations();
                        }
                        else
                        {
                            System.Console.WriteLine("You cannot change the name as ur status is InActive");
                            Operations();
                        }
                        break;
                    case 4:
                        if (e.Balance == 0)
                        {
                            System.Console.WriteLine("Your account has 0 balance");
                            Operations();
                        }
                        else if (e.Balance > 0)
                        {
                            System.Console.WriteLine("enter the withdraw amount");
                            int a = Convert.ToInt32(Console.ReadLine());
                            if (a <= (e.Balance))
                            {
                                e.Balance = e.Balance - a;
                                System.Console.WriteLine($"The withdraw amount is: {a} and new balance is {e.Balance}");
                                Operations();
                            }
                            else
                            {
                                System.Console.WriteLine("The entered amount is greater than available balance");
                                Operations();
                            }
                        }
                        break;
                    case 5:
                        if (e.Count < 5)
                        {
                            string s = "";
                            Read();
                            void Read()
                            {
                                System.Console.WriteLine($"You current city is {e.City}");
                                System.Console.WriteLine("Enter new city");
                                s = System.Console.ReadLine();
                                check();
                            }
                            void check()
                            {
                                if (s.Equals(e.City))
                                {
                                    System.Console.WriteLine("Your previous city and new city are same");
                                    Read();

                                }
                                else
                                {
                                    e.City = s;
                                    e.Count = e.Count + 1;
                                    System.Console.WriteLine($"New city is : {e.City}\nYou have changed the city : {e.Count} times");
                                    Operations();
                                }
                            }

                        }
                        else
                        {
                            System.Console.WriteLine("You have already changed the city 5 times");
                            Operations();
                        }
                        break;
                    case 6:
                        System.Console.WriteLine("Successfully exited the application");
                        break;
                    default:
                        System.Console.WriteLine("Enter the option between 1 and 6");
                        Operations();
                        break;
                }

            }
        }

    }
}
