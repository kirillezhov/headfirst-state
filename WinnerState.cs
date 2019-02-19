using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class WinnerState : State
    {
        public WinnerState(GumballMachine gumballMachine) : base(gumballMachine){}

        public override void Dispense()
        {
            gumballMachine.ReleaseBall();
            if(gumballMachine.GetCount() == 0)
            {
                gumballMachine.SetState(gumballMachine.GetSoldOutState());
            }
            else
            {
                gumballMachine.ReleaseBall();
                Console.WriteLine("YOU'RE A WINNER! You got two gumballs for your quarter");

                if(gumballMachine.GetCount() > 0)
                {
                    gumballMachine.SetState(gumballMachine.GetNoQuarterState());
                }
                else
                {
                    Console.WriteLine("Oops, out of gumballs");
                    gumballMachine.SetState(gumballMachine.GetSoldOutState());
                }
            }
        }
    }
}
