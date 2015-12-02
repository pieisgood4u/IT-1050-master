using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program5
{
    public class Student
    {
        public string Name;
        public int SNumber;

        public void Print()
        {
            System.Console.WriteLine("[" + this.Name + "] " + this.SNumber);
        }
    }
}
