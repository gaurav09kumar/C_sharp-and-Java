using System;
using System.Collections;
using System.Collections.Generic;
namespace ConsoleApp17
{
    class First
    {
        public void display()
        {
            Console.WriteLine("First method");
        }
    }
    //inheritance
    class Second : First
    {
        //override
        public void display()
        {
            Console.WriteLine("Second method");
        }
        public int sub(int x, int y)
        {
            return x - y;
        }
        //overload
        public double sub(double x, double y)
        {
            return x - y;
        }
    }
    //encapsulation
    class EncapDemo
    {
        private string s;
        public void setName(string newName)
        {
            s = newName;
        }
        public void getName()
        {
            Console.WriteLine(s);
        }
    }

    //abstraction
    abstract class Car
    {
        public abstract void run();
    }
    class Hyundai: Car
    {
        //implementation of abstract method
        public override void run()
        {
            Console.WriteLine("Hyundai car");
        }
    }
    class Program
    {
        static void Main(string [] args)
        {
            First f = new First();
            f.display();
            Second s = new Second();
            s.display();
            Console.WriteLine(s.sub(4,8));
            Console.WriteLine(s.sub(8, 10)); //polymorphism
            EncapDemo e = new EncapDemo();
            e.setName("Dell");
            e.getName();
            Car c = new Hyundai();
            c.run();

        }
    }
}
