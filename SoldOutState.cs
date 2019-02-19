using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class SoldOutState : State
    {
        public override void Dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }

        public override void EjectQuarter()
        {
            Console.WriteLine("You can't eject, you haven't inserted a quarter yet");
        }

        public override void InsertQuarter()
        {
            Console.WriteLine("You can't insert quarter, the machine is sold out");
        }

        public override void TurnCrank()
        {
            Console.WriteLine("You turned but there are no gumballs");
        }

        public override string ToString()
        {
            return "Sold out";
        }
    }
}
