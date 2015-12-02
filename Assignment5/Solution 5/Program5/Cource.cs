using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program5
{
    public class Cource
    {
        public string name;
        public string CRN;
        public Student[] Students;

        public void Print()
        {
            System.Console.WriteLine("[" + this.name + "] " + this.CRN);
        }
    }
}
