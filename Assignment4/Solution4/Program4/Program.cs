using System;


namespace Program4
{
    class Program
    {
        static void Main(string[] args)
        {
            Ticket ChildMatinee = new Ticket("Child matinee", 3.99);
            Ticket AdultMatinee = new Ticket("Adult Matinee", 5.99);
            Ticket SeniorMatinee = new Ticket("Senior Matinee", 4.50);
            Ticket ChildEvening = new Ticket("Child Evening", 6.99);
            Ticket AdultEvening = new Ticket("Adult Evening", 10.99);
            Ticket SeniorEvening = new Ticket("Senior Evening", 8.50);

            Snack SmallSoda = new Snack("Small soda", 3.50);
            Snack LargeSoda = new Snack("Large soda", 5.99);
            Snack HotDog = new Snack("Hot Dog", 3.99);
            Snack Popcorn = new Snack("Popcorn", 4.50);
            Snack Candy = new Snack("Candy", 1.99);

            Console.WriteLine("Welcome to Cinemark Valley View!");

            int time = Question.askQuestion("What time is it? (0 - 2399 hours): ");

            if (time >= 1400 && time <= 1730)
            {
                ChildMatinee.AskAmmount();
                AdultMatinee.AskAmmount();
                SeniorMatinee.AskAmmount();
            }

            else
            {
                ChildEvening.AskAmmount();
                AdultEvening.AskAmmount();
                SeniorEvening.AskAmmount();
            }

            bool wantSnack = Question.askYesOrNo("Would you like to buy some snacks? ");

            if (wantSnack == true)
            {
                SmallSoda.AskAmmount();
                LargeSoda.AskAmmount();
                HotDog.AskAmmount();
                Popcorn.AskAmmount();
                Candy.AskAmmount();
            }
            Console.WriteLine();
            int eveningTotal = ChildEvening.count + AdultEvening.count + SeniorEvening.count;
            double ticketTotal = ChildMatinee.Cost() + AdultMatinee.Cost() + SeniorMatinee.Cost() + ChildEvening.Cost() + AdultEvening.Cost() + SeniorEvening.Cost();
            double snackTotal = SmallSoda.Cost() + LargeSoda.Cost() + HotDog.Cost() + Popcorn.Cost() + Candy.Cost();
            double totalCost = ticketTotal + snackTotal;

            if (eveningTotal >= 3 && Popcorn.Count >= 1)
            {
                totalCost = totalCost - 4.50;
            }

            if (Candy.Count >= 4)
            {
                totalCost = totalCost - ((Candy.Count / 4) * 1.99);
            }
            
            if (Popcorn.Count <= LargeSoda.Count)
            {
                totalCost = totalCost - (Popcorn.Count * 2);
            }
            else
            {
                totalCost = totalCost - (LargeSoda.Count * 2);
            }

            Console.WriteLine("Your total for today is " + totalCost);
            Console.WriteLine("Enjoy your movie!");
            Console.ReadKey();
        }
    }
}
