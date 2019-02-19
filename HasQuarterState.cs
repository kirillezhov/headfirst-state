using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class HasQuarterState : State
    {
        Random randomWinner = new Random(CurrentTimeMillis());

        public HasQuarterState(GumballMachine gumballMachine) : base(gumballMachine){ }

        public override void Dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }

        public override void EjectQuarter()
        {
            Console.WriteLine("Quarted returned");
            gumballMachine.SetState(gumballMachine.GetNoQuarterState());
        }

        public override void InsertQuarter()
        {
            Console.WriteLine("You can't insert another quarter");
        }

        public override void TurnCrank()
        {
            Console.WriteLine("You turned...");
            int winner = randomWinner.Next(10);
            if(winner == 0 && gumballMachine.GetCount() > 1)
            {
                gumballMachine.SetState(gumballMachine.GetWinnerState());
            }
            else
            {
                gumballMachine.SetState(gumballMachine.GetSoldState());
            }
        }

        private static readonly DateTime Jan1st1970 = new DateTime
            (1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        public static int CurrentTimeMillis()
        {
            return (int)(DateTime.UtcNow - Jan1st1970).TotalMilliseconds;
        }
    }
}
