using System;

namespace Program4
{
    class Ticket
    {
        private double Price;
        private string Label;
        private int count;
        

        public Ticket(string name, double price)
        {
            Label = name;
            Price = price;
            count = 0;
        }

        
        public void AskAmmount()
        {
            this.count = Question.askQuestion("How many " + this.Label + " tickets? ");
        }

        public double Cost()
        {
            return this.Price * this.count;
        }   
    }
}
