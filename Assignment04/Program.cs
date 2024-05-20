using System.ComponentModel;
using System.Security.Cryptography;

namespace Assignment04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.AcceptDetails();
            student.PrintDetails();

            Console.WriteLine("Press Any Key to end");
            Console.ReadKey();
           
        }
    }

    public class Student
    {

        private string _Name;
        private bool _Gender;
        private int _Age;
        private int _Std;
        private char _Div;
        private double _Marks;

        public Student() { }
        public Student(string name, bool gender,int age,int std,char div,double marks)
        {
            _Name = name;
            _Gender = gender;
            _Age = age;
            _Std = std;
            _Div = div;
            _Marks = marks;
        }

        public void AcceptDetails()
        {
            Console.WriteLine("Enter Name");
            _Name = Console.ReadLine();
            Console.WriteLine("Enter Gender True or false");
            _Gender = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Enter Age");
            _Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter std");
            _Std = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter div");
            _Div = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter Marks");
            _Marks = Convert.ToDouble(Console.ReadLine());
        }

        public void PrintDetails()
        {
            Console.WriteLine("Name -" + _Name);
            Console.WriteLine("Gender -"+ _Gender);
            Console.WriteLine("Age -"+ _Age);
            Console.WriteLine("STD -" + _Std);
            Console.WriteLine("DIV -"+ _Div);
            Console.WriteLine("MARKS -"+ _Marks);
        }
       
        public double Marks
        {
            get { return _Marks; }
            set { _Marks = value; }
        }


        public char Div
        {
            get { return _Div; }
            set { _Div = value; }
        }


        public int Std
        {
            get { return _Std; }
            set { _Std = value; }
        }


        public int MyProperty
        {
            get { return _Age; }
            set { _Age = value; }
        }


        public bool Gender
        {
            get { return _Gender; }
            set { _Gender = value; }
        }


        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }


    }
}
