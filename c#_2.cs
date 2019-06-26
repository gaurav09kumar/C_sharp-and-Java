namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Welcome to the calculator application");
            int number1 = 0;
            int number2 = 0;
            string val;
            Console.WriteLine("Enter the first number");
            val= Console.ReadLine();
            number1 = Convert.ToInt32(val);
            
            Console.WriteLine("Enter the second number");
            val = Console.ReadLine();
            number2 = Convert.ToInt32(val);
            Console.WriteLine("Addition result of " + number1 + " and " + number2 + " is " + (number1 + number2));
            Console.WriteLine("Subtraction result of " + number1 + " and " + number2 + " is " + (number1 - number2));
            Console.WriteLine("Multiplication result of " + number1 + " and " + number2 + " is " + (number1 * number2));
            Console.WriteLine("Division result of " + number1 + " and " + number2 + " is " + (number1 / number2));
            Console.ReadKey();
        }
    }
}
