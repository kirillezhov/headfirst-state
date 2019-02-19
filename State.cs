using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    abstract class State
    {
        protected GumballMachine gumballMachine;

        public State(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public State(){ }

        public virtual void InsertQuarter()
        {
            Console.WriteLine("Please wait, we are already giving you a gumball");
        }

        public virtual void EjectQuarter()
        {
            Console.WriteLine("Sorry, you already turned the crank");
        }
        public virtual void TurnCrank()
        {
            Console.WriteLine("Turning twice doesn't get you another gumball!");
        }
        public abstract void Dispense();
    }
}
