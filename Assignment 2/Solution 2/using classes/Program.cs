using System;

namespace using_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person.Count = 0;

            Person p1 = new Person();
            Person.Count++;
            Person spouse1 = new Person();
            p1.Spouse = spouse1;

            p1.firstName = Question.Ask("What is your first name?");
            p1.lastName = Question.Ask("What is your last name?");
            p1.Age = Question.AskNumber("What is your age?");
            p1.married = Question.AskYesOrNo("Are you married?");
            p1.spouseOrNone();

            //If not married, give "none" as spouse name and 0 as spouse age.

            spouse1.firstName = Question.Ask("What is your spouse's name?");
            spouse1.Age = Question.AskNumber("What is your spouse's age?");

            Console.WriteLine(" ");
            Console.WriteLine("Next person:");
            
            Person p2 = new Person();
            Person.Count++;
            Person spouse2 = new Person();
            p2.Spouse = spouse2;

            p2.firstName = Question.Ask("What is your first name?");
            p2.lastName = Question.Ask("What is your last name?");
            p2.Age = Question.AskNumber("What is your age?");
            p2.married = Question.AskYesOrNo("Are you married?");
            p2.spouseOrNone();
          
            spouse2.firstName = Question.Ask("What is your spouse's name?");
            spouse2.Age = Question.AskNumber("What is your spouse's age?");

            Console.WriteLine(" ");
            Console.WriteLine("Next person:");

            Person p3 = new Person();
            Person.Count++;
            Person spouse3 = new Person();
            p3.Spouse = spouse3;

            p3.firstName = Question.Ask("What is your first name?");
            p3.lastName = Question.Ask("What is your last name?");
            p3.Age = Question.AskNumber("What is your age?");
            p3.married = Question.AskYesOrNo("Are you married?");
            p3.spouseOrNone();

            spouse3.firstName = Question.Ask("What is your spouse's name?");
            spouse3.Age = Question.AskNumber("What is your spouse's age?");

            Console.WriteLine(" ");

            Console.WriteLine("Person 1:");
            p1.PrintNameAndAge();

            Console.WriteLine(" ");

            Console.WriteLine("Person 2:");
            p2.PrintNameAndAge();

            Console.WriteLine(" ");

            Console.WriteLine("Person 3:");
            p3.PrintNameAndAge();

            Person.averageAge = (p1.Age + p2.Age + p3.Age + spouse1.Age + spouse2.Age + spouse3.Age) / Person.Count;

            Console.WriteLine("Average age: " + Person.averageAge);
            Console.ReadLine();

        }
    }
}
