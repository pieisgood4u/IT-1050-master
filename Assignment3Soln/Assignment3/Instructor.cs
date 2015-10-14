using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Instructor
    {
        private string Name;
        private string courseName;

        public Instructor(string firstName, string lastName, string course)
        {
            this.Name = firstName + " " + lastName;
            this.courseName = course;
        }

        public void SetStudentGrade(Student student, int grade)
        {
            student.SetGrade(grade);
        }

        public string PrintInfo()
        {
            return Name + " Course: " + courseName;
        }
    }
}
