using System;

namespace ConsoleApp7
{
    class Person
    {
        int ID;
        string name;
        int mobile;
        string address;
        string gender;
        public void setPersonDetails(int id, string n, int m, string a, string g)
        {
            this.ID = id;
            this.name = n;
            this.mobile = m;
            this.address = a;
            this.gender = g;
        }
        public void getPersonDetails()
        {
            Console.WriteLine("ID : "+ ID);
            Console.WriteLine("name : " + name);
            Console.WriteLine("mobile : " + mobile);
            Console.WriteLine("address : " + address);
            Console.WriteLine("gender : " + gender);
        }
    }
    class Student : Person
    {
        int standard;
        string section;

        public void setStudentDetails(int id, string n, int m, string a, string g,int s, string sec)
        {
            setPersonDetails(id, n, m, a, g);
            this.standard = s;
            this.section = sec;
        }
        public void getStudentDetails()
        {
            Console.WriteLine("---------------");
            Console.WriteLine("Student details");
            getPersonDetails();
            Console.WriteLine(standard+ " : standard");
            Console.WriteLine(section + " : section");
        }
    }
    class Teacher : Person
    {
        int experience;
        public void setTeacherDetails(int id, string n, int m, string a, string g,int e)
        {
            setPersonDetails(id, n, m, a, g);
            this.experience = e;
        }
        public void getTeacherDetails()
        {
            Console.WriteLine("---------------");
            Console.WriteLine("Teacher details");
            getPersonDetails();
            Console.WriteLine("Experience is " +experience);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.setStudentDetails(101,"raju",1234567890,"Hyderabad", "male", 10, "A");
            s1.getStudentDetails();
            Teacher t1 = new Teacher();
            t1.setTeacherDetails(111,"Rose",0987654321,"Gandhinagar","female",5);
            t1.getTeacherDetails();
            Console.ReadKey();
        }
    }
}
