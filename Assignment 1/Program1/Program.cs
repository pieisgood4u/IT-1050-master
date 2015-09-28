using System;

namespace Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();
            Console.WriteLine("What is your middle initial?");
            string middleInitial = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();

            string fullName = firstName + " " + middleInitial + " " + lastName;

            Console.WriteLine("What is your height in feet and inches?");
            Console.WriteLine("Feet:");
            int heightFeet = int.Parse(Console.ReadLine());
            Console.WriteLine("Inches:");
            double heightInches = double.Parse(Console.ReadLine());

            double totalHeightCM = ((heightFeet * 12) + heightInches) * 2.54;

            Console.WriteLine("What is your age?");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Are you a citizen?");
            bool isCitizen = bool.Parse(Console.ReadLine());

            bool canVote = age >= 18 && isCitizen;

            Console.WriteLine("Height:");
            Console.WriteLine(totalHeightCM);
            Console.WriteLine("Name:");
            Console.WriteLine(fullName);
            Console.WriteLine("Can you vote?");
            Console.WriteLine(canVote);

        }
    }
}
