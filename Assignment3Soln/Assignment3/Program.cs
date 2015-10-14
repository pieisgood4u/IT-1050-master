using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Instructor John = new Instructor("John", "Stamos", "English");
            Instructor Mike = new Instructor("Mike", "Rowe", "Math");

            Student Jane = new Student("Jane", "Doe", John);
            Student Joe = new Student("Joe", "Cool", John);
            Student Melissa = new Student("Melissa", "Cannowitz", Mike);
            Student Matt = new Student("Matt", "Carpenter", Mike);

            John.SetStudentGrade(Jane, 95);
            John.SetStudentGrade(Joe, 85);
            Mike.SetStudentGrade(Melissa, 90);

            Mike.SetStudentGrade(Matt, 92);

            Console.WriteLine(Jane.PrintStudentInfo());
            Console.WriteLine(Joe.PrintStudentInfo());
            Console.WriteLine(Melissa.PrintStudentInfo());
            Console.WriteLine(Matt.PrintStudentInfo());

            Console.ReadKey();
        }
    }
}
