using System;

namespace gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aray1
            double [] numbers= new double[4];
            numbers[0]=15.1;
            numbers[1]=78.1;
            numbers[2]=99.1;
            numbers[3]=10.1;
            var result=0.0;
            foreach(var number in numbers){
                result+=number;
            }
            System.Console.WriteLine(result);
            
            //Array2
            var numbers1= new [] {1.1,2.2,3.3,4.4};
            var result1=0.0;
             foreach(var number in numbers1){
                result1+=number;
            }
            System.Console.WriteLine(result1);
        }
    }
}
