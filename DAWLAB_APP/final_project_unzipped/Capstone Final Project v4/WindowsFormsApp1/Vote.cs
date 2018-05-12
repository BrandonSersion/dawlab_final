using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Vote
    {
        public Vote(string number, int num)
        {
            Number = number;
            Num = num;
        }

        public string Number { get; }
        public int Num { get; }

        public override string ToString()
        {
            return Number;
        }
    }
}
