using System;

namespace using_classes
{
   public class Person
    {
        public int Age;
        public string firstName;
        public string lastName;
        public bool married;
        public Person Spouse;
        public static int Count;
        public static double averageAge;

        public void spouseOrNone()
        {
            if (married == true)
            {
                Person.Count++;

            }
        }   
       

        public string GetFullName()
        {
            return firstName + " " + lastName;
        }
        
        public void PrintNameAndAge()
        {
            Console.WriteLine("Full name: " + GetFullName());
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Spouse's name: " + Spouse.firstName);
            Console.WriteLine("Spouse's age: " + Spouse.Age);
        }

        
    }
}
