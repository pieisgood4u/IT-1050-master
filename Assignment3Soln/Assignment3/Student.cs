using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Student
    {
        private string Name;
        private int Grade;
        private Instructor Teacher;

        public Student(string firstName, string lastName, Instructor teacher)
        {
            this.Name = firstName + " " + lastName;
            this.Teacher = teacher;
            this.Grade = 0;
        }

        public void SetGrade(int newGrade)
        {
            this.Grade = newGrade;
        }

        public string PrintStudentInfo()
        {
            return "Name: " + Name + " Grade: " + Grade + " Teacher's info: " + this.Teacher.PrintInfo();
        }
    }
}
