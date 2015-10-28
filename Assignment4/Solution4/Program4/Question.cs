using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program4
{
    public class Question
    {
        public static int askQuestion(string prompt)
        {
            Console.WriteLine();
            Console.Write(prompt);
            return int.Parse(Console.ReadLine());
        }

        public static bool askYesOrNo(string prompt)
        {
            Console.WriteLine();
            Console.Write(prompt);
            return Console.ReadLine().Contains("y");
        }
    }
}
