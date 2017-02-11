using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Program
    {
        struct Student
        {
            public string firstName;
            public string lastName;
            public int gpa;

            public Student(string _firstName, string _lastName, int _gpa) //constructor with parameters of type string and integer
            {
                firstName = _firstName; // assign parameters to variables
                lastName = _lastName;
                gpa = _gpa;
            }

            public override string ToString() //method
            {
                return firstName + " " + lastName + ", gpa " + gpa;
            }
        }

        static void Main(string[] args)
        {
            Student p = new Student("Sabina", "Akpayeva", 4);
            Console.WriteLine(p);
            Console.ReadKey();
        }
    }
}
