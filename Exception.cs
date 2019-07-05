using System;

namespace ConsoleApp18
{
    public class DivideByOddNumberException : ApplicationException
    {
        public override string Message
        {
            get
            {
                return "attempted to divide by odd number";
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter first number");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter second number");
                int x = Convert.ToInt32(Console.ReadLine());

                int z = x /a;
                Console.WriteLine("result is:"+z);

                if (a%x >0)
                {
                    throw new DivideByOddNumberException();
                }
            }
            catch (DivideByZeroException y)
            {
                Console.WriteLine(y.Message);
            }
            catch (ArithmeticException y)
            {
                Console.WriteLine(y.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
