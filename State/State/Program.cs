using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            GumballMachine gumballMachine = new GumballMachine(5);

            Console.WriteLine(gumballMachine);
            Console.WriteLine();

            for (int i = 0; i < 6; i++) {
                gumballMachine.insertQuarter();

                Console.WriteLine(gumballMachine);
                Console.WriteLine();

                gumballMachine.turnCrank();

                Console.WriteLine(gumballMachine);
                Console.WriteLine();
            }
            

            Console.ReadLine();
        }
    }
}
