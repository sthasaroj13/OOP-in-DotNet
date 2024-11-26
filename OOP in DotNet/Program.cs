using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationCSharp.OOP
{
    internal class Student
    {
        //declearing variables
        private int rollNo;
        private string name;
        private int age;

        //accept bhanni method banako 
        public void Accept(int rollNo, string name, int age)
        {
            this.rollNo = rollNo;
            this.name = name;
            this.age = age;

        }
        // tyo accept  method lai display garauni display method banako 
        public void Display()
        {
            Console.WriteLine(" Rollno is {0} and name is {1} and age is {2}", rollNo, name, age);
        }
        //main method banako 
        public static void Main(string[] args)
        {
            //object banako
            Student student = new Student();
            student.Accept(2011, "saroj shrestha", 24);
            student.Display();
            Student student2 = new Student();
            student2.Accept(2012, "Bodhan Dhakal", 25);
            student2.Display();
        }

    }
}
