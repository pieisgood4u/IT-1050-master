using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program5
{
    public class Question
    {
        public static string AskForString(string prompt)
        {
            System.Console.WriteLine(prompt + "  : ");
            return System.Console.ReadLine();
        }

        public static int AskForInt(string prompt)
        {
            System.Console.WriteLine(prompt + "  : ");
            return int.Parse(System.Console.ReadLine());
        }
    }
}
