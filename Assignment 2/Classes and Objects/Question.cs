using System;


namespace using_classes
{
    public class Question
    {
        public static string Ask(string prompt)
        {
            Console.Write(prompt + " - ");
            return Console.ReadLine();
        }

        public static int AskNumber(string prompt)
        {
            string answer = Ask(prompt);
            return int.Parse(answer);
        }

        public static bool AskYesOrNo(string prompt)
        {
            string answer = Ask(prompt);
            return answer.StartsWith("y");
        }
    }
}
