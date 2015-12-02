using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program5
{
    class Program
    {
        static void Main(string[] args)
        {
            string Answer = "yes";
            while (Answer.StartsWith("y"))
            {
                Cource C1 = new Cource();
                C1.name = Question.AskForString("What is the cource name?");
                C1.CRN = Question.AskForString("What is the cource number?");
                int count = Question.AskForInt("How many students?");
                C1.Students = new Student[count];

                for (int i = 0; i < count; i++)
                {
                    C1.Students[i] = new Student();
                    C1.Students[i].Name = Question.AskForString("Name");
                    C1.Students[i].SNumber = Question.AskForInt("Number");
                }

                foreach (Student item in C1.Students)
                {
                    item.Print();
                }

                Answer = Question.AskForString("Do you need to start over?");
            }

            Console.ReadKey();
        }
    }
}