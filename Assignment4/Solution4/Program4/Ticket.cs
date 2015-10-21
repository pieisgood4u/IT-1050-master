using System;

namespace Program4
{
    class Ticket
    {
        private double Price;
        private string Label;

        static int count;

        public Ticket(string name, double price)
        {
            Label = name;
            Price = price;
        }

    }
}
