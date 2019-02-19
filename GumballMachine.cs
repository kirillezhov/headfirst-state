using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class GumballMachine
    {
        State
            soldOutState,
            noQuarterState,
            hasQuarterState,
            soldState,
            winnerState;

        State state;
        int count = 0;

        public GumballMachine(int numberGumballs)
        {
            count = numberGumballs;

            soldOutState = new SoldOutState();
            noQuarterState = new NoQuarterState(this);
            hasQuarterState = new HasQuarterState(this);
            soldState = new SoldState(this);
            winnerState = new WinnerState(this);

            if(count > 0)
            {
                state = noQuarterState;
            }
            else
            {
                state = soldOutState;
            }
        }

        public void InsertQuarter()
        {
            state.InsertQuarter();
        }

        public void EjectQuarter()
        {
            state.EjectQuarter();
        }

        public void TurnCrank()
        {
            state.TurnCrank();
            state.Dispense();
        }

        public void SetState(State state)
        {
            this.state = state;
        }

        public void ReleaseBall()
        {
            Console.WriteLine("A gumball comes rolling out the slot...");
            if(count != 0)
            {
                count--;
            }
        }

        public int GetCount() => count;

        public State GetHasQuarterState() => hasQuarterState;
        public State GetNoQuarterState() => noQuarterState;
        public State GetSoldState() => soldState;
        public State GetSoldOutState() => soldOutState;
        public State GetWinnerState() => winnerState;
    }
}
