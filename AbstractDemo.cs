using System;

namespace ConsoleApp13
{
    public abstract class Iphone{
        public void common(string version)
        {
            string os = "Mac OS";
            string Keypad = "Iphone Keypad";
            Console.WriteLine($"Iphone Version is:{version}\nOS is : {os}\nKeypad is : {Keypad} ");
        }
        public abstract void features(string s, string c, string b, int p, string ROM,string RAM); 
    }
    class Demo : Iphone
    {
        public override void features(string s, string c, string b, int p, string ROM, string RAM)
        {
            Console.WriteLine($"Screen size is : {s}\nCamera is: {c}\nBattery is: {b}\nPrice is: {p}\nMemory is: {ROM}\nRAM is: {RAM}");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Demo d1 = new Demo();
            d1.common("5");
            d1.features("5 inches","16 MP", "1250 MAh", 40000 , "128 GB", "4 GB");
            d1.common("6");
            d1.features("6 inches", "32 MP", "2250 MAh", 60000, "256 GB", "6 GB");

        }
    }
}
