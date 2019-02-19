using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class NoQuarterState : State
    {
        public NoQuarterState(GumballMachine gumballMachine) : base(gumballMachine){}

        public override void Dispense()
        {
            Console.WriteLine("You need to pay first");
        }

        public override void EjectQuarter()
        {
            Console.WriteLine("You haven't inserted a quarter");
        }

        public override void InsertQuarter()
        {
            Console.WriteLine("You inserted a quarter");
            gumballMachine.SetState(gumballMachine.GetHasQuarterState());
        }

        public override void TurnCrank()
        {
            Console.WriteLine("You turned, but there's no quarter");
        }
    }
}
