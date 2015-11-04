using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program4
{
    class Snack
    {
        private string Name;
        private double Price;
        private int Count;
        

        public Snack(string name, double price)
        {
            Name = name;
            Price = price;
            Count = 0;
        }

        public void AskAmmount()
        {
            this.Count = Question.askQuestion("How many " + this.Name + "s do you want? ");
        }

        public double Cost()
        {
            return this.Price * this.Count;
        }
    }
}
