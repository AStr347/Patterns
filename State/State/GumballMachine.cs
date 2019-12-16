using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class GumballMachine
    {
        IState state;
        int count;

        public GumballMachine(int ballcount)
        {
            count = ballcount;
            if (count > 0)
            {
                state = new NoQuarterState(this);
            }
            else
            {
                state = new SoldOutState(this);
            }
        }

        public void insertQuarter()
        {
            state.insertQuarter();
        }
        public void ejectQuarter()
        {
            state.ejectQuarter();
        }
        public void turnCrank()
        {
            state.turnCrank();
            state.dispense();
        }

        public void releaseBall()
        {
            state.dispense();
        }

        public void setState(IState _s)
        {
            state = _s;
        }

        public int getCount() { return count; }
        public void setCount(int c) { count = c; }

        public override string ToString()
        {
            return string.Format("count Gumball = {0}, Type of State = {1}", count, state.GetType());
        }

    }
}
