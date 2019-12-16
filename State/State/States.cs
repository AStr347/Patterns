using System;

namespace State
{
    interface IState
    {
        void insertQuarter();
        void ejectQuarter();
        void turnCrank();
        void dispense();
    }


    class SoldState : IState
    {
        GumballMachine gumballMachine;

        public SoldState(GumballMachine g)
        {
            gumballMachine = g;
            gumballMachine.releaseBall();
        }

        public void insertQuarter()
        {
            Console.WriteLine("Please wait, we’re already giving you a gumball");
        }
        public void ejectQuarter()
        {
            Console.WriteLine("Sorry, you already turned the crank");
        }
        public void turnCrank()
        {
            Console.WriteLine("Turning twice doesn’t get you another gumball!");
        }

        public void dispense()
        {
            Console.WriteLine("A gumball comes rolling out the slot...");
            gumballMachine.setCount(gumballMachine.getCount() - 1);

            if (gumballMachine.getCount() > 0)
            {
                gumballMachine.setState(new NoQuarterState(gumballMachine));
            }
            else
            {
                Console.WriteLine("Oops, out of gumballs!");
                gumballMachine.setState(new SoldOutState(gumballMachine));
            }
        }
    }

    class SoldOutState : IState
    {
        GumballMachine gumballMachine;

        public SoldOutState(GumballMachine g)
        {
            gumballMachine = g;
        }


        public void insertQuarter()
        {
            Console.WriteLine("Oops, out of gumballs!");
        }
        public void ejectQuarter()
        {
            Console.WriteLine("Oops, out of gumballs!");
        }
        public void turnCrank()
        {
            Console.WriteLine("Oops, out of gumballs!");
        }

        public void dispense()
        {
            Console.WriteLine("Oops, out of gumballs!");
        }
    }

    class NoQuarterState : IState
    {
        GumballMachine gumballMachine;

        public NoQuarterState(GumballMachine g)
        {
            gumballMachine = g;
        }

        public void insertQuarter()
        {
            Console.WriteLine("You inserted a quarter");
            gumballMachine.setState(new HasQuarterState(gumballMachine));
        }
        public void ejectQuarter()
        {
            Console.WriteLine("You haven’t inserted a quarter");
        }
        public void turnCrank()
        {
            Console.WriteLine("You turned, but there’s no quarter");
        }
        public void dispense()
        {
            Console.WriteLine("You need to pay first");
        }
    }

    class HasQuarterState : IState
    {
        GumballMachine gumballMachine;
        Random r = new Random();

        public HasQuarterState(GumballMachine g)
        {
            gumballMachine = g;
        }

        public void insertQuarter()
        {
            Console.WriteLine("You can’t insert another quarter");
        }
        public void ejectQuarter()
        {
            Console.WriteLine("Quarter returned");
            gumballMachine.setState(new NoQuarterState(gumballMachine));
        }
        public void turnCrank()
        {
            Console.WriteLine("You turned...");
            int winner = r.Next(5);
            if ((winner == 0) && (gumballMachine.getCount() > 1))
            {
                gumballMachine.setState(new WinnerState(gumballMachine));
            }
            else
            {
                gumballMachine.setState(new SoldState(gumballMachine));
            }
        }
        public void dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }
    }

    class WinnerState : IState
    {
        GumballMachine gumballMachine;

        public WinnerState(GumballMachine g)
        {
            gumballMachine = g;
        }

        public void insertQuarter()
        {
            Console.WriteLine("Please wait, we’re already giving you a gumball");
        }
        public void ejectQuarter()
        {
            Console.WriteLine("Sorry, you already turned the crank");
        }
        public void turnCrank()
        {
            Console.WriteLine("Turning twice doesn’t get you another gumball!");
        }
        public void dispense() {
            if (gumballMachine.getCount() == 0)
            {
                gumballMachine.setState(new SoldOutState(gumballMachine));
            }
            else
            {
                Console.WriteLine("YOU’RE A WINNER! You got two gumballs for your quarter");
                gumballMachine.setCount(gumballMachine.getCount() - 2);
                if (gumballMachine.getCount() > 0)
                {
                    gumballMachine.setState(new NoQuarterState(gumballMachine));
                }
                else
                {
                    Console.WriteLine("Oops, out of gumballs!");
                    gumballMachine.setState(new SoldOutState(gumballMachine));
                }
            }
        }
    }
}
