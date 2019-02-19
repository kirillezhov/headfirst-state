using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class SoldState : State
    {
        public SoldState(GumballMachine gumballMachine) : base(gumballMachine){}

        public override void Dispense()
        {
            gumballMachine.ReleaseBall();
            if(gumballMachine.GetCount() > 0)
            {
                gumballMachine.SetState(gumballMachine.GetNoQuarterState());
            }
            else
            {
                Console.WriteLine("Oops, out of gumballs!");
                gumballMachine.SetState(gumballMachine.GetSoldOutState());
            }
        }
    }
}
