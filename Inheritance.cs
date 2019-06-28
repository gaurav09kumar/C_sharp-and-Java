using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Person
    {
        string name;
        int age;
        string gender;
        public void setPersonDetails(string name,int age, string gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }
        public void getPersonalDetails()
        {
            Console.WriteLine("name : " + name);
            Console.WriteLine("age : " + age);
            Console.WriteLine("gender : " + gender);
        }
    }

    class Employee : Person
    {
        int id;
        float salary;
        public void setEmployeeDetails(int id,string name,int age,string gender, float salary)
        {
            setPersonDetails(name, age, gender);
                this.id = id;
                this.salary = salary;
            
        }
        public void getEmployeeDetails()
        {
            getPersonalDetails();
            Console.WriteLine("id : "+ id);
            Console.WriteLine("salary : " + salary);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1.setEmployeeDetails(100,"Rahul",45,"Male",7000.7f);
            e1.getEmployeeDetails();
            Console.WriteLine(e1.GetHashCode());
            Console.ReadKey();
        }
    }
}
